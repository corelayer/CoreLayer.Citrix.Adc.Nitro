namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingGetRequestOptions : NitroRequestOptions
    {
        public override string ToString()
        {
            return base.ToString() == string.Empty ? "?bulkbindings=yes" : base.ToString();
        }
    }

    public enum LbvserverBindingGetRequestOptionsProperties
    {
        
    }
}