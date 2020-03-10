using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Objects.Configuration.LoadBalancing.Lbvserver
{
    public class GetLbvserverTest
    {
        [Theory]
        [ClassData(typeof(GetLbvserverTestData))]
        public void AddLbvserverValidationTest(LbvserverConfiguration lb, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(lb, typeof(LbvserverConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }
    public class GetLbvserverTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new LbvserverConfiguration()
                {
                    Name = "test",
                    Port = 100,
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\",\"port\":100}"}
                }
            };
            yield return new object[]
            {
                new LbvserverConfiguration()
                {
                    Name = "Test",
                    Port = 100, 
                    Comment = "TestComment"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"port\":100,\"comment\":\"TestComment\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}