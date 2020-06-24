using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddLbmonitorRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingAddLbmonitorRequestConfigurationValidationTestData))]
        public void ServicegroupBindingAddLbmonitorRequestConfigurationValidationTest(
            ServicegroupBindingAddLbmonitorRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServicegroupBindingAddLbmonitorRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingAddLbmonitorRequestConfiguration(new ServicegroupBindingAddLbmonitorRequestDataRoot(
                    new dynamic[]
                    {
                        new ServicegroupBindingAddLbmonitorRequestData("test1"), 
                        new ServicegroupBindingAddLbmonitorRequestData("test2")
                        {
                            MonitorName = "testMon"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_lbmonitor_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_lbmonitor_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"servicegroup_lbmonitor_binding\":[{\"servicegroupname\":\"test1\"}," +
                                       "{\"servicegroupname\":\"test2\",\"monitor_name\":\"testMon\"}" +
                                       "]}"}
                }
            };          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}