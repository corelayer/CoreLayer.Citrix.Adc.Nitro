using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.Csvserver
{
    public class GetCsvserverTest
    {
        [Theory]
        [ClassData(typeof(GetCsvserverTestData))]
        public void AddLbvserverValidationTest(CsvserverConfiguration cs, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(cs, typeof(CsvserverConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetCsvserverTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsvserverConfiguration()
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
                new CsvserverConfiguration()
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