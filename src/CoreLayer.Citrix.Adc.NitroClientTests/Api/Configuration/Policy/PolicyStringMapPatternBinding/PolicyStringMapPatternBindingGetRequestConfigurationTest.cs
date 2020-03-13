using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapPatternBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Policy.PolicyStringMapPatternBinding
{
    public class PolicyStringMapPatternBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(PolicyStringMapPatternBindingGetRequestTestValidationData))]
        public void PolicyStringMapPatternBindingGetRequestConfigurationValidationTest(
            PolicyStringMapPatternBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class PolicyStringMapPatternBindingGetRequestTestValidationData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new PolicyStringMapPatternBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"RequestUri", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new PolicyStringMapPatternBindingGetRequestConfiguration
                {
                    Options = new PolicyStringMapPatternBindingGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"RequestUri", "/nitro/v1/config/policystringmap_pattern_binding?attrs=wrongFilter"},
                    {"Options", "?attrs=wrongFilter"},
                    {"ValidationResult", "False"}
                }
            };
            yield return new object[]
            {
                new PolicyStringMapPatternBindingGetRequestConfiguration
                {
                    Options = new PolicyStringMapPatternBindingGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"RequestUri", "/nitro/v1/config/policystringmap_pattern_binding?attrs=Name"},
                    {"Options", "?attrs=Name"},
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