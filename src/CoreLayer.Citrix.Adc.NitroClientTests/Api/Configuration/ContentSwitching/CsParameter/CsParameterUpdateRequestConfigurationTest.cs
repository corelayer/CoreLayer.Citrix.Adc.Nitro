using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsParameter;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsParameterUpdateRequestConfigurationValidationTestData))]
        public void CsParameterUpdateRequestConfigurationValidationTest(
            CsParameterUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsParameterUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsParameterUpdateRequestConfiguration(new CsParameterUpdateRequestDataRoot(new CsParameterUpdateRequestData())),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csparameter"},
                    {"RequestUri", "/nitro/v1/config/csparameter"},
                    {"RequestContent", "{\"csparameter\":{}}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new CsParameterUpdateRequestConfiguration(
                    new CsParameterUpdateRequestDataRoot(new dynamic[]
                    {
                        new CsParameterUpdateRequestData()
                        {
                            StateUpdate = "test"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csparameter"},
                    {"RequestUri", "/nitro/v1/config/csparameter"},
                    {"RequestContent", "{\"csparameter\":[{\"stateupdate\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}