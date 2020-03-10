using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroRequestPropertyNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToLower();
        }
    }
}