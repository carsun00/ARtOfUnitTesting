using System;

namespace CH3._4._1.LogAn
{
    /// <summary>
    ///     3.4.1 -
    /// </summary>
    class LogAnalyzer
    {

        public bool IsValidLogFileName(string fileName)
        {
            FileExtensionManager mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }

    /// <summary>
    ///     3.4.1 擷取介面更換底層內容 - 實作
    /// </summary>
    class FileExtensionManager
    {
        public bool IsValid(string fileName)
        {
            throw new NotImplementedException();
        }

    }
}
