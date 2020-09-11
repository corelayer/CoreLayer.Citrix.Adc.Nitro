using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.Reporting
{
    public class ReportingEnableRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(ReportingEnableRequestConfigurationValidationTestData))]
        public void ReportingEnableRequestConfigurationValidationTest(ReportingEnableRequestConfiguration configuration,
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

    public class ReportingEnableRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ReportingEnableRequestConfiguration(), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/reporting"},
                    {"RequestUri", "/nitro/v1/config/reporting?action=enable"},
                    {"RequestContent", "{\"reporting\":{}}"},
                    {"Options", "?action=enable"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}