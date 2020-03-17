using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NCoreUtils.Internal;

namespace NCoreUtils
{
    public sealed class ReadOnlyMemoryContent : HttpContent
    {
        readonly ReadOnlyMemory<byte> _buffer;

        public ReadOnlyMemoryContent(ReadOnlyMemory<byte> buffer)
            => _buffer = buffer;

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
            => stream.WriteAsync(_buffer).AsTask();

        protected override bool TryComputeLength(out long length)
        {
            length = _buffer.Length;
            return true;
        }

        protected override Task<Stream> CreateContentReadStreamAsync() =>
            Task.FromResult<Stream>(new ReadOnlyMemoryStream(_buffer));
    }
}