using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAnalyticsProfileBinding
{
    public class CsvserverAnalyticsProfileBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAnalyticsProfileBindingAddRequestConfigurationValidationTestData))]
        public void CsvserverAnalyticsProfileBindingAddRequestConfigurationValidationTest(
            CsvserverAnalyticsProfileBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverAnalyticsProfileBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAnalyticsProfileBindingAddRequestConfiguration(new CsvserverAnalyticsProfileBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAnalyticsProfileBindingAddRequestData(),
                        new CsvserverAnalyticsProfileBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_analyticsprofile_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_analyticsprofile_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_analyticsprofile_binding\":[{}," +
                                       "{\"name\":\"test\"}]}"}   
                } 
            };        
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}