using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServiceBinding
{
    public class ServiceBindingAddLbmonitorRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingAddLbmonitorRequestConfigurationValidationTestData))]
        public void ServiceBindingAddLbmonitorRequestConfigurationValidationTest(
            ServiceBindingAddLbmonitorRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServiceBindingAddLbmonitorRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingAddLbmonitorRequestConfiguration(new ServiceBindingAddLbmonitorRequestDataRoot(
                    new dynamic[]
                    {
                        new ServiceBindingAddLbmonitorRequestData("test1"), 
                        new ServiceBindingAddLbmonitorRequestData("test2")
                        {
                            Monitor_Name = "testMon"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/service_lbmonitor_binding"},
                    {"RequestUri", "/nitro/v1/config/service_lbmonitor_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"service_lbmonitor_binding\":[{\"name\":\"test1\"}," +
                                       "{\"name\":\"test2\",\"monitor_name\":\"testMon\"}" +
                                       "]}"}
                }
            };          }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}