using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Bot.Bot;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Bot.Bot
{
    public class BotStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(BotStatRequestConfigurationValidationTestData))]
        public void BotStatRequestConfigurationValidationTest(BotStatRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class BotStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new BotStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/bot"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/bot"}
                } 
            };
            yield return new object[]
            {
                new BotStatRequestConfiguration
                {
                    Options = new BotStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/bot"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/bot/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new BotStatRequestConfiguration
                {
                    Options = new BotStatRequestOptions
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
                    {"ResourcePath", "/nitro/v1/stat/bot"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/bot/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}