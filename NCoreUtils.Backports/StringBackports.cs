using System;

namespace NCoreUtils
{
    public static class StringBackports
    {
#if !NETSTANDARD2_1

        public static bool StartsWith(this string? input, char value)
            => !string.IsNullOrEmpty(input) && input![0] == value;

        public static bool EndsWith(this string? input, char value)
            => !string.IsNullOrEmpty(input) && input![input!.Length - 1] == value;

#endif
    }
}