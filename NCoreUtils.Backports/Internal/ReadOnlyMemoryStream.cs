using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace NCoreUtils.Internal
{
    /// <summary>
    /// Original source: https://github.com/stephentoub/corefx/blob/5d38ea8d6642e885058180680c9664c3e27ca054/src/Common/src/System/IO/ReadOnlyMemoryStream.cs
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal sealed class ReadOnlyMemoryStream : Stream
    {

        static Task CompletedTask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                #if NET452
                return Task.FromResult(true);
                #else
                return Task.CompletedTask;
                #endif
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static Task<T> CreateCancelledTask<T>(CancellationToken cancellationToken)
            where T : struct
        {
            #if NET452
            return new Task<T>(() => default(T), cancellationToken);
            #else
            return Task.FromCanceled<T>(cancellationToken);
            #endif
        }

        private readonly ReadOnlyMemory<byte> _content;
        private int _position;

        public ReadOnlyMemoryStream(ReadOnlyMemory<byte> content)
        {
            _content = content;
        }

        public override bool CanRead => true;
        public override bool CanSeek => true;
        public override bool CanWrite => false;

        public override long Length => _content.Length;

        public override long Position
        {
            get => _position;
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _position = (int)value;
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            long pos =
                origin == SeekOrigin.Begin ? offset :
                origin == SeekOrigin.Current ? _position + offset :
                origin == SeekOrigin.End ? _content.Length + offset :
                throw new ArgumentOutOfRangeException(nameof(origin));

            if (pos > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }
            else if (pos < 0)
            {
                throw new IOException("Unable to seek to negative position.");
            }

            _position = (int)pos;
            return _position;
        }

        public override int ReadByte()
        {
            ReadOnlySpan<byte> s = _content.Span;
            return _position < s.Length ? s[_position++] : -1;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            ValidateReadArrayArguments(buffer, offset, count);
            return Read(new Span<byte>(buffer, offset, count));
        }

        public int Read(Span<byte> destination)
        {
            int remaining = _content.Length - _position;
            if (remaining <= 0 || destination.Length == 0)
            {
                return 0;
            }
            else if (remaining <= destination.Length)
            {
                _content.Span.Slice(_position).CopyTo(destination);
                _position = _content.Length;
                return remaining;
            }
            else
            {
                _content.Span.Slice(_position, destination.Length).CopyTo(destination);
                _position += destination.Length;
                return destination.Length;
            }
        }

        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            ValidateReadArrayArguments(buffer, offset, count);
            return cancellationToken.IsCancellationRequested ?
                CreateCancelledTask<int>(cancellationToken) :
                Task.FromResult(Read(new Span<byte>(buffer, offset, count)));
        }

        public ValueTask<int> ReadAsync(Memory<byte> destination, CancellationToken cancellationToken = default(CancellationToken)) =>
            cancellationToken.IsCancellationRequested ?
                new ValueTask<int>(CreateCancelledTask<int>(cancellationToken)) :
                new ValueTask<int>(Read(destination.Span));

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) =>
            TaskToApm.Begin(ReadAsync(buffer, offset, count), callback, state);


        public override int EndRead(IAsyncResult asyncResult) =>
            TaskToApm.End<int>(asyncResult);

        public new void CopyTo(Stream destination, int bufferSize)
        {
            ValidateCopyToArgs(this, destination, bufferSize);
            if (_content.Length > _position)
            {
                destination.Write(_content.Span.Slice(_position));
            }
        }

        public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
        {
            ValidateCopyToArgs(this, destination, bufferSize);
            return _content.Length > _position
                ? destination.WriteAsync(_content.Slice(_position), cancellationToken).AsTask()
                : CompletedTask;
        }

        public override void Flush() { }

        public override Task FlushAsync(CancellationToken cancellationToken) => CompletedTask;

        public override void SetLength(long value) => throw new NotSupportedException();

        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();

        private static void ValidateReadArrayArguments(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }
            if (offset < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }
            if (count < 0 || buffer.Length - offset < count)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
        }

        /// <summary>Validate the arguments to CopyTo, as would Stream.CopyTo.</summary>
        static void ValidateCopyToArgs(Stream source, Stream destination, int bufferSize)
        {
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            if (bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bufferSize));
            }

            bool sourceCanRead = source.CanRead;
            if (!sourceCanRead && !source.CanWrite)
            {
                throw new ObjectDisposedException(null);
            }

            bool destinationCanWrite = destination.CanWrite;
            if (!destinationCanWrite && !destination.CanRead)
            {
                throw new ObjectDisposedException(nameof(destination));
            }

            if (!sourceCanRead)
            {
                throw new NotSupportedException();
            }

            if (!destinationCanWrite)
            {
                throw new NotSupportedException();
            }
        }
    }
}