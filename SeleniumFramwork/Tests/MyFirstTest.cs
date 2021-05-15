
using NUnit.Framework;
namespace Test
{
    [TestFixture]
    public class MyFirstTest : TestBase
    {
        [Test]
        public void NopCommerceDummyTest()
        {
            Pages.Home.isAt();
            Pages.Home.GoToComputers();
            Pages.Computers.isAt();
            Pages.Computers.EnterSearchText("Search for me");
            Pages.Computers.ClickSearch();
        }
    }
}