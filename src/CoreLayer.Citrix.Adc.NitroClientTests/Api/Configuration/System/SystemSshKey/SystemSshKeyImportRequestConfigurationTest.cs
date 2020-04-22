using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyImportRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemSshKeyImportRequestConfigurationValidationTestData))]
        public void SystemSshKeyImportRequestConfigurationValidationTest(SystemSshKeyImportRequestConfiguration configuration, 
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

    public class SystemSshKeyImportRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemSshKeyImportRequestConfiguration(new SystemSshKeyImportRequestDataRoot(new SystemSshKeyImportRequestData(){Name = "test"})),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemsshkey"},
                    {"RequestUri", "/nitro/v1/config/systemsshkey?action=Import"},
                    {"RequestContent", "{\"systemsshkey\":[{\"name\":\"test\"}]}"},
                    {"Options", "?action=Import"}
                }
            };
            yield return new object[]
            {
                new SystemSshKeyImportRequestConfiguration(new SystemSshKeyImportRequestDataRoot(new SystemSshKeyImportRequestData()
                {
                    Name = "test",
                    Src = "testSrc"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemsshkey"},
                    {"RequestUri", "/nitro/v1/config/systemsshkey?action=Import"},
                    {"RequestContent", "{\"systemsshkey\":[{\"name\":\"test\",\"src\":\"testSrc\"}]}"},
                    {"Options", "?action=Import"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}