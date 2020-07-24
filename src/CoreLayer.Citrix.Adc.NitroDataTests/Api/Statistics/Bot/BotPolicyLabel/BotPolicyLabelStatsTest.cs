using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Bot.BotPolicyLabel
{
    public class BotPolicyLabelStatsTest
    {
        [Theory]
        [ClassData(typeof(BotPolicyLabelStatsValidationTestData))]
        public void BotPolicyLabelStatsValidationTest(BotPolicyLabelStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(BotPolicyLabelStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class BotPolicyLabelStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new BotPolicyLabelStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new BotPolicyLabelStats()
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
                new BotPolicyLabelStats()
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