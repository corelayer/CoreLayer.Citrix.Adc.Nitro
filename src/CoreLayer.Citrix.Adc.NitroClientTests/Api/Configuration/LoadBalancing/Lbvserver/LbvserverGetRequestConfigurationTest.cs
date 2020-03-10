using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverGetRequestConfigurationValidationTestData))]
        public async void LbvserverGetRequestConfigurationValidationTest(
            LbvserverGetRequestConfiguration configuration, 
            Dictionary<string, string> expected)
        {
            var result = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
            Assert.Equal(expected["ValidationResult"], result.IsValid.ToString());
        }
    }
    public class LbvserverGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"ValidationResult", "True"}
                    
                }
            };
            
            yield return new object[]
            {
                new LbvserverGetRequestConfiguration
                {
                    Options = new LbvserverGetRequestOptions
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver/instance1?attrs=wrongFilter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=wrongFilter"},
                    {"ValidationResult", "False"}
                }
            };
            yield return new object[]
            {
                new LbvserverGetRequestConfiguration
                {
                    Options = new LbvserverGetRequestOptions
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver/instance1?attrs=Name"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Name"},
                    {"ValidationResult", "True"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}