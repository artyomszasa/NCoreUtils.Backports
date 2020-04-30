using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace NCoreUtils
{
    public static class PolyfillConvert
    {
        #region passthrough

        public static object DBNull
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Convert.DBNull;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static object ChangeType(object value, Type conversionType)
            => Convert.ChangeType(value, conversionType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static object ChangeType(object value, Type conversionType, IFormatProvider provider)
            => Convert.ChangeType(value, conversionType, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static object ChangeType(object value, TypeCode typeCode)
            => Convert.ChangeType(value, typeCode);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
            => Convert.ChangeType(value, typeCode, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
            => Convert.FromBase64CharArray(inArray, offset, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] FromBase64String(string s)
            => Convert.FromBase64String(s);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeCode GetTypeCode(object value)
            => Convert.GetTypeCode(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDBNull(object value)
            => Convert.IsDBNull(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
            => Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
            => Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options)
            => Convert.ToBase64String(inArray, offset, length, options);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToBase64String(byte[] inArray, int offset, int length)
            => Convert.ToBase64String(inArray, offset, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToBase64String(byte[] inArray)
            => Convert.ToBase64String(inArray);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToBase64String(byte[] inArray, Base64FormattingOptions options)
            => Convert.ToBase64String(inArray, options);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(object value, IFormatProvider provider)
            => Convert.ToBoolean(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(ulong value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(uint value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(ushort value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(string value, IFormatProvider provider)
            => Convert.ToBoolean(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(string value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(float value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(sbyte value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(object value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(double value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(int value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(short value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(decimal value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(DateTime value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(char value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(byte value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(bool value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(long value)
            => Convert.ToBoolean(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(float value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(string value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(string value, IFormatProvider provider)
            => Convert.ToByte(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(ulong value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(ushort value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(uint value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(sbyte value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(string value, int fromBase)
            => Convert.ToByte(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(object value, IFormatProvider provider)
            => Convert.ToByte(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(short value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(long value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(byte value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(char value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(DateTime value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(bool value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(double value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(int value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(decimal value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(object value)
            => Convert.ToByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(ulong value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(object value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(uint value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(ushort value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(string value, IFormatProvider provider)
            => Convert.ToChar(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(string value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(float value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(sbyte value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(object value, IFormatProvider provider)
            => Convert.ToChar(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(long value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(short value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(double value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(decimal value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(DateTime value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(char value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(byte value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(bool value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToChar(int value)
            => Convert.ToChar(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(sbyte value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(float value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(string value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(ulong value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(ushort value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(uint value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(object value, IFormatProvider provider)
            => Convert.ToDateTime(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(string value, IFormatProvider provider)
            => Convert.ToDateTime(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(object value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(double value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(int value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(bool value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(byte value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(char value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(long value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(decimal value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(short value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime ToDateTime(DateTime value)
            => Convert.ToDateTime(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(ulong value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(uint value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(ushort value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(string value, IFormatProvider provider)
            => Convert.ToDecimal(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(string value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(float value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(object value, IFormatProvider provider)
            => Convert.ToDecimal(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(object value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(sbyte value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(int value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(bool value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(byte value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(char value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(long value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(decimal value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(double value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(short value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ToDecimal(DateTime value)
            => Convert.ToDecimal(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(object value, IFormatProvider provider)
            => Convert.ToDouble(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(uint value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(ushort value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(string value, IFormatProvider provider)
            => Convert.ToDouble(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(string value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(float value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(sbyte value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(ulong value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(object value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(int value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(bool value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(byte value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(char value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(long value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(decimal value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(double value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(short value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(DateTime value)
            => Convert.ToDouble(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(object value, IFormatProvider provider)
            => Convert.ToInt16(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(uint value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(ushort value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(string value, int fromBase)
            => Convert.ToInt16(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(string value, IFormatProvider provider)
            => Convert.ToInt16(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(string value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(float value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(sbyte value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(ulong value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(object value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(int value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(short value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(double value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(decimal value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(DateTime value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(char value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(byte value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(bool value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(long value)
            => Convert.ToInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(sbyte value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(string value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(string value, IFormatProvider provider)
            => Convert.ToInt32(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(object value, IFormatProvider provider)
            => Convert.ToInt32(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(ushort value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(uint value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(ulong value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(string value, int fromBase)
            => Convert.ToInt32(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(object value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(float value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(int value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(byte value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(char value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(DateTime value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(bool value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(double value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(long value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(short value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(decimal value)
            => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(sbyte value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(ulong value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(uint value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(ushort value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(string value, int fromBase)
            => Convert.ToInt64(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(string value, IFormatProvider provider)
            => Convert.ToInt64(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(string value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(float value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(object value, IFormatProvider provider)
            => Convert.ToInt64(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(object value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(long value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(byte value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(char value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(DateTime value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(bool value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(double value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(short value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(int value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(decimal value)
            => Convert.ToInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(object value, IFormatProvider provider)
            => Convert.ToSByte(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(ulong value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(uint value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(ushort value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(string value, int fromBase)
            => Convert.ToSByte(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(string value, IFormatProvider provider)
            => Convert.ToSByte(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(float value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(sbyte value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(object value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(string value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(int value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(long value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(byte value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(char value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(DateTime value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(bool value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(double value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(short value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(decimal value)
            => Convert.ToSByte(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(ulong value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(object value, IFormatProvider provider)
            => Convert.ToSingle(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(uint value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(ushort value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(string value, IFormatProvider provider)
            => Convert.ToSingle(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(float value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(sbyte value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(object value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(string value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(int value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(short value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(double value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(decimal value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(DateTime value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(char value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(byte value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(bool value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToSingle(long value)
            => Convert.ToSingle(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]

        public static string ToString(sbyte value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(object value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(long value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(ulong value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(long value, int toBase)
            => Convert.ToString(value, toBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(sbyte value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(object value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(float value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(ushort value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(string value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(string value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(ushort value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(uint value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(uint value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(ulong value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(long value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(float value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(int value, int toBase)
            => Convert.ToString(value, toBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(short value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(int value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(int value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(bool value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(bool value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte value, int toBase)
            => Convert.ToString(value, toBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(char value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(char value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(byte value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(DateTime value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(decimal value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(decimal value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(double value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(double value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(short value, IFormatProvider provider)
            => Convert.ToString(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(short value, int toBase)
            => Convert.ToString(value, toBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString(DateTime value)
            => Convert.ToString(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(float value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(string value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(string value, IFormatProvider provider)
            => Convert.ToUInt16(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(ulong value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(ushort value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(uint value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(sbyte value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(string value, int fromBase)
            => Convert.ToUInt16(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(object value, IFormatProvider provider)
            => Convert.ToUInt16(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(double value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(long value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(object value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(byte value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(char value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(DateTime value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(bool value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(short value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(int value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(decimal value)
            => Convert.ToUInt16(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(sbyte value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(ulong value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(uint value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(ushort value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(string value, int fromBase)
            => Convert.ToUInt32(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(string value, IFormatProvider provider)
            => Convert.ToUInt32(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(string value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(float value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(object value, IFormatProvider provider)
            => Convert.ToUInt32(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(bool value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(long value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(int value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(short value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(double value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(decimal value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(DateTime value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(char value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(byte value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(object value)
            => Convert.ToUInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(sbyte value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(float value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(ushort value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(string value, IFormatProvider provider)
            => Convert.ToUInt64(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(string value, int fromBase)
            => Convert.ToUInt64(value, fromBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(object value, IFormatProvider provider)
            => Convert.ToUInt64(value, provider);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(string value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(object value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(decimal value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(int value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(short value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(double value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(DateTime value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(char value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(byte value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(bool value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(uint value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(long value)
            => Convert.ToUInt64(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(ulong value)
            => Convert.ToUInt64(value);

        #endregion

        public static bool TryToBase64Chars(
            ReadOnlySpan<byte> bytes,
            Span<char> chars,
            out int charsWritten,
            Base64FormattingOptions options = System.Base64FormattingOptions.None)
        {
            var byteBuffer = ArrayPool<byte>.Shared.Rent(bytes.Length);
            try
            {
                var charSize = (int)(Math.Ceiling((double)bytes.Length / 3.0d) * 4.0d) + 4;
                var charBuffer = ArrayPool<char>.Shared.Rent(charSize);
                try
                {
                    bytes.CopyTo(byteBuffer.AsSpan());
                    var written = Convert.ToBase64CharArray(byteBuffer, 0, bytes.Length, charBuffer, 0, options);
                    if (written < chars.Length)
                    {
                        charsWritten = default;
                        return false;
                    }
                    charBuffer.AsSpan().Slice(0, written).CopyTo(chars);
                    charsWritten = written;
                    return true;
                }
                finally
                {
                    ArrayPool<char>.Shared.Return(charBuffer);
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(byteBuffer);
            }
        }

        public static bool TryFromBase64String(string s, Span<byte> bytes, out int bytesWritten)
        {
            var byteBuffer = Convert.FromBase64String(s);
            if (byteBuffer.AsSpan().TryCopyTo(bytes))
            {
                bytesWritten = byteBuffer.Length;
                return true;
            }
            bytesWritten = default;
            return false;
        }

        public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = System.Base64FormattingOptions.None)
        {
            var byteBuffer = ArrayPool<byte>.Shared.Rent(bytes.Length);
            bytes.CopyTo(byteBuffer);
            try
            {
                return Convert.ToBase64String(byteBuffer, options);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(byteBuffer);
            }
        }
    }
}