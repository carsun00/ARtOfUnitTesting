using CH3._4._1.LogAn.Interface;
using System;

namespace CH3._4._1.LogAn
{
    /// <summary>
    ///     3.4.1 -
    /// </summary>
    class LogAnalyzerV2
    {

        public bool IsValidLogFileName(string fileName)
        {
            //  原本使用的方式
            //  FileExtensionManagerV2 mgr = new FileExtensionManagerV2();

            //  透過介面隔離出來
            IExtensionManager mgr=  new FileExtensionManagerV2();
            return mgr.IsValid(fileName);
        }
    }

    /// <summary>
    ///     3.4.1 
    ///     1.  擷取介面更換底層內容
    ///     2.  實作
    /// </summary>
    class FileExtensionManagerV2 : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            throw new NotImplementedException();
        }

    }
}
