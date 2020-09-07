using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationFile
{
    public class LocationFileImportRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFileImportRequestConfigurationValidationTestData))]
        public void LocationFileImportRequestConfigurationValidationTest(
            LocationFileImportRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationFileImportRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFileImportRequestConfiguration(new LocationFileImportRequestDataRoot(new LocationFileImportRequestData()
                {
                    Src = "5",
                    LocationFile = "file"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile"},
                    {"RequestUri", "/nitro/v1/config/locationfile?action=Import"},
                    {"RequestContent", "{\"locationfile\":[{\"locationfile\":\"file\",\"src\":\"5\"}]}"},
                    {"Options", "?action=Import"}
                }
            };
            yield return new object[]
            {
                new LocationFileImportRequestConfiguration(
                    new LocationFileImportRequestDataRoot(new dynamic[]
                    {
                        new LocationFileImportRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/locationfile"},
                    {"RequestUri", "/nitro/v1/config/locationfile?action=Import"},
                    {"RequestContent", "{\"locationfile\":[{}]}"},
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