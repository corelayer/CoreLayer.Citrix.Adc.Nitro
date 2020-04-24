using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserSysCmdPolicyBindGetReqConfValTestData))]
        public void SystemUserSysCmdPolicyBindGetReqConfValTest(SystemUserSystemCmdPolicyBindingGetRequestConfiguration configuration, 
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemUserSysCmdPolicyBindGetReqConfValTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"}
                } 
            };
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingGetRequestConfiguration
                {
                    Options = new SystemUserSystemCmdPolicyBindingGetRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Filter"},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding/resourceName?attrs=Filter"}
                } 
            };
            yield return new object[]
            {
                new SystemUserSystemCmdPolicyBindingGetRequestConfiguration
                {
                    Options = new SystemUserSystemCmdPolicyBindingGetRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }, 
                        Count = true,
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/systemuser_systemcmdpolicy_binding"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?count=yes&attrs=Name"},
                    {"RequestUri", "/nitro/v1/config/systemuser_systemcmdpolicy_binding/resourceName?count=yes&attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}