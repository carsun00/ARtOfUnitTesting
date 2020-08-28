using CH3._6._1.LogAn.Interface;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CH3.6.1.LogAn.UnitTests")]
namespace CH3._6._1.LogAn
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
