using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsactionUpdateRequestConfigurationValidationTestData))]
        public void CsactionUpdateRequestConfigurationValidationTest(CsactionUpdateRequestConfiguration configuration,
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

    public class CsactionUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsactionUpdateRequestConfiguration(new CsactionUpdateRequestDataRoot(new CsactionUpdateRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction"},
                    {"RequestContent", "{\"csaction\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new CsactionUpdateRequestConfiguration(
                    new CsactionUpdateRequestDataRoot(new dynamic[]
                    {
                        new CsactionUpdateRequestData("test")
                        {
                            Comment = "testComment"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction"},
                    {"RequestContent", "{\"csaction\":[{\"name\":\"test\",\"comment\":\"testComment\"}]}"},
                    {"Options", ""}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}