using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.BotPolicyLabel;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Bot.BotPolicyLabel
{
    public class BotPolicyLabelStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(BotPolicyLabelStatRequestConfigurationValidationTestData))]
        public void BotPolicyLabelStatRequestConfigurationValidationTest(
            BotPolicyLabelStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class BotPolicyLabelStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
             yield return new object[]
            {
                new BotPolicyLabelStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/botpolicylabel"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/botpolicylabel"}
                } 
            };
            yield return new object[]
            {
                new BotPolicyLabelStatRequestConfiguration
                {
                    Options = new BotPolicyLabelStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/botpolicylabel"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/botpolicylabel/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new BotPolicyLabelStatRequestConfiguration
                {
                    Options = new BotPolicyLabelStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/botpolicylabel"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/botpolicylabel/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}