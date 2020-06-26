using System;
using System.Linq;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class PrimitiveTests
    {
        [Fact]
        public void TryWriteGuidBytes()
        {
            var guid = Guid.NewGuid();
            Assert.False(PrimitiveBackports.TryWriteBytes(guid, new byte[10].AsSpan()));
            var buffer = new byte[16];
            Assert.True(PrimitiveBackports.TryWriteBytes(guid, buffer.AsSpan()));
            Assert.True(guid.ToByteArray().SequenceEqual(buffer));
        }
    }
}