using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingGetRequestConfigurationValidationTestData))]
        public void ServicegroupBindingGetRequestConfigurationValidationTest(
            ServicegroupBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServicegroupBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_binding?bulkbindings=yes"},
                    {"Options", "?bulkbindings=yes"},
                }, 
            };
            yield return new object[]
            {
                new ServicegroupBindingGetRequestConfiguration
                {
                    Options = new ServicegroupBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_binding?count=yes&attrs=Filter"},
                    {"Options", "?count=yes&attrs=Filter"}
                    
                }
            };
            yield return new object[]
            {
                new ServicegroupBindingGetRequestConfiguration
                {
                    Options = new ServicegroupBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_binding?attrs=ServiceGroupName"},
                    {"Options", "?attrs=ServiceGroupName"}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}