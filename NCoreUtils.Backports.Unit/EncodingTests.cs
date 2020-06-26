using System;
using System.Linq;
using System.Text;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class EncodingTests
    {
        private static UTF8Encoding _utf8 = new UTF8Encoding(false);

        [Theory]
        [InlineData("")]
        [InlineData("xasd")]
        [InlineData("xasdsdlkgkjsdlkgdslkg")]
        public void GetBytes(string input)
        {
            var expected = _utf8.GetBytes(input);
            var actual = new byte[expected.Length];
            EncodingBackports.GetBytes(_utf8, input.AsSpan(), actual.AsSpan());
            Assert.True(expected.SequenceEqual(actual));
        }

        [Theory]
        [InlineData("")]
        [InlineData("xasd")]
        [InlineData("xasdsdlkgkjsdlkgdslkg")]
        public void GetChars(string input)
        {
            var data = _utf8.GetBytes(input);
            var expected = _utf8.GetChars(data);
            var actual = new char[expected.Length];
            EncodingBackports.GetChars(_utf8, data.AsSpan(), actual.AsSpan());
            Assert.True(expected.SequenceEqual(actual));
        }
    }
}