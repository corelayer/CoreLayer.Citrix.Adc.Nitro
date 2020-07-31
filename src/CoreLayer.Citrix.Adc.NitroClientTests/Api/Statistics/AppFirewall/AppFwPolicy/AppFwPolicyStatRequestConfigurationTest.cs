using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicy;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.AppFirewall.AppFwPolicy
{
    public class AppFwPolicyStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(AppFwPolicyStatRequestConfigurationValidationTestData))]
        public void AppFwPolicyStatRequestConfigurationValidationTestData(
            AppFwPolicyStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class AppFwPolicyStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AppFwPolicyStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/appfwpolicy"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/appfwpolicy"}
                } 
            };
            yield return new object[]
            {
                new AppFwPolicyStatRequestConfiguration
                {
                    Options = new AppFwPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/appfwpolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/appfwpolicy/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new AppFwPolicyStatRequestConfiguration
                {
                    Options = new AppFwPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/appfwpolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/appfwpolicy/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}