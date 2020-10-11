using CH3._6._2.LogAn.Interface;

namespace CH3._6._2.LogAn.UnitTests.FakeObject
{
    class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}
