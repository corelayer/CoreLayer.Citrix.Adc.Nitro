using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ExtendedMemoryParamUpdateRequestConfigurationValidationTestData))]
        public void ExtendedMemoryParamUpdateRequestConfigurationValidationTest(
            ExtendedMemoryParamUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ExtendedMemoryParamUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ExtendedMemoryParamUpdateRequestConfiguration(new ExtendedMemoryParamUpdateRequestDataRoot(new ExtendedMemoryParamUpdateRequestData())),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/extendedmemoryparam"},
                    {"RequestUri", "/nitro/v1/config/extendedmemoryparam"},
                    {"RequestContent", "{\"extendedmemoryparam\":{}}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ExtendedMemoryParamUpdateRequestConfiguration(
                    new ExtendedMemoryParamUpdateRequestDataRoot(
                        new ExtendedMemoryParamUpdateRequestData()
                            {
                                MemLimit = 5
                            }
                    )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/extendedmemoryparam"},
                    {"RequestUri", "/nitro/v1/config/extendedmemoryparam"},
                    {"RequestContent", "{\"extendedmemoryparam\":{\"memlimit\":5}}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}