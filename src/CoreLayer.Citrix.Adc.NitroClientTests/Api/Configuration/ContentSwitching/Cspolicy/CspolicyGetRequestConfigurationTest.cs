using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CspolicyGetRequestConfigurationValidationTestData))]
        public void CspolicyGetRequestConfigurationValidationTest(CspolicyGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CspolicyGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CspolicyGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy"},
                    {"Method", "GET"},
                    {"Options", ""}
                }
            };
            
            yield return new object[]
            {
                new CspolicyGetRequestConfiguration
                {
                    Options = new CspolicyGetRequestOptions
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy/instance1?attrs=Filter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new CspolicyGetRequestConfiguration
                {
                    Options = new CspolicyGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        },
                        ResourceName = "instance1",
                        Action = "testAction"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy/instance1?action=testAction"},
                    {"Method", "GET"},
                    {"Options", "/instance1?action=testAction"}
                }
            };        
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}