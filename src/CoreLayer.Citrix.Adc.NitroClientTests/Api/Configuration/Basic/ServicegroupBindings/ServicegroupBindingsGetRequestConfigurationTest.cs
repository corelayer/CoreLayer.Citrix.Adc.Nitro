using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBindings;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBindings
{
    public class ServicegroupBindingsGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingsGetRequestConfigurationValidationTestData))]
        public void ServicegroupBindingsGetRequestConfigurationValidationTest(
            ServicegroupBindingsGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServicegroupBindingsGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingsGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroupbindings"},
                    {"RequestUri", "/nitro/v1/config/servicegroupbindings"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new ServicegroupBindingsGetRequestConfiguration
                {
                    Options = new ServicegroupBindingsGetRequestOptions("test")
                    {
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }, 
                        Count = true
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroupbindings"},
                    {"RequestUri", "/nitro/v1/config/servicegroupbindings/test?count=yes&attrs=Filter"},
                    {"Options", "/test?count=yes&attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new ServicegroupBindingsGetRequestConfiguration
                {
                    Options = new ServicegroupBindingsGetRequestOptions("test")
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
                    {"ResourcePath", "/nitro/v1/config/servicegroupbindings"},
                    {"RequestUri", "/nitro/v1/config/servicegroupbindings/test?attrs=ServiceGroupName"},
                    {"Options", "/test?attrs=ServiceGroupName"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}