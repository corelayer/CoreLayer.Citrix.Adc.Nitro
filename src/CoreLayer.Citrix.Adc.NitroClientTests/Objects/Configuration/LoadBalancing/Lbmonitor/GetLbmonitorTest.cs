using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Objects.Configuration.LoadBalancing.Lbmonitor
{
    public class GetLbmonitorTest
    {
        [Theory]
        [ClassData(typeof(GetLbmonitorTestData))]
        public void AddLbvserverValidationTest(LbmonitorConfiguration lbmon, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(lbmon, typeof(LbmonitorConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetLbmonitorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbmonitorConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LbmonitorConfiguration()
                {
                    MonitorName = "test",
                    DownTime = 100,
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"monitorname\":\"test\",\"downtime\":100}"}
                }
            };
            yield return new object[]
            {
                new LbmonitorConfiguration()
                {
                    MonitorName = "Test",
                    DownTime = 100, 
                    RespCode = new string[]{ "200"}
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"monitorname\":\"Test\",\"respcode\":[\"200\"],\"downtime\":100}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}