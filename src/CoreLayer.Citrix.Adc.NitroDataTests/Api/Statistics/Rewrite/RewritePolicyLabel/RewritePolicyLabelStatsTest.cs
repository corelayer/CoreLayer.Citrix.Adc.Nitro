using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Rewrite;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Rewrite.RewritePolicyLabel
{
    public class RewritePolicyLabelStatsTest
    {
        [Theory]
        [ClassData(typeof(RewritePolicyLabelStatsTestData))]
        public void RewritePolicyLabelStatsTests(RewritePolicyLabelStats rewritePolicyLabelStats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(rewritePolicyLabelStats, typeof(RewritePolicyLabelStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }
    
    public class RewritePolicyLabelStatsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RewritePolicyLabelStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new RewritePolicyLabelStats()
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
                new RewritePolicyLabelStats()
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