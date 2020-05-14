using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemCmdPolicyAddRequestDataRoot(dynamic data)
        {
            SystemCmdPolicy = new dynamic[] {data};
        }
        public SystemCmdPolicyAddRequestDataRoot(dynamic[] data)
        {
            SystemCmdPolicy = data;
        }
        public dynamic[] SystemCmdPolicy { get; set; }

        public override string ToString()
        {
            string result= "";
            foreach (var dataItem in SystemCmdPolicy)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}