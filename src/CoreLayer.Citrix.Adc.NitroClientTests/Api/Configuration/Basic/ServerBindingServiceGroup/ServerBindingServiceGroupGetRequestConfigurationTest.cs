using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingServiceGroup;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServerBindingServiceGroup
{
    public class ServerBindingServiceGroupGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingServiceGroupGetRequestConfigurationValidationTestData))]
        public void ServerBindingServiceGroupGetRequestConfigurationValidationTest(
            ServerBindingServiceGroupGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServerBindingServiceGroupGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingServiceGroupGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/server_servicegroup_binding"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"},
                    {"RequestUri", "/nitro/v1/config/server_servicegroup_binding?bulkbindings=yes"}
                } 
            };
            yield return new object[]
            {
                new ServerBindingServiceGroupGetRequestConfiguration
                {
                    Options = new ServerBindingServiceGroupGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server_servicegroup_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/config/server_servicegroup_binding/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new ServerBindingServiceGroupGetRequestConfiguration
                {
                    Options = new ServerBindingServiceGroupGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server_servicegroup_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/server_servicegroup_binding/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}