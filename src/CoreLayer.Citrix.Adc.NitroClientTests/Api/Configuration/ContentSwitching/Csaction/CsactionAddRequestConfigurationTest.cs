using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsactionAddRequestConfigurationValidationTestData))]
        public void CsactionAddRequestConfigurationValidationTest(CsactionAddRequestConfiguration configuration,
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
    public class CsactionAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsactionAddRequestConfiguration(new CsactionAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsactionAddRequestData("test1"),
                        new CsactionAddRequestData("test2"),
                        new CsactionAddRequestData("test3")
                        {
                            Comment = "testComment"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction"},
                    {"Options", ""},
                    {"RequestContent", "{\"csaction\":[{\"name\":\"test1\"}," +
                                       "{\"name\":\"test2\"}," +
                                       "{\"name\":\"test3\",\"comment\":\"testComment\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new CsactionAddRequestConfiguration(new CsactionAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsactionAddRequestData("test1"),
                        new CsactionAddRequestData("test2"),
                        new CsactionAddRequestData("test3")
                        {
                            Comment = "testComment"
                        },
                        new CsactionAddRequestData("test4")
                        {
                            TargetLbvserver = "testTarget"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction"},
                    {"Options", ""},
                    {"RequestContent", "{\"csaction\":[{\"name\":\"test1\"}," +
                                       "{\"name\":\"test2\"}," +
                                       "{\"name\":\"test3\",\"comment\":\"testComment\"}," +
                                       "{\"name\":\"test4\",\"targetlbvserver\":\"testTarget\"}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}