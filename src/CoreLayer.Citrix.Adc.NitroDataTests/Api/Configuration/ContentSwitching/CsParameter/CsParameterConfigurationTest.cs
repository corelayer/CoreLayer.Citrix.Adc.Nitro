using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroDataTests.Api.Configuration.ContentSwitching.CsParameter
{
    public class CsParameterConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsParameterConfigurationValidationTestData))]
        public void CsParameterConfigurationValidationTest(CsParameterConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(configuration, typeof(CsParameterConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class CsParameterConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsParameterConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsParameterConfiguration()
                {
                    StateUpdate = "test",
                    Feature = "Feature"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"stateupdate\":\"test\",\"feature\":\"Feature\"}"}
                }
            };
            yield return new object[]
            {
                new CsParameterConfiguration()
                {
                    StateUpdate = "Test",
                    BuiltIn = new string[]{"TestComment"}
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"stateupdate\":\"Test\",\"builtin\":[\"TestComment\"]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}