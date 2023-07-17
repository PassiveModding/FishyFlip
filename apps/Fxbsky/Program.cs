// <copyright file="Program.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlip;
using FishyFlip.Models;
using FishyFlip.Tools;
using Fxbsky;
using HandlebarsDotNet;

var handlebarTemplate = Handlebars.Compile(ResourceHelpers.GetResourceFileContentAsString("Templates.Base.hbs") ?? throw new NullReferenceException());

var atProtocolBuilder = new ATProtocolBuilder()
    .EnableAutoRenewSession(true);

var atProtocol = atProtocolBuilder.Build() ?? throw new NullReferenceException();
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

#if DEBUG
app.MapGet("/", (Func<string>)(() => "Hello World!"));
#else
app.MapGet("/", () => Results.Redirect("https://github.com/drasticactions/FishyFlip"));
#endif
app.MapGet("/profile/{handle}/post/{rkey}", InvokeProxy);

async Task InvokeProxy(string handle, string rkey, HttpContext context)
{
    try
    {
        ArgumentNullException.ThrowIfNull(atProtocol);

        var atHandle = ATHandle.Create(handle) ?? throw new Exception($"Error creating handle: {handle}");
        var actorRecord = (await atProtocol.Repo.GetActorAsync(atHandle)).HandleResult();
        if (actorRecord?.Uri is not ATUri uri || actorRecord?.Value?.Avatar is not Image image)
        {
            throw new Exception("Error getting actor record");
        }

        var avatarLink = $"{atProtocol.Options.Url}/{Constants.Urls.ATProtoSync.GetBlob}?did={uri.Did!}&cid={image.Ref!.Link!}";
        var post = (await atProtocol.Repo.GetPostAsync(atHandle, rkey)).HandleResult();
        var images = new List<ImageLink>();

        if (post?.Value?.Embed is ImagesEmbed imageEmbed)
        {
            foreach (var img in imageEmbed.Images ?? Array.Empty<ImageEmbed>())
            {
                var imageUri = img.Image?.Ref?.Link;
                if (imageUri is not null)
                {
                    images.Add(new($"{atProtocol.Options.Url}/{Constants.Urls.ATProtoSync.GetBlob}?did={uri.Did!}&cid={imageUri}"));
                }
            }
        }

        var html = handlebarTemplate.Invoke(new
        {
            Handle = handle,
            RedirectUrl = $"https://bsky.app/profile/{handle}/post/{rkey}",
            OnlyText = !images.Any(),
            Text = TextUtils.SanitizeText(post?.Value?.Text ?? string.Empty),
            Author = actorRecord?.Value?.DisplayName ?? handle,
            Images = images,
        });
        await context.Response.WriteAsync(html);
    }
    catch (Exception ex)
    {
        // Worst case is to redirect and log the error.
        Results.Redirect($"https://bsky.app/profile/{handle}/post/{rkey}");
    }
}

app.Run();

class ImageLink
{
    public ImageLink(string img)
    {
        this.Link = img;
    }

    public string Link { get; set; } = string.Empty;
}