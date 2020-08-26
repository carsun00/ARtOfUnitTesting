using CH3._4._4.LogAnalyzer.Interface;
using System;

namespace CH3._4._4.LogAnalyzer.UnitTests.FakeObject
{
    internal class FakeExtensionManager : IExtensionManager
    {
       
        public bool WillBeValid = false;

        //  模擬異常
        public Exception WillThrow = null;
        public bool IsValid(string fileName)
        {
            if(WillThrow != null)
            { throw WillThrow; }
            return WillBeValid;
        }
    }
}
