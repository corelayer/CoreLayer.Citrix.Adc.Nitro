using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public PolicyStringMapBindingAddRequestDataRoot(PolicyStringMapBindingAddRequestData data)
        {
            PolicyStringMap_Pattern_Binding = new PolicyStringMapBindingAddRequestData[]{data};
        }

        public PolicyStringMapBindingAddRequestDataRoot(PolicyStringMapBindingAddRequestData[] data)
        {
            PolicyStringMap_Pattern_Binding = data;
        }
        //Doesn't follow naming convention because the propertyname needs to be passed as data and needs underscores to be read correctly
        public PolicyStringMapBindingAddRequestData[] PolicyStringMap_Pattern_Binding { get; set; }
        
        public override string ToString()
        {
            return PolicyStringMap_Pattern_Binding.ToString();
        }
    }
}