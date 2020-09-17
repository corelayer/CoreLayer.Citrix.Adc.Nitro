﻿using System.Collections.Generic;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroRequestBulkBindingsOptions : NitroRequestOptions
    {
         protected override List<string> GenerateQueryParameterList()
        {
            List<string> queryParameters = new List<string>();

            if (ResourceName == string.Empty)
            {
                queryParameters.Add("bulkbindings=yes");
            }
            if (!Action.Equals(string.Empty))
                queryParameters.Add("action=" + Action);
            else
            {
                if(Count)
                    queryParameters.Add("count=yes");
                
                if (ResourceFilter.Count > 0)
                    queryParameters.Add(ResourceFilterToString());

                if (PropertyFilter.Count > 0)
                    queryParameters.Add(PropertyFilterToString());
            }

            return queryParameters;
        }
    }
}