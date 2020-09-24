using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuthorizationPolicyBinding
{
    public class CsvserverAuthorizationPolicyBindingRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAuthorizationPolicyBindingRemoveRequestConfigurationValidationTestData))]
        public void CsvserverAuthorizationPolicyBindingRemoveRequestConfigurationValidationTest(
            CsvserverAuthorizationPolicyBindingRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverAuthorizationPolicyBindingRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuthorizationPolicyBindingRemoveRequestConfiguration()
                {
                    Options = new CsvserverAuthorizationPolicyBindingRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testCsv"},{"policyname", "testPolicy"}}
                    }
                },
                new Dictionary<string, string>()
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_authorizationpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_authorizationpolicy_binding?args=name:testCsv,policyname:testPolicy"},
                    {"Options", "?args=name:testCsv,policyname:testPolicy"},
                } 
            };        
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}