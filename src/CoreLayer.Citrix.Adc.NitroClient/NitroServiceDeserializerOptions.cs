using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroServiceDeserializerOptions
    {
        public static JsonSerializerOptions DeserializerOptions => new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
    }
}