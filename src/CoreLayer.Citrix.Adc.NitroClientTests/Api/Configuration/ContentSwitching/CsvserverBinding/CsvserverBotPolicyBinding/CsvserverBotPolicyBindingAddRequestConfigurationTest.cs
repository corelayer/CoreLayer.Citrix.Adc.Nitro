using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBotPolicyBindingAddRequestConfigurationValidationTestData))]
        public void CsvserverBotPolicyBindingAddRequestConfigurationValidationTest(
            CsvserverBotPolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverBotPolicyBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBotPolicyBindingAddRequestConfiguration(new CsvserverBotPolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverBotPolicyBindingAddRequestData(),
                        new CsvserverBotPolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_botpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_botpolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_botpolicy_binding\":[{}," +
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