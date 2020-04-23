using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUser
{
    public class SystemUserUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserUpdateRequestConfigurationValidationTestData))]
        public void SystemUserUpdateRequestConfigurationValidationTest(
            SystemUserUpdateRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemUserUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserUpdateRequestConfiguration(
                    new SystemUserUpdateRequestDataRoot(new dynamic[]
                    {
                        new SystemUserUpdateRequestData()
                        {
                            UserName = "test"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/systemuser"},
                    {"RequestUri", "/nitro/v1/config/systemuser"},
                    {"RequestContent", "{\"systemuser\":[{\"username\":\"test\"}]}"},
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