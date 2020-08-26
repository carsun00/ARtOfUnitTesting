using CH3.LogAn.UnitTests.FakeObject;
using NUnit.Framework;

namespace CH3.LogAn.UnitTests
{
    [TestFixture]
    class LogAnalyzer3Tests
    {

        #region 一般假物件。
        [Test]
        public void IsValidFileName_ValidName_RemembersTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            LogAnalyzerCH3 log = new LogAnalyzerCH3(myFakeManager);
            
            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }
        #endregion

        #region 3.4.5 提供屬性設定的方式。
        /// <summary>
        ///     使用這個方法的時機，
        ///     1.  對於被測試的工作單元來說，這個相依物件式非必要的。
        ///         EX: 今天有一個驗證登入並更新資訊功能，
        ///         只要測試更新資訊功能這部分，
        ///         那麼驗證登入對於這個側式的工作單元就是非必要的。
        ///     2.  在初始化物件時會有預設的的執行個體，
        ///         EX: 預設值
        ///         同第一點
        /// </summary>
        public void IsValidFileName_SupportedExtension_ReturnsTrue()
        {
            LogAnalyzerCH3 log = new LogAnalyzerCH3();
            //  log.ExtensionManager = 某些虛設常式的處理;
            //  Assert的驗證邏輯
        }
        #endregion
    }
}
