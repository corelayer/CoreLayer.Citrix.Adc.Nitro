using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAQPBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAQPBindingAddRequestConfigurationValidationTestData))]
        public void CsvserverAQPBindingAddRequestConfigurationValidationTest(
            CsvserverAppQoePolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverAQPBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAppQoePolicyBindingAddRequestConfiguration(new CsvserverAppQoePolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAppQoePolicyBindingAddRequestData(),
                        new CsvserverAppQoePolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_appqoepolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_appqoepolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_appqoepolicy_binding\":[{}," +
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