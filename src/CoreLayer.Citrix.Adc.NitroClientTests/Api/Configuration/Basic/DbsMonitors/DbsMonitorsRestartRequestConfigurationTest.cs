using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.DbsMonitors;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.DbsMonitors
{
    public class DbsMonitorsRestartRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DbsMonitorsRestartRequestConfigurationValidationTestData))]
        public void DbsMonitorsRestartRequestConfigurationValidationTest(
            DbsMonitorsRestartRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class DbsMonitorsRestartRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DbsMonitorsRestartRequestConfiguration(), 
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/dbsmonitors"},
                    {"RequestUri", "/nitro/v1/config/dbsmonitors?action=restart"},
                    {"RequestContent", "{\"dbsmonitors\":{}}"},
                    {"Options", "?action=restart"}
                }

            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}