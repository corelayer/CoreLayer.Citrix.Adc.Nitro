using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetServicegroupRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverBindingGetServicegroupRequestConfigurationValidationTestData))]
        public void LbvserverBindingGetServicegroupRequestConfigurationValidationTest(
            LbvserverBindingGetServicegroupRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LbvserverBindingGetServicegroupRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverBindingGetServicegroupRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_servicegroup_binding?bulkbindings=yes"},
                    {"Options", "?bulkbindings=yes"},
                }, 
            };
            yield return new object[]
            {
                new LbvserverBindingGetServicegroupRequestConfiguration
                {
                    Options = new LbvserverBindingGetServicegroupRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }, Count = true
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_servicegroup_binding?bulkbindings=yes&count=yes&attrs=Filter"},
                    {"Options", "?bulkbindings=yes&count=yes&attrs=Filter"}
                    
                }
            };
            yield return new object[]
            {
                new LbvserverBindingGetServicegroupRequestConfiguration
                {
                    Options = new LbvserverBindingGetServicegroupRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_servicegroup_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_servicegroup_binding?bulkbindings=yes&attrs=Filter"},
                    {"Options", "?bulkbindings=yes&attrs=Filter"}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}