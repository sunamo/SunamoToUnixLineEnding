// variables names: ok

namespace SunamoToUnixLineEnding.Tests;

/// <summary>
/// Tests for verifying Unix line ending conversion from file content.
/// </summary>
public class LoadingFromFileTests
{
    /// <summary>
    /// Tests that ToUnixLineEnding correctly converts Windows line endings to Unix line endings
    /// when reading from files.
    /// </summary>
    [Fact]
    public void ToUnixLineEnding_ConvertsWindowsLineEndings()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), "SunamoToUnixLineEnding_Tests");
        Directory.CreateDirectory(tempDirectory);

        var unixFilePath = Path.Combine(tempDirectory, "unix.txt");
        var windowsFilePath = Path.Combine(tempDirectory, "windows.txt");

        try
        {
            List<string> list = ["a", "c"];
            File.WriteAllText(unixFilePath, string.Join("\n", list));
            File.WriteAllText(windowsFilePath, string.Join("\r\n", list));

            var unixContent = File.ReadAllText(unixFilePath);
            var windowsContent = File.ReadAllText(windowsFilePath);

            var convertedContent = windowsContent.ToUnixLineEnding();

            Assert.Equal(unixContent, convertedContent);
            Assert.DoesNotContain("\r\n", convertedContent);
        }
        finally
        {
            if (File.Exists(unixFilePath)) File.Delete(unixFilePath);
            if (File.Exists(windowsFilePath)) File.Delete(windowsFilePath);
            if (Directory.Exists(tempDirectory)) Directory.Delete(tempDirectory, false);
        }
    }

    /// <summary>
    /// Tests that ToUnixLineEnding on IList converts all elements' line endings to Unix format.
    /// </summary>
    [Fact]
    public void ToUnixLineEnding_ConvertsList()
    {
        List<string> list = ["line1\r\nline2", "line3\r\nline4"];

        IList<string> convertedList = list.ToUnixLineEnding();

        Assert.Equal("line1\nline2", convertedList[0]);
        Assert.Equal("line3\nline4", convertedList[1]);
    }

    /// <summary>
    /// Runs the file-based line ending conversion test manually.
    /// </summary>
    internal void DoTest()
    {
        ToUnixLineEnding_ConvertsWindowsLineEndings();
        ToUnixLineEnding_ConvertsList();
    }
}
