using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServiceBindings
{
    public class ServiceBindingsConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingsConfigurationValidationTestData))]
        public void ServiceBindingsConfigurationValidationTest(ServiceBindingsConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServiceBindingsConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServiceBindingsConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingsConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServiceBindingsConfiguration()
                {
                    ServiceName = "test",
                    ServerState = "test2",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicename\":\"test\",\"svrstate\":\"test2\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}