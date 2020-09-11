using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationFile
{
    public class LocationFileRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFileRemoveRequestConfigurationValidationTestData))]
        public void LocationFileRemoveRequestConfigurationValidationTest(
            LocationFileRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationFileRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFileRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/locationfile"},
                    {"RequestUri", "/nitro/v1/config/locationfile"},
                    {"Options", ""},
                },
            };
            yield return new object[]
            {
                new LocationFileRemoveRequestConfiguration()
                {
                    Options = new LocationFileRemoveRequestOptions()
                    {
                        ResourceName = "resource"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/locationfile"},
                    {"RequestUri", "/nitro/v1/config/locationfile/resource"},
                    {"Options", "/resource"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}