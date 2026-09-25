namespace SunamoToUnixLineEnding;

public static class StringToUnixLineEndingExtensions
{
    public static string ToUnixLineEnding(this string text)
    {
        return text.Replace(Consts2.CarriageReturnNewline, Consts2.Newline).Replace("\r", Consts2.Newline);
    }
}
