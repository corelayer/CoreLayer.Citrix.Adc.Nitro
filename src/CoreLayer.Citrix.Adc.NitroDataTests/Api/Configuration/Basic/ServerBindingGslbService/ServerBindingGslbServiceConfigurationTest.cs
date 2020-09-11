using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServerBindingGslbService
{
    public class ServerBindingGslbServiceConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingGslbServiceConfigurationValidationTestData))]
        public void ServerBindingGslbServiceConfigurationValidationTest(
                    ServerBindingGslbServiceConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServerBindingGslbServiceConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServerBindingGslbServiceConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingGslbServiceConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServerBindingGslbServiceConfiguration()
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