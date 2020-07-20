using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Authentication.AuthenticationLoginSchemaPolicy;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.AuthenticationLoginSchemaPolicy.AuthenticationLoginSchemaPolicy
{
    public class AuthenticationLoginSchemaPolicyStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(AuthenticationLoginSchemaPolicyStatRequestValidationTestData))]
        public void AuthenticationLoginSchemaPolicyStatRequestValidationTest(
            AuthenticationLoginSchemaPolicyStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class AuthenticationLoginSchemaPolicyStatRequestValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new AuthenticationLoginSchemaPolicyStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/authenticationloginschemapolicy"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/authenticationloginschemapolicy"}
                } 
            };
            yield return new object[]
            {
                new AuthenticationLoginSchemaPolicyStatRequestConfiguration
                {
                    Options = new AuthenticationLoginSchemaPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/authenticationloginschemapolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/authenticationloginschemapolicy/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new AuthenticationLoginSchemaPolicyStatRequestConfiguration
                {
                    Options = new AuthenticationLoginSchemaPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/authenticationloginschemapolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/authenticationloginschemapolicy/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}