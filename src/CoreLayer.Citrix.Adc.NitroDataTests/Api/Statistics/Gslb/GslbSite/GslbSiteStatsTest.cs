using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Gslb.GslbSite
{
    public class GslbSiteStatsTest
    {
        [Theory]
        [ClassData(typeof(GslbSiteStatsValidationTestData))]
        public void GslbSiteStatsValidationTest(GslbSiteStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(GslbSiteStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GslbSiteStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbSiteStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new GslbSiteStats()
                {
                    SiteName = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sitename\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new GslbSiteStats()
                {
                    SiteName = "Test",
                    SiteRequestsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sitename\":\"Test\",\"siterequestsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}