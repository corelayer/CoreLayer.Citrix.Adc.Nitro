using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Location;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Location
{
    public class LocationRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(LocationRemoveRequestConfigurationValidationTestData))]
        public void LocationRemoveRequestConfigurationValidationTest(LocationRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class LocationRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new LocationRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/location"},
                    {"RequestUri", "/nitro/v1/config/location"},
                    {"Options", ""},
                },
            };
            yield return new object[]
            {
                new LocationRemoveRequestConfiguration()
                {
                    Options = new LocationRemoveRequestOptions("ipfrom")
                    {
                        Arguments = new Dictionary<string, string>(){{"ipto","test"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/location"},
                    {"RequestUri", "/nitro/v1/config/location/ipfrom?args=ipto:test"},
                    {"Options", "/ipfrom?args=ipto:test"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}