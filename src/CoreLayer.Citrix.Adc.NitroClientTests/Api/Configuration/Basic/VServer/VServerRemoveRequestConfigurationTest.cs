using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.VServer
{
    public class VServerRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(VServerRemoveRequestConfigurationValidationTestData))]
        public void VServerRemoveRequestConfigurationValidationTest(VServerRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class VServerRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VServerRemoveRequestConfiguration()
                {
                    Options =new VServerRemoveRequestOptions()
                   {
                      Arguments = new Dictionary<string, string>(){{"name", "testS"}}
                  }
                },
                new Dictionary<string, string>
                {
                   {"Method", "DELETE"},
                  {"ResourcePath", "/nitro/v1/config/vserver"},
                 {"RequestUri", "/nitro/v1/config/vserver?args=name:testS"},
                 {"Options", "?args=name:testS"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}