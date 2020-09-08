using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUnsetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationParameterUnsetRequestConfigurationValidationTestData))]
        public void LocationParameterUnsetRequestConfigurationValidationTest(
            LocationParameterUnsetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationParameterUnsetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationParameterUnsetRequestConfiguration(new LocationParameterUnsetRequestDataRoot(new LocationParameterUnsetRequestData()
                {
                    Context = true,
                    
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationparameter"},
                    {"RequestUri", "/nitro/v1/config/locationparameter?action=unset"},
                    {"RequestContent", "{\"locationparameter\":{\"context\":true}}"},
                    {"Options", "?action=unset"}
                }
            };
            yield return new object[]
            {
                new LocationParameterUnsetRequestConfiguration(
                    new LocationParameterUnsetRequestDataRoot(
                    
                        new LocationParameterUnsetRequestData()
                        {
                            
                        }
                     )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationparameter"},
                    {"RequestUri", "/nitro/v1/config/locationparameter?action=unset"},
                    {"RequestContent", "{\"locationparameter\":{}}"},
                    {"Options", "?action=unset"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}