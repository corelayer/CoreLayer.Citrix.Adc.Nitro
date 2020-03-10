using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public static class NitroServiceSerializerOptions
    {
        public static JsonSerializerOptions JsonSerializerOptions =>
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = new NitroRequestPropertyNamingPolicy(),
                IgnoreNullValues = true,
            };
    }
}