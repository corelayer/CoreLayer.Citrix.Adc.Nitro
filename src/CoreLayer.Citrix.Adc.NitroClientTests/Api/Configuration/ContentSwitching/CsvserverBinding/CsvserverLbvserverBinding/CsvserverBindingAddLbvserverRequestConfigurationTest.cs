using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverLbvserverBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverLbvserverBinding
{
    public class CsvserverBindingAddLbvserverRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverBindingAddLbvserverRequestConfigurationValidationTestData))]
        public void CsvserverBindingAddLbvserverRequestConfigurationValidationTest(
            CsvserverBindingAddLbvserverRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class CsvserverBindingAddLbvserverRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverBindingAddLbvserverRequestConfiguration(new CsvserverBindingAddLbvserverRequestDataRoot(
                    new dynamic[]
                    {
                        new CsvserverBindingAddLbvserverRequestData("testName"),
                        new CsvserverBindingAddLbvserverRequestData("testName2")
                        {
                            LoadBalancingVirtualServer= "testLbvserverName"
                        }, 
                    })),
                new Dictionary<string, string>()
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver_lbvserver_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_lbvserver_binding"},
                    {"Options", ""},
                    {"RequestContent", "{\"csvserver_lbvserver_binding\":[{\"name\":\"testName\"}," +
                                       "{\"name\":\"testName2\",\"lbvserver\":\"testLbvserverName\"}]}"}   
                } 
            };        
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}