using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ExtendedMemoryParamConfigurationValidationTestData))]
        public void ExtendedMemoryParamConfigurationValidationTest(ExtendedMemoryParamConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(ExtendedMemoryParamConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class ExtendedMemoryParamConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ExtendedMemoryParamConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new ExtendedMemoryParamConfiguration()
                {
                    MemoryLimit = 10,
                    MemoryLimitActive = 100,
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"memlimitactive\":100,\"memlimit\":10}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}