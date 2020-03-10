using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Login
{
    public class NitroLoginResponseTest
    {
        private readonly NitroLoginResponse _test;

        public NitroLoginResponseTest()
        {
            _test = new NitroLoginResponse
            {
                ErrorCode = 0,
                Severity = "severity",
                Message = "message",
                SessionId = "sessionid"
            };
        }

        [Fact]
        public void TestNitroLoginResponseEqual()
        {
            Assert.Equal(0, _test.ErrorCode);
            Assert.Equal("severity", _test.Severity);
            Assert.Equal("message", _test.Message);
            Assert.Equal("sessionid", _test.SessionId);
        }

        [Fact]
        public void TestNitroLoginResponseInvalid()
        {
            Assert.NotEqual(1, _test.ErrorCode);
            Assert.NotEqual("Severity", _test.Severity);
            Assert.NotEqual("Message", _test.Message);
            Assert.NotEqual("Sessionid", _test.SessionId);
        }
        
        
    }
}