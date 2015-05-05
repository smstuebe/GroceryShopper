using NUnit.Framework;
using Xamarin.UITest;

namespace GroceryShopper.XamarinUITest
{
    [TestFixture]
    public class UiConsole
    {
        private IApp _app;

        [SetUp]
        public void TestSetup()
        {
            _app = XamarinUiTestInitializer.ConfigureAndStart(Platform.Android, false);
        }

        [Test]
        public void StartREPL()
        {
            _app.Repl();
        }
    }
}