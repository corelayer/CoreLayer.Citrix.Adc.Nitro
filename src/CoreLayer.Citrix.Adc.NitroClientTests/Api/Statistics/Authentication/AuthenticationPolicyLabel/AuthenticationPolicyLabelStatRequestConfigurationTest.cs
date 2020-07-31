using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationPolicyLabel;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Authentication.AuthenticationPolicyLabel
{
    public class AuthenticationPolicyLabelStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationPolicyLabelStatRequestConfigurationValidationTestData))]
        public void AuthenticationPolicyLabelStatRequestConfigurationValidationTest(
            AuthenticationPolicyLabelStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class AuthenticationPolicyLabelStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationPolicyLabelStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/authenticationpolicylabel"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/authenticationpolicylabel"}
                } 
            };
            yield return new object[]
            {
                new AuthenticationPolicyLabelStatRequestConfiguration
                {
                    Options = new AuthenticationPolicyLabelStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/authenticationpolicylabel"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/authenticationpolicylabel/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new AuthenticationPolicyLabelStatRequestConfiguration
                {
                    Options = new AuthenticationPolicyLabelStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/authenticationpolicylabel"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/authenticationpolicylabel/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}