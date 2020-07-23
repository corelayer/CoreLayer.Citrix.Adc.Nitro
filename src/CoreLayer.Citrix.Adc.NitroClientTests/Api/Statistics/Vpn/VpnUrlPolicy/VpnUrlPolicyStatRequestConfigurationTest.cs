using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Vpn.VpnUrlPolicy;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Vpn.VpnUrlPolicy
{
    public class VpnUrlPolicyStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(VpnUrlPolicyStatRequestConfigurationValidationTestData))]
        public void VpnUrlPolicyStatRequestConfigurationValidationTest(VpnUrlPolicyStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class VpnUrlPolicyStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VpnUrlPolicyStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/vpnurlpolicy"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/vpnurlpolicy"}
                } 
            };
            yield return new object[]
            {
                new VpnUrlPolicyStatRequestConfiguration
                {
                    Options = new VpnUrlPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/vpnurlpolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/vpnurlpolicy/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new VpnUrlPolicyStatRequestConfiguration
                {
                    Options = new VpnUrlPolicyStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/vpnurlpolicy"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/vpnurlpolicy/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}