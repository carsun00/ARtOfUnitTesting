using CH4._3.LogAn.Interface;

namespace CH4._3.LogAn.UnitTest.Services
{
    class FakeWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
