using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbmonitorRemoveRequestConfigurationValidationTestData))]
        public void LbmonitorRemoveRequestConfigurationValidationTest(
            LbmonitorRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class LbmonitorRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbmonitorRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new LbmonitorRemoveRequestConfiguration()
                {
                    Options = new LbmonitorRemoveRequestOptions("testMon")
                    {
                        Arguments = new Dictionary<string, string>(){{"type", "HTTP"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/lbmonitor"},
                    {"RequestUri", "/nitro/v1/config/lbmonitor/testMon?args=type:HTTP"},
                    {"Options", "/testMon?args=type:HTTP"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}