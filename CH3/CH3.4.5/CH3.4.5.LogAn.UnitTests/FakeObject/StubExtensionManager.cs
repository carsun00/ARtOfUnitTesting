using CH3._4._5.LogAn.Interface;

namespace CH3._4._5.LogAn.UnitTests.FakeObject
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
