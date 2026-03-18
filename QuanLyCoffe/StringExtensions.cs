using System.Text;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    public static string GenerateSlug(this string phrase)
    {
        string str = phrase.ToLower();

        // Bỏ dấu tiếng Việt
        str = RemoveDiacritics(str);

        // Xóa ký tự đặc biệt
        str = Regex.Replace(str, @"[^a-z0-9\s-]", "");

        // Đổi khoảng trắng thành dấu -
        str = Regex.Replace(str, @"\s+", "-").Trim('-');

        return str;
    }

    private static string RemoveDiacritics(string text)
    {
        var normalized = text.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (var c in normalized)
        {
            if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c)
                != System.Globalization.UnicodeCategory.NonSpacingMark)
            {
                sb.Append(c);
            }
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}
