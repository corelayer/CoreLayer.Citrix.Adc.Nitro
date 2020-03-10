using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsHttpProfileRemoveRequestConfigurationValidationTestData))]
        public void NsHttpProfileRemoveRequestConfigurationValidationTest(
            NsHttpProfileRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class NsHttpProfileRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsHttpProfileRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new NsHttpProfileRemoveRequestConfiguration()
                {
                    Options = new NsHttpProfileRemoveRequestOptions("testHttpProf")
                    {
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/nshttpprofile"},
                    {"RequestUri", "/nitro/v1/config/nshttpprofile/testHttpProf"},
                    {"Options", "/testHttpProf"},
                }, 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}