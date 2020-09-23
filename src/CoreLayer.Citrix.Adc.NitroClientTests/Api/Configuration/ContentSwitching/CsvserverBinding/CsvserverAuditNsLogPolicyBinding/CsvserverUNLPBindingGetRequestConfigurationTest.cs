using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverUNLPBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverUNLPBindingGetRequestConfigurationValidationTestData))]
        public void CsvserverUNLPBindingGetRequestConfigurationValidationTest(
            CsvserverAuditNsLogPolicyBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverUNLPBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuditNsLogPolicyBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_auditnslogpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_auditnslogpolicy_binding?bulkbindings=yes"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"}
                }
            };
            
            yield return new object[]
            {
                new CsvserverAuditNsLogPolicyBindingGetRequestConfiguration
                {
                    Options = new CsvserverAuditNsLogPolicyBindingGetRequestOptions()
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_auditnslogpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_auditnslogpolicy_binding/instance1?attrs=Filter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new CsvserverAuditNsLogPolicyBindingGetRequestConfiguration
                {
                    Options = new CsvserverAuditNsLogPolicyBindingGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        },
                        ResourceName = "instance1",
                        Action = "testAction"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_auditnslogpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_auditnslogpolicy_binding/instance1?action=testAction"},
                    {"Method", "GET"},
                    {"Options", "/instance1?action=testAction"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}