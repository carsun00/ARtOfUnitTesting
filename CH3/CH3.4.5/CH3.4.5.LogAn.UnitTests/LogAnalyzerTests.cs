using CH3._4._5.LogAn.UnitTests.FakeObject;
using NUnit.Framework;

namespace CH3._4._5.LogAn.UnitTests
{
    [TestFixture]
    class LogAnalyzerTests
    {
        #region 一般假物件。
        [Test]
        public void IsValidFileName_ValidName_RemembersTrue()
        {
            StubExtensionManager myFakeManager = new StubExtensionManager();
            myFakeManager.ShouldBeValid = true;

            LogAnalyzer log = new LogAnalyzer();
            //  將我們的虛設常式物件注入(依賴注入)
            log.ExtensionManager = myFakeManager;

            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }
        #endregion

    }
}
