using CH3._6._1.LogAnFramework.UnitTests.FakeObject;
using NUnit.Framework;

namespace CH3._6._1.LogAnFramework.UnitTests
{
    /// <summary>
    ///     在Framework中使用[internal]
    ///         1.  保持封裝的原則
    ///         2.  僅限定的專案可以開放存取
    ///             A.  到- CH3.6.1.LogAnFramework.Properties.AssemblyInfo.cs
    ///             B.  新增屬性 [assembly: InternalsVisibleTo("允許存取的專案")]
    ///             
    /// </summary>
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void overrideTestWithStub()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            //  初始化衍伸類別並給予回傳的結果。
            LogAnalyzer logan = new LogAnalyzer(myFakeManager);

            //  驗證測試
            bool result = logan.IsValidLogFileName("short.ext");
            Assert.True(result, "...");
        }
    }
}
