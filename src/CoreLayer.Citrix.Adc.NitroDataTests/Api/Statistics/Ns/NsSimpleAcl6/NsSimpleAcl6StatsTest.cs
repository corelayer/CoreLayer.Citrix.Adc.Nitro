using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsSimpleAcl6
{
    public class NsSimpleAcl6StatsTest
    {
        [Theory]
        [ClassData(typeof(NsSimpleAcl6StatsValidationTestData))]
        public void NsSimpleAcl6StatsValidationTest(NsSimpleAcl6Stats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsSimpleAcl6Stats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsSimpleAcl6StatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsSimpleAcl6Stats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsSimpleAcl6Stats()
                {
                    SimpleAcl6TotalHits = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sacl6tothits\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsSimpleAcl6Stats()
                {
                    SimpleAcl6TotalHits = "Test",
                    SimpleAcl6HitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sacl6tothits\":\"Test\",\"sacl6hitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}