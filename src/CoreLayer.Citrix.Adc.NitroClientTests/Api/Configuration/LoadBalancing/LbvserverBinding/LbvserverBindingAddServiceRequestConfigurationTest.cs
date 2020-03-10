using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingAddServiceRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LbvserverBindingAddServiceRequestConfigurationValidationTestData))]
        public void LbvserverBindingAddServiceRequestConfigurationValidationTest(
            LbvserverBindingAddServiceRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class LbvserverBindingAddServiceRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LbvserverBindingAddServiceRequestConfiguration(new LbvserverBindingAddServiceRequestDataRoot(
                    new dynamic[]
                    {
                        new LbvserverBindingAddServiceRequestData("testName"),
                        new LbvserverBindingAddServiceRequestData("testName2")
                        {
                            ServiceName = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/lbvserver_service_binding"},
                    {"RequestUri", "/nitro/v1/config/lbvserver_service_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"lbvserver_service_binding\":[{\"name\":\"testName\"}," +
                                       "{\"name\":\"testName2\",\"servicename\":\"test\"}]}"}   
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}