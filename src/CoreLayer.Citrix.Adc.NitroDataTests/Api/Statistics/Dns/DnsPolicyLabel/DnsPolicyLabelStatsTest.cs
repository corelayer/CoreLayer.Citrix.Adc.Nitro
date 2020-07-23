using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Dns.DnsPolicyLabel
{
    public class DnsPolicyLabelStatsTest
    {
        [Theory]
        [ClassData(typeof(DnsPolicyLabelStatsValidationTestData))]
        public void DnsPolicyLabelStatsValidationTest(DnsPolicyLabelStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(DnsPolicyLabelStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class DnsPolicyLabelStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsPolicyLabelStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new DnsPolicyLabelStats()
                {
                    LabelName = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"labelname\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new DnsPolicyLabelStats()
                {
                    LabelName = "Test",
                    PolicyLabelHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"labelname\":\"Test\",\"pipolicylabelhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}