using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbSite;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Gslb.GslbSite
{
    public class GslbSiteStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(GslbSiteStatRequestConfigurationValidationTestData))]
        public void GslbSiteStatRequestConfigurationValidationTest(GslbSiteStatRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class GslbSiteStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbSiteStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/gslbsite"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/gslbsite"}
                } 
            };
            yield return new object[]
            {
                new GslbSiteStatRequestConfiguration
                {
                    Options = new GslbSiteStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/gslbsite"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/gslbsite/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new GslbSiteStatRequestConfiguration
                {
                    Options = new GslbSiteStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/gslbsite"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/gslbsite/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}