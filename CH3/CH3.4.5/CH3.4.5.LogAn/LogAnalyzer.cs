using CH3._4._5.LogAn.Interface;
using CH3._4._5.LogAn.Model;

namespace CH3._4._5.LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = new FileExtensionManager();
        }

        /// <summary>
        ///     允許透過get、set來設定相依物件。
        ///     
        ///     使用的時機
        ///         1.  這個相依物件非必要
        ///         2.  這個相依物件再測試過程中有預設值
        ///             EX: 狀態判斷
        /// </summary>
        public IExtensionManager ExtensionManager
        {
            get { return manager; }
            set { manager = value; }
        }
        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);

        }
    }
}
