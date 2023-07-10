// <copyright file="CreatePostResponse.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace FishyFlip.Models;

public class CreatePostResponse
{
    [JsonConstructor]
    public CreatePostResponse(AtUri uri, Cid cid)
    {
        this.Cid = cid;
        this.Uri = uri;
    }

    public Cid Cid { get; }

    public AtUri Uri { get; }
}

public class PutPostResponse
{
    [JsonConstructor]
    public PutPostResponse(AtUri uri, Cid cid)
    {
        this.Cid = cid;
        this.Uri = uri;
    }

    public Cid Cid { get; }

    public AtUri Uri { get; }
}