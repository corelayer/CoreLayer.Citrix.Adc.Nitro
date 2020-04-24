using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemSshKeyRemoveRequestConfigurationValidationTestData))]
        public void SystenSshKeyRemoveRequestConfigurationValidationTest(
            SystemSshKeyRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemSshKeyRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemSshKeyRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/systemsshkey"},
                    {"RequestUri", "/nitro/v1/config/systemsshkey"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new SystemSshKeyRemoveRequestConfiguration()
                {
                    Options = new SystemSshKeyRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "test"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/systemsshkey"},
                    {"RequestUri", "/nitro/v1/config/systemsshkey?args=name:test"},
                    {"Options", "?args=name:test"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}