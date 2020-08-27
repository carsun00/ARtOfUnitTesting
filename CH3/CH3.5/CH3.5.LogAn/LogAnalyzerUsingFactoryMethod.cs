using CH3._5.LogAn.Model;

namespace CH3._5.LogAn
{
    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        {
            return this.IsValid(fileName);
        }

        /// <summary>
        ///     被測試類別中的方法，索回傳的是驗證完的結果。
        ///     同時給予了虛擬(virtual)的屬性
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected virtual bool IsValid(string fileName)
        {
            FileExtensionManager mgr= new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }
}
