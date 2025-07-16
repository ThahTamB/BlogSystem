using System.Text.RegularExpressions;

namespace BlogSystem.Helpers
{
    public static class SlugHelper
    {
        public static string GenerateSlug(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return "";

            // Lowercase
            title = title.ToLowerInvariant();

            // Remove invalid chars
            title = Regex.Replace(title, @"[^a-z0-9\s-]", "");

            // Convert multiple spaces into one dash
            title = Regex.Replace(title, @"\s+", "-").Trim();

            // Remove duplicate dashes
            title = Regex.Replace(title, @"-+", "-");

            return title;
        }
    }
}
