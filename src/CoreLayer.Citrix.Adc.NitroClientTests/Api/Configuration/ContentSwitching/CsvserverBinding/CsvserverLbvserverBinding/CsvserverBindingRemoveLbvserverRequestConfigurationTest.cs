using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverLbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverLbvserverBinding
{
    public class CsvserverBindingRemoveLbvserverRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBindingRemoveLbvserverRequestConfigurationValidationTestData))]
        public void CsvserverBindingRemoveLbvserverRequestConfigurationValidationTest(
            CsvserverBindingRemoveLbvserverRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CsvserverBindingRemoveLbvserverRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBindingRemoveLbvserverRequestConfiguration()
                {
                    Options = new CsvserverBindingRemoveLbvserverRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name", "testCsv"},{"lbvserver", "testLB"}}
                    }
                },
                new Dictionary<string, string>()
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_lbvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_lbvserver_binding?args=name:testCsv,lbvserver:testLB"},
                    {"Options", "?args=name:testCsv,lbvserver:testLB"},
                } 
            };        
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}