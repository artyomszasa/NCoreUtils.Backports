using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NCoreUtils
{
    public static unsafe class EncodingBackports
    {
        #if !NETSTANDARD2_1

        public static int GetChars(this Encoding encoding, ReadOnlySpan<byte> bytes, Span<char> chars)
        {
            fixed (byte* bytesPtr = &MemoryMarshal.GetReference(bytes))
            fixed (char* charsPtr = &MemoryMarshal.GetReference(chars))
            {
                return encoding.GetChars(bytesPtr, bytes.Length, charsPtr, chars.Length);
            }
        }

        public static int GetBytes(this Encoding encoding, ReadOnlySpan<char> chars, Span<byte> bytes)
        {
            fixed (byte* bytesPtr = &MemoryMarshal.GetReference(bytes))
            fixed (char* charsPtr = &MemoryMarshal.GetReference(chars))
            {
                return encoding.GetBytes(charsPtr, chars.Length, bytesPtr, bytes.Length);
            }
        }

        #endif
    }
}