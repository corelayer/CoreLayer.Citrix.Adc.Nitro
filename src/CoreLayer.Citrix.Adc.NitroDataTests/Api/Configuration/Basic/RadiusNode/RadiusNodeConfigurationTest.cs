using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeConfigurationTest
    {
        [Theory]
        [ClassData(typeof(RadiusNodeConfigurationValidationTestData))]
        public void RadiusNodeConfigurationValidationTest(RadiusNodeConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(RadiusNodeConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class RadiusNodeConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RadiusNodeConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new RadiusNodeConfiguration()
                {
                    RadKey = "key",
                    NodePrefix = "100",
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"nodeprefix\":\"100\",\"radkey\":\"key\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}