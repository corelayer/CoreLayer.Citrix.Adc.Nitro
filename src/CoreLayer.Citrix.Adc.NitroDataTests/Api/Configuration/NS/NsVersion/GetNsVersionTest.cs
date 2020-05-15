using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.NS.NsVersion
{
    public class GetNsVersionTest
    {
        [Theory]
        [ClassData(typeof(GetNsVersionTestData))]
        public void GetServerValidationTest(NsVersionConfiguration nsVersionConfiguration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nsVersionConfiguration, typeof(NsVersionConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetNsVersionTestData : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsVersionConfiguration()
                {
                    InstalledVersion = false,
                    Version = "version string",
                    Mode = "1" 
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"installedversion\":false,\"version\":\"version string\",\"mode\":\"1\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}