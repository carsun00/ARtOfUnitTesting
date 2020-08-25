using NUnit.Framework;
using System;

namespace LogAn.UnitTests
{

    [TestFixture]
    class LogAnalyzerTests
    {

        #region 1.1 單一驗證
        /// <summary>
        ///     最基礎的驗證方法，
        ///     測試的參數寫死在程式中，
        ///     彈性不足，無法針對多個參數做驗證。
        /// 
        ///     方法名稱會建議下列格式
        ///     被測試的方法名稱_進行測試的假設條件_預期的行為結果。
        /// </summary>
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            Assert.False(result);
        }
        #endregion

        #region 1.2 驗證大小寫。
        /// <summary>
        ///     假設今天要驗證檔案名稱的大小，需要撰寫兩個測試
        ///     這樣假設有10個測試案例，舊需要撰寫10個測試程式，
        ///     會降低撰寫測試程式的意願。
        /// </summary>
        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");

            Assert.True(result);
        }
        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");

            Assert.True(result);
        }
        #endregion

        #region 2.1 使用TestCase驗證多Case
        /// <summary>
        ///     改使用[TestCase]的方法，讓一個測試程式可以測試多種參數。
        /// </summary>
        /// <param name="file"></param>
        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            Assert.True(result);
        }
        #endregion

        #region 2.2 使用TestCase進行複合性驗證(正確與錯誤)
        /// <summary>
        ///     這個測試內容包含了兩種內容
        ///     1.  測試副檔名的大小寫
        ///     2.  錯誤的副檔名時驗證應該要失敗。
        /// </summary>
        /// <param name="file"></param>
        /// <param name="expected"></param>
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName_VariousExtensions_ChecksThem(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, result);
        }
        #endregion

        #region 3.1 例外基礎Function
        /// <summary>
        ///     提供後續程式進行測試使用
        /// </summary>
        /// <returns></returns>
        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
        #endregion

        #region 3.2 例外測試1 - 不建議使用
        /// <summary>
        ///     這個方法是在Nunit2.0中所使用，
        ///     當前版本3.0已經移除。
        ///     
        ///     主要內容在描述，例外的測試撰寫方式，
        ///     下面這個方法是一個不推薦的撰寫方式
        /// </summary>
        /*
        [Test]
        [ExpectedException(typeof(ArgumentException),
              ExpectedMessage = "filename has to be provided")]
        public void IsValidLogFileName_EmptyFileName_ThrowsException()
        {
            LogAnalyzer la = MakeAnalyzer();
            la.IsValidLogFileName(string.Empty);
        }
        */
        #endregion

        #region 3.3 例外測試2 - 一般使用方式
        /// <summary>
        ///     主要內容在描述，例外的測試撰寫方式，
        ///     透過Assert.Throws的方式，進行例外的驗證
        ///     書中原本使用Assert.Catch()
        /// </summary>
        [Test]
        public void IsValidLogFileName_EmptyFileName_Throws()
        {
            LogAnalyzer la = MakeAnalyzer();

            //Assert.Throws<錯誤類型>
            var ex = Assert.Throws<ArgumentException>(() => la.IsValidLogFileName(""));

            //  簡化字串相關的驗證
            StringAssert.Contains("filename has to be provided", ex.Message);
            /*  一般來說驗證結果是使用[ Assert.AreEqual]
             *  但是在字串的測試上，經常會發生變化
             *  但使用[ StringAssert.Contains ]可以針對[不正常]的字串自動做處理，
             *          #待補充
             */

        }


        /// <summary>
        ///     網路上所尋找到的另外一種驗證方式。
        /// </summary>
        [Test]
        public void IsValidLogFileName_EmptyFileName_ThrowsException()
        {
            LogAnalyzer la = MakeAnalyzer();
            Assert.That(() => la.IsValidLogFileName(string.Empty),
                        //  Throws.TypeOf<錯誤類型>());
                        Throws.TypeOf<ArgumentException>());

        }
        #endregion

        #region 3.4例外測試 - 流利語法(Fluent syntax)

        [Test]
        public void IsValidLogFileName_EmptyFileName_ThrowsFluent()
        {
            LogAnalyzer la = MakeAnalyzer();

            var ex = Assert.Throws<ArgumentException>(() => la.IsValidLogFileName(""));

            //  The Text prefix is deprecated beginning with NUnit 2.5.1 and will be removed in NUnit 3.0.
            //  Assert.That(ex.Message, Is.StringContaining("filename has to be provided"));
            //  http://nunitsoftware.com/nunitv2/index.php?p=compatibility&r=2.7.0
            Assert.That(ex.Message, Does.Contain("filename has to be provided"));
        }


        #endregion

        #region 4.1 忽略測試
        /*
        /// <summary>
        ///     緊急情況下，忽略某一些測試。
        ///     此狀況應該是非常罕見，
        ///     如果經常性出現代表流程規劃有疑問。
        /// </summary>
        [Test]
        [Ignore("there is a problem with this test")]
        public void NoTestSyntax()
        {
            Assert.Fail();
        }
        */
        #endregion

        #region 5.1 測試分類(特性)

        /// <summary>
        ///     根據[Category("類型")]
        ///     可以將每一個測試進行分類。
        ///     提升檢驗報告的可讀性。
        ///     Test Explorer的特性欄位，可以進行篩選。
        /// </summary>
        [Test]
        [Category("Fast Test")]
        public void CategoryA()
        {
            //  Do something
            Assert.Pass();
        }
        [Test]
        [Category("Fast Test")]
        public void CategoryB()
        {
            //  Do something
            Assert.Pass();
        }
        #endregion

        #region 6.1 系統狀態檢查- 第一版
        /// <summary>
        ///     透過呼叫[IsValidLogFileName]來驗證[WasLastFileNameValid]的狀態
        ///
        ///     因此方法名稱格式
        ///     被測試的方法名稱_當被呼叫_被修改過的狀態驗證。
        /// </summary>
        [Test]
        public void IsValidLogFileName_WhenCalled_ChangesWasLastFileNameValid()
        {
            LogAnalyzer la = MakeAnalyzer();

            la.IsValidLogFileName("badname.foo");

            Assert.IsFalse(la.WasLastFileNameValid);
        }

        #region 6.2 系統狀態檢查- 第二版

        #endregion
        /// <summary>
        ///     針對[6.1]進行重購，
        ///     同時使用[TestCase來進行多個案例測試]
        /// </summary>
        /// <param name="file"></param>
        /// <param name="expected"></param>
        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        public void IsValidLogFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer la = MakeAnalyzer();

            la.IsValidLogFileName(file);

            Assert.AreEqual(expected, la.WasLastFileNameValid);
        }
        #endregion
    }
}
