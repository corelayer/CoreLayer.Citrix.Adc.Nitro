using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingRemoveServicegroupMemberRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingRemoveServicegroupMemberRequestConfigurationValidationTestData))]
        public void ServicegroupBindingRemoveServicegroupMemberRequestConfigurationValidationTest(
            ServicegroupBindingRemoveServicegroupMemberRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServicegroupBindingRemoveServicegroupMemberRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingRemoveServicegroupMemberRequestConfiguration()
                {
                    Options =new ServicegroupBindingRemoveServicegroupMemberRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"servicegroupname", "testSG"},{"servername","testServer"}, {"port", "20"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_servicegroupmember_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_servicegroupmember_binding?args=servicegroupname:testSG,servername:testServer,port:20"},
                    {"Options", "?args=servicegroupname:testSG,servername:testServer,port:20"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}