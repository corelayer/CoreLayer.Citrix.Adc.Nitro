using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsNsRecAddRequestConfigurationValidationTestData))]
        public void DnsNsRecAddRequestConfigurationValidationTest(DnsNsRecAddRequestConfiguration configuration,
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

    public class DnsNsRecAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsNsRecAddRequestConfiguration(new DnsNsRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsNsRecAddRequestData("test1", "test"),
                        new DnsNsRecAddRequestData("test2", "test"),
                        new DnsNsRecAddRequestData("test3", "test")
                        {
                            
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnsnsrec"},
                    {"RequestUri", "/nitro/v1/config/dnsnsrec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnsnsrec\":[{\"domain\":\"test1\",\"nameserver\":\"test\"}," +
                                       "{\"domain\":\"test2\",\"nameserver\":\"test\"}," +
                                       "{\"domain\":\"test3\",\"nameserver\":\"test\"}]}"}
                }
            }; 
            yield return new object[]
            {
                new DnsNsRecAddRequestConfiguration(new DnsNsRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsNsRecAddRequestData("test1", "test"),
                        new DnsNsRecAddRequestData("test2", "test"),
                        new DnsNsRecAddRequestData("test3", "test")
                        ,
                        new DnsNsRecAddRequestData("test4", "test")
                        {
                            TimeToLive = 5
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnsnsrec"},
                    {"RequestUri", "/nitro/v1/config/dnsnsrec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnsnsrec\":[{\"domain\":\"test1\",\"nameserver\":\"test\"}," +
                                       "{\"domain\":\"test2\",\"nameserver\":\"test\"}," +
                                       "{\"domain\":\"test3\",\"nameserver\":\"test\"}," +
                                       "{\"domain\":\"test4\",\"nameserver\":\"test\",\"ttl\":5}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}