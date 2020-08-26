using CH3._4._3.LogAn.UnitTests.FakeObject;
using NUnit.Framework;

namespace CH3._4._3.LogAn.UnitTests
{
    class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_ValidName_RemembersTrue()
        {
            //  虛式常式物件
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            //  指定狀態
            myFakeManager.WillBeValid = true;

            //  方法參數注入
            LogAnalyzer log = new LogAnalyzer(myFakeManager);

            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }
    }
}
