using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetLbmonitorRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingGetLbmonitorRequestConfigurationValidationTestData))]
        public void ServicegroupBindingGetLbmonitorRequestConfigurationValidationTest(
            ServicegroupBindingGetLbmonitorRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServicegroupBindingGetLbmonitorRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingGetLbmonitorRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_lbmonitor_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_lbmonitor_binding?bulkbindings=yes"},
                    {"Options", "?bulkbindings=yes"},
                }, 
            };
            yield return new object[]
            {
                new ServicegroupBindingGetLbmonitorRequestConfiguration
                {
                    Options = new ServicegroupBindingGetLbmonitorRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }, Count = true
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_lbmonitor_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_lbmonitor_binding?bulkbindings=yes&count=yes&attrs=Filter"},
                    {"Options", "?bulkbindings=yes&count=yes&attrs=Filter"}
                    
                }
            };
            yield return new object[]
            {
                new ServicegroupBindingGetLbmonitorRequestConfiguration
                {
                    Options = new ServicegroupBindingGetLbmonitorRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "ServiceGroupName"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_lbmonitor_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_lbmonitor_binding?bulkbindings=yes&attrs=ServiceGroupName"},
                    {"Options", "?bulkbindings=yes&attrs=ServiceGroupName"}
                }
            };         }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}