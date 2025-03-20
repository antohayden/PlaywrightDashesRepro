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
        public async Task TestToDemoDashesIssue()
        {
            await Page.GotoAsync("https://www.thetimes.com/");

            // wait for the cookie banner to appear
            await Expect(Page.Locator("css=div[id*='sp_message_container']")).ToBeVisibleAsync();

            // Intentionally cause a timeout that generates formatted call log
            await Page.Locator("css=div[id='main-container']").ClickAsync(new() { Timeout = 5000 });
        }
    }
}
