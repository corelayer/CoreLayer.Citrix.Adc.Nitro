namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public interface ICsactionConfiguration
    {
        string Name { get; set; }
        string TargetLbvserver { get; set; }
        string TargetVserver { get; set; }
        string TargetvserverExpression { get; set; } //[JsonPropertyName("targetvserverexpr")]
        string Comment { get; set; }
        string NewName { get; set; }
        string Hits { get; set; }
        string ReferenceCount { get; set; }
        string UndefinedHits { get; set; } //[JsonPropertyName("undefhits")]
        string[] BuiltIn { get; set; }
        string Feature { get; set; }
        double? Count { get; set; } //[JsonPropertyName("__count")]
    }
}