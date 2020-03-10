namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetRequestOptions : NitroRequestOptions
    {
        public override string ToString()
        {
            if (base.ToString() == string.Empty)
            {
                return "?bulkbindings=yes";
            }
            else
            {
                return base.ToString();
            }
            
        }
    }

    public enum ServicegroupBindingGetRequestOptionsProperties
    {
        
    }
}