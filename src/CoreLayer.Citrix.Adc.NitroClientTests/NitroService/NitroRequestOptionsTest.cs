using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.NitroService
{
    public class NitroRequestOptionsTest
    {
        [Theory]
        [ClassData(typeof(NitroRequestOptionsTestData))]
        public void NitroRequestOptionsDefaultTest(INitroRequestOptions data, string expected)
        {
            var result = data.ToString();
            
            Assert.Equal(expected, result);
        }
    }
}