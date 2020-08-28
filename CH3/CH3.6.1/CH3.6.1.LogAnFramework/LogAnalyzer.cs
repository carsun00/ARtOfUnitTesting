using CH3._6._1.LogAnFramework.Interface;

namespace CH3._6._1.LogAnFramework
{

    public class LogAnalyzer
    {
        private IExtensionManager manager;

        internal LogAnalyzer(IExtensionManager extentonMgr)
        {
            manager = extentonMgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);

        }
    }
}
