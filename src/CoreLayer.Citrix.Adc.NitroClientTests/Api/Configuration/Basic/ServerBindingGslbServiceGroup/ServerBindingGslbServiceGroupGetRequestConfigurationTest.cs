using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBindingGslbServiceGroup;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServerBindingGslbServiceGroup
{
    public class ServerBindingGslbServiceGroupGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerBindingGslbServiceGroupGetRequestConfigurationValidationTestData))]
        public void ServerBindingGslbServiceGroupGetRequestConfigurationValidationTest(
            ServerBindingGslbServiceGroupGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServerBindingGslbServiceGroupGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerBindingGslbServiceGroupGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/server_gslbservicegroup_binding"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/server_gslbservicegroup_binding"}
                } 
            };
            yield return new object[]
            {
                new ServerBindingGslbServiceGroupGetRequestConfiguration
                {
                    Options = new ServerBindingGslbServiceGroupGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server_gslbservicegroup_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/config/server_gslbservicegroup_binding/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new ServerBindingGslbServiceGroupGetRequestConfiguration
                {
                    Options = new ServerBindingGslbServiceGroupGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/server_gslbservicegroup_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/server_gslbservicegroup_binding/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}