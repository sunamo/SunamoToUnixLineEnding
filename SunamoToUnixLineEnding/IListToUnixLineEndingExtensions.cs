namespace SunamoToUnixLineEnding;

public static class IListToUnixLineEndingExtensions
{
    public static IList<string> ToUnixLineEnding(this IList<string> list)
    {
        for (var i = 0; i < list.Count; i++) list[i] = list[i].ToUnixLineEnding();
        return list;
    }
}
