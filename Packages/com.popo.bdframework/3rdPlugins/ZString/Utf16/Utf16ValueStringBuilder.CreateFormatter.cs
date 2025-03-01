using System;

namespace Cysharp.Text
{
    public partial struct Utf16ValueStringBuilder
    {
        static object CreateFormatter(Type type)
        {
            if (type == typeof(System.SByte))
            {
                return new TryFormat<System.SByte>((System.SByte x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Int16))
            {
                return new TryFormat<System.Int16>((System.Int16 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Int32))
            {
                return new TryFormat<System.Int32>((System.Int32 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Int64))
            {
                return new TryFormat<System.Int64>((System.Int64 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Byte))
            {
                return new TryFormat<System.Byte>((System.Byte x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.UInt16))
            {
                return new TryFormat<System.UInt16>((System.UInt16 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.UInt32))
            {
                return new TryFormat<System.UInt32>((System.UInt32 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.UInt64))
            {
                return new TryFormat<System.UInt64>((System.UInt64 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Single))
            {
                return new TryFormat<System.Single>((System.Single x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Double))
            {
                return new TryFormat<System.Double>((System.Double x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.TimeSpan))
            {
                return new TryFormat<System.TimeSpan>((System.TimeSpan x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.DateTime))
            {
                return new TryFormat<System.DateTime>((System.DateTime x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.DateTimeOffset))
            {
                return new TryFormat<System.DateTimeOffset>((System.DateTimeOffset x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Decimal))
            {
                return new TryFormat<System.Decimal>((System.Decimal x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Guid))
            {
                return new TryFormat<System.Guid>((System.Guid x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(System.Byte?))
            {
                return CreateNullableFormatter<System.Byte>();
            }
            if (type == typeof(System.DateTime?))
            {
                return CreateNullableFormatter<System.DateTime>();
            }
            if (type == typeof(System.DateTimeOffset?))
            {
                return CreateNullableFormatter<System.DateTimeOffset>();
            }
            if (type == typeof(System.Decimal?))
            {
                return CreateNullableFormatter<System.Decimal>();
            }
            if (type == typeof(System.Double?))
            {
                return CreateNullableFormatter<System.Double>();
            }
            if (type == typeof(System.Int16?))
            {
                return CreateNullableFormatter<System.Int16>();
            }
            if (type == typeof(System.Int32?))
            {
                return CreateNullableFormatter<System.Int32>();
            }
            if (type == typeof(System.Int64?))
            {
                return CreateNullableFormatter<System.Int64>();
            }
            if (type == typeof(System.SByte?))
            {
                return CreateNullableFormatter<System.SByte>();
            }
            if (type == typeof(System.Single?))
            {
                return CreateNullableFormatter<System.Single>();
            }
            if (type == typeof(System.TimeSpan?))
            {
                return CreateNullableFormatter<System.TimeSpan>();
            }
            if (type == typeof(System.UInt16?))
            {
                return CreateNullableFormatter<System.UInt16>();
            }
            if (type == typeof(System.UInt32?))
            {
                return CreateNullableFormatter<System.UInt32>();
            }
            if (type == typeof(System.UInt64?))
            {
                return CreateNullableFormatter<System.UInt64>();
            }
            if (type == typeof(System.Guid?))
            {
                return CreateNullableFormatter<System.Guid>();
            }
            if (type == typeof(System.Boolean?))
            {
                return CreateNullableFormatter<System.Boolean>();
            }
            if (type == typeof(System.IntPtr))
            {
                // ignore format
                return new TryFormat<System.IntPtr>((System.IntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> _) => System.IntPtr.Size == 4
                    ? x.ToInt32().TryFormat(dest, out written, default)
                    : x.ToInt64().TryFormat(dest, out written, default));
            }
            if (type == typeof(System.UIntPtr))
            {
                // ignore format
                return new TryFormat<System.UIntPtr>((System.UIntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> _) => System.UIntPtr.Size == 4
                    ? x.ToUInt32().TryFormat(dest, out written, default)
                    : x.ToUInt64().TryFormat(dest, out written, default));
            }
            return null;
        }
    }
}