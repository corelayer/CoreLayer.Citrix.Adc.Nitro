using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsHttpProfileGetRequestConfigurationValidationTestData))]
        public void NsHttpProfileGetRequestCOnfigurationValidationTest(
            NsHttpProfileGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NsHttpProfileGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsHttpProfileGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile"}
                } 
            };
            yield return new object[]
            {
                new NsHttpProfileGetRequestConfiguration
                {
                    Options = new NsHttpProfileGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new NsHttpProfileGetRequestConfiguration
                {
                    Options = new NsHttpProfileGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile/resourceName?count=yes&attrs=Name"}
                } 
            };
         }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}