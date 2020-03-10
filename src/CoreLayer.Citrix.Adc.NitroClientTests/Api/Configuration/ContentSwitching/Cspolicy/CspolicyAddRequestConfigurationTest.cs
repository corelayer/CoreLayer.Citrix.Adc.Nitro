using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CspolicyAddRequestConfigurationValidationTestData))]
        public void CspolicyAddRequestConfigurationValidationTest(CspolicyAddRequestConfiguration configuration,
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
    public class CspolicyAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CspolicyAddRequestConfiguration(new CspolicyAddRequestDataRoot(new CspolicyAddRequestData("test1"))), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy"},
                    {"Options", ""},
                    {"RequestContent", "{\"cspolicy\":[{\"policyname\":\"test1\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new CspolicyAddRequestConfiguration(new CspolicyAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CspolicyAddRequestData("test1"),
                        new CspolicyAddRequestData("test2"),
                        new CspolicyAddRequestData("test3")
                        {
                            Domain = "testDomain"
                        },
                        new CspolicyAddRequestData("test4")
                        {
                            Rule = "testRule"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy"},
                    {"Options", ""},
                    {"RequestContent", "{\"cspolicy\":[{\"policyname\":\"test1\"}," +
                                       "{\"policyname\":\"test2\"}," +
                                       "{\"policyname\":\"test3\",\"domain\":\"testDomain\"}," +
                                       "{\"policyname\":\"test4\",\"rule\":\"testRule\"}]}"}
                }
            };        
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}