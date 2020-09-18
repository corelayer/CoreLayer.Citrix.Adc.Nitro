using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.VServer
{
    public class VServerEnableRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(VServerEnableRequestConfigurationValidationTestData))]
        public void VServerEnableRequestConfigurationValidationTest(VServerEnableRequestConfiguration configuration,
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

    public class VServerEnableRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VServerEnableRequestConfiguration(new VServerEnableRequestDataRoot(new VServerEnableRequestData()
                {
                    Name = "test"
                })), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/vserver"},
                    {"RequestUri", "/nitro/v1/config/vserver?action=enable"},
                    {"RequestContent", "{\"vserver\":{\"name\":\"test\"}}"},
                    {"Options", "?action=enable"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}