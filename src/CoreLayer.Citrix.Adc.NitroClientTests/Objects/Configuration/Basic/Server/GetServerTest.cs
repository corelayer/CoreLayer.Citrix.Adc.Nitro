using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Objects.Configuration.Basic.Server
{
    public class GetServerTest
    {
        [Theory]
        [ClassData(typeof(GetServerTestData))]
        public void GetServerValidationTest(ServerConfiguration serverConfiguration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(serverConfiguration, typeof(ServerConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetServerTestData : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServerConfiguration()
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
                new ServerConfiguration()
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