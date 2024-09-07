// <copyright file="PkceExtensionMethods.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FishyFlip.Tools.Pkce;

/// <summary>
/// Pkce Extension Methods.
/// </summary>
public static class PkceExtensionMethods
{
    /// <summary>
    /// Convert a string to a SHA256 byte array.
    /// </summary>
    /// <param name="input">String input.</param>
    /// <returns>Hash.</returns>
    public static byte[] ToSHA256ByteArray(this string input)
    {
#if NET8_0_OR_GREATER
        return SHA256.HashData(Encoding.UTF8.GetBytes(input));
#else
        using var sha256 = SHA256.Create();
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
#endif
    }
}
