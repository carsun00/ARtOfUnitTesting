using CH3._4._6._2.LogAn.Interface;
using CH3._4._6._2.LogAn.Model;

namespace CH3._4._6._2.LogAn
{
    public class LogAnalyzerUsingFactoryMethod
    {
        /// <summary>
        ///     程式碼中正常使用該工廠。
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool IsValidLogFileName(string fileName)
        {
            return GetManager().IsValid(fileName);
        }

        /// <summary>
        ///     被測試類別的區域虛擬方法(protected virtual)。
        ///     新的虛擬工廠方法並回傳一個物件的執行個體
        /// </summary>
        /// <returns></returns>
        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}
