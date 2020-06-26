using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NCoreUtils.Backports.Unit
{
    public class BitConverterTests
    {
        private sealed class Int16Inputs : IEnumerable<object[]>
        {
            private static readonly short[] _inputs = new short[] { short.MinValue, -1, 0, 1, short.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class Int32Inputs : IEnumerable<object[]>
        {
            private static readonly int[] _inputs = new int[] { int.MinValue, -1, 0, 1, int.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class Int64Inputs : IEnumerable<object[]>
        {
            private static readonly long[] _inputs = new long[] { long.MinValue, -1, 0, 1, long.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class UInt16Inputs : IEnumerable<object[]>
        {
            private static readonly ushort[] _inputs = new ushort[] { 0, 1, ushort.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class UInt32Inputs : IEnumerable<object[]>
        {
            private static readonly uint[] _inputs = new uint[] { 0, 1, uint.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class UInt64Inputs : IEnumerable<object[]>
        {
            private static readonly ulong[] _inputs = new ulong[] { 0, 1, ulong.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class SingleInputs : IEnumerable<object[]>
        {
            private static readonly float[] _inputs = new float[] { float.NegativeInfinity, float.MinValue, -1.0f, 0.0f, 1.0f, float.MaxValue, float.PositiveInfinity, float.Epsilon };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class DoubleInputs : IEnumerable<object[]>
        {
            private static readonly double[] _inputs = new double[] { double.NegativeInfinity, double.MinValue, -1.0, 0.0, 1.0, double.MaxValue, double.PositiveInfinity, double.Epsilon };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class CharInputs : IEnumerable<object[]>
        {
            private static readonly char[] _inputs = new char[] { char.MinValue, 'a', '0', 'z', 'ő', char.MaxValue };

            public IEnumerator<object[]> GetEnumerator()
            {
                foreach (var input in _inputs)
                {
                    yield return new object[] { System.BitConverter.GetBytes(input), input };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        [Theory]
        [ClassData(typeof(Int16Inputs))]
        public void ToInt16(byte[] input, short expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToInt16(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(Int32Inputs))]
        public void ToInt32(byte[] input, int expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToInt32(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(Int64Inputs))]
        public void ToInt64(byte[] input, long expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToInt64(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(UInt16Inputs))]
        public void ToUInt16(byte[] input, ushort expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToUInt16(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(UInt32Inputs))]
        public void ToUInt32(byte[] input, uint expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToUInt32(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(UInt64Inputs))]
        public void ToUInt64(byte[] input, ulong expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToUInt64(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(SingleInputs))]
        public void ToSingle(byte[] input, float expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToSingle(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(DoubleInputs))]
        public void ToDouble(byte[] input, double expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToDouble(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(CharInputs))]
        public void ToChar(byte[] input, char expected)
        {
            Assert.Equal(expected, PolyfillBitConverter.ToChar(input.AsSpan()));
        }

        [Theory]
        [ClassData(typeof(Int16Inputs))]
        public void TryWriteInt16(byte[] expected, short input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(Int32Inputs))]
        public void TryWriteInt32(byte[] expected, int input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(Int64Inputs))]
        public void TryWriteInt64(byte[] expected, long input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(UInt16Inputs))]
        public void TryWriteUInt16(byte[] expected, ushort input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(UInt32Inputs))]
        public void TryWriteUInt32(byte[] expected, uint input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(UInt64Inputs))]
        public void TryWriteUInt64(byte[] expected, ulong input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(SingleInputs))]
        public void TryWriteSingle(byte[] expected, float input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(DoubleInputs))]
        public void TryWriteDouble(byte[] expected, double input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Theory]
        [ClassData(typeof(CharInputs))]
        public void TryWriteChar(byte[] expected, char input)
        {
            var insufficientBuffer = new byte[expected.Length - 1];
            Assert.False(PolyfillBitConverter.TryWriteBytes(insufficientBuffer.AsSpan(), input));
            var buffer = new byte[expected.Length];
            Assert.True(PolyfillBitConverter.TryWriteBytes(buffer.AsSpan(), input));
            Assert.True(expected.SequenceEqual(buffer));
        }

        [Fact]
        public void InsufficientTo()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToInt16(new byte[sizeof(short) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToInt32(new byte[sizeof(int) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToInt64(new byte[sizeof(long) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToUInt16(new byte[sizeof(ushort) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToUInt32(new byte[sizeof(uint) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToUInt64(new byte[sizeof(ulong) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToSingle(new byte[sizeof(float) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToDouble(new byte[sizeof(double) - 1].AsSpan()));
            Assert.Throws<ArgumentOutOfRangeException>(() => PolyfillBitConverter.ToChar(new byte[sizeof(char) - 1].AsSpan()));
        }
    }
}