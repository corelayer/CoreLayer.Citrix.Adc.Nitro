using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverRemoveRequestConfigurationValidationTestData))]
        public void CsvserverRemoveRequestConfigurationValidationTest(
            CsvserverRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CsvserverRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new CsvserverRemoveRequestConfiguration()
                {
                    Options = new CsvserverRemoveRequestOptions()
                    {
                        ResourceName = "testCsvs"
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver/testCsvs"},
                    {"Options", "/testCsvs"},
                }, 
            };        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}