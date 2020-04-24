using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUser
{
    public class SystemUserAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserAddRequestConfigurationValidationTestData))]
        public void SystemUserAddRequestConfigurationValidationTest(SystemUserAddRequestConfiguration configuration,
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

    public class SystemUserAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserAddRequestConfiguration(new SystemUserAddRequestDataRoot(new SystemUserAddRequestData(){UserName = "test"})),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemuser"},
                    {"RequestUri", "/nitro/v1/config/systemuser"},
                    {"RequestContent", "{\"systemuser\":[{\"username\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new SystemUserAddRequestConfiguration(new SystemUserAddRequestDataRoot(new SystemUserAddRequestData()
                {
                    UserName = "test",
                    Timeout = 123
                })),
                new Dictionary<string, string>
                {
                    {"Method", "POST"},
                    {"ResourcePath", "/nitro/v1/config/systemuser"},
                    {"RequestUri", "/nitro/v1/config/systemuser"},
                    {"RequestContent", "{\"systemuser\":[{\"username\":\"test\",\"timeout\":123}]}"},
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