using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddCsPolicyRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBindingAddCsPolicyRequestConfigurationValidationTestData))]
        public void CsvserverBindingAddCsPolicyRequestConfigurationValidationTest(
            CsvserverBindingAddCsPolicyRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CsvserverBindingAddCsPolicyRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBindingAddCsPolicyRequestConfiguration(new CsvserverBindingAddCsPolicyRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverBindingAddCsPolicyRequestData("testName"),
                        new CsvserverBindingAddCsPolicyRequestData("testName2")
                        {
                            PolicyName = "testPolicy"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_cspolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_cspolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_cspolicy_binding\":[{\"name\":\"testName\"}," +
                                       "{\"name\":\"testName2\",\"policyname\":\"testPolicy\"}]}"}   
                } 
            };        
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}