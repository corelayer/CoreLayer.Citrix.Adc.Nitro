using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsPbr6
{
    public class NsPbr6StatsTest
    {
        [Theory]
        [ClassData(typeof(NsPbr6StatsValidationTestData))]
        public void NsPbr6StatsValidationTest(NsPbr6Stats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsPbr6Stats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsPbr6StatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsPbr6Stats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsPbr6Stats()
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
                new NsPbr6Stats()
                {
                    Name = "Test",
                    Pbr6HitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"pbr6perhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}