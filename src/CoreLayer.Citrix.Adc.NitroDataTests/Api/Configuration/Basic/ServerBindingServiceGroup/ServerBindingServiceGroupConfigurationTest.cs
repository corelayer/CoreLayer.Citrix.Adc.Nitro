using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServerBindingServiceGroup
{
    public class ServerBindingServiceGroupConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingServiceGroupConfigurationValidationTestData))]
        public void ServerBindingServiceGroupConfigurationValidationTest(
            ServerBindingServiceGroupConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServerBindingServiceGroupConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServerBindingServiceGroupConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingServiceGroupConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServerBindingServiceGroupConfiguration()
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