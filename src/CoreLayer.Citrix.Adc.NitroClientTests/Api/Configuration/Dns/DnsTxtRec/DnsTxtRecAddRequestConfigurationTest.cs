using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsTxtReCAddRequestConfigurationValidationTestData))]
        public void DnsTxtRecAddRequestConfigurationValidationTest(DnsTxtRecAddRequestConfiguration configuration,
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

    public class DnsTxtReCAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsTxtRecAddRequestConfiguration(new DnsTxtRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsTxtRecAddRequestData("test1", new string[] {"test"}),
                        new DnsTxtRecAddRequestData("test2", new string[] {"test"}),
                        new DnsTxtRecAddRequestData("test3", new string[] {"test"})
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnstxtrec"},
                    {"RequestUri", "/nitro/v1/config/dnstxtrec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnstxtrec\":[{\"domain\":\"test1\",\"string\":[\"test\"]}," +
                                       "{\"domain\":\"test2\",\"string\":[\"test\"]}," +
                                       "{\"domain\":\"test3\",\"string\":[\"test\"]}]}"}
                }
            }; 
            yield return new object[]
            {
                new DnsTxtRecAddRequestConfiguration(new DnsTxtRecAddRequestDataRoot(
                    new dynamic[]
                    {
                        new DnsTxtRecAddRequestData("test1", new string[] {"test"}),
                        new DnsTxtRecAddRequestData("test2", new string[] {"test"}),
                        new DnsTxtRecAddRequestData("test3", new string[] {"test"})
                        ,
                        new DnsTxtRecAddRequestData("test4", new string[] {"test"})
                        {
                            TimeToLive = 5
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dnstxtrec"},
                    {"RequestUri", "/nitro/v1/config/dnstxtrec"},
                    {"Options", ""},
                    {"RequestContent", "{\"dnstxtrec\":[{\"domain\":\"test1\",\"string\":[\"test\"]}," +
                                       "{\"domain\":\"test2\",\"string\":[\"test\"]}," +
                                       "{\"domain\":\"test3\",\"string\":[\"test\"]}," +
                                       "{\"domain\":\"test4\",\"string\":[\"test\"],\"ttl\":5}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}