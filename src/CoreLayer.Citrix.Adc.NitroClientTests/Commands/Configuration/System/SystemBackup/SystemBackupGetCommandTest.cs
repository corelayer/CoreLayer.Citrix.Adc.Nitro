using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupGetCommandTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupGetCommandTestData))]
        // TODO - Add more meaningful tests?
        public void SystemBackupDeleteCommandValidationTest(
            SystemBackupGetCommand command,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["Options"], command.Data.Options.ToString()); 
        }
    }
}