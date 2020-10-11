
#define Debug
using CH3._6._2.LogAn.UnitTests.FakeObject;
using NUnit.Framework;
using System.Diagnostics;

namespace CH3._6._2.LogAn.UnitTests
{
    [TestFixture]
    class LogAnalyzerTests
    {

        [Test]
        public void overrideTestWithStub()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            //  初始化衍伸類別並給予回傳的結果。
            LogAnalyzer logan = new LogAnalyzer();

            logan.BuildLogAnalyzer(myFakeManager);
            //  驗證測試
            bool result = logan.IsValidLogFileName("short.ext");
            Assert.True(result, "...");
        }
        
    }

}
