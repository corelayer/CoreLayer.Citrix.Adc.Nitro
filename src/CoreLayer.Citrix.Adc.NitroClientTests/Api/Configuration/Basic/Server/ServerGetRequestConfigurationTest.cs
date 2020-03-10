using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Server
{
    public class ServerGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerGetRequestConfigurationValidationTestData))]
        public async void ServerGetRequestConfigurationValidationTest(
            ServerGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
        }
    }
    public class ServerGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"ValidationResult", "True"},
                    {"RequestUri", "/nitro/v1/config/server"}
                } 
            };
            yield return new object[]
            {
                new ServerGetRequestConfiguration
                {
                    Options = new ServerGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"ValidationResult", "False"},
                    {"RequestUri", "/nitro/v1/config/server/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new ServerGetRequestConfiguration
                {
                    Options = new ServerGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"ValidationResult", "True"},
                    {"RequestUri", "/nitro/v1/config/server/resourceName?attrs=Name"}
                } 
            };
 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}