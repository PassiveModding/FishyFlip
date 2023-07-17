using System.Reflection;

namespace Fxbsky;

public static class ResourceHelpers
{
    internal static string GetResourceFileContentAsString(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        if (assembly is null)
        {
            return string.Empty;
        }

        var resourceName = "Fxbsky." + fileName;

        string? resource = null;
        using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream is null)
            {
                return string.Empty;
            }

            using StreamReader reader = new StreamReader(stream);
            resource = reader.ReadToEnd();
        }

        return resource ?? string.Empty;
    }
}
