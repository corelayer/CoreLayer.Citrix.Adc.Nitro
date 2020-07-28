using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.AppFirewall.AppFwPolicyLabel
{
    public class AppFwPolicyLabelStatsTest
    {
        [Theory]
        [ClassData(typeof(AppFwPolicyLabelStatsValidationTestData))]
        public void AppFwPolicyLabelStatsValidationTest(AppFwPolicyLabelStats stats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AppFwPolicyLabelStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AppFwPolicyLabelStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AppFwPolicyLabelStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AppFwPolicyLabelStats()
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
                new AppFwPolicyLabelStats()
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