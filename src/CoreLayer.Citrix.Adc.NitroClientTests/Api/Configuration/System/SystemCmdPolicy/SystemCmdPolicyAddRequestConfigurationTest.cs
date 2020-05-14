using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemCmdPolicyAddRequestConfigurationValidationTestData))]
        public void SystemCmdPolicyAddRequestConfigurationValidationTest(SystemCmdPolicyAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemCmdPolicyAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemCmdPolicyAddRequestConfiguration(new SystemCmdPolicyAddRequestDataRoot(new SystemCmdPolicyAddRequestData("test"){})),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemcmdpolicy"},
                    {"RequestUri", "/nitro/v1/config/systemcmdpolicy"},
                    {"RequestContent", "{\"systemcmdpolicy\":[{\"policyname\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new SystemCmdPolicyAddRequestConfiguration(new SystemCmdPolicyAddRequestDataRoot(new SystemCmdPolicyAddRequestData("test")
                {
                    CmdSpec = "spec"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemcmdpolicy"},
                    {"RequestUri", "/nitro/v1/config/systemcmdpolicy"},
                    {"RequestContent", "{\"systemcmdpolicy\":[{\"policyname\":\"test\",\"cmdspec\":\"spec\"}]}"},
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