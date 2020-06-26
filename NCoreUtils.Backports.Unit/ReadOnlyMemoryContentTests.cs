using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class ReadOnlyMemoryContentTests
    {
        private static readonly byte[] _data;

        static ReadOnlyMemoryContentTests()
        {
            IEnumerable<byte> chunk = Convert.FromBase64String("JGKSwyabEZe3aaaDV0u/ZJENB90CVG1Ni8HNok4sTqjXsl2O2/eksQ==");
            _data = Enumerable.Repeat(chunk, 16 * 1024).Aggregate((a, b) => a.Concat(b)).ToArray();
        }

        [Fact]
        public async Task Def()
        {
            var content = new ReadOnlyMemoryContent(_data.AsMemory());
            Assert.Equal(_data.Length, content.Headers.ContentLength!.Value);
            using (var buffer = new MemoryStream())
            {
                await content.CopyToAsync(buffer);
                Assert.True(_data.SequenceEqual(buffer.ToArray()));
            }
            using (var buffer = new MemoryStream())
            {
                using var stream = await content.ReadAsStreamAsync();
                Assert.Equal(_data.Length, stream.Length);
                await stream.CopyToAsync(buffer);
                Assert.True(_data.SequenceEqual(buffer.ToArray()));
            }
        }
    }
}