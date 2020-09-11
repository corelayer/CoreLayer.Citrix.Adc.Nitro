using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6AddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFile6AddRequestConfigurationValidationTestData))]
        public void LocationFile6AddRequestConfigurationValidationTest(LocationFile6AddRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationFile6AddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFile6AddRequestConfiguration(new LocationFile6AddRequestDataRoot(new LocationFile6AddRequestData()
                {
                    Format = "5",
                    LocationFile = "file"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile6"},
                    {"RequestUri", "/nitro/v1/config/locationfile6"},
                    {"RequestContent", "{\"locationfile6\":[{\"locationfile\":\"file\",\"format\":\"5\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LocationFile6AddRequestConfiguration(
                    new LocationFile6AddRequestDataRoot(new dynamic[]
                    {
                        new LocationFile6AddRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile6"},
                    {"RequestUri", "/nitro/v1/config/locationfile6"},
                    {"RequestContent", "{\"locationfile6\":[{}]}"},
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