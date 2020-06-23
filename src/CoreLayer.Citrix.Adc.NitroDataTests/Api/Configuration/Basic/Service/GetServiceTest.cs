using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.Service
{
    public class GetServiceTest
    {
        [Theory]
        [ClassData(typeof(GetServiceTestData))]
        public void GetServiceValidationTest(ServiceConfiguration serviceConfiguration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(serviceConfiguration, typeof(ServiceConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetServiceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ServiceConfiguration()
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
                new ServiceConfiguration()
                {
                    Name = "Test",
                    Port = 100,
                    ClientTimeout = 10
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"port\":100,\"clttimeout\":10}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}