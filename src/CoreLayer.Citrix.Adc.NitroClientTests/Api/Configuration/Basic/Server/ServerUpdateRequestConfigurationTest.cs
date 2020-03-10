using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Server
{
    public class ServerUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServerUpdateRequestConfigurationValidationTestData))]
        public void ServerUpdateRequestConfigurationValidationTest(ServerUpdateRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class ServerUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServerUpdateRequestConfiguration(new ServerUpdateRequestDataRoot(new ServerUpdateRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"RequestContent", "{\"server\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new ServerUpdateRequestConfiguration(
                    new ServerUpdateRequestDataRoot(new dynamic[]
                    {
                        new ServerUpdateRequestData("test")
                        {
                            Comment = "testComment"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/server"},
                    {"RequestUri", "/nitro/v1/config/server"},
                    {"RequestContent", "{\"server\":[{\"name\":\"test\",\"comment\":\"testComment\"}]}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}