using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.Login
{
    public class NitroLoginRequestDataRootInitializationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLoginRequestDataRoot(), 
                "{\"username\":\"nsroot\",\"password\":\"nsroot\",\"timeout\":\"600\"}" 
            };
            yield return new object[]
            {
                new NitroLoginRequestDataRoot
                {
                    Login = new NitroLoginRequestData("testuser", "testpassword", 8000)
                }, 
                "{\"username\":\"testuser\",\"password\":\"testpassword\",\"timeout\":\"8000\"}" 
            };
            yield return new object[]
            {
                new NitroLoginRequestDataRoot(new NitroLoginRequestData("testuser", "testpassword", 8000)), 
                "{\"username\":\"testuser\",\"password\":\"testpassword\",\"timeout\":\"8000\"}" 
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}