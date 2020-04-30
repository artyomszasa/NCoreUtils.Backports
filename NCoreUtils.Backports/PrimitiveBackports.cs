using System;

namespace NCoreUtils
{
    public static class PrimitiveBackports
    {
        #if !NETSTANDARD2_1

        public static bool TryWriteBytes(this Guid guid, Span<byte> destination)
        {
            var data = guid.ToByteArray();
            if (destination.Length < data.Length)
            {
                return false;
            }
            data.AsSpan().CopyTo(destination);
            return true;
        }

        #endif
    }
}