using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Bot.BotProfile
{
    public class BotProfileStatsTest
    {
        [Theory]
        [ClassData(typeof(BotProfileStatsValidationTestData))]
        public void BotProfileStatsValidationTest(BotProfileStats stats, Dictionary<string, string> expected)
        {
             Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(BotProfileStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class BotProfileStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new BotProfileStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new BotProfileStats()
                {
                    Name = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new BotProfileStats()
                {
                    Name = "Test",
                    BotRequestsPerProfileRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"botrequestsperprofilerate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}