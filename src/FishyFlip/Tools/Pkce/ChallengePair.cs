// <copyright file="ChallengePair.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace FishyFlip.Tools.Pkce;

/// <summary>
/// Challenge Pair for PKCE.
/// </summary>
/// <param name="CodeVerifier">Code Verifier.</param>
/// <param name="CodeChallenge">Code Challenge.</param>
public record ChallengePair(string CodeVerifier, string CodeChallenge);
