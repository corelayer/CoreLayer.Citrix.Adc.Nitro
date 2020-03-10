using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Network.NetProfile
{
    public class NetProfileGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NetProfileGetRequestConfigurationValidationTestData))]
        public void NetProfileGetRequestConfigurationValidationTest(NetProfileGetRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NetProfileGetRequestConfigurationValidationTestData: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NetProfileGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/netprofile"}
                } 
            };
            yield return new object[]
            {
                new NetProfileGetRequestConfiguration
                {
                    Options = new NetProfileGetRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/netprofile/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new NetProfileGetRequestConfiguration
                {
                    Options = new NetProfileGetRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }, 
                        Count = true,
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/netprofile"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/netprofile/resourceName?count=yes&attrs=Name"}
                } 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}