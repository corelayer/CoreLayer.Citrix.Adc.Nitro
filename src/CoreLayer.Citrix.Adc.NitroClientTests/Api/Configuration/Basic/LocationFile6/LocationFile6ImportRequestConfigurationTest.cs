using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6ImportRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFile6ImportRequestConfigurationValidationTestData))]
        public void LocationFile6ImportRequestConfigurationValidationTest(
            LocationFile6ImportRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationFile6ImportRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFile6ImportRequestConfiguration(new LocationFile6ImportRequestDataRoot(new LocationFile6ImportRequestData()
                {
                    Src = "5",
                    LocationFile = "file"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile6"},
                    {"RequestUri", "/nitro/v1/config/locationfile6?action=Import"},
                    {"RequestContent", "{\"locationfile6\":[{\"locationfile\":\"file\",\"src\":\"5\"}]}"},
                    {"Options", "?action=Import"}
                }
            };
            yield return new object[]
            {
                new LocationFile6ImportRequestConfiguration(
                    new LocationFile6ImportRequestDataRoot(new dynamic[]
                    {
                        new LocationFile6ImportRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile6"},
                    {"RequestUri", "/nitro/v1/config/locationfile6?action=Import"},
                    {"RequestContent", "{\"locationfile6\":[{}]}"},
                    {"Options", "?action=Import"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}