// <copyright file="Pkce.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

// Copied from https://github.com/JerrettDavis/PkceChallenge/blob/main/PkceChallenge/Pkce.cs
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FishyFlip.Tools.Pkce;

/// <summary>
/// Pkce.
/// </summary>
public class Pkce
{
    /// <summary>
    /// Generate a PKCE code challenge from a code verifier.
    /// </summary>
    /// <param name="codeVerifier">Code Verifier.</param>
    /// <returns>Challenge string.</returns>
    public static string GenerateChallenge(string codeVerifier)
    {
        var hashBytes = codeVerifier.ToSHA256ByteArray();
        var base64Url = Convert.ToBase64String(hashBytes)
            .Replace("/", "_")
            .Replace("+", "-")
            .Replace("=", string.Empty);

        return base64Url;
    }

    /// <summary>
    /// Generate a PKCE challenge pair.
    /// </summary>
    /// <param name="length">Length of the verifier (between 43-128). Defaults to 43.</param>
    /// <returns>PKCE challenge pair.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Throw when the length is outside of the allowed range of 43-128.</exception>
    public static ChallengePair PkceChallenge(int? length = null)
    {
        length ??= 43;

        if (length is < 43 or > 128)
        {
            throw new ArgumentOutOfRangeException(
                nameof(length),
                $"Expected a length between 43 and 128. Received {length}.");
        }

        var verifier = GenerateVerifier(length.Value);
        var challenge = GenerateChallenge(verifier);

        return new(verifier, challenge);
    }

    /// <summary>
    /// Verify that a codeVerifier produces the expected code challenge.
    /// </summary>
    /// <param name="codeVerifier">The verifier to use to validate the challenge.</param>
    /// <param name="expectedChallenge">The code challenge to verify.</param>
    /// <returns>True if challengers are equal. False otherwise.</returns>
    public static bool VerifyChallenge(
        string codeVerifier,
        string expectedChallenge) =>
        GenerateChallenge(codeVerifier) == expectedChallenge;

    /// <summary>
    /// Creates an array of length `size` of random bytes.
    /// </summary>
    /// <param name="size">The length of the array.</param>
    /// <returns>Array of random bytes (0 to 255).</returns>
    private static byte[] GetRandomValues(int size)
    {
        var randomBytes = new byte[size];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomBytes);

        return randomBytes;
    }

    /// <summary>
    /// Generate a cryptographically strong random string.
    /// </summary>
    /// <param name="size">The desired length of the string.</param>
    /// <returns>The random string.</returns>
    private static string Random(int size)
    {
        const string mask = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._~";
        var builder = new StringBuilder();
        var randomBytes = GetRandomValues(size);

        for (var i = 0; i < size; i++)
        {
            var randomIndex = randomBytes[i] % mask.Length;
            builder.Append(mask[randomIndex]);
        }

        return builder.ToString();
    }

    /// <summary>
    /// Generate a PKCE challenge verifier.
    /// </summary>
    /// <param name="length">Length of the verifier.</param>
    /// <returns>A random verifier `length` characters long.</returns>
    private static string GenerateVerifier(int length) => Random(length);
}
