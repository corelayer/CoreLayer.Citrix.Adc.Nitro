namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestOptions : NitroRequestOptions
    {
    }
    public enum SystemBackupCreateRequestOptionsProperties
    {
        Filename,
        Level,
        IncludeKernel,
        Comment,
        Size,
        UseLocalTimezone,
        CreationTime,
        Version,
        CreatedBy,
        IpAddress
    }
}