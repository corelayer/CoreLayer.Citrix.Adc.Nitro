using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingDosPolicyConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingDosPolicyConfigurationValidationTestData))]
        public void ServiceBindingDosPolicyConfigurationValidationTest(
            ServiceBindingDosPolicyConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ServiceBindingDosPolicyConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ServiceBindingDosPolicyConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingDosPolicyConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServiceBindingDosPolicyConfiguration()
                {
                    Name = "test",
                    PolicyName = "test2",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"policyname\":\"test2\",\"name\":\"test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}