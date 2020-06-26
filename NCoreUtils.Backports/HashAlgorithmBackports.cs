using System;
using System.Buffers;
using System.Security.Cryptography;

namespace NCoreUtils
{
    #if !NETSTANDARD2_1
    public static class HashAlgorithmBackports
    {
        public static bool TryComputeHash(this HashAlgorithm alg, ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
        {
            var sourceBuffer = ArrayPool<byte>.Shared.Rent(source.Length);
            source.CopyTo(sourceBuffer);
            try
            {
                var destinationBuffer = alg.ComputeHash(sourceBuffer, 0, source.Length);
                if (destinationBuffer.AsSpan().TryCopyTo(destination))
                {
                    bytesWritten = destinationBuffer.Length;
                    return true;
                }
                bytesWritten = default;
                return false;
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(sourceBuffer);
            }
        }
    }
    #endif
}