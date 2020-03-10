using System.Text.Json;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public static class NitroRequestResponseDeserializer
    {
        public static T GenerateObject<T>(string jsonResponse)
        {
             
            return  DeserializeIntoObject<T>(jsonResponse);
        }

        private static T DeserializeIntoObject<T>(string jsonText)
        {
            T result = (T)JsonSerializer.Deserialize(jsonText,
              typeof(T), NitroServiceDeserializerOptions.DeserializerOptions);
          
            return result;
        }
    }
}