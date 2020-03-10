using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CspolicyRemoveRequestConfigurationValidationTestData))]
        public void CspolicyRemoveRequestConfigurationValidationTest(CspolicyRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CspolicyRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CspolicyRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new CspolicyRemoveRequestConfiguration()
                {
                    Options = new CspolicyRemoveRequestOptions("resource")
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/cspolicy"},
                    {"RequestUri", "/nitro/v1/config/cspolicy/resource"},
                    {"Options", "/resource"},
                }, 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}