using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace NCoreUtils
{
    public static class PolyfillBitConverter
    {
        #region passthrough

        public static bool IsLittleEndian
        {
            [ExcludeFromCodeCoverage]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => BitConverter.IsLittleEndian;
        }

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long DoubleToInt64Bits(double value)
            => BitConverter.DoubleToInt64Bits(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(bool value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(char value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(double value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(short value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(int value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(long value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(float value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(ushort value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(uint value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(ulong value)
            => BitConverter.GetBytes(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Int64BitsToDouble(long value)
            => BitConverter.Int64BitsToDouble(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(byte[] value, int startIndex)
            => BitConverter.ToBoolean(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(byte[] value, int startIndex)
            => BitConverter.ToChar(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(byte[] value, int startIndex)
            => BitConverter.ToDouble(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(byte[] value, int startIndex)
            => BitConverter.ToInt16(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(byte[] value, int startIndex)
            => BitConverter.ToInt32(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(byte[] value, int startIndex)
            => BitConverter.ToInt64(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(byte[] value, int startIndex)
            => BitConverter.ToSingle(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte[] value)
            => BitConverter.ToString(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte[] value, int startIndex)
            => BitConverter.ToString(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte[] value, int startIndex, int length)
            => BitConverter.ToString(value, startIndex, length);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(byte[] value, int startIndex)
            => BitConverter.ToUInt16(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(byte[] value, int startIndex)
            => BitConverter.ToUInt32(value, startIndex);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(byte[] value, int startIndex)
            => BitConverter.ToUInt64(value, startIndex);

        #endregion

        #if NETSTANDARD2_1

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(ReadOnlySpan<byte> value)
            => BitConverter.ToInt16(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(ReadOnlySpan<byte> value)
            => BitConverter.ToInt32(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(ReadOnlySpan<byte> value)
            => BitConverter.ToInt64(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(ReadOnlySpan<byte> value)
            => BitConverter.ToUInt16(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(ReadOnlySpan<byte> value)
            => BitConverter.ToUInt32(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(ReadOnlySpan<byte> value)
            => BitConverter.ToUInt64(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(ReadOnlySpan<byte> value)
            => BitConverter.ToSingle(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(ReadOnlySpan<byte> value)
            => BitConverter.ToDouble(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(ReadOnlySpan<byte> value)
            => BitConverter.ToChar(value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, short value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, int value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, long value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, ushort value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, uint value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, ulong value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, float value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, double value)
            => BitConverter.TryWriteBytes(destination, value);

        [ExcludeFromCodeCoverage]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBytes(Span<byte> destination, char value)
            => BitConverter.TryWriteBytes(destination, value);

        #else

        public static short ToInt16(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(short))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(short)];
            value.Slice(0, sizeof(short)).CopyTo(bytes.AsSpan());
            return BitConverter.ToInt16(bytes, 0);
        }

        public static int ToInt32(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(int))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(int)];
            value.Slice(0, sizeof(int)).CopyTo(bytes.AsSpan());
            return BitConverter.ToInt32(bytes, 0);
        }

        public static long ToInt64(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(long))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(long)];
            value.Slice(0, sizeof(long)).CopyTo(bytes.AsSpan());
            return BitConverter.ToInt64(bytes, 0);
        }

        public static ushort ToUInt16(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(ushort))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(ushort)];
            value.Slice(0, sizeof(ushort)).CopyTo(bytes.AsSpan());
            return BitConverter.ToUInt16(bytes, 0);
        }

        public static uint ToUInt32(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(uint))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(uint)];
            value.Slice(0, sizeof(uint)).CopyTo(bytes.AsSpan());
            return BitConverter.ToUInt32(bytes, 0);
        }

        public static ulong ToUInt64(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(ulong))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(ulong)];
            value.Slice(0, sizeof(ulong)).CopyTo(bytes.AsSpan());
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static float ToSingle(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(float))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(float)];
            value.Slice(0, sizeof(float)).CopyTo(bytes.AsSpan());
            return BitConverter.ToSingle(bytes, 0);
        }

        public static double ToDouble(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(double))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(double)];
            value.Slice(0, sizeof(double)).CopyTo(bytes.AsSpan());
            return BitConverter.ToDouble(bytes, 0);
        }

        public static char ToChar(ReadOnlySpan<byte> value)
        {
            if (value.Length < sizeof(char))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(char)];
            value.Slice(0, sizeof(char)).CopyTo(bytes.AsSpan());
            return BitConverter.ToChar(bytes, 0);
        }

        public static bool TryWriteBytes(Span<byte> destination, short value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, int value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, long value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, ushort value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, uint value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, ulong value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, float value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, double value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        public static bool TryWriteBytes(Span<byte> destination, char value)
            => BitConverter.GetBytes(value).AsSpan().TryCopyTo(destination);

        #endif
    }
}