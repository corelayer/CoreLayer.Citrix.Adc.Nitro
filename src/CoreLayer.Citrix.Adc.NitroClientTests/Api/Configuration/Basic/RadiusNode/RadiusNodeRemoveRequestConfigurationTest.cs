using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(RadiusNodeRemoveRequestConfigurationValidationTestData))]
        public void RadiusNodeRemoveRequestConfigurationValidationTest(
            RadiusNodeRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class RadiusNodeRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RadiusNodeRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/radiusnode"},
                    {"RequestUri", "/nitro/v1/config/radiusnode"},
                    {"Options", ""},
                },
            };
            yield return new object[]
            {
                new RadiusNodeRemoveRequestConfiguration()
                {
                    Options = new RadiusNodeRemoveRequestOptions()
                    {
                        ResourceName = "resource"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/radiusnode"},
                    {"RequestUri", "/nitro/v1/config/radiusnode/resource"},
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