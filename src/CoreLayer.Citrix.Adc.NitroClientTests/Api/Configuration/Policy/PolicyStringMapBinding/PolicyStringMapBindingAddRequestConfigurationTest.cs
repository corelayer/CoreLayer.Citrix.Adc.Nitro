using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingInsertRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(PolicyStringMapBindingAddRequestConfigurationValidationTestData))]
        public async void PolicyStringMapBindingInsertRequestConfigurationValidationTest(
            PolicyStringMapBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
        }
    }
    public class PolicyStringMapBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[]
            {
                new PolicyStringMapBindingAddRequestConfiguration(
                    new PolicyStringMapBindingAddRequestDataRoot(
                        new PolicyStringMapBindingAddRequestData[]
                            {new PolicyStringMapBindingAddRequestData("test1", "testKey", "testValue")}
                        )
                    )
                , 
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"RequestUri", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"DataRootData", "name:test1, key:testKey, value:testValue"},
                    {"Options", ""},
                    {"RequestContent", "{\"policystringmap_pattern_binding\":[{\"name\":\"test1\",\"key\":\"testKey\",\"value\":\"testValue\"}]}"},
                    {"ValidationResult", "True"}
                }
            };
            yield return new object[]
            {
                new PolicyStringMapBindingAddRequestConfiguration(
                    new PolicyStringMapBindingAddRequestDataRoot(
                        new PolicyStringMapBindingAddRequestData[]
                            {new PolicyStringMapBindingAddRequestData("test1", "testKey", "testValue"),new PolicyStringMapBindingAddRequestData("test2", "key2", "value2") }
                    )
                )
                , 
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"RequestUri", "/nitro/v1/config/policystringmap_pattern_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"policystringmap_pattern_binding\":[{\"name\":\"test1\",\"key\":\"testKey\",\"value\":\"testValue\"}," +
                                       "{\"name\":\"test2\",\"key\":\"key2\",\"value\":\"value2\"}]}"},
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