using System.Text.RegularExpressions;

namespace Materialempfehlung.Helper
{
    internal static class StringHelper
    {

        internal static string BreiteEntfernen(string artikelnummer)
        {
            if (!string.IsNullOrEmpty(artikelnummer))
            {
                var regexMatch = Regex.Match(artikelnummer, "[-]\\w*$").Value;
                return artikelnummer[..^regexMatch.Length];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
