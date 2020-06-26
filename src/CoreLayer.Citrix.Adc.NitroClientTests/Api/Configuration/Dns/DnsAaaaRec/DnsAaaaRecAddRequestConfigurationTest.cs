using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecAddRequestConfigurationTest 
    {
        [Theory]
        [ClassData(typeof(DnsAaaaRecAddRequestConfigurationValidationTestData))]
        public void DnsAaaaRecAddRequestConfigurationValidationTest(DnsAaaaRecAddRequestConfiguration configuration,
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

    public class DnsAaaaRecAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsAaaaRecAddRequestConfiguration(new DnsAaaaRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsAaaaRecAddRequestData("test1", "test"),
                        new DnsAaaaRecAddRequestData("test2", "test"),
                        new DnsAaaaRecAddRequestData("test3", "test")
                        {
                            
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnsaaaarec"},
                    {"RequestUri", "/nitro/v1/config/dnsaaaarec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnsaaaarec\":[{\"hostname\":\"test1\",\"ipv6address\":\"test\"}," +
                                       "{\"hostname\":\"test2\",\"ipv6address\":\"test\"}," +
                                       "{\"hostname\":\"test3\",\"ipv6address\":\"test\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new DnsAaaaRecAddRequestConfiguration(new DnsAaaaRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsAaaaRecAddRequestData("test1", "test"),
                        new DnsAaaaRecAddRequestData("test2", "test"),
                        new DnsAaaaRecAddRequestData("test3", "test")
                        ,
                        new DnsAaaaRecAddRequestData("test4", "test")
                        {
                            TimeToLive = 5
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnsaaaarec"},
                    {"RequestUri", "/nitro/v1/config/dnsaaaarec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnsaaaarec\":[{\"hostname\":\"test1\",\"ipv6address\":\"test\"}," +
                                       "{\"hostname\":\"test2\",\"ipv6address\":\"test\"}," +
                                       "{\"hostname\":\"test3\",\"ipv6address\":\"test\"}," +
                                       "{\"hostname\":\"test4\",\"ipv6address\":\"test\",\"ttl\":5}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}