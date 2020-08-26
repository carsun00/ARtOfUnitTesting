using CH3._4._4.LogAnalyzer.UnitTests.FakeObject;
using NUnit.Framework;
using System;

namespace CH3._4._4.LogAnalyzer.UnitTests
{
    class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_ValidName_RemembersTrue()
        {
            //  虛式常式物件
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            //  指定狀態
            myFakeManager.WillThrow = new Exception("這是錯誤例外訊息。");

            //  方法參數注入
            LogAnalyzer log = new LogAnalyzer(myFakeManager);

            bool result = log.IsValidLogFileName("AlwaysEception.err");
            Assert.False(result);
        }
    }
}
