using CH3.LogAn.Interface;

namespace CH3.LogAn.UnitTests.Stub
{

    /// <summary>
    ///     虛式常式
    ///         提供單元測試的狀態檢驗。
    /// </summary>
    internal class StubExtensionManager : IExtensionManager
    {
        public bool ShouldBeValid;

        public bool IsValid(string fileName)
        {
            return ShouldBeValid;
        }
    }
}
