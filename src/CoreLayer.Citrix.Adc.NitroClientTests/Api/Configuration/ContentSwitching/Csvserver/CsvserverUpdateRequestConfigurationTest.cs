using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverUpdateRequestDatas;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverUpdateRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverUpdateRequestConfigurationValidationTestData))]
        public void CsvserverUpdateRequestConfigurationValidationTest(CsvserverUpdateRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["RequestContent"], configuration.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverUpdateRequestConfiguration(new CsvserverUpdateRequestDataRoot(new CsvserverUpdateHttpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"RequestContent", "{\"csvserver\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new CsvserverUpdateRequestConfiguration(
                    new CsvserverUpdateRequestDataRoot(new dynamic[]
                    {
                        new CsvserverUpdateTcpRequestData("test")
                        {
                            TcpProfileName = "testProf"
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"RequestContent", "{\"csvserver\":[{\"tcpprofilename\":\"testProf\",\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new CsvserverUpdateRequestConfiguration(new CsvserverUpdateRequestDataRoot(new CsvserverUpdateSslRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"RequestContent", "{\"csvserver\":[{\"name\":\"test\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new CsvserverUpdateRequestConfiguration(new CsvserverUpdateRequestDataRoot(new CsvserverUpdateUdpRequestData("test"))),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/csvserver"},
                    {"RequestUri", "/nitro/v1/config/csvserver"},
                    {"RequestContent", "{\"csvserver\":[{\"name\":\"test\"}]}"},
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