using System;
using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupGetCommandTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                NitroCommand.Create<SystemBackupGetCommand>(
                    new NitroHttpClient(
                        new NitroLoginRequestData("nsroot", "nsroot"), 
                        new NitroServiceConnectionSettings(new Uri("http://localhost"),
                            false,
                            360,
                            NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection)
                    ),
                    new SystemBackupGetRequestOptions()
                ),
                new Dictionary<string, string>
                {
                    {"Options", ""},
                    {"DataRoot", ""}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}