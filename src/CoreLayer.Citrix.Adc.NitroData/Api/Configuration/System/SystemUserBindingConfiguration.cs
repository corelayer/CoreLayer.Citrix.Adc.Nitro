using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemUserBindingConfiguration
    {
        public string UserName { get; set; }
        [JsonPropertyName("systemuser_systemgroup_binding")]
        public SystemUserSystemGroupBindingConfiguration[] SystemUserSystemGroupBinding { get; set; }
        
        [JsonPropertyName("systemuser_nspartition_binding")]
        public SystemUserNsPartitionBindingConfigurationConfiguration[] SystemUserNsPartition { get; set; }
        
        [JsonPropertyName("systemuser_systemcmdpolicy_binding")]
        public SystemUserSystemCmdPolicyBindingConfiguration[] SystemUserSystemCmdPolicy { get; set; }
    }
}