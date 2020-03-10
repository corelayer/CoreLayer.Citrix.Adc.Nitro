using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;

namespace CoreLayer.Citrix.Adc.NitroClientTests.NitroService
{
    public class NitroSerializerOptionsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLoginRequestData("nsroot", "nsroot", 3600),
                "{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":3600}"
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}