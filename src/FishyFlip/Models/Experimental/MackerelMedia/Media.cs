// <copyright file="Media.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace FishyFlip.Models.Experimental.MackerelMedia;

/// <summary>
/// Media Record.
/// </summary>
public class Media : ATRecord
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Media"/> class.
    /// </summary>
    /// <param name="mimeType">The MIME type of the image.</param>
    /// <param name="size">The size of the image in bytes.</param>
    /// <param name="type">The type of the image.</param>
    [JsonConstructor]
    public Media(string? mimeType, int size, string? type)
        : base(type)
    {
        this.MimeType = mimeType;
        this.Size = size;
        this.Type = type ?? Constants.Experimental.MackerelMediaTypes.Media;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Media"/> class from a CBOR object.
    /// </summary>
    /// <param name="image">The CBOR object representing the image.</param>
    public Media(CBORObject image)
    {
        this.Type = image["$type"]?.AsString() ?? Constants.Experimental.MackerelMediaTypes.Media;
        this.Size = image["size"]?.AsInt32() ?? 0;
        this.MimeType = image["mimeType"]?.AsString() ?? string.Empty;
        var refObj = image["ref"];
        if (refObj is not null)
        {
            this.Ref = new MediaRef(image["ref"]);
        }
    }

    /// <summary>
    /// Gets the MIME type of the image.
    /// </summary>
    public string? MimeType { get; }

    /// <summary>
    /// Gets the size of the image in bytes.
    /// </summary>
    public int Size { get; }

    /// <summary>
    /// Gets or sets the reference to the image.
    /// </summary>
    [JsonPropertyName("ref")]
    public MediaRef? Ref { get; set; }
}