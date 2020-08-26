using CH3._4._4.LogAnalyzer.Interface;
using System;

namespace CH3._4._4.LogAnalyzer
{
    /// <summary>
    ///     本章節專注在測如何模擬異常的測試
    ///     
    /// </summary>
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        /// <summary>
        ///     為了讓測試通過，導致這個方法要增一個例外處理。
        ///     書中也有說明，不建議這樣的例外寫法，因為如果未來程式追蹤異常，
        ///     我們會無法得知在哪段程式中判斷錯誤，導致問題追蹤困難。
        /// 
        ///     如果要維持原本的程式，測試方法要改寫成Exception。
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool IsValidLogFileName(string fileName)
        {
            try
            {
                return manager.IsValid(fileName);
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}