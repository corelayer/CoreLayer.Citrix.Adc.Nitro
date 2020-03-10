using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbmonitorGetRequestConfigurationValidationTestData))]
        public async void LbmonitorGetRequestConfigurationValidationTest(LbmonitorGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
        }
    }
    public class LbmonitorGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbmonitorGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"ValidationResult", "True"}
                    
                }
            };
            
            yield return new object[]
            {
                new LbmonitorGetRequestConfiguration
                {
                    Options = new LbmonitorGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor/instance1?attrs=wrongFilter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=wrongFilter"},
                    {"ValidationResult", "False"}
                }
            };
            yield return new object[]
            {
                new LbmonitorGetRequestConfiguration
                {
                    Options = new LbmonitorGetRequestOptions
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "MonitorName"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor/instance1?attrs=MonitorName"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=MonitorName"},
                    {"ValidationResult", "True"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}