using CH3.LogAn.Interface;

namespace CH3.LogAn.UnitTests.FakeObject
{

    /// <summary>
    ///     3.4.1 擷取介面更換底層內容 - Fake Object
    /// </summary>
    class AlwaysVaildFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
