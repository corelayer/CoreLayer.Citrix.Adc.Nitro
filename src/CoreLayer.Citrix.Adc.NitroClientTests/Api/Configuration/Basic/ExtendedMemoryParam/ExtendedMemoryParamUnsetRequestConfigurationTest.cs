using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUnsetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ExtendedMemoryParamUnsetRequestConfigurationValidationTestData))]
        public void ExtendedMemoryParamUnsetRequestConfigurationValidationTest(
            ExtendedMemoryParamUnsetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ExtendedMemoryParamUnsetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ExtendedMemoryParamUnsetRequestConfiguration(), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/extendedmemoryparam"},
                    {"RequestUri", "/nitro/v1/config/extendedmemoryparam?action=unset"},
                    {"RequestContent", "{\"extendedmemoryparam\":{\"memlimit\":true}}"},
                    {"Options", "?action=unset"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}