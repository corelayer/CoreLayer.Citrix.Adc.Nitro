using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Bot.Bot
{
    public class BotStatsTest
    {
        [Theory]
        [ClassData(typeof(BotStatsValidationTestData))]
        public void BotStatsValidationTest(BotStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(BotStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class BotStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new BotStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new BotStats()
                {
                    BotRequests = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"botrequests\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new BotStats()
                {
                    BotRequests = "Test",
                    BotRequestsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"botrequests\":\"Test\",\"botrequestsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}