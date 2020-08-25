using NUnit.Framework;

namespace MemCalculator.UnitTests
{
    [TestFixture()]
    public class MemCalculatorTests
    {
        #region 1.1 預設值測試

        [Test()]
        public void Sum_ByDefault_ReturnZero()
        {
            MemCalculator calc = new MemCalculator();
            int lastSum = calc.Sum();
            Assert.AreEqual(0, lastSum);
        }
        #endregion

        #region 1.2 數值測試
        [Test()]
        public void Add_WhenCalled_ChangeSum()
        {
            MemCalculator calc = MakeCalc();
            calc.Add(1);
            int sum = calc.Sum();
            Assert.AreEqual(1, sum);
        }
        /// <summary>
        ///     使用工廠方法初始化物件，
        ///     優點
        ///     1.  提升程式可讀性
        ///     2.  保證每個物件都是以相同的方式建立。
        ///     3.  如果有多個地方使用上，只需要在一個地方修改程式碼，
        ///         提升測試的可維護性。
        /// </summary>
        /// <returns></returns>
        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();
        }
        #endregion
    }
}