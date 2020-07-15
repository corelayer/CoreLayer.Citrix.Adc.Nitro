using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Responder;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Responder.ResponderPolicyLabel
{
    public class ResponderPolicyLabelStatsTest
    {
        [Theory]
        [ClassData(typeof(ResponderPolicyLabelStatTestData))]
        public void ResponderPolicyLabelStatTests(ResponderPolicyLabelStats responderPolicyLabelStats,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(responderPolicyLabelStats, typeof(ResponderPolicyLabelStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ResponderPolicyLabelStatTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ResponderPolicyLabelStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ResponderPolicyLabelStats()
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
                new ResponderPolicyLabelStats()
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