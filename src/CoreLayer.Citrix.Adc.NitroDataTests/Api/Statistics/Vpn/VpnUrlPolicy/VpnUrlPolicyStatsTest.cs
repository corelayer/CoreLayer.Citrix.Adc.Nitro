using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Vpn;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Vpn.VpnUrlPolicy
{
    public class VpnUrlPolicyStatsTest
    {
        [Theory]
        [ClassData(typeof(VpnUrlPolicyStatsValidationTestData))]
        public void VpnUrlPolicyStatsValidationTest(VpnUrlPolicyStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(VpnUrlPolicyStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class VpnUrlPolicyStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VpnUrlPolicyStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new VpnUrlPolicyStats()
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
                new VpnUrlPolicyStats()
                {
                    Name = "Test",
                    PolicyHitsRate = 5
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