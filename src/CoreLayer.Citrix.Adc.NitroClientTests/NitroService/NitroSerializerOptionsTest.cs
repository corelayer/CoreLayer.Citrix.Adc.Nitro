using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.NitroService
{
    public class NitroSerializerOptionsTest
    {
        private readonly JsonSerializerOptions _test = NitroServiceSerializerOptions.JsonSerializerOptions;
        
        [Theory]
        [ClassData(typeof(NitroSerializerOptionsTestData))]
        public void JsonSerializerOptionsTest(NitroLoginRequestData dataRoot, string expected)
        {
            var serializedCredentials = JsonSerializer.Serialize(dataRoot, _test);

            Assert.Equal(expected, serializedCredentials);
        }
    }
}