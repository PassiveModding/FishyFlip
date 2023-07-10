// <copyright file="FrameHeader.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyFlip.Models;

public class FrameHeader
{
    [System.Text.Json.Serialization.JsonPropertyName("op")]
    public int Operation { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("t")]
    public string Type { get; set; }
}