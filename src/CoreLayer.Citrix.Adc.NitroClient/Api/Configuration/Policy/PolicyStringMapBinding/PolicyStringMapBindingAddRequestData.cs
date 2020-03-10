using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Policy.PolicyStringMapBinding
{
    public class PolicyStringMapBindingAddRequestData : INitroRequestData
    {
        private readonly string _stringMapName;
        private readonly string _key;
        private readonly string _value;
        public PolicyStringMapBindingAddRequestData(string stringMapName, string key, string value)
        {
            _stringMapName = stringMapName;
            _key = key;
            _value = value;
        }

        public string Name => _stringMapName;
        public string Key => _key;
        public string Value => _value;

        public override string ToString()
        {
            return "name:" + Name + ", key:" + Key + ", value:" + Value;
        }
    }
}