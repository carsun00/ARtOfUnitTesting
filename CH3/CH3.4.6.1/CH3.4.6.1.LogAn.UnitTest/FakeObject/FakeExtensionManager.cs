using CH3._4._6._1.LogAn.Interface;

namespace CH3._4._6._1.LogAn.UnitTest.FakeObject
{
    /// <summary>
    ///     3.4.3 虛設常式內容
    ///     透過虛設常式，模擬相依物件中的運作與回傳資料。
    /// </summary>
    class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}
