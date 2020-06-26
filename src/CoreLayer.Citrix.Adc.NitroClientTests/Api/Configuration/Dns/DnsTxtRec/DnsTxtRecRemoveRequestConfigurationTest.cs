using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecRemoveRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(DnsTxtRecRemoveRequestConfigurationValidationTestData))]
        public void DnsTxtRecRemoveRequestConfigurationValidationTest(DnsTxtRecRemoveRequestConfiguration configuration,
            Dictionary<string, string> expected)
        {
             Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
             Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
             Assert.Equal(expected["Method"], configuration.Method.ToString());
             Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
             Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class DnsTxtRecRemoveRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new DnsTxtRecRemoveRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnstxtrec"},
                    {"RequestUri", "/nitro/v1/config/dnstxtrec"},
                    {"Options", ""},
                }, 
            };
            yield return new object[]
            {
                new DnsTxtRecRemoveRequestConfiguration()
                {
                    Options = new DnsTxtRecRemoveRequestOptions()
                    {
                        Arguments = new Dictionary<string, string>(){{"name","testName"}}
                    }
                },
                new Dictionary<string, string>
                {
                    {"Method", "DELETE"},
                    {"ResourcePath", "/nitro/v1/config/dnstxtrec"},
                    {"RequestUri", "/nitro/v1/config/dnstxtrec?args=name:testName"},
                    {"Options", "?args=name:testName"},
                }, 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}