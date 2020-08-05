using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsTrafficDomain
{
    public class NsTrafficDomainStatsTest
    {
        [Theory]
        [ClassData(typeof(NsTrafficDomainStatsValidationTestData))]
        public void NsTrafficDomainStatsValidationTest(NsTrafficDomainStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsTrafficDomainStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsTrafficDomainStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsTrafficDomainStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsTrafficDomainStats()
                {
                    TrafficDomain = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"td\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsTrafficDomainStats()
                {
                    TrafficDomain = "Test",
                    NsTrafficDomainDroppedPacketsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"td\":\"Test\",\"nstddroppedpktsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}