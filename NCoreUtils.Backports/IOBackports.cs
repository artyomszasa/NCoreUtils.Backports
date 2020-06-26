using System;
using System.Buffers;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace NCoreUtils
{
    #if !NETSTANDARD2_1
    public static class IOBackports
    {
        /// <summary>
        /// Maximum used chunk size --> to avoid large arrays being created on LOH.
        /// </summary>
        const int MaxChunkSize = 16 * 1024;

        public static int Read(this Stream stream, Span<byte> buffer)
        {
            var localBuffer = ArrayPool<byte>.Shared.Rent(MaxChunkSize);
            try
            {
                var total = 0;
                while (true)
                {
                    var read = stream.Read(localBuffer, 0, Math.Min(MaxChunkSize, buffer.Length - total));
                    if (0 == read)
                    {
                        return total;
                    }
                    localBuffer.AsSpan().Slice(0, read).CopyTo(buffer.Slice(total));
                    total += read;
                    if (total == buffer.Length)
                    {
                        return total;
                    }
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(localBuffer);
            }
        }

        public static ValueTask<int> ReadAsync(this Stream stream, Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            if (MemoryMarshal.TryGetArray(buffer, out ArraySegment<byte> array))
            {
                return new ValueTask<int>(stream.ReadAsync(array.Array, array.Offset, array.Count, cancellationToken));
            }
            return DoReadAsync(stream, buffer, cancellationToken);

            static async ValueTask<int> DoReadAsync(Stream stream, Memory<byte> buffer, CancellationToken cancellationToken)
            {
                var localBuffer = ArrayPool<byte>.Shared.Rent(MaxChunkSize);
                try
                {
                    var total = 0;
                    while (true)
                    {
                        var read = await stream.ReadAsync(localBuffer, 0, Math.Min(MaxChunkSize, buffer.Length - total), cancellationToken).ConfigureAwait(false);
                        if (0 == read)
                        {
                            return total;
                        }
                        localBuffer.AsSpan().Slice(0, read).CopyTo(buffer.Span.Slice(total));
                        total += read;
                        if (total == buffer.Length)
                        {
                            return total;
                        }
                    }
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(localBuffer);
                }
            }
        }

        public static void Write(this Stream stream, ReadOnlySpan<byte> buffer)
        {
            var localBuffer = ArrayPool<byte>.Shared.Rent(MaxChunkSize);
            try
            {
                var total = 0;
                while (true)
                {
                    var n = Math.Min(MaxChunkSize, buffer.Length - total);
                    if (0 == n)
                    {
                        return;
                    }
                    buffer.Slice(total, n).CopyTo(localBuffer.AsSpan());
                    stream.Write(localBuffer, 0, n);
                    total += n;
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(localBuffer);
            }
        }

        public static ValueTask WriteAsync(this Stream stream, ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default)
        {
            if (MemoryMarshal.TryGetArray(buffer, out ArraySegment<byte> array))
            {
                return new ValueTask(stream.WriteAsync(array.Array, array.Offset, array.Count, cancellationToken));
            }
            return DoWriteAsync(stream, buffer, cancellationToken);

            static async ValueTask DoWriteAsync(Stream stream, ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
            {
                var localBuffer = ArrayPool<byte>.Shared.Rent(MaxChunkSize);
                try
                {
                    var total = 0;
                    while (true)
                    {
                        var n = Math.Min(MaxChunkSize, buffer.Length - total);
                        if (0 == n)
                        {
                            return;
                        }
                        buffer.Span.Slice(total, n).CopyTo(localBuffer.AsSpan());
                        await stream.WriteAsync(localBuffer, 0, n, cancellationToken).ConfigureAwait(false);
                        total += n;
                    }
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(localBuffer);
                }
            }
        }
    }
    #endif
}