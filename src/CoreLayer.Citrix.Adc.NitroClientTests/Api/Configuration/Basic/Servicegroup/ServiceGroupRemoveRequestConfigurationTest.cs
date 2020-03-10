using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Servicegroup
{
    public class ServiceGroupRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceGroupRemoveRequestConfigurationValidationTestData))]
        public void ServiceGroupRemoveRequestConfigurationValidationTest(
            ServicegroupRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class ServiceGroupRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new ServicegroupRemoveRequestConfiguration()
                {
                    Options = new ServicegroupRemoveRequestOptions()
                    {
                        ResourceName = "testSG"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup/testSG"},
                    {"Options", "/testSG"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}