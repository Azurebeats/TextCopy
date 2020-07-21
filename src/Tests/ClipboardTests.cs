using System.Threading.Tasks;
using TextCopy;
using Xunit;

public class ClipboardTests
{
    [Fact]
    public async Task Simple()
    {
        VerifyInner("Foo");
        VerifyInner("🅢");
        await VerifyInnerAsync("Foo");
        await VerifyInnerAsync("🅢");
    }

    static void VerifyInner(string expected)
    {
        ClipboardService.SetText(expected);

        var actual = new Clipboard().GetText();
        Assert.Equal(expected, actual);
    }

    static async Task VerifyInnerAsync(string expected)
    {
        await new Clipboard().SetTextAsync(expected);

        var actual = await ClipboardService.GetTextAsync();
        Assert.Equal(expected, actual);
    }
}