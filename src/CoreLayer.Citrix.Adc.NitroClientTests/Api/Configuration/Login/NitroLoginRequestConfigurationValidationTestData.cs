using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Login
{
    public class NitroLoginRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLoginRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/login"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
                    {"ValidationResult", "True"}
                } 
            };
//            yield return new object[]
//            {
//                new NitroLoginRequestConfiguration(),
//                new Dictionary<string, string>
//                {
//                    {"ResourcePath", "/nitro/v1/config/login"},
//                    {"Method", "POST"},
//                    {"ContentType", "application/json"},
//                    {"ValidationResult", "True"}
//                } 
//            };
            yield return new object[]
            {
                new NitroLoginRequestConfiguration
                {
                    Options = new NitroLoginRequestOptions
                    {
                        PropertyFilter = new List<string> { "item1"}
                    }
                },
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/login"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
                    {"ValidationResult", "True"},
                } 
            };
            yield return  new object[]
            {
                new NitroLoginRequestConfiguration
                {
                    Options = new NitroLoginRequestOptions
                    {
                        ResourceName = "resource1",
                        Action = "action1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/login"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
                    {"ValidationResult", "True"},
                }
            };
            yield return new object[]
            {
                new NitroLoginRequestConfiguration(
                    new NitroLoginRequestDataRoot
                    {
                        Login = new NitroLoginRequestData("","")
                    }),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/login"},
                    {"Method", "POST"},
                    {"ContentType", "application/json"},
                    {"ValidationResult", "True"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}