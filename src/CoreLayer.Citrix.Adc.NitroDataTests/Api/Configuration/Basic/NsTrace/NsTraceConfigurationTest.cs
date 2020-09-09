using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.NsTrace
{
    public class NsTraceConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsTraceConfigurationValidationTestData))]
        public void NsTraceConfigurationValidationTest(NsTraceConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(NsTraceConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class NsTraceConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsTraceConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new NsTraceConfiguration()
                {
                    State = "state",
                    FileId = "100",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"state\":\"state\",\"fileid\":\"100\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}