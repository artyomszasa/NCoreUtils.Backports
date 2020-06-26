using System;

namespace NCoreUtils
{
    #if !NETSTANDARD2_1
    public static class PrimitiveBackports
    {
        public static bool TryWriteBytes(this Guid guid, Span<byte> destination)
            => guid.ToByteArray().AsSpan().TryCopyTo(destination);
    }
    #endif
}