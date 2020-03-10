using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(PolicyStringMapBindingGetRequestConfigurationValidationTestData))]
        public async void PolicyStringMapBindingGetRequestConfigurationValidationtest(
            PolicyStringMapBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
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
    public class PolicyStringMapBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new PolicyStringMapBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/policystringmapbinding"},
                    {"RequestUri", "/nitro/v1/config/policystringmapbinding"},
                    {"Options", ""},
                    {"ValidationResult", "True"}
                }, 
            };
            yield return new object[]
            {
                new PolicyStringMapBindingGetRequestConfiguration
                {
                    Options = new PolicyStringMapBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/policystringmapbinding"},
                    {"RequestUri", "/nitro/v1/config/policystringmapbinding?attrs=wrongFilter"},
                    {"Options", "?attrs=wrongFilter"},
                    {"ValidationResult", "False"}
                }
            };
            yield return new object[]
            {
                new PolicyStringMapBindingGetRequestConfiguration
                {
                    Options = new PolicyStringMapBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/policystringmapbinding"},
                    {"RequestUri", "/nitro/v1/config/policystringmapbinding?attrs=Name"},
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