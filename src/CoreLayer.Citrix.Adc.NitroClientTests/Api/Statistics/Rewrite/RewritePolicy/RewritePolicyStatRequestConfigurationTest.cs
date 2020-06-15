using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Rewrite.RewritePolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Rewrite.RewritePolicy
{
    public class RewritePolicyStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(RewritePolicyStatRequestConfigurationValidationTestData))]
        public void RewritePolicyStatRequestConfigurationValidationTest(
            RewritePolicyStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }

    }

    public class RewritePolicyStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RewritePolicyStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/rewritepolicy"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/rewritepolicy"}
                } 
            };
            yield return new object[]
            {
                new RewritePolicyStatRequestConfiguration
                {
                    Options = new RewritePolicyStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/rewritepolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/rewritepolicy/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new RewritePolicyStatRequestConfiguration
                {
                    Options = new RewritePolicyStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/rewritepolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/rewritepolicy/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}