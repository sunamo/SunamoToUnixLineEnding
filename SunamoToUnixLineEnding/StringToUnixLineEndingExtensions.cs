namespace SunamoToUnixLineEnding;

public static class StringToUnixLineEndingExtensions
{
    public static string ToUnixLineEnding(this string text)
    {
        return text.ReplaceLineEndings(Consts2.Newline);
    }
}
