// MarkdownRenderingIssueTest.cs
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightMarkdownIssueRepro
{
    [TestFixture]
    public class MarkdownRenderingIssueTest : PageTest
    {
        [Test]
        public async Task Test_Timeout_With_HTML_And_Dashes()
        {
            await Page.GotoAsync("https://example.com");

            // Intentionally cause a timeout that generates formatted call log
            await Page.Locator("//button[text()='Sign In']").ClickAsync(new() { Timeout = 1000 });
        }
    }
}
