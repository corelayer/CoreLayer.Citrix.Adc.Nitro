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
    public class SystemFileRemoveCommandTest
    {
        [Theory]
        [ClassData(typeof(SystemFileRemoveCommandTestData))]
        public void SystemFileRemoveCommandValidationTest(SystemFileRemoveCommand command,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["Options"], command.Data.Options.ToString()); 
        }
    }

    public class SystemFileRemoveCommandTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                NitroCommandFactory.Create<SystemFileRemoveCommand>(
                    new NitroServiceClient(
                        new NitroLoginRequestData("nsroot", "nsroot"), 
                        new NitroServiceConnectionSettings(
                            new Uri("http://localhost"),
                            360,
                            NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection),
                        NitroHttpClientCertificateValidation.Disabled
                    ),
                    new SystemFileRemoveRequestOptions("test.tgz")
                    {
                    }
                ),
                new Dictionary<string, string>
                {
                    {"Options", "/test.tgz"},
                    {"DataRoot", string.Empty}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}