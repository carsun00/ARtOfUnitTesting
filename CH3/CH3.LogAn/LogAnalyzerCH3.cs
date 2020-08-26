using CH3.LogAn.Interface;

namespace CH3.LogAn
{
    public class LogAnalyzerCH3
    {
        #region InterFace 隔離相依

        /// <summary>
        ///     透過 InterFace 取出程式中驗證讀取檔案的程式。
        /// </summary>
        private IExtensionManager manager;

        /// <summary>
        ///      建構函式
        ///      缺點： 假如今天有10個物件
        ///             參數列會繼續增長下去。
        /// </summary>
        /// <param name="mgr"></param>
        public LogAnalyzerCH3(IExtensionManager mgr)
        {
            manager = mgr;
        }
        #endregion


        #region 3.4.5 透過屬性的方式驗證參數。

        public IExtensionManager ExtensionManager
        {
            get { return  manager; }
            set { manager = value; }
        }
        /// <summary>
        ///     
        /// </summary>
        public LogAnalyzerCH3()
        {
            manager = new FileExtensionManager(); ;
        }
        #endregion


        public bool IsValidLogFileName(string fileName)
        {

            #region 3.4.1 
            /*  
             *  原本一般Obj使用的方式都是 New 一個新的物件，
             *  現在透過
             *      InterFace
             *      建構函式注入 [ LogAnalyzerCH3(IExtensionManager mgr) ]的方式建立，
             *  達到介面隔離解除外部依賴。
             */
            //  IExtensionManager mgr = new FileExtensionManager();
            #endregion
            return manager.IsValid(fileName);
        }
    }
}
