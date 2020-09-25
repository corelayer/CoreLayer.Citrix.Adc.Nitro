using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFwPolicyBinding
{
    public class CsvAFwPBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvAFwPBindingAddRequestConfigurationValidationTestData))]
        public void CsvAFwPBindingAddRequestConfigurationValidationTest(
            CsvserverAppFwPolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvAFwPBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAppFwPolicyBindingAddRequestConfiguration(new CsvserverAppFwPolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAppFwPolicyBindingAddRequestData(),
                        new CsvserverAppFwPolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_appfwpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_appfwpolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_appfwpolicy_binding\":[{}," +
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