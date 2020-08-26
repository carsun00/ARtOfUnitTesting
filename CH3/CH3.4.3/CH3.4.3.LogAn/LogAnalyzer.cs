using CH3._4._3.LogAn.Interface;

namespace CH3._4._3.LogAn
{
    /// <summary>
    ///     3.4.2 依賴注入：在被測試單元中注入一個假的實作內容
    ///     
    ///     步驟
    ///     1.  在建構函式中得到一個介面的物件，並將其封存到欄位(field)中供後續使用
    ///     2.  在屬性的get或set方法中得到一個介面的物件，並將其存到欄位中供後續使用。
    ///     3.  透過下列其中一種方式，在被測試方法呼叫之前獲得一個介面的假物件。
    ///         A.  方法的參數(參數注入)
    ///         B.  工廠類別
    ///         C.  區域工廠方法(local factory method)
    ///         D.  前面幾種方法的變形
    /// </summary>
    public class LogAnalyzer
    {
        #region InterFace 隔離相依

        /// <summary>
        ///     透過 InterFace 取出程式中驗證讀取檔案的程式。
        /// </summary>
        private IExtensionManager manager;

        /// <summary>
        ///      建構函式
        ///         方法的參數注入
        ///         
        ///      缺點： 假如今天有10個物件
        ///             參數列會繼續增長下去，但可以透過別的方法解決。
        /// </summary>
        /// <param name="mgr"></param>
        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }
        #endregion

        /// <summary>
        ///     原本一般Obj使用的方式都是 New 一個新的物件，
        ///     現在透過[InterFace]
        ///     建構函式注入[LogAnalyzerCH3(IExtensionManager mgr)] 的方式建立，
        ///     達到介面隔離解除外部依賴。
        ///     
        ///     又稱之為「方法的參數注入」。
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);
        }
    }
}
