using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Responder;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Responder.ResponderPolicy
{
    public class ResponderPolicyStatsTest
    {
        [Theory]
        [ClassData(typeof(ResponderPolicyTestData))]
        public void ResponderPolicyTests(ResponderPolicyStats responderPolicyStats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(responderPolicyStats, typeof(ResponderPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ResponderPolicyTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ResponderPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ResponderPolicyStats()
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
                new ResponderPolicyStats()
                {
                    Name = "Test",
                    PiPolicyHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"pipolicyhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}