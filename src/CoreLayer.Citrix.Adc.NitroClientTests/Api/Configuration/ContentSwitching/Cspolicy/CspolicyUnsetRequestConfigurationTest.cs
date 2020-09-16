using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUnsetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CspolicyUnsetRequestConfigurationValidationTestData))]
        public void CspolicyUnsetRequestConfigurationValidationTest(CspolicyUnsetRequestConfiguration configuration,
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

    public class CspolicyUnsetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CspolicyUnsetRequestConfiguration(new CspolicyUnsetRequestDataRoot(new CspolicyUnsetRequestData()
                {
                    Rule = true
                })), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy?action=unset"},
                    {"RequestContent", "{\"cspolicy\":{\"rule\":true}}"},
                    {"Options", "?action=unset"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}