using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Login
{
    // TODO - Convert test to verify against HttpRequestMessage
    // TODO - Test with empty credentials - Done? -ArgumentOutOfRangeException?
    // TODO - Test with additional Options ? -Done
    public class NitroLoginRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NitroLoginRequestConfigurationValidationTestData))]
        public async void NitroLoginRequestConfigurationValidationTest(
            NitroLoginRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            var validationResult = await configuration.ValidateAsync();

            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["ContentType"], configuration.ContentType.ToString());
            Assert.Equal(expected["ValidationResult"], validationResult.IsValid.ToString());
            
            Assert.Equal(expected["ResourcePath"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
        }
    }
}