using System.Collections.Generic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingGetLbmonitorRequestOptions : NitroRequestOptions
    {
        public override string ToString()
        {
            if (ResourceName == string.Empty)
            {
                List<string> list = new List<string>();
                list.Add("bulkbindings=yes");
                var queryParameters = GenerateQueryParameterList(list);
                return AddQueryParametersToRequestQuery(queryParameters);
            }
            else
            {
                return base.ToString();
            }
            
        }
    }

    public enum ServicegroupBindingGetLbmonitorRequestOptionsProperties
    {
        
    }
}