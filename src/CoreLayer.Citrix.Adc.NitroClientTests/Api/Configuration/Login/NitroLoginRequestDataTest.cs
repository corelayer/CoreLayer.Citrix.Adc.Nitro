using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Login
{
    public class NitroLoginRequestDataTest
    {
        private readonly NitroLoginRequestData _test;

        public NitroLoginRequestDataTest()
        {
            _test = new NitroLoginRequestData("nsroot","nsroot", 8000);
        }
        
        [Fact]
        public void TestNitroLoginRequestData()
        {
            Assert.Equal("nsroot", _test.Username);
            Assert.Equal("nsroot", _test.Password);
            Assert.Equal(8000, _test.Timeout);
            Assert.Equal("{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":\"8000\"}", _test.ToString());
        }
    }
}