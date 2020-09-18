using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsPolicyLabel;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsPolicyLabel
{
    public class CsPolicyLabelRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsPolicyLabelRemoveRequestConfigurationValidationTestData))]
        public void CsPolicyLabelRemoveRequestConfigurationValidationTest(
            CsPolicyLabelRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsPolicyLabelRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsPolicyLabelRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new CsPolicyLabelRemoveRequestConfiguration()
                {
                    Options = new CsPolicyLabelRemoveRequestOptions()
                    {
                        ResourceName = "resource"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/cspolicylabel"},
                    {"RequestUri", "/nitro/v1/config/cspolicylabel/resource"},
                    {"Options", "/resource"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}