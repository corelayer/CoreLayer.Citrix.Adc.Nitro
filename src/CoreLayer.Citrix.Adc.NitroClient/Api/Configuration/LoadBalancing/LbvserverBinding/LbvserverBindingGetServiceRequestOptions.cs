namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetServiceRequestOptions : NitroRequestOptions
    {
        public override string ToString()
        {
            return base.ToString() == string.Empty ? "?bulkbindings=yes" : base.ToString();
        }
    }

    public enum LbvserverBindingGetServiceRequestOptionsProperties
    {
        
    }
}