﻿using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverGetCommand : NitroCommand
    {
        public CsvserverGetCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
            :base(httpClient, requestConfiguration){}
    }
}