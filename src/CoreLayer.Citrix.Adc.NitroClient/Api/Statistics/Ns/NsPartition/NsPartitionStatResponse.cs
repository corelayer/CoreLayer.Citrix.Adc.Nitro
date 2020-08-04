using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPartition
{
    public class NsPartitionStatResponse : NitroResponse
    {
        [JsonPropertyName("nspartition")]public NsPartitionStats[] NsPartitionStatistics { get; set; }
    }
}