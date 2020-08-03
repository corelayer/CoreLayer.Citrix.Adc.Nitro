using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsAcl6
{
    public class NsAcl6StatsTest
    {
        [Theory]
        [ClassData(typeof(NsAcl6StatsValidationTestData))]
        public void NsAcl6StatValidationTest(NsAcl6Stats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsAcl6Stats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }
    public class NsAcl6StatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsAcl6Stats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsAcl6Stats()
                {
                    Acl6Name = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"acl6name\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsAcl6Stats()
                {
                    Acl6Name = "Test",
                    Acl6HitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"acl6name\":\"Test\",\"acl6hitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}