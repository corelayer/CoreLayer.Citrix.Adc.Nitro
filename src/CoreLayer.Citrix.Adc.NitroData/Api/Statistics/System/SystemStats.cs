using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System
{
    public class SystemStats
    {
        [JsonPropertyName("voltagev12n")]public double? VoltageNegative12VOutput { get; set; }
        [JsonPropertyName("voltagev5n")]public double? VoltageNegative5VOutput { get; set; }
        public string CpuUsage { get; set; }
        [JsonPropertyName("rescpuusage")]public string AverageCpuUsage { get; set; }
        [JsonPropertyName("slavecpuusage")]public string SecondaryCpuUsage { get; set; }
        [JsonPropertyName("mastercpuusage")]public string PrimaryCpuUsage { get; set; }
        [JsonPropertyName("auxvolt7")]public double? AuxiliaryVoltagePin7 { get; set; }
        [JsonPropertyName("auxvolt6")]public double? AuxiliaryVoltagePin6 { get; set; }
        [JsonPropertyName("auxvolt5")]public double? AuxiliaryVoltagePin5 { get; set; }
        [JsonPropertyName("auxvolt4")]public double? AuxiliaryVoltagePin4 { get; set; }
        [JsonPropertyName("auxvolt3")]public double? AuxiliaryVoltagePin3 { get; set; }
        [JsonPropertyName("auxvolt2")]public double? AuxiliaryVoltagePin2 { get; set; }
        [JsonPropertyName("auxvolt1")]public double? AuxiliaryVoltagePin1 { get; set; }
        [JsonPropertyName("auxvolt0")]public double? AuxiliaryVoltagePin0 { get; set; }
        [JsonPropertyName("voltagevsen2")]public double? VoltageSensor2Input { get; set; }
        [JsonPropertyName("voltagev5sb")]public double? VoltageV5Standby { get; set; }
        [JsonPropertyName("voltagevtt")]public double? VoltageVtt { get; set; }
        [JsonPropertyName("voltagevbat")]public double? VoltageVBatteryOutput { get; set; }
        [JsonPropertyName("voltagev12p")]public double? VoltagePositive12VOutput { get; set; }
        [JsonPropertyName("voltagev5p")]public double? VoltagePositive5VOutput { get; set; }
        [JsonPropertyName("voltagev33stby")]public double? VoltageV33Standby { get; set; }
        [JsonPropertyName("voltagev33main")]public double? VoltageV33Main { get; set; }
        [JsonPropertyName("voltagevcc1")]public double? VoltageVCpuCore1 { get; set; }
        [JsonPropertyName("voltagevcc0")]public double? VoltageVCpuCore0 { get; set; }
        [JsonPropertyName("numcpus")]public string NumberOfCpus { get; set; }
        [JsonPropertyName("memusagepcnt")]public double? MemoryUsagePercent { get; set; }
        [JsonPropertyName("memuseinmb")]public string MemoryUseInMb { get; set; }
        [JsonPropertyName("addimgmtcpuusagepcnt")]public double? AdditionalManagementCpuUsagePercent { get; set; }
        [JsonPropertyName("mgmtcpu0usagepcnt")]public double? ManagementCpu0UsagePercent { get; set; }
        [JsonPropertyName("mgmtcpuusagepcnt")]public double? ManagementAverageCpuUsagePercent { get; set; }
        [JsonPropertyName("pktcpuusagepcnt")]public double? PacketEngineAverageCpuUsagePercent { get; set; }
        [JsonPropertyName("cpuusagepcnt")]public double? CpuUsagePercent { get; set; }
        [JsonPropertyName("rescpuusagepcnt")]public double? AverageCpuUsagePercent { get; set; }
        public string StartTimeLocal { get; set; }
        public string StartTime { get; set; }
        [JsonPropertyName("disk0perusage")]public double? Disk0PercentUsage { get; set; }
        [JsonPropertyName("disk1perusage")]public double? Disk1PercentUsage { get; set; }
        [JsonPropertyName("cpufan0speed")]public double? CpuFan0Speed { get; set; }
        [JsonPropertyName("cpufan1speed")]public double? CpuFan1Speed { get; set; }
        [JsonPropertyName("systemfanspeed")]public double? SystemFanSpeed { get; set; }
        [JsonPropertyName("fan0speed")]public double? Fan0Speed { get; set; }
        [JsonPropertyName("fanspeed")]public double? FanSpeed { get; set; }
        [JsonPropertyName("cpu0temp")]public double? Cpu0Temperature { get; set; }
        [JsonPropertyName("cpu1temp")]public double? Cpu1Temperature { get; set; }
        [JsonPropertyName("internaltemp")]public double? InternalTemperature { get; set; }
        public string PowerSupply1Status { get; set; }
        public string PowerSupply2Status { get; set; }
        public string PowerSupply3Status { get; set; }
        public string PowerSupply4Status { get; set; }
        public double? Disk0Size { get; set; }
        public double? Disk0Used { get; set; }
        [JsonPropertyName("disk0avail")]public double? Disk0Available { get; set; }
        public double? Disk1Size { get; set; }
        public double? Disk1Used { get; set; }
        [JsonPropertyName("disk1avail")]public double? Disk1Available { get; set; }
        public double? Fan2Speed { get; set; }
        public double? Fan3Speed { get; set; }
        public double? Fan4Speed { get; set; }
        public double? Fan5Speed { get; set; }
        [JsonPropertyName("auxtemp0")]public double? AuxiliaryTemperaturePin0 { get; set; }
        [JsonPropertyName("auxtemp1")]public double? AuxiliaryTemperaturePin1 { get; set; }
        [JsonPropertyName("auxtemp2")]public double? AuxiliaryTemperaturePin2 { get; set; }
        [JsonPropertyName("auxtemp3")]public double? AuxiliaryTemperaturePin3 { get; set; }
        public string TimeSinceStart { get; set; }
        [JsonPropertyName("memsizemb")]public string MemorySizeMb { get; set; }
    }
}