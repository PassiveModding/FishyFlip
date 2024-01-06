// <copyright file="ATRecordJsonConverter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace FishyFlip.Tools.Json;

#pragma warning disable IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
public class ATRecordJsonConverter : JsonConverter<ATRecord>
{
    public override ATRecord? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (JsonDocument.TryParseValue(ref reader, out var doc))
        {
            if (doc.RootElement.TryGetProperty("$type", out var type))
            {
                var text = type.GetString()?.Trim() ?? string.Empty;
                var rawText = doc.RootElement.GetRawText();
                switch (text)
                {
                    case Constants.FeedType.Like:
                        return JsonSerializer.Deserialize<Like>(doc.RootElement.GetRawText(), options);
                    case Constants.FeedType.Post:
                        return JsonSerializer.Deserialize<Post>(doc.RootElement.GetRawText(), options);
                    case Constants.FeedType.Repost:
                        return JsonSerializer.Deserialize<Repost>(doc.RootElement.GetRawText(), options);
                    case Constants.GraphTypes.Follow:
                        return JsonSerializer.Deserialize<Follow>(doc.RootElement.GetRawText(), options);
                    default:
#if DEBUG
                        System.Diagnostics.Debugger.Break();
#endif
                        break;
                }
            }
        }

        return null;
    }

    public override void Write(Utf8JsonWriter writer, ATRecord value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
#pragma warning restore IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code