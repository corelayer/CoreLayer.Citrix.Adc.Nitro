using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Network.Nat64
{
    public class Nat64StatsTest
    {
        [Theory]
        [ClassData(typeof(Nat64StatsValidationTestData))]
        public void Nat64StatsValidationTest(Nat64Stats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(Nat64Stats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class Nat64StatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Nat64Stats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new Nat64Stats()
                {
                    Nat64TotalSessions = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"nat64totsessions\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new Nat64Stats()
                {
                    Nat64TotalSessions = "Test",
                    Nat64SessionsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"nat64sessionsrate\":5,\"nat64totsessions\":\"Test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}