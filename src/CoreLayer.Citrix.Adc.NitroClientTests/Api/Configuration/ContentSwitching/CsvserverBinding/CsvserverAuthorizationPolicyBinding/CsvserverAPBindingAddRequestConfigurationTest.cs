using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAPBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAPBindingAddRequestConfigurationValidationTestData))]
        public void CsvserverAPBindingAddRequestConfigurationValidationTest(
            CsvserverAuthorizationPolicyBindingAddRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverAPBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingAddRequestConfiguration(new CsvserverAuthorizationPolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAuthorizationPolicyBindingAddRequestData(),
                        new CsvserverAuthorizationPolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_authorizationpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_authorizationpolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_authorizationpolicy_binding\":[{}," +
                                       "{\"name\":\"test\"}]}"}   
                } 
            }; 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}