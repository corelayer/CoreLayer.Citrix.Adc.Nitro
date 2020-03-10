using CoreLayer.Citrix.Adc.NitroClient;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.NitroService
{
    public class NitroResponseTest
    {
        public NitroResponseDefault test = new NitroResponseDefault
        {
            ErrorCode = 0,
            Message = "message",
            Severity = "severity"
        };

        [Fact]
        public void NitroResponseDefaultTest()
        {
            Assert.Equal(0, test.ErrorCode);
            Assert.Equal("message", test.Message);
            Assert.Equal("severity", test.Severity);
        }
    }
}