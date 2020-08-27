using CH3._4._6._2.LogAn.Interface;
using NUnit.Framework;

namespace CH3._4._6._2.LogAn.UnitTests
{
    /// <summary>
    ///     適合用在模擬被測試類別的輸入，
    ///     不適用在驗證對相依物件的呼叫。
    ///     
    ///     EX：
    ///         Web服務得到一個回傳值，想要模擬自訂的回傳資料 <- 擷取與覆寫
    ///         驗證被測試類別與Web服務的互動，就需要撰寫大量程式碼，建議改用隔離(Isolation)
    ///         
    ///         隔離(Isolation)於第四章節說明
    /// </summary>
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void overrideTest()
        {
            FakeExtensionManager stub = new FakeExtensionManager();
            stub.WillBeValid = true;

            /* 
             *  初始化測試專案中新增的衍生類別物件[ TestableLogAnalyzer ]，
             *  而非被測試物件[ LogAnalyzerUsingFactoryMethod ]
             */
            TestableLogAnalyzer log = new TestableLogAnalyzer(stub);

            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }

        /// <summary>
        ///     偽造方法
        ///         因為[GetManager()]被宣告為虛擬方法，
        ///         因此可以在衍伸(繼承)的子類別中被覆寫
        ///         
        ///         子類別：父類別
        ///         TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
        ///         
        ///     將工廠介面擷取出來，並覆寫回傳的工廠類型。
        /// 
        /// </summary>
        class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
        {
            public TestableLogAnalyzer(IExtensionManager mgr)
            {
                Manager = mgr;
            }

            /// <summary>
            ///     針對要取代的介面(IExtensionManager)建立一個公開的欄位(Manager)
            /// </summary>
            public IExtensionManager Manager;

            /// <summary>
            ///     覆寫的虛擬工廠方法。
            ///     
            ///     回傳公開的方法。
            /// </summary>
            /// <returns></returns>
            protected override IExtensionManager GetManager()
            {
                return Manager;
            }
        }

        /// <summary>
        ///     實作一個[IExtensionManager]虛設常式物件
        /// </summary>
        internal class FakeExtensionManager : IExtensionManager
        {
            public bool WillBeValid = false;

            public bool IsValid(string fileName)
            {
                return WillBeValid;
            }
        }
    }
}
