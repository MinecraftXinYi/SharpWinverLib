﻿using System;

namespace SharpWinNTInterop;

public readonly partial struct BOOL : IComparable, IComparable<BOOL>, IEquatable<BOOL>, IFormattable
{
    public readonly byte Value;

    public BOOL(byte value) => Value = value;

    public static BOOL FALSE => new((byte)DefinedBoolValue.FALSE);

    public static BOOL TRUE => new((byte)DefinedBoolValue.DefaultTRUE);

    public static bool operator ==(BOOL left, BOOL right) => left.Value == right.Value;

    public static bool operator !=(BOOL left, BOOL right) => left.Value != right.Value;

    public static bool operator <(BOOL left, BOOL right) => left.Value < right.Value;

    public static bool operator <=(BOOL left, BOOL right) => left.Value <= right.Value;

    public static bool operator >(BOOL left, BOOL right) => left.Value > right.Value;

    public static bool operator >=(BOOL left, BOOL right) => left.Value >= right.Value;

    public static implicit operator bool(BOOL value) => DefinedBoolValueHelper.IsTrue(value.Value);

    public static implicit operator BOOL(bool value) => new(value ? (byte)DefinedBoolValue.DefaultTRUE : (byte)DefinedBoolValue.FALSE);

    public static bool operator false(BOOL value) => DefinedBoolValueHelper.IsFalse(value.Value);

    public static bool operator true(BOOL value) => DefinedBoolValueHelper.IsTrue(value.Value);

    public static implicit operator BOOL(sbyte value) => new((byte)value);

    public static explicit operator sbyte(BOOL value) => (sbyte)value.Value;

    public static implicit operator BOOL(short value) => new((byte)value);

    public static explicit operator short(BOOL value) => value.Value;

    public static implicit operator BOOL(int value) => new((byte)value);

    public static implicit operator int(BOOL value) => value.Value;

    public static explicit operator BOOL(long value) => new((byte)value);

    public static implicit operator long(BOOL value) => value.Value;

    public static explicit operator BOOL(nint value) => new((byte)value);

    public static implicit operator nint(BOOL value) => value.Value;

    public static implicit operator BOOL(byte value) => new(value);

    public static explicit operator byte(BOOL value) => value.Value;

    public static implicit operator BOOL(ushort value) => new((byte)value);

    public static explicit operator ushort(BOOL value) => value.Value;

    public static explicit operator BOOL(uint value) => new((byte)value);

    public static explicit operator uint(BOOL value) => value.Value;

    public static explicit operator BOOL(ulong value) => new((byte)value);

    public static explicit operator ulong(BOOL value) => value.Value;

    public static explicit operator BOOL(nuint value) => new((byte)value);

    public static explicit operator nuint(BOOL value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is BOOL other) return CompareTo(other);
        else return obj is null ? 1 : throw new ArgumentException(WErrorMessage.ObjNotBOOLEAN);
    }

    public int CompareTo(BOOL other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => obj is BOOL other && Equals(other);

    public bool Equals(BOOL other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => $"BOOLEAN:{DefinedBoolValueHelper.IsTrue(Value).ToString().ToUpper()}";

    public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotSupportedException(WErrorMessage.TargetAPINotSupported);

    public static bool BoolEquals(BOOL a, BOOL b) => (bool)a == (bool)b;

    public static bool ToBool(BOOL bOOL) => DefinedBoolValueHelper.IsTrue(bOOL.Value);
}
