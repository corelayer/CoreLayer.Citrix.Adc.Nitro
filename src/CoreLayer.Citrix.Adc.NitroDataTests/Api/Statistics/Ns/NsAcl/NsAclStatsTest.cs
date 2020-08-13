using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Statistics.Ns.NsAcl
{
    public class NsAclStatsTest
    {
        [Theory]
        [ClassData(typeof(NsAclStatsValidationTestData))]
        public void NsAclStatsValidationTest(NsAclStats stats, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(stats, typeof(NsAclStats), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsAclStatsValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsAclStats()
                {
                    
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsAclStats()
                {
                    AclName = "test"
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"aclname\":\"test\"}"}
                }
            };
            yield return new object[]
            {
                new NsAclStats()
                {
                    AclName = "Test",
                    AclHitsRate = 5
                }, 
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"aclname\":\"Test\",\"aclhitsrate\":5}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}