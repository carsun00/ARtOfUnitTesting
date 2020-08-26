using CH3._4._3.LogAn.Interface;

namespace CH3._4._3.LogAn.UnitTests.FakeObject
{
    class FakeExtensionManager : IExtensionManager
    {
        //  方法的參數注入
        public bool WillBeValid = false;
        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}
