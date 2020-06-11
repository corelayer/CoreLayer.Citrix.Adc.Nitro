namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Responder
{
    public class ResponderPolicyStats
    {
        public string Name { get; set; }
        public string PiPolicyUndefHits { get; set; }
        public double? PiPolicyUndefHitsRate { get; set; }
        public string PiPolicyHits { get; set; }
        public double? PiPolicyHitsRate { get; set; }
    }
}