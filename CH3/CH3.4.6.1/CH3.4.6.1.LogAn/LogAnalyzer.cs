using CH3._4._6._1.LogAn.Factory;
using CH3._4._6._1.LogAn.Interface;
using System.IO;

namespace CH3._4._6._1.LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName)
                && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }
    }
}
