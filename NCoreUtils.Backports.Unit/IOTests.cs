using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class IOTests
    {
        private static readonly byte[] _data;

        static IOTests()
        {
            IEnumerable<byte> chunk = Convert.FromBase64String("JGKSwyabEZe3aaaDV0u/ZJENB90CVG1Ni8HNok4sTqjXsl2O2/eksQ==");
            _data = Enumerable.Repeat(chunk, 16 * 1024).Aggregate((a, b) => a.Concat(b)).ToArray();
        }

        [Fact]
        public void Read()
        {
            using (var stream = new MemoryStream(_data, false))
            {
                var buffer = new byte[_data.Length];
                var size = IOBackports.Read(stream, buffer.AsSpan());
                Assert.Equal(_data.Length, size);
                Assert.True(_data.SequenceEqual(buffer));
            }

            using (var stream = new MemoryStream(_data, false))
            {
                var buffer = new byte[_data.Length + 1];
                var size = IOBackports.Read(stream, buffer.AsSpan());
                Assert.Equal(_data.Length, size);
                Assert.True(_data.SequenceEqual(buffer.Take(size)));
            }
        }

        [Fact]
        public async Task ReadAsync()
        {
            using (var stream = new MemoryStream(_data, false))
            {
                var buffer = new byte[_data.Length];
                var size = await IOBackports.ReadAsync(stream, buffer.AsMemory());
                Assert.Equal(_data.Length, size);
                Assert.True(_data.SequenceEqual(buffer));
            }

            using (var stream = new MemoryStream(_data, false))
            {
                var buffer = new byte[_data.Length + 1];
                var size = await IOBackports.ReadAsync(stream, buffer.AsMemory());
                Assert.Equal(_data.Length, size);
                Assert.True(_data.SequenceEqual(buffer.Take(size)));
            }

            using (var stream = new MemoryStream(_data, false))
            {
                using var m = new UnmanagedMemoryManager<byte>(_data.Length);
                var size = await IOBackports.ReadAsync(stream, m.Memory);
                Assert.Equal(_data.Length, size);
                Assert.True(_data.AsSpan().IsSame(m.Memory.Span));
            }

            using (var stream = new MemoryStream(_data, false))
            {
                using var m = new UnmanagedMemoryManager<byte>(_data.Length + 1);
                var size = await IOBackports.ReadAsync(stream, m.Memory);
                Assert.Equal(_data.Length, size);
                Assert.True(_data.AsSpan().IsSame(m.Memory.Span.Slice(0, size)));
            }
        }

        [Fact]
        public void Write()
        {
            using (var stream = new MemoryStream())
            {
                IOBackports.Write(stream, _data.AsSpan());
                Assert.Equal(_data.Length, stream.Length);
                Assert.True(_data.SequenceEqual(stream.ToArray()));
            }
        }

        [Fact]
        public async Task WriteAsync()
        {
            using (var stream = new MemoryStream())
            {
                await IOBackports.WriteAsync(stream, _data.AsMemory());
                Assert.Equal(_data.Length, stream.Length);
                Assert.True(_data.SequenceEqual(stream.ToArray()));
            }

            using (var stream = new MemoryStream())
            {
                using var m = new UnmanagedMemoryManager<byte>(_data.Length);
                _data.AsSpan().CopyTo(m.Memory.Span);
                await IOBackports.WriteAsync(stream, m.Memory);
                Assert.Equal(_data.Length, stream.Length);
                Assert.True(_data.SequenceEqual(stream.ToArray()));
            }
        }
    }
}