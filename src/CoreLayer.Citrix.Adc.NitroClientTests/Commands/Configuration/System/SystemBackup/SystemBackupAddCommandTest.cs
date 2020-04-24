using System;
using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupAddCommandTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupAddCommandTestData))]
        public void SystemBackupAddCommandValidationTest(
            SystemBackupAddCommand command,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["Options"], command.Data.Options.ToString());
            Assert.Equal(expected["DataRoot"], command.Data.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
        }
    }

    public class SystemBackupAddCommandTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                NitroCommandFactory.Create<SystemBackupAddCommand>(
                    new NitroServiceClient(
                        new NitroLoginRequestData("nsroot", "nsroot"), 
                        new NitroServiceConnectionSettings(
                            new Uri("http://localhost"),
                            360,
                            NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection),
                        NitroHttpClientCertificateValidation.Disabled
                    ),
                    new SystemBackupAddRequestData("testfile")
                    {
                        
                    }

                    ),
                new Dictionary<string, string>()
                {
                    {"Options", string.Empty},
                    {"DataRoot", "{\"systembackup\":[{\"filename\":\"testfile\"}]}"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}