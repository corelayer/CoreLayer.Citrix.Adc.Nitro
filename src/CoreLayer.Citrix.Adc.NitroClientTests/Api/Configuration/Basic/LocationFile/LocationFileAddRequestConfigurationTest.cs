using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationFile
{
    public class LocationFileAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFileAddRequestConfigurationValidationTestData))]
        public void LocationFileAddRequestConfigurationValidationTest(LocationFileAddRequestConfiguration configuration,
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

    public class LocationFileAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFileAddRequestConfiguration(new LocationFileAddRequestDataRoot(new LocationFileAddRequestData()
                {
                    Format = "5",
                    LocationFile = "file"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile"},
                    {"RequestUri", "/nitro/v1/config/locationfile"},
                    {"RequestContent", "{\"locationfile\":[{\"locationfile\":\"file\",\"format\":\"5\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LocationFileAddRequestConfiguration(
                    new LocationFileAddRequestDataRoot(new dynamic[]
                    {
                        new LocationFileAddRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile"},
                    {"RequestUri", "/nitro/v1/config/locationfile"},
                    {"RequestContent", "{\"locationfile\":[{}]}"},
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