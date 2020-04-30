using System;
using System.Runtime.CompilerServices;

namespace NCoreUtils
{
    public static class PolyfillBitConverter
    {
        #region passthrough

        public static bool IsLittleEndian
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => BitConverter.IsLittleEndian;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long DoubleToInt64Bits(double value)
            => BitConverter.DoubleToInt64Bits(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(bool value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(char value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(double value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(short value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(int value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(long value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(float value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(ushort value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(uint value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] GetBytes(ulong value)
            => BitConverter.GetBytes(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Int64BitsToDouble(long value)
            => BitConverter.Int64BitsToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(byte[] value, int startIndex)
            => BitConverter.ToBoolean(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(byte[] value, int startIndex)
            => BitConverter.ToChar(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(byte[] value, int startIndex)
            => BitConverter.ToDouble(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(byte[] value, int startIndex)
            => BitConverter.ToInt16(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(byte[] value, int startIndex)
            => BitConverter.ToInt32(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(byte[] value, int startIndex)
            => BitConverter.ToInt64(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(byte[] value, int startIndex)
            => BitConverter.ToSingle(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte[] value)
            => BitConverter.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte[] value, int startIndex)
            => BitConverter.ToString(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte[] value, int startIndex, int length)
            => BitConverter.ToString(value, startIndex, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(byte[] value, int startIndex)
            => BitConverter.ToUInt16(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(byte[] value, int startIndex)
            => BitConverter.ToUInt32(value, startIndex);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(byte[] value, int startIndex)
            => BitConverter.ToUInt64(value, startIndex);

        #endregion

        public static short ToInt16(ReadOnlySpan<byte> value)
        {
            #if NESTANDARD2_1
            return BitConverter.ToInt16(value);
            #else
            if (value.Length < sizeof(short))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            var bytes = new byte[sizeof(short)];
            value.Slice(0, sizeof(short)).CopyTo(bytes.AsSpan());
            return BitConverter.ToInt16(bytes, 0);
            #endif
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

        public static bool TryWriteBytes(Span<byte> destination, short value)
        {
            var data = BitConverter.GetBytes(value);
            if (destination.Length < data.Length)
            {
                return false;
            }
            data.AsSpan().CopyTo(destination);
            return true;
        }

        public static bool TryWriteBytes(Span<byte> destination, int value)
        {
            var data = BitConverter.GetBytes(value);
            if (destination.Length < data.Length)
            {
                return false;
            }
            data.AsSpan().CopyTo(destination);
            return true;
        }

        public static bool TryWriteBytes(Span<byte> destination, long value)
        {
            var data = BitConverter.GetBytes(value);
            if (destination.Length < data.Length)
            {
                return false;
            }
            data.AsSpan().CopyTo(destination);
            return true;
        }
    }
}