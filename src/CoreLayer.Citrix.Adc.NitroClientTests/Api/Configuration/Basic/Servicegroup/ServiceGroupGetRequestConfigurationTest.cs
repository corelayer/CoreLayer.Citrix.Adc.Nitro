using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Servicegroup
{
    public class ServiceGroupGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ServiceGroupGetRequestConfigurationValidationTestData))]
        public async void ServiceGroupGetRequestConfigurationValidationTest(
            ServicegroupGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
        }
    }
    public class ServiceGroupGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ServicegroupGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup"},
                    {"Options", ""},
                    {"ValidationResult", "True"}
                }, 
            };
            yield return new object[]
            {
                new ServicegroupGetRequestConfiguration
                {
                    Options = new ServicegroupGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup?attrs=wrongFilter"},
                    {"Options", "?attrs=wrongFilter"},
                    {"ValidationResult", "False"}
                }
            };
            yield return new object[]
            {
                new ServicegroupGetRequestConfiguration
                {
                    Options = new ServicegroupGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "ServiceGroupName"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/servicegroup"},
                    {"RequestUri", "/nitro/v1/config/servicegroup?attrs=ServiceGroupName"},
                    {"Options", "?attrs=ServiceGroupName"},
                    {"ValidationResult", "True"}
                }
            };
        }
        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}