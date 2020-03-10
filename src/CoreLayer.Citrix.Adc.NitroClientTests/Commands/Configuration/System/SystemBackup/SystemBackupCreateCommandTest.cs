using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupCreateCommandTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupCreateCommandTestData))]
        // TODO - Add more meaningful tests?
        public void SystemBackupCreateCommandValidationTest(
            SystemBackupCreateCommand command,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["Options"], command.Data.Options.ToString());
            Assert.Equal(expected["DataRoot"], command.Data.GenerateHttpRequestMessageAsync().Result.Content.ReadAsStringAsync().Result);
        }
    }
}