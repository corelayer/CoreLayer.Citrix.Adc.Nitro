using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServiceBindings;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServiceBindings
{
    public class ServiceBindingsGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceBindingsGetRequestConfigurationValidationTestData))]
        public void ServiceBindingsGetRequestConfigurationValidationTest(
            ServiceBindingsGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServiceBindingsGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceBindingsGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/svcbindings"},
                    {"RequestUri", "/nitro/v1/config/svcbindings"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new ServiceBindingsGetRequestConfiguration
                {
                    Options = new ServiceBindingsGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/svcbindings"},
                    {"RequestUri", "/nitro/v1/config/svcbindings?count=yes&attrs=Filter"},
                    {"Options", "?count=yes&attrs=Filter"}
                    
                }
            };
            yield return new object[]
            {
                new ServiceBindingsGetRequestConfiguration
                {
                    Options = new ServiceBindingsGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/svcbindings"},
                    {"RequestUri", "/nitro/v1/config/svcbindings?attrs=ServiceGroupName"},
                    {"Options", "?attrs=ServiceGroupName"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}