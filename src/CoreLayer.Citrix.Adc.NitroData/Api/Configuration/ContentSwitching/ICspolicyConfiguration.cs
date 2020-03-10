namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public interface ICspolicyConfiguration
    {
        string PolicyName { get; set; }
        string Url { get; set; }
        string Rule { get; set; }
        string Domain { get; set; }
        string Action { get; set; }
        string LogAction { get; set; }
        string NewName { get; set; }
        string VsType { get; set; }
        string Hits { get; set; }
        string BindHits { get; set; }
        string PiHits { get; set; }
        string PiPolicyHits { get; set; }
        string LabelName { get; set; }
        string LabelType { get; set; }
        string Priority { get; set; }
        bool? ActivePolicy { get; set; }
        string CspolicyType { get; set; }
        double? Count { get; set; }//[JsonPropertyName("__count")]
    }
}