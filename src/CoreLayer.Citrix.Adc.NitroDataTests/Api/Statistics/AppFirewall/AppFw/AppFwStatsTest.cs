using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.AppFirewall;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.AppFirewall.AppFw
{
    public class AppFwStatsTest
    {
        [Theory]
        [ClassData(typeof(AppFwStatsValidationTestData))]
        public void AppFwStatsValidationTest(AppFwStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(AppFwStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class AppFwStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AppFwStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new AppFwStats()
                {
                    AppFirewallSignatureLogs = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"appfirewallsignaturelogs\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new AppFwStats()
                {
                    AppFirewallSignatureLogs = "Test",
                    AppFirewallLogRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"appfirewalllograte\":5,\"appfirewallsignaturelogs\":\"Test\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}