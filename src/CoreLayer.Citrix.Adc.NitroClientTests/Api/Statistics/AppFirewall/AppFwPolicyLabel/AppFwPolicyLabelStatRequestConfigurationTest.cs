using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.AppFirewall.AppFwPolicyLabel;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.AppFirewall.AppFwPolicyLabel
{
    public class AppFwPolicyLabelStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(AppFwPolicyLabelStatRequestConfigurationValidationTestData))]
        public void AppFwPolicyLabelStatRequestConfigurationValidationTest(
            AppFwPolicyLabelStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class AppFwPolicyLabelStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AppFwPolicyLabelStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/appfwpolicylabel"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/appfwpolicylabel"}
                } 
            };
            yield return new object[]
            {
                new AppFwPolicyLabelStatRequestConfiguration
                {
                    Options = new AppFwPolicyLabelStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/appfwpolicylabel"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/appfwpolicylabel/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new AppFwPolicyLabelStatRequestConfiguration
                {
                    Options = new AppFwPolicyLabelStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/appfwpolicylabel"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/appfwpolicylabel/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}