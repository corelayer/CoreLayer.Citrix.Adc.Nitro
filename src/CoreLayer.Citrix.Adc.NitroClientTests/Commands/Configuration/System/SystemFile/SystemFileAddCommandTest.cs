using System;
using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemFile;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Commands.Configuration.System.SystemFile
{
    public class SystemFileAddCommandTest
    {
        [Theory]
        [ClassData(typeof(SystemFileAddCommandValidationTestData))]
        public void SystemFileAddCommandValidationTest(SystemFileAddCommand command,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["Options"], command.Data.Options.ToString());
            Assert.Equal(expected["DataRoot"], command.Data.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
        }
    }

    public class SystemFileAddCommandValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                NitroCommandFactory.Create<SystemFileAddCommand>(
                    new NitroServiceClient(
                        new NitroLoginRequestData("nsroot", "nsroot"), 
                        new NitroServiceConnectionSettings(
                            new Uri("http://localhost"),
                            360,
                            NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection),
                        NitroHttpClientCertificateValidation.Disabled
                    ),
                    new SystemFileAddRequestData("testfile", "testContent")
                    {
                        FileLocation = "testLocation"
                    }

                ),
                new Dictionary<string, string>()
                {
                    {"Options", string.Empty},
                    {"DataRoot", "{\"systemfile\":[{\"filename\":\"testfile\",\"filecontent\":\"testContent\",\"filelocation\":\"testLocation\"}]}"}
                }
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}