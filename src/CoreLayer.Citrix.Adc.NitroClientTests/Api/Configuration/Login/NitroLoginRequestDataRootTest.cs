using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Login
{
    public class NitroLoginRequestDataRootTest
    {
        [Theory]
        [ClassData(typeof(NitroLoginRequestDataRootInitializationTestData))]
        public void NitroLoginRequestDataRootInitializationTest(NitroLoginRequestDataRoot data, string expected)
        {
            Assert.Equal(expected, data.Login.ToString());
        }
    }
}