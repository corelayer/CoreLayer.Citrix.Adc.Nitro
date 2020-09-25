using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBotPolicyBindingRemoveRequestConfigurationValidationTestData))]
        public void CsvserverBotPolicyBindingRemoveRequestConfigurationValidationTest(
            CsvserverBotPolicyBindingRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverBotPolicyBindingRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBotPolicyBindingRemoveRequestConfiguration()
                {
                    Options = new CsvserverBotPolicyBindingRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testCsv"},{"policyname", "testPolicy"}}
                    }
                },
                new Dictionary<string, string>()
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_botpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_botpolicy_binding?args=name:testCsv,policyname:testPolicy"},
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