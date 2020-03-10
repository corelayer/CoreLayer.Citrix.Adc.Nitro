using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Server
{
    public class ServerRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerRemoveRequestConfigurationValidationTestData))]
        public void ServerRemoveRequestConfigurationValidationTest(ServerRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServerRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new ServerRemoveRequestConfiguration()
                {
                    Options = new ServerRemoveRequestOptions()
                    {
                        ResourceName = "testServerName"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server/testServerName"},
                    {"Options", "/testServerName"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}