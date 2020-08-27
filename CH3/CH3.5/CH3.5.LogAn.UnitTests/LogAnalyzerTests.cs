using NUnit.Framework;

namespace CH3._5.LogAn.UnitTests
{
    /// <summary>
    ///     不需要用介面就能控制被測試類別的另一種方法。
    ///     1.  可能沒有介面可以使用
    ///     2.  不想額外撰寫過多的程式。
    ///     
    ///     風險：
    ///         違反封裝的概念「隱藏所有使用類別所不需要看見的東西」。
    ///         將在CH3.6說明。
    /// </summary>
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void overrideTestWithStub()
        {
            //  初始化衍伸類別並給予回傳的結果。
            TestableLogAnalyzer logan = new TestableLogAnalyzer();
            logan.IsSupported = true;

            //  驗證測試
            bool result = logan.IsValidLogFileName("short.ext");
            Assert.True(result, "...");
        }
        /// <summary>
        ///     在衍伸類別中新增一個[IsSupported]
        ///     並覆寫[IsValid]方法，
        /// </summary>
        class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
        {
            public bool IsSupported;

            protected override bool IsValid(string fileName)
            {
                return IsSupported;
            }
        }
    }
}
