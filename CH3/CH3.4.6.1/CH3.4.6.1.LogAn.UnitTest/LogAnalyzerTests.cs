using CH3._4._6._1.LogAn;
using CH3._4._6._1.LogAn.Factory;
using CH3._4._6._1.LogAn.UnitTest.FakeObject;
using NUnit.Framework;

namespace CH3._4._6._1.LogAn.UnitTest
{
    /// <summary>
    ///     測試程式
    /// </summary>
    class LogAnalyzerTests
    {
        /// <summary>
        ///     1.  初始化一個[IExtensionManager]的虛設常式物件(Stub)
        ///     
        ///     2.  使用工廠模式
        ///         在[ExtensionManagerFactory] 中，
        ///         回傳一個[IExtensionManager] 的虛設常式物件。
        ///         
        ///     3.  P.80 的補充說明
        /// </summary>
        [Test]
        public void IsValidFileName_SupportedExtension_RetrunsTrue()
        {
            /* 
             *      層次深度1：針對類別中的[FileExtensionManager]變數 
             *          新增一個建構函式參數[FakeExtensionManager]的[WillBeValid]
             *      
             *      缺點
             *          此方法應該要儘量避免，會違反[OCP 開放封閉原則]的概念。
             *          不必要的參數可以被公開存取。
             */
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            /*  
             *      層次深度2：針對從工廠注入被測試類別的相依物件
             *          透過工廠模式的賦值給予一個假的相依物件[FakeExtensionManager]
             *          因為是「Stub」所以在被測試的程式中完全不需要調整。
             *          
             *      缺點
             *          需要了解誰會呼叫工廠，
             *          因此在使用這個方法前需要先對程式有一定程度的了解。
             */
            ExtensionManagerFactory.SetManager(myFakeManager);

            /*  
             *      層次深度3：針對返回物件的工廠類別
             *          將工廠類別值接替換成一個假工廠，
             *              對應Code new LogAnalyzer()
             *          假工廠會回傳一個假的相依物件，
             *              LogAnalyzer() 中 ExtensionManagerFactory.Create();
             *          
             *          因為上方Code： ExtensionManagerFactory.SetManager(myFakeManager);
             *          已經將物件注入了因此再測試過程中，
             *          工廠是假的、相依物件也是假的。
             *          被測試類別完全不需要調整。
             *          
             *      缺點
             *          要自己建立一個假工廠，
             *          如果沒有介面，可能還要先重構產生介面出來。
             *          同時一個假工廠還有一個假的相依物件，會導致測試程式碼難以閱讀。
             *          
             *      解決方法：使用區域的工廠方法(擷取與覆寫)     
             */
            LogAnalyzer log = new LogAnalyzer();

            //  執行驗證邏輯
            bool result = log.IsValidLogFileName("file.ext");
            Assert.IsFalse(result, "File name should be too short to be considered valid");
        }

    }

}
