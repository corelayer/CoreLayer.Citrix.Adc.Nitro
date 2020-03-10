using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverGetRequestConfigurationValidationTestData))]
        public async void CsvserverGetRequestConfigurationValidationTest(
            CsvserverGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();
            
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
        }
    }
    public class CsvserverGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"Options", ""},
                    {"ValidationResult", "True"}
                }, 
            };
            yield return new object[]
            {
                new CsvserverGetRequestConfiguration
                {
                    Options = new CsvserverGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver?attrs=wrongFilter"},
                    {"Options", "?attrs=wrongFilter"},
                    {"ValidationResult", "False"}
                }
            };
            yield return new object[]
            {
                new CsvserverGetRequestConfiguration
                {
                    Options = new CsvserverGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"Method", "GET"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver?attrs=Name"},
                    {"Options", "?attrs=Name"},
                    {"ValidationResult", "True"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}