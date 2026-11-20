namespace SunamoToUnixLineEnding;

/// <summary>
/// Represents the i list to unix line ending extensions type.
/// </summary>
public static class IListToUnixLineEndingExtensions
{
    /// <summary>
    /// To unix line ending.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The to unix line ending result.</returns>
    public static IList<string> ToUnixLineEnding(this IList<string> list)
    {
        for (var i = 0; i < list.Count; i++) list[i] = list[i].ToUnixLineEnding();
        return list;
    }
}
