using System.Collections.Generic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerRemoveRequestOptions : NitroRequestOptions
    {
        public new Dictionary<string, string> ResourceFilter { get; }
        public new List<string> PropertyFilter { get; }
        public new string Action { get; }
        public new bool Count { get; }
    }
    public enum ServerRemoveRequestOptionsProperties
    {
        
    }
}