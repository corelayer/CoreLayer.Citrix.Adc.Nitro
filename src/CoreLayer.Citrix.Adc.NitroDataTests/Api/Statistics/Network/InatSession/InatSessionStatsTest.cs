using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.InatSession
{
    public class InatSessionStatsTest
    {
        [Theory]
        [ClassData(typeof(InatSessionStatsValidationTestData))]
        public void InatSessionStatsValidationTest(InatSessionStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(InatSessionStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class InatSessionStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new InatSessionStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new InatSessionStats()
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
                new InatSessionStats()
                {
                    Name = "Test",
                    InatHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"inathitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}