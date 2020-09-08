using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationParameterUpdateRequestConfigurationValidationTestData))]
        public void LocationParameterUpdateRequestConfigurationValidationTest(
            LocationParameterUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationParameterUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationParameterUpdateRequestConfiguration(new LocationParameterUpdateRequestDataRoot(new LocationParameterUpdateRequestData()
                {
                    Context = "5",
                    Qualifier1Label = "label"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/locationparameter"},
                    {"RequestUri", "/nitro/v1/config/locationparameter"},
                    {"RequestContent", "{\"locationparameter\":[{\"context\":\"5\",\"q1label\":\"label\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LocationParameterUpdateRequestConfiguration(
                    new LocationParameterUpdateRequestDataRoot(new dynamic[]
                    {
                        new LocationParameterUpdateRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/locationparameter"},
                    {"RequestUri", "/nitro/v1/config/locationparameter"},
                    {"RequestContent", "{\"locationparameter\":[{}]}"},
                    {"Options", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}