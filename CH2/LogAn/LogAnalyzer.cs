using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        #region 系統狀態檢驗 (1/3)
        public bool WasLastFileNameValid { get; set; }
        #endregion

        public bool IsValidLogFileName(string fileName)
        {

            #region 系統狀態檢驗 (2/3)
            WasLastFileNameValid = false;
            #endregion

            #region 3.1~3.3 例外處理
            if(string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provided");
            }
            #endregion

            #region 1.1~2.2 一般測試

            if(!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }


            #region 系統狀態檢驗 (3/3)
            WasLastFileNameValid = true;
            #endregion
            return true;
            #endregion
        }
    }
}
