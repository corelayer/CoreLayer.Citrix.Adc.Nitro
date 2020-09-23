using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverANLPBindingRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverANLPBindingRemoveRequestConfigurationValidationTestData))]
        public void CsvserverANLPBindingRemoveRequestConfigurationValidationTest(
            CsvserverAuditNsLogPolicyBindingRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverANLPBindingRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuditNsLogPolicyBindingRemoveRequestConfiguration()
                {
                    Options = new CsvserverAuditNsLogPolicyBindingRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testCsv"},{"policyname", "testPolicy"}}
                    }
                },
                new Dictionary<string, string>()
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_auditnslogpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_auditnslogpolicy_binding?args=name:testCsv,policyname:testPolicy"},
                    {"Options", "?args=name:testCsv,policyname:testPolicy"},
                } 
            };        
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}