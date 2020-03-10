namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetLbmonitorRequestOptions : NitroRequestOptions
    {
        public override string ToString()
        {
            return base.ToString() == string.Empty ? "?bulkbindings=yes" : base.ToString();
        }
    }

    public enum ServicegroupBindingGetLbmonitorRequestOptionsProperties
    {
        
    }
}