using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverRemoveRequestConfigurationValidationTestData))]
        public void LbvserverRemoveRequestConfigurationValidationTest(
            LbvserverRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class LbvserverRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new LbvserverRemoveRequestConfiguration()
                {
                    Options = new LbvserverRemoveRequestOptions()
                    {
                        ResourceName = "testLbvs"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver"},
                    {"RequestUri", "/nitro/v1/config/lbvserver/testLbvs"},
                    {"Options", "/testLbvs"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}