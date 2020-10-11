using CH4._3.LogAn.UnitTest.Services;
using NUnit.Framework;

namespace CH4._3.LogAn.UnitTest
{
    public class Tests
    {
        [Test]
        public void Amalyze_TooShortFileName_CallWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("Filename too short:abc.ext", mockService.LastError);
        }
    }
}