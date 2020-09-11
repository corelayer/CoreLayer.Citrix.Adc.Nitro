using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServerBinding
{
    public class ServerBindingConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingConfigurationValidationTestData))]
        public void ServerBindingConfigurationValidationTest(ServerBindingConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServerBindingConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServerBindingConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServerBindingConfiguration()
                {
                    Name = "key",
                    
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"key\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}