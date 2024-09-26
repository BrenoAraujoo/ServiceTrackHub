﻿using System.Text.RegularExpressions;
using ServiceTrackHub.Domain.Enums.Common.Erros;

namespace ServiceTrackHub.Domain.Enums.ValueObjects;

public class SmartPhoneNumber : ValueObject
{
    public string Value { get; private set; }

    public SmartPhoneNumber(string value)
    {
        if (string.IsNullOrEmpty(value)||!IsValidPhone(value))
            throw new ArgumentException(ErrorMessage.InvalidPhone);
        Value = value;
    }

    public static bool IsValidPhone(string value)
    {
        if (value.Length != 11)
            return false;

        string pattern = @"^\d{11}$";
        return Regex.IsMatch(value, pattern);
    }

    public override bool IsValid(object value)
    {
        return IsValidPhone(value as string);
    }
}