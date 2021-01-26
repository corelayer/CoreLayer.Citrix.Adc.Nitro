﻿using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditSysLogPolicyBinding
{
    public class CsvserverASLPBindingAddRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverASLPBindingAddRequestConfigurationValidationTestData))]
        public void CsvserverASLPBindingAddRequestConfigurationValidationTest(
            CsvserverAuditSysLogPolicyBindingAddRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverASLPBindingAddRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAuditSysLogPolicyBindingAddRequestConfiguration(new CsvserverAuditSysLogPolicyBindingAddRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverAuditSysLogPolicyBindingAddRequestData(),
                        new CsvserverAuditSysLogPolicyBindingAddRequestData()
                        {
                            Name = "test"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_auditsyslogpolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_auditsyslogpolicy_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_auditsyslogpolicy_binding\":[{}," +
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