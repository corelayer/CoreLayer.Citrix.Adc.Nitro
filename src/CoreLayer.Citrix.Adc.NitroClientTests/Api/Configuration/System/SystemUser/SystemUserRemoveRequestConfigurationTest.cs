using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemUser;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.System.SystemUser
{
    public class SystemUserRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(SystemUserRemoveRequestConfigurationValidationTestData))]
        public void SystemUserRemoveRequestConfigurationValidationTest(
            SystemUserRemoveRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class SystemUserRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new SystemUserRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/systemuser"},
                    {"RequestUri", "/nitro/v1/config/systemuser"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new SystemUserRemoveRequestConfiguration()
                {
                    Options = new SystemUserRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "test"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/systemuser"},
                    {"RequestUri", "/nitro/v1/config/systemuser?args=name:test"},
                    {"Options", "?args=name:test"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}