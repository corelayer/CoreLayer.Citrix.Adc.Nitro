using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserSystemCmdPolicyBindingRemoveRequestConfigurationValTestData))]
        public void SystemUserSystemCmdPolicyBindingRemoveRequestconfigurationValidationTest(
            SystemUserSystemCmdPolicyBindingRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemUserSystemCmdPolicyBindingRemoveRequestConfigurationValTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingRemoveRequestConfiguration()
                {
                    Options = new SystemUserSystemCmdPolicyBindingRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "test"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding?args=name:test"},
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