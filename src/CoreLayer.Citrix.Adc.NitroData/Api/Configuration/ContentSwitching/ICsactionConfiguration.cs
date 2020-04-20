namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public interface ICsactionConfiguration
    {
        string Name { get; set; }
        string TargetLbvserver { get; set; }
        string TargetVserver { get; set; }
        string TargetvserverExpr { get; set; } 
        string Comment { get; set; }
        string NewName { get; set; }
        string Hits { get; set; }
        string ReferenceCount { get; set; }
        string UndefHits { get; set; } 
        string[] BuiltIn { get; set; }
        string Feature { get; set; }
        double? Count { get; set; } //[JsonPropertyName("__count")]
    }
}