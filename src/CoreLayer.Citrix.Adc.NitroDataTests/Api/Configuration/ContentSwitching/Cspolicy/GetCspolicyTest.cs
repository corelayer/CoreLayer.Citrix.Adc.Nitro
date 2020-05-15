using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.Cspolicy
{
    public class GetCspolicyTest
    {
        [Theory] 
        [ClassData(typeof(GetCspolicyTestData))]
        public void AddLbvserverValidationTest(CspolicyConfiguration csp, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(csp, typeof(CspolicyConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetCspolicyTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CspolicyConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CspolicyConfiguration()
                {
                    PolicyName = "test",
                    PiPolicyHits = "0"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"policyname\":\"test\",\"pipolicyhits\":\"0\"}"}
                }
            };
            yield return new object[]
            {
                new CspolicyConfiguration()
                {
                    PolicyName = "Test",
                    CspolicyType = "testPolicy"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"policyname\":\"Test\",\"cspolicytype\":\"testPolicy\"}"}
                }
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}