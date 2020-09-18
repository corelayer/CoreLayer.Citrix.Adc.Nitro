using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUnsetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsParameterUnsetRequestConfigurationValidationTestData))]
        public void CsParameterUnsetRequestConfigurationValidationTest(
            CsParameterUnsetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsParameterUnsetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsParameterUnsetRequestConfiguration(new CsParameterUnsetRequestDataRoot(new CsParameterUnsetRequestData()
                {
                    
                })), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/csparameter"},
                    {"RequestUri", "/nitro/v1/config/csparameter?action=unset"},
                    {"RequestContent", "{\"csparameter\":{\"stateupdate\":true}}"},
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