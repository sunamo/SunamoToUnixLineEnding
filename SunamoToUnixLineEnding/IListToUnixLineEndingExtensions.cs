namespace SunamoToUnixLineEnding;

/// <summary>
/// Extension methods for converting line endings to Unix format in string lists.
/// </summary>
public static class IListToUnixLineEndingExtensions
{
    /// <summary>
    /// Converts all line endings in each element of the list to Unix line endings.
    /// </summary>
    /// <param name="list">The list of strings whose line endings will be converted.</param>
    /// <returns>The same list instance with all elements converted to Unix line endings.</returns>
    public static IList<string> ToUnixLineEnding(this IList<string> list)
    {
        for (var i = 0; i < list.Count; i++) list[i] = list[i].ToUnixLineEnding();
        return list;
    }
}
