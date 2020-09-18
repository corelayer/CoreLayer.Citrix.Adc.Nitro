using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingLbmonitorConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingLbmonitorConfigurationValidationTestData))]
        public void ServiceBindingLbmonitorConfigurationValidationTest(
            ServiceBindingLbmonitorConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServiceBindingLbmonitorConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServiceBindingLbmonitorConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingLbmonitorConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServiceBindingLbmonitorConfiguration()
                {
                    MonitorConfiguredState = "test",
                    MonitorStatParameter1 = 100,
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"monstate\":\"test\",\"monstatparam1\":100}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}