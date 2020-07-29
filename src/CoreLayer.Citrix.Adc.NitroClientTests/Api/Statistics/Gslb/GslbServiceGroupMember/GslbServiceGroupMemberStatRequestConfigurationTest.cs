using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroupMember;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Gslb.GslbServiceGroupMember
{
    public class GslbServiceGroupMemberStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(GslbServiceGroupMemberStatRequestConfigurationValidationTestData))]
        public void GslbServiceGroupMemberStatRequestConfigurationValidationTest(
            GslbServiceGroupMemberStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }
    public class GslbServiceGroupMemberStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GslbServiceGroupMemberStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/gslbservicegroupmember"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/gslbservicegroupmember"}
                } 
            };
            yield return new object[]
            {
                new GslbServiceGroupMemberStatRequestConfiguration
                {
                    Options = new GslbServiceGroupMemberStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/gslbservicegroupmember"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/gslbservicegroupmember/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new GslbServiceGroupMemberStatRequestConfiguration
                {
                    Options = new GslbServiceGroupMemberStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/gslbservicegroupmember"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/gslbservicegroupmember/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}