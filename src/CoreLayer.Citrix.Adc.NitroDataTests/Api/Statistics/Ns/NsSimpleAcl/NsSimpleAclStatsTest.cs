using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsSimpleAcl
{
    public class NsSimpleAclStatsTest
    {
        [Theory]
        [ClassData(typeof(NsSimpleAclStatsValidationTestData))]
        public void NsSimpleAclStatsValidationTest(NsSimpleAclStats stats, Dictionary<string, string> expected)
        {
             Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsSimpleAclStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
        
    }
    

    public class NsSimpleAclStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsSimpleAclStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsSimpleAclStats()
                {
                    SimpleAclTotalHits = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sacltothits\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsSimpleAclStats()
                {
                    SimpleAclTotalHits = "Test",
                    SimpleAclHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"sacltothits\":\"Test\",\"saclhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}