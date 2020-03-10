using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverBindingGetRequestConfigurationValidationTestData))]
        public void LbvserverBindingGetRequestConfigurationValidationTest(
            LbvserverBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LbvserverBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_binding?bulkbindings=yes"},
                    {"Options", "?bulkbindings=yes"},
                }, 
            };
            yield return new object[]
            {
                new LbvserverBindingGetRequestConfiguration
                {
                    Options = new LbvserverBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/lbvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_binding?count=yes&attrs=Filter"},
                    {"Options", "?count=yes&attrs=Filter"}
                    
                }
            };
            yield return new object[]
            {
                new LbvserverBindingGetRequestConfiguration
                {
                    Options = new LbvserverBindingGetRequestOptions
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
                    {"ResourcePath", "/nitro/v1/config/lbvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_binding?attrs=Filter"},
                    {"Options", "?attrs=Filter"}
                }
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}