using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Service
{
    public class ServiceRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceRemoveRequestConfigurationValidationTestData))]
        public void ServiceRemoveRequestConfigurationValidationTest(ServiceRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServiceRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServiceRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new ServiceRemoveRequestConfiguration()
                {
                    Options = new ServiceRemoveRequestOptions()
                    {
                        ResourceName = "testS"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/service"},
                    {"RequestUri", "/nitro/v1/config/service/testS"},
                    {"Options", "/testS"},
                }, 
            };
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}