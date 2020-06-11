using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLayer.Citrix.Adc.NitroClient;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup;
using CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemFile;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroOperations
{
    public static class NitroBackup
    {
        public static async Task<SystemBackupGetResponse> GetAsync(INitroServiceClient client,
            string fileName)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(client,
                new SystemBackupGetRequestOptions
                {
                    ResourceName = fileName
                });

            return await systemBackupGetCommand.GetResponse();
        }
        
        public static async Task<SystemBackupGetResponse> GetAllAsync(INitroServiceClient client)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(
                client);

            return await systemBackupGetCommand.GetResponse();
        }
        
        public static async Task<SystemBackupCreateResponse> CreateAsync(INitroServiceClient client, string fileName,
            string level = "full")
        {
            var systemBackupCreateCommand = NitroCommandFactory.Create<SystemBackupCreateCommand>(
                client,
                new SystemBackupCreateRequestData(level)
                {
                    Filename = fileName.Replace(".tgz", "")
                });
            
            return await systemBackupCreateCommand.GetResponse();
        }
        
        public static async Task<SystemBackupDeleteResponse> DeleteAsync(INitroServiceClient client, string fileName)
        {
            var systemBackupDeleteCommand = NitroCommandFactory.Create<SystemBackupDeleteCommand>(
                client,
                new SystemBackupDeleteRequestOptions(fileName)
            );

            return await systemBackupDeleteCommand.GetResponse();
        }

        public static async Task<SystemFileConfiguration> DownloadAsBase64Async(INitroServiceClient client, string fileName)
        {
            var systemFileGetCommand = NitroCommandFactory.Create<SystemFileGetCommand>(
                client,
                new SystemFileGetRequestOptions
                {
                    Arguments = new Dictionary<string, string>
                    {
                        {"FileLocation", "/var/ns_sys_backup"},
                        {"FileName", fileName}
                    }
                });

            var response = await systemFileGetCommand.GetResponse();
            
            return response.SystemFiles.Single(file => file.FileName.Equals(fileName));
        }
        
        
    }
}