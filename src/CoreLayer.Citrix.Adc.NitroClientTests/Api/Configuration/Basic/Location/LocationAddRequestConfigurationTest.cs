using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Location
{
    public class LocationAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationAddRequestConfigurationValidationTestData))]
        public void LocationAddRequestConfigurationValidationTest(LocationAddRequestConfiguration configuration,
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

    public class LocationAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationAddRequestConfiguration(new LocationAddRequestDataRoot(new LocationAddRequestData("testFrom",  "testTo", "testlocation")
                {
                    Longitude = 5,
                    Latitude = 10
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/location"},
                    {"RequestUri", "/nitro/v1/config/location"},
                    {"RequestContent", "{\"location\":[{\"ipfrom\":\"testFrom\",\"ipto\":\"testTo\",\"preferredlocation\":\"testlocation\",\"longitude\":5,\"latitude\":10}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new LocationAddRequestConfiguration(
                    new LocationAddRequestDataRoot(new dynamic[]
                    {
                        new LocationAddRequestData("testFrom",  "testTo", "testlocation")
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/location"},
                    {"RequestUri", "/nitro/v1/config/location"},
                    {"RequestContent", "{\"location\":[{\"ipfrom\":\"testFrom\",\"ipto\":\"testTo\",\"preferredlocation\":\"testlocation\"}]}"},
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