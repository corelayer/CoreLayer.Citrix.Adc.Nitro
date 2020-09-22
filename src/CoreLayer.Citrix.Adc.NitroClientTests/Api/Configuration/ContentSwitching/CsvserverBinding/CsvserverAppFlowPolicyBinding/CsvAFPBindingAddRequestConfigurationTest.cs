using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding
{
    public class CsvAFPBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvAFPBindingAddRequestConfigurationValidationTestData))]
        public void CsvAFPBindingAddRequestConfigurationValidationTest(
            CsvserverAppFlowPolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvAFPBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAppFlowPolicyBindingAddRequestConfiguration(new CsvserverAppFlowPolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAppFlowPolicyBindingAddRequestData(),
                        new CsvserverAppFlowPolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_appflowpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_appflowpolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_appflowpolicy_binding\":[{}," +
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