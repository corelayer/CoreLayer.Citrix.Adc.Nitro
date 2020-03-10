using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Logout;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Logout
{
    public class NitroLogoutRequestConfigurationTest
    {
        // TODO - implement Logout test : -configuration:done
        [Theory]
        [ClassData(typeof(NitroLogoutRequestConfigurationTestData))]
        public async void NitroLogoutRequestConfigurationValidationTest(
            NitroLogoutRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["ContentType"], configuration.ContentType.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
        }
    }
    public class NitroLogoutRequestConfigurationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLogoutRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/logout"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
                    {"ValidationResult", "True"}
                } 
            };
            yield return new object[]
            {
                new NitroLogoutRequestConfiguration
                {
                    Options = new NitroLogoutRequestOptions
                    {
                        Action = "action",
                        PropertyFilter = new List<string>
                        {
                            "propFilter"
                        },
                        ResourceFilter = new Dictionary<string, string>
                        {
                            {"key", "value"}
                        },
                        ResourceName = "resource"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/logout"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
                    {"ValidationResult", "True"}
                } 
            };
            yield return  new object[]
            {
                new NitroLogoutRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/logout"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
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