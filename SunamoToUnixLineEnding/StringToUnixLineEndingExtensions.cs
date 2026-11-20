namespace SunamoToUnixLineEnding;

/// <summary>
/// Represents the string to unix line ending extensions type.
/// </summary>
public static class StringToUnixLineEndingExtensions
{
    /// <summary>
    /// To unix line ending.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The to unix line ending result.</returns>
    public static string ToUnixLineEnding(this string text)
    {
        return text.Replace(Consts2.CarriageReturnNewline, Consts2.Newline).Replace("\r", Consts2.Newline);
    }
}
