using CH3._6._1.LogAnFramework.Interface;

namespace CH3._6._1.LogAnFramework.UnitTests.FakeObject
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
