using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Objects.Configuration.ContentSwitching.Csaction
{
    public class GetCsactionTest
    {
        [Theory]
        [ClassData(typeof(GetCsactionTestData))]
        public void AddLbvserverValidationTest(CsactionConfiguration csa, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(csa, typeof(CsactionConfiguration), NitroServiceSerializerOptions.JsonSerializerOptions));
        }
    }

    public class GetCsactionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsactionConfiguration()
                {

                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"}
                }
            };
            yield return new object[]
            {
                new CsactionConfiguration()
                {
                    Name = "test",
                    Feature = "Feature"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"test\",\"feature\":\"Feature\"}"}
                }
            };
            yield return new object[]
            {
                new CsactionConfiguration()
                {
                    Name = "Test",
                    Comment = "TestComment"
                },
                new Dictionary<string, string>
                {
                    {"ContentString", "{\"name\":\"Test\",\"comment\":\"TestComment\"}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}