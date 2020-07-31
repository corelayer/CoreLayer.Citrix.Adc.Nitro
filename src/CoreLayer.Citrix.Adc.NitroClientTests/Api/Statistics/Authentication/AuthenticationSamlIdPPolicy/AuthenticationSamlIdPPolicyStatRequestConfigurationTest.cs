using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationSamlIdPPolicy;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Authentication.AuthenticationSamlIdPPolicy
{
    public class AuthenticationSamlIdPPolicyStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationSamlIdPPolicyStatRequestConfigurationValidationTestData))]
        public void AuthenticationSamlIdPPolicyStatRequestConfigurationValidationTest(
            AuthenticationSamlIdPPolicyStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class AuthenticationSamlIdPPolicyStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationSamlIdPPolicyStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/authenticationsamlidppolicy"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/authenticationsamlidppolicy"}
                } 
            };
            yield return new object[]
            {
                new AuthenticationSamlIdPPolicyStatRequestConfiguration
                {
                    Options = new AuthenticationSamlIdPPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/authenticationsamlidppolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/authenticationsamlidppolicy/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new AuthenticationSamlIdPPolicyStatRequestConfiguration
                {
                    Options = new AuthenticationSamlIdPPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/authenticationsamlidppolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/authenticationsamlidppolicy/resourceName?attrs=Name"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}