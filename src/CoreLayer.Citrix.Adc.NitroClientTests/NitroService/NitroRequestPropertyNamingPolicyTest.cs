using CoreLayer.Citrix.Adc.NitroClient;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.NitroService
{
    public class NitroRequestPropertyNamingPolicyTest
    {
        private readonly NitroRequestPropertyNamingPolicy test = new NitroRequestPropertyNamingPolicy();
        
        [Fact]
        public void ConvertNameTest()
        {
            var result = test.ConvertName("Name");
            Assert.Equal("name", result);
        }
    }
}