using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionRenameRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsactionRenameRequestConfigurationValidationTestData))]
        public void CsactionRenameRequestConfigurationValidationTest(CsactionRenameRequestConfiguration configuration,
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

    public class CsactionRenameRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsactionRenameRequestConfiguration(new CsactionRenameRequestDataRoot(new CsactionRenameRequestData()
                {
                    Name = "test"
                })), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction?action=rename"},
                    {"RequestContent", "{\"csaction\":{\"name\":\"test\"}}"},
                    {"Options", "?action=rename"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}