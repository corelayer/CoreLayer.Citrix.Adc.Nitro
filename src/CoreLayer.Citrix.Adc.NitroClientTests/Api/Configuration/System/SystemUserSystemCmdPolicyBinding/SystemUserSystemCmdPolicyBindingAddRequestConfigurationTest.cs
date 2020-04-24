using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserSystemCmdPolicyBindAddReqConfValTestData))]
        public void SystemUserSystemCmdPolicyBindAddReqConfValTest(
            SystemUserSystemCmdPolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemUserSystemCmdPolicyBindAddReqConfValTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingAddRequestConfiguration(new SystemUserSystemCmdPolicyBindingAddRequestDataRoot(
                    new SystemUserSystemCmdPolicyBindingAddRequestData(){UserName = "test"})),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"RequestContent", "{\"systemuser_systemcmdpolicy_binding\":[{\"username\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingAddRequestConfiguration(new SystemUserSystemCmdPolicyBindingAddRequestDataRoot(
                    new SystemUserSystemCmdPolicyBindingAddRequestData()
                {
                    UserName = "test",
                    Priority = 123
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"RequestContent", "{\"systemuser_systemcmdpolicy_binding\":[{\"username\":\"test\",\"priority\":123}]}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}