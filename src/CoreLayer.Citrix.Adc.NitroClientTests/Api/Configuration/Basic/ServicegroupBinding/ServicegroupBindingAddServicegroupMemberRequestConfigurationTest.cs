using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddServicegroupMemberRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServicegroupBindingAddServicegroupMemberRequestConfigurationValidationTestData))]
        public void ServicegroupBindingAddServicegroupMemberRequestConfigurationValidationTest(
            ServicegroupBindingAddServicegroupMemberRequestConfiguration configuration,
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
    public class ServicegroupBindingAddServicegroupMemberRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupBindingAddServicegroupMemberRequestConfiguration(new ServicegroupBindingAddServicegroupMemberRequestDataRoot(
                    new dynamic[]
                    {
                        new ServicegroupBindingAddServicegroupMemberRequestData("test1"), 
                        new ServicegroupBindingAddServicegroupMemberRequestData("test2")
                        {
                            Ip = "testIp"
                        }
                    })
                ), 
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup_servicegroupmember_binding"},
                    {"RequestUri", "/nitro/v1/config/servicegroup_servicegroupmember_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"servicegroup_servicegroupmember_binding\":[{\"servicegroupname\":\"test1\"}," +
                                       "{\"servicegroupname\":\"test2\",\"ip\":\"testIp\"}" +
                                       "]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}