using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csaction;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csaction
{
    public class CsactionRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsactionRemoveRequestConfigurationValidationTestData))]
        public void CsactionRemoveRequestConfigurationValidationTest(
            CsactionRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CsactionRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsactionRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new CsactionRemoveRequestConfiguration()
                {
                    Options = new CsactionRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name","testName"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csaction"},
                    {"RequestUri", "/nitro/v1/config/csaction?args=name:testName"},
                    {"Options", "?args=name:testName"},
                }, 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}