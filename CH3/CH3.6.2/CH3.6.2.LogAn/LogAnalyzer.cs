using CH3._6._2.LogAn.Interface;
using System.Diagnostics;

namespace CH3._6._2.LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        /// <summary>
        ///     使用前提
        ///         1.  使用方要宣告定義 [ #define Debug ]
        ///             請參考CH3.6.2.LogAn.UnitTests.LogAnalyzerTests
        ///         2.  被使用方要宣告   [Conditional("Debug")] 
        ///             
        ///     如果是Release的編譯，將會忽略這個方法。    
        /// </summary>
        /// <param name="extentonMgr"></param>
        [Conditional("Debug")]
        public void BuildLogAnalyzer(IExtensionManager extentonMgr)
        {
            manager = extentonMgr;
        }


        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);

        }
    }
}
