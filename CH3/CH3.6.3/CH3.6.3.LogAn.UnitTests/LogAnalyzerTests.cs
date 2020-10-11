using CH3._6._3.LogAn.UnitTests.FakeObject;
using NUnit.Framework;

namespace CH3._6._3.LogAn.UnitTests
{
    class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_SupportedExtension_RetrunsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            LogAnalyzer log = new LogAnalyzer(myFakeManager);

            //  執行驗證邏輯
            bool result = log.IsValidLogFileName("file.ext");
            Assert.IsFalse(result, "File name should be too short to be considered valid");
        }

    }
}
