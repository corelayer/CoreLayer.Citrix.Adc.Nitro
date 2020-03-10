using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsTcpProfileUpdateRequestConfigurationValidationTestData))]
        public void NsTcpProfileUpdateRequestConfigurationValidationTest(
            NsTcpProfileUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class NsTcpProfileUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsTcpProfileUpdateRequestConfiguration(new NsTcpProfileUpdateRequestDataRoot(new NsTcpProfileUpdateRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile"},
                    {"RequestContent", "{\"nstcpprofile\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new NsTcpProfileUpdateRequestConfiguration(new NsTcpProfileUpdateRequestDataRoot(new NsTcpProfileUpdateRequestData("test")
                {
                    TcpFastOpen = "ENABLE"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/nstcpprofile"},
                    {"RequestUri", "/nitro/v1/config/nstcpprofile"},
                    {"RequestContent", "{\"nstcpprofile\":[{\"name\":\"test\",\"tcpfastopen\":\"ENABLE\"}]}"},
                    {"Options", ""}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}