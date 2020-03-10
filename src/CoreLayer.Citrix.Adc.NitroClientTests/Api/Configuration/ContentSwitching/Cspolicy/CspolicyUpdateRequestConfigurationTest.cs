using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CspolicyUpdateRequestConfigurationValidationTestData))]
        public void CspolicyUpdateRequestConfigurationValidationTest(CspolicyUpdateRequestConfiguration configuration,
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
    public class CspolicyUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CspolicyUpdateRequestConfiguration(new CspolicyUpdateRequestDataRoot(new CspolicyUpdateRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy"},
                    {"RequestContent", "{\"cspolicy\":[{\"policyname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new CspolicyUpdateRequestConfiguration(
                    new CspolicyUpdateRequestDataRoot(new dynamic[]
                    {
                        new CspolicyUpdateRequestData("test")
                        {
                            Rule = "testRule"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy"},
                    {"RequestContent", "{\"cspolicy\":[{\"policyname\":\"test\",\"rule\":\"testRule\"}]}"},
                    {"Options", ""}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}