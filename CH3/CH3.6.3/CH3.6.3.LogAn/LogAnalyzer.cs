using CH3._6._3.LogAn.Interface;
using System.IO;

namespace CH3._6._3.LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        #if DEBUG
        public LogAnalyzer(IExtensionManager extentonMgr)
        {
            manager = extentonMgr;
        }
        #endif

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName)
                && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }
    }
}
