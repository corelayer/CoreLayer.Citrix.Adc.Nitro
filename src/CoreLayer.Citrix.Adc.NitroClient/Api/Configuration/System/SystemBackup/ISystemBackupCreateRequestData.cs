using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemBackup
{
    public interface ISystemBackupCreateRequestData : INitroRequestData
    {
        string Filename { get; }
//        bool UseLocalTimezone { get; }
        string Level { get; }
//        string IncludeKernel { get; }
        string Comment { get; }
    }
}