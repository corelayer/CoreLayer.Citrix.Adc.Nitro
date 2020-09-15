using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Basic.VServer
{
    public class VServerUpdateRequestConfigurationTest
    {
        
    }

    public class VServerUpdateRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new VServerUpdateRequestConfiguration(new VServerUpdateRequestDataRoot(new VServerUpdateRequestData()
                {
                    Name = "5",
                    PushVirtualServer = "1"
                })),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/vserver"},
                    {"RequestUri", "/nitro/v1/config/vserver"},
                    {"RequestContent", "{\"radiusnode\":[{\"name\":\"5\",\"pushvserver\":\"1\"}]}"},
                    {"Options", ""}
                }
            };
            yield return new object[]
            {
                new VServerUpdateRequestConfiguration(
                    new VServerUpdateRequestDataRoot(new dynamic[]
                    {
                        new VServerUpdateRequestData()
                        {
                            
                        }
                    } )
                ),
                new Dictionary<string, string>
                {
                    {"Method", "PUT"},
                    {"ResourcePath", "/nitro/v1/config/vserver"},
                    {"RequestUri", "/nitro/v1/config/vserver"},
                    {"RequestContent", "{\"radiusnode\":[{}]}"},
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