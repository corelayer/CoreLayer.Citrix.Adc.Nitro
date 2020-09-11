using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationFile6;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.LocationFile6
{
    public class LocationFile6RemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationFile6RemoveRequestConfigurationValidationTestData))]
        public void LocationFile6RemoveRequestConfigurationValidationTest(
            LocationFile6RemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationFile6RemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationFile6RemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/locationfile6"},
                    {"RequestUri", "/nitro/v1/config/locationfile6"},
                    {"Options", ""},
                },
            };
            yield return new object[]
            {
                new LocationFile6RemoveRequestConfiguration()
                {
                    Options = new LocationFile6RemoveRequestOptions()
                    {
                        ResourceName = "resource"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/locationfile6"},
                    {"RequestUri", "/nitro/v1/config/locationfile6/resource"},
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