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
    public class SystemFileGetCommandTest
    {
        [Theory]
        [ClassData(typeof(SystemFileGetCommandValidationTestData))]
        public void SystemFileGetCommandValidationTest(SystemFileGetCommand command,
            Dictionary<string, string> expected)
        {
            Assert.Equal(expected["Options"], command.Data.Options.ToString()); 
        }
    }

    public class SystemFileGetCommandValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                NitroCommandFactory.Create<SystemFileGetCommand>(
                    new NitroHttpClient(
                        new NitroLoginRequestData("nsroot", "nsroot"), 
                        new NitroServiceConnectionSettings(new Uri("http://localhost"),
                            false,
                            360,
                            NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection)
                    ),
                    new SystemFileGetRequestOptions()
                    {
                        
                    }
                ),
                new Dictionary<string, string>
                {
                    {"Options", ""},
                    {"DataRoot", ""}
                }
            };

            yield return new object[]
            {
                NitroCommandFactory.Create<SystemFileGetCommand>(
                    new NitroHttpClient(
                        new NitroLoginRequestData("nsroot", "nsroot"), 
                        new NitroServiceConnectionSettings(new Uri("http://localhost"),
                            false,
                            360,
                            NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection)
                        ),
                    new SystemFileGetRequestOptions()
                    {
                        PropertyFilter = {"filter"},
                        Count = true
                    }
                ),
                new Dictionary<string, string>
                {
                    {"Options", "?count=yes&attrs=filter"},
                    {"DataRoot", ""}
                }
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}