using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServerBindingService
{
    public class ServerBindingServiceConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingServiceConfigurationValidationTestData))]
        public void ServerBindingServiceConfigurationValidationTest(ServerBindingServiceConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServerBindingServiceConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }
    
    public class ServerBindingServiceConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingServiceConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServerBindingServiceConfiguration()
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