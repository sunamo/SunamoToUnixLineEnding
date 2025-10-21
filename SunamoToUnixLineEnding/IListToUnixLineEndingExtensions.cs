// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoToUnixLineEnding;

public static class IListToUnixLineEndingExtensions
{
    public static IList<string> ToUnixLineEnding(this IList<string> t)
    {
        for (var i = 0; i < t.Count; i++) t[i] = t[i].ToUnixLineEnding();
        return t;
    }
}