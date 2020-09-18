using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingService;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServerBindingService
{
    public class ServerBindingServiceGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingServiceGetRequestConfigurationValidationTestData))]
        public void ServerBindingServiceGetRequestConfigurationValidationTest(
            ServerBindingServiceGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServerBindingServiceGetRequestConfigurationValidationTestData : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingServiceGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/server_service_binding"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"},
                    {"RequestUri", "/nitro/v1/config/server_service_binding?bulkbindings=yes"}
                } 
            };
            yield return new object[]
            {
                new ServerBindingServiceGetRequestConfiguration
                {
                    Options = new ServerBindingServiceGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server_service_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/config/server_service_binding/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new ServerBindingServiceGetRequestConfiguration
                {
                    Options = new ServerBindingServiceGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server_service_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/server_service_binding/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}