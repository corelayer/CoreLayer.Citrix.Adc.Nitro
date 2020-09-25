using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverANLPBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverANLPBindingAddRequestConfigurationValidationTestData))]
        public void CsvserverANLPBindingAddRequestConfigurationValidationTest(
            CsvserverAuditNsLogPolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverANLPBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuditNsLogPolicyBindingAddRequestConfiguration(new CsvserverAuditNsLogPolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAuditNsLogPolicyBindingAddRequestData(),
                        new CsvserverAuditNsLogPolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_auditnslogpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_auditnslogpolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_auditnslogpolicy_binding\":[{}," +
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