using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverBotPolicyBinding
{
    public class CsvserverBotPolicyBindingAddRequestDataRoot : INitroRequestDataRoot
    {
        public CsvserverBotPolicyBindingAddRequestDataRoot(dynamic data)
        {
            Csvserver_BotPolicy_Binding = new dynamic[]{data};
        }

        public CsvserverBotPolicyBindingAddRequestDataRoot(dynamic[] data)
        {
            Csvserver_BotPolicy_Binding = data;
        }
        
        // name doesnt follow convention because it gets serialized
        public dynamic[] Csvserver_BotPolicy_Binding { get; set; }
    }
}