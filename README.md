# NCoreUtils.Backports [![Build Status](https://travis-ci.org/artyomszasa/NCoreUtils.Backports.svg?branch=master)](https://travis-ci.org/artyomszasa/NCoreUtils.Backports)

_`Span`/`ReadOnlySpan`/`Memory`/`ReadOnlyMemory` related extensions and polyfills._

NETStandard 2.1 introduced variuos method variations that take advantage of generified memory usage. While all related
structures are available through `System.Memory` package the methods are not available _out-of-box_. In order to keep up
with the .NET evolution newly created packages sgould use these new features. If you maintain lots of applications that
still targets earlier versions of .NET not supporting these features one must either upgrade all of them to the newer
versions of .NET or maintain compatiblity in all dependencies. And sometimes an upgrade is not an option...

`NCoreUtils.Backports` provides extensions and polyfills to make your life easier if you have to keep your packages
compatible with older versions of .NET while adapting new functionality when used with newer .NET versions.

## Installing
You can install [`NCoreUtils.Backports`](https://www.nuget.org/packages/NCoreUtils.Backports) package through NuGet:

```
dotnet add package NCoreUtils.Backports
```

When used with `TargetFramework` below .NETStandard2.1 the library is shipped with the project providing various
extensions.

When used with .NETStandard2.1 or above the library contains no extensions and can be excluded from references, e.g.:
```xml
<ItemGroup Condition=" '$(TargetFramework)' == 'netstandard2.0' ">
  <PackageReference Include="NCoreUtils.Backports" Version="x.y.z" />
</ItemGroup>
```

## Usage

The only purpose of shipping .NETStandard2.1 version is to provide even more easy way to use the backports (i.e.
completely without preprocesor directives):

```csharp
using Convert = NCoreUtils.PolyfillConvert;

/* ... */

  ReadOnlySpan<byte> data = /* ... */;
  var b64String = Convert.ToBase64String(data);

/* ... */
```

When dependency is added conditionally some preprocessing is still needed:
```csharp
#if NETSTADRD2_0
using Convert = NCoreUtils.PolyfillConvert;
#else
using Convert = System.Convert;
#endif

/* ... */

  ReadOnlySpan<byte> data = /* ... */;
  var b64String = Convert.ToBase64String(data);

/* ... */
```

## Polyfills

`NCoreUtils.Backports` provides two polyfill static classes:
* `PolfillConvert` -- provides all methods of `System.Convert` including `Span`/`ReadOnlySpan` based methods;
* `PolyfillBitConverter` -- provides all methods of `System.BitConverter` including `Span`/`ReadOnlySpan` based methods.

All non-`Span`/`ReadOnlySpan` methods are propagated directly to the BCL implmentation, e.g.:
```csharp

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ulong ToUInt64(ushort value)
      => Convert.ToUInt64(value);

```

## Extensions

Extensions methods are only included in library targeting .NETStandard 2.0 or .NET Framework.

Extensions methods:
* `System.Text.Encoding`:
  * [`GetChars`](https://docs.microsoft.com/hu-hu/dotnet/api/system.text.encoding.getchars?view=netstandard2.1#System_Text_Encoding_GetChars_System_ReadOnlySpan_System_Byte__System_Span_System_Char__)
  * [`GetBytes`](https://docs.microsoft.com/hu-hu/dotnet/api/system.text.encoding.getbytes?view=netstandard2.1#System_Text_Encoding_GetBytes_System_ReadOnlySpan_System_Char__System_Span_System_Byte__)
* `System.Security.Cryptography.HashAlgorithm`:
  * [`TryComputeHash`](https://docs.microsoft.com/hu-hu/dotnet/api/system.security.cryptography.hashalgorithm.trycomputehash?view=netstandard-2.1#System_Security_Cryptography_HashAlgorithm_TryComputeHash_System_ReadOnlySpan_System_Byte__System_Span_System_Byte__System_Int32__)
* `System.IO.Stream`:
  * [`Read`](https://docs.microsoft.com/hu-hu/dotnet/api/system.io.stream.read?view=netstandard-2.1#System_IO_Stream_Read_System_Span_System_Byte__)
  * [`ReadAsync`](https://docs.microsoft.com/hu-hu/dotnet/api/system.io.stream.readasync?view=netstandard-2.1#System_IO_Stream_ReadAsync_System_Memory_System_Byte__System_Threading_CancellationToken_)
  * [`Write`](https://docs.microsoft.com/hu-hu/dotnet/api/system.io.stream.write?view=netstandard-2.1#System_IO_Stream_Write_System_ReadOnlySpan_System_Byte__)
  * [`WriteAsync`](https://docs.microsoft.com/hu-hu/dotnet/api/system.io.stream.writeasync?view=netstandard-2.1#System_IO_Stream_WriteAsync_System_ReadOnlyMemory_System_Byte__System_Threading_CancellationToken_)
* `System.Guid`:
  * [`TryWriteBytes`](https://docs.microsoft.com/hu-hu/dotnet/api/system.guid.trywritebytes?view=netstandard-2.1)
* `System.String`:
  * [`StartsWith`](https://docs.microsoft.com/hu-hu/dotnet/api/system.string.startswith?view=netstandard-2.1#System_String_StartsWith_System_Char_)
  * [`EndsWith`](https://docs.microsoft.com/hu-hu/dotnet/api/system.string.endswith?view=netstandard-2.1)

Furthermore the library provides `System.Net.Http` related content:
* [`ReadOnlyMemoryContent`](https://docs.microsoft.com/hu-hu/dotnet/api/system.net.http.readonlymemorycontent?view=netstandard-2.1)