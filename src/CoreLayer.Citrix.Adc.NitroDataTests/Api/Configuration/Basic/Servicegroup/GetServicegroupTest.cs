using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.Servicegroup
{
    public class GetServicegroupTest
    {
        [Theory]
        [ClassData(typeof(GetServicegroupTestData))]
        public void GetServiceValidationTest(ServicegroupConfiguration service, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(service, typeof(ServicegroupConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetServicegroupTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServicegroupConfiguration()
                {
                    ServicegroupName = "test",
                    Port = 100,
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicegroupname\":\"test\",\"port\":100}"}
                }
            };
            yield return new object[]
            {
                new ServicegroupConfiguration()
                {
                    ServicegroupName = "Test",
                    Port = 100,
                    ClientTimeout = 10
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"servicegroupname\":\"Test\",\"clttimeout\":10,\"port\":100}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}