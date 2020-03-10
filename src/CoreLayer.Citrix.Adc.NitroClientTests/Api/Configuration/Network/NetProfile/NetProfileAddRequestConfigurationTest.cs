using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Network.NetProfile
{
    public class NetProfileAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NetProfileAddRequestConfigurationValidationTestData))]
        public void NetProfileAddRequestConfigurationValidationTest(NetProfileAddRequestConfiguration configuration,
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
    public class NetProfileAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NetProfileAddRequestConfiguration(new NetProfileAddRequestDataRoot(new NetProfileAddRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"RequestUri", "/nitro/v1/config/netprofile"},
                    {"RequestContent", "{\"netprofile\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new NetProfileAddRequestConfiguration(new NetProfileAddRequestDataRoot(new NetProfileAddRequestData("test")
                {
                    OverrideLsn = "testO"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"RequestUri", "/nitro/v1/config/netprofile"},
                    {"RequestContent", "{\"netprofile\":[{\"name\":\"test\",\"overridelsn\":\"testO\"}]}"},
                    {"Options", ""}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}