using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.VServer
{
    public class VServerDisableRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(VServerDisableRequestConfigurationValidationTestData))]
        public void VServerDisableRequestConfigurationValidationTest(VServerDisableRequestConfiguration configuration,
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

    public class VServerDisableRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VServerDisableRequestConfiguration(new VServerDisableRequestDataRoot(new VServerDisableRequestData()
                {
                    Name = "test"
                })), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/vserver"},
                    {"RequestUri", "/nitro/v1/config/vserver?action=disable"},
                    {"RequestContent", "{\"vserver\":{\"name\":\"test\"}}"},
                    {"Options", "?action=disable"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}