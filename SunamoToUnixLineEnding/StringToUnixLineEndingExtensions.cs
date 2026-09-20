namespace SunamoToUnixLineEnding;

/// <summary>
/// Extension methods for converting line endings to Unix format in strings.
/// </summary>
public static class StringToUnixLineEndingExtensions
{
    /// <summary>
    /// Converts all line endings in the string to Unix line endings (LF only).
    /// </summary>
    /// <param name="text">The string whose line endings will be converted.</param>
    /// <returns>The string with all line endings replaced by Unix line feed characters.</returns>
    public static string ToUnixLineEnding(this string text)
    {
        return text.Replace(Consts2.CarriageReturnNewline, Consts2.Newline).Replace("\r", Consts2.Newline);
    }
}
