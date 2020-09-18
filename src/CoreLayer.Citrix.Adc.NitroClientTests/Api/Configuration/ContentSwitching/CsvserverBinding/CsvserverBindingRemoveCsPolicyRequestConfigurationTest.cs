using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverCsPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingRemoveCsPolicyRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBindingRemoveCsPolicyRequestConfigurationValidationTestData))]
        public void CsvserverBindingRemoveCsPolicyRequestConfigurationValidationTest(
            CsvserverBindingRemoveCsPolicyRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CsvserverBindingRemoveCsPolicyRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBindingRemoveCsPolicyRequestConfiguration()
                {
                    Options = new CsvserverBindingRemoveCsPolicyRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testCsv"},{"policyname", "testPolicy"}}
                    }
                },
                new Dictionary<string, string>()
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_cspolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_cspolicy_binding?args=name:testCsv,policyname:testPolicy"},
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