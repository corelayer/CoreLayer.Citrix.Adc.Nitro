using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServerBindingGslbServiceGroup
{
    public class ServerBindingGslbServiceGroupConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingGslbServiceGroupConfigurationValidationTestData))]
        public void ServerBindingGslbServiceGroupConfigurationValidationTest(
            ServerBindingGslbServiceGroupConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServerBindingGslbServiceGroupConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServerBindingGslbServiceGroupConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingGslbServiceGroupConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServerBindingGslbServiceGroupConfiguration()
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