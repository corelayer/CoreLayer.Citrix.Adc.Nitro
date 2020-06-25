using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsAddRecAddRequestConfigurationValidationTestData))]
        public void DnsAddRecAddRequestConfigurationValidationTest(DnsAddRecAddRequestConfiguration configuration,
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

    public class DnsAddRecAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsAddRecAddRequestConfiguration(new DnsAddRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsAddRecAddRequestData("test1", "testip"),
                        new DnsAddRecAddRequestData("test2", "testip"),
                        new DnsAddRecAddRequestData("test3", "testip")
                        {
                            
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnsaddrec"},
                    {"RequestUri", "/nitro/v1/config/dnsaddrec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnsaddrec\":[{\"hostname\":\"test1\",\"ipaddress\":\"testip\"}," +
                                       "{\"hostname\":\"test2\",\"ipaddress\":\"testip\"}," +
                                       "{\"hostname\":\"test3\",\"ipaddress\":\"testip\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new DnsAddRecAddRequestConfiguration(new DnsAddRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsAddRecAddRequestData("test1", "testip"),
                        new DnsAddRecAddRequestData("test2", "testip2"),
                        new DnsAddRecAddRequestData("test3", "testip3")
                        ,
                        new DnsAddRecAddRequestData("test4", "testip4")
                        {
                            TimeToLive = 5
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnsaddrec"},
                    {"RequestUri", "/nitro/v1/config/dnsaddrec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnsaddrec\":[{\"hostname\":\"test1\",\"ipaddress\":\"testip\"}," +
                                       "{\"hostname\":\"test2\",\"ipaddress\":\"testip2\"}," +
                                       "{\"hostname\":\"test3\",\"ipaddress\":\"testip3\"}," +
                                       "{\"hostname\":\"test4\",\"ipaddress\":\"testip4\",\"ttl\":5}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}