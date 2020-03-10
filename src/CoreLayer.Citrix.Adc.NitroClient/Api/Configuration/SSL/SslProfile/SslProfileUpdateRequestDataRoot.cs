using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileUpdateRequestDataRoot : INitroRequestDataRoot

    {
    public SslProfileUpdateRequestDataRoot(dynamic data)
    {
        SslProfile = new dynamic[] {data};
    }

    public SslProfileUpdateRequestDataRoot(dynamic[] data)
    {
        SslProfile = data;
    }

    public dynamic[] SslProfile { get; set; }

    public override string ToString()
    {
        string result = "";
        foreach (var dataItem in SslProfile)
        {
            result += dataItem.ToString();
        }

        return result.ToString();
    }
    }
}