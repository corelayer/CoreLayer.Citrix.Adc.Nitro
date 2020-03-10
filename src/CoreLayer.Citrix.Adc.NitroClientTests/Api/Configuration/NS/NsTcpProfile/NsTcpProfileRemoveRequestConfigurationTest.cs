using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsTcpProfileRemoveRequestConfigurationValidationTestData))]
        public void NsTcpProfileRemoveRequestConfigurationValidationTest(
            NsTcpProfileRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NsTcpProfileRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsTcpProfileRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new NsTcpProfileRemoveRequestConfiguration()
                {
                    Options = new NsTcpProfileRemoveRequestOptions("testTcpProf")
                    {
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile/testTcpProf"},
                    {"Options", "/testTcpProf"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}