using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Objects.Configuration.Network.NetProfile
{
    public class GetNetProfileTest
    {
        [Theory]
        [ClassData(typeof(GetNetProfileTestData))]
        public void GetIpSetValidationTest( NetProfileConfiguration netProfileConfiguration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(netProfileConfiguration, typeof(NetProfileConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetNetProfileTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NetProfileConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NetProfileConfiguration()
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
                new NetProfileConfiguration()
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