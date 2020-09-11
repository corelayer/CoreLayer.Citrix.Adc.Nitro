using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.RadiusNode
{
    public class RadiusNodeUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(RadiusNodeUpdateRequestConfigurationValidationTestData))]
        public void RadiusNodeUpdateRequestConfigurationValidationTest(RadiusNodeUpdateRequestConfiguration configuration,
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
    
    public class RadiusNodeUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new RadiusNodeUpdateRequestConfiguration(new RadiusNodeUpdateRequestDataRoot(new RadiusNodeUpdateRequestData()
                {
                    NodePrefix = "5",
                    RadId = "1"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/radiusnode"},
                    {"RequestUri", "/nitro/v1/config/radiusnode"},
                    {"RequestContent", "{\"radiusnode\":[{\"radid\":\"1\",\"nodeprefix\":\"5\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new RadiusNodeUpdateRequestConfiguration(
                    new RadiusNodeUpdateRequestDataRoot(new dynamic[]
                    {
                        new RadiusNodeUpdateRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/radiusnode"},
                    {"RequestUri", "/nitro/v1/config/radiusnode"},
                    {"RequestContent", "{\"radiusnode\":[{}]}"},
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