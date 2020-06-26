using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class ConvertTests
    {
        private class Base64CharsInputs : IEnumerable<object[]>
        {
            private static string[] b64Strings = new []
            {
                "V471Jpo/lNrm6A==",
                "irbtPcI6DtUGgtZNKRC5X4u/IA4=",
                "E5uwEU51e+oi2vQPEb+w9qGuNVTpEQD91XGwnoGN",
                "JGKSwyabEZe3aaaDV0u/ZJENB90CVG1Ni8HNok4sTqjXsl2O2/eksQ==",
                "vZJXius1qyqSonfPk4dd6TTIT8fixMCee0qScnnQXz+f0iw8kwt75enV0crXdeSi7IVeAPwDYME1eNXJnwYp5HsLOMzjwX9X3WIxH/2nPUf4cMA6m4KcriamSydmwDzzk+v3NDliYh58lHABG69XFPE3ekpSaUgV"
            };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var b64 in b64Strings)
                {
                    var array = System.Convert.FromBase64String(b64);
                    yield return new object[]
                    {
                        array,
                        b64
                    };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        [Theory]
        [ClassData(typeof(Base64CharsInputs))]
        public void TryToBase64CharsTests(byte[] input, string expected)
        {
            var insufficientBuffer = new char[expected.Length -1];
            Assert.False(PolyfillConvert.TryToBase64Chars(input.AsSpan(), insufficientBuffer.AsSpan(), out var _, Base64FormattingOptions.None));
            var buffer = new char[expected.Length];
            Assert.True(PolyfillConvert.TryToBase64Chars(input.AsSpan(), buffer.AsSpan(), out var size, Base64FormattingOptions.None));
            var actual = new string(buffer, 0, size);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(Base64CharsInputs))]
        public void ToBase64StringTests(byte[] input, string expected)
        {
            var actual = PolyfillConvert.ToBase64String(input.AsSpan(), Base64FormattingOptions.None);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(Base64CharsInputs))]
        public void TryFromBase64StringTests(byte[] expected, string input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillConvert.TryFromBase64String(input, insufficientBuffer.AsSpan(), out var _));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillConvert.TryFromBase64String(input, buffer.AsSpan(), out var size));
            Assert.Equal(expected.Length, size);
            Assert.True(buffer.SequenceEqual(expected));
        }
    }
}