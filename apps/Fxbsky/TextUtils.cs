using System.Text.RegularExpressions;

namespace Fxbsky;

public static class TextUtils
{
    public static string SanitizeText(string text)
    {
        return Regex.Replace(text, "\"", "&#34;")
            .Replace("'", "&#39;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }

    public static string UnescapeText(string text)
    {
        return Regex.Replace(text, "&#34;", "\"")
            .Replace("&#39;", "'")
            .Replace("&lt;", "<")
            .Replace("&gt;", ">")
            .Replace("&amp;", "&");
    }
}
