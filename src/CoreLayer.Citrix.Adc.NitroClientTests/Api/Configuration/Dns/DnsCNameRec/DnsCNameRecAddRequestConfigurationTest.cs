using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsCNameRecAddRequestConfigurationValidationTestData))]
        public void DnsCNameRecAddRequestConfigurationValidationTest(DnsCNameRecAddRequestConfiguration configuration,
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

    public class DnsCNameRecAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsCNameRecAddRequestConfiguration(new DnsCNameRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsCNameRecAddRequestData("test1", "test"),
                        new DnsCNameRecAddRequestData("test2", "test"),
                        new DnsCNameRecAddRequestData("test3", "test")
                        {
                            
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnscnamerec"},
                    {"RequestUri", "/nitro/v1/config/dnscnamerec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnscnamerec\":[{\"aliasname\":\"test1\",\"canonicalname\":\"test\"}," +
                                       "{\"aliasname\":\"test2\",\"canonicalname\":\"test\"}," +
                                       "{\"aliasname\":\"test3\",\"canonicalname\":\"test\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new DnsCNameRecAddRequestConfiguration(new DnsCNameRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsCNameRecAddRequestData("test1", "test"),
                        new DnsCNameRecAddRequestData("test2", "test"),
                        new DnsCNameRecAddRequestData("test3", "test")
                        ,
                        new DnsCNameRecAddRequestData("test4", "test")
                        {
                            TimeToLive = 5
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnscnamerec"},
                    {"RequestUri", "/nitro/v1/config/dnscnamerec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnscnamerec\":[{\"aliasname\":\"test1\",\"canonicalname\":\"test\"}," +
                                       "{\"aliasname\":\"test2\",\"canonicalname\":\"test\"}," +
                                       "{\"aliasname\":\"test3\",\"canonicalname\":\"test\"}," +
                                       "{\"aliasname\":\"test4\",\"canonicalname\":\"test\",\"ttl\":5}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}