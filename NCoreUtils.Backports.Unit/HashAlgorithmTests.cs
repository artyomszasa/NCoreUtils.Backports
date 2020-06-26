using System;
using System.Linq;
using System.Security.Cryptography;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class HashAlgorithmTests
    {
        private static readonly byte[] _data = Convert.FromBase64String("JGKSwyabEZe3aaaDV0u/ZJENB90CVG1Ni8HNok4sTqjXsl2O2/eksQ==");

        [Fact]
        public void ComputeHash()
        {
            using var sha512 = SHA512.Create();
            var expected = sha512.ComputeHash(_data);
            var actual = new byte[expected.Length];
            Assert.True(HashAlgorithmBackports.TryComputeHash(sha512, _data.AsSpan(), actual.AsSpan(), out var size));
            Assert.Equal(expected.Length, size);
            Assert.True(expected.SequenceEqual(actual));

            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(HashAlgorithmBackports.TryComputeHash(sha512, _data.AsSpan(), insufficientBuffer.AsSpan(), out var _));
        }
    }
}