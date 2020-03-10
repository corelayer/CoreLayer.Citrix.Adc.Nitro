using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Network.NetProfile
{
    public class NetProfileRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NetProfileRemoveRequestConfigurationValidationTestData))]
        public void NetProfileRemoveRequestConfigurationValidationTest(
            NetProfileRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NetProfileRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NetProfileRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"RequestUri", "/nitro/v1/config/netprofile"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new NetProfileRemoveRequestConfiguration()
                {
                    Options = new NetProfileRemoveRequestOptions("testNP")
                    {
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"RequestUri", "/nitro/v1/config/netprofile/testNP"},
                    {"Options", "/testNP"},
                }, 
            };        
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}