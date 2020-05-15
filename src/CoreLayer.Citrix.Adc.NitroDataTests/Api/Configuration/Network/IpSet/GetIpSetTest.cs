using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Network.IpSet
{
    public class GetIpSetTest
    {
        [Theory]
        [ClassData(typeof(GetIpSetTestData))]
        public void GetIpSetValidationTest( IpSetConfiguration ipset, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(ipset, typeof(IpSetConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetIpSetTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new IpSetConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new IpSetConfiguration()
                {
                    Name = "test",
                    TrafficDomain = "0"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\",\"td\":\"0\"}"}
                }
            };
            yield return new object[]
            {
                new IpSetConfiguration()
                {
                    Name = "Test",
                    TrafficDomain = "100", 
                    Count = 10
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"td\":\"100\",\"__count\":10}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}