### Ns

#### ns

+ Get
    * Properties  

        The following properties van be found in each NsStats found in the array "NsStatistics" inside of a NsStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        AverageCpuUsagePercent|rescpuusagepcnt|double|Average CPU utilization percentage. Not applicable for a single-CPU system.
        CpuUsagePercent|cpuusagepcnt|double|CPU utilization percentage.
        CacheMaxMemoryKb|cachemaxmemorykb|string|Largest amount of memory the Citrix ADC can dedicate to caching, up to 50% of available memory. A 0 value disables caching, but the caching module continues to run.
        CompressionRatio|delcmpratio|double|Ratio of compressible data received to compressed data transmitted.If this ratio is one (uncmp:1.0) that means compression is disabled or we are not able to compress even a single compressible packet.
        AverageCpuUsage|rescpuusage|string|Shows average CPU utilization percentage if more than 1 CPU is present.
        CpuUsage|cpuusage|string|CPU utilization percentage.
        ResponseMemoryUsagePercent|resmemusage|string|Percentage of memory utilization on Citrix ADC.
        CompressionTotalDataCompressionRatio|comptotaldatacompressionratio|double|Ratio of total HTTP data received to total HTTP data transmitted.
        CompressionRatioServerToClient|compratio|double|Ratio of the compressible data received from the server to the compressed data sent to the client.
        CacheUtilizedMemoryKb|cacheutilizedmemorykb|string|Amount of memory the integrated cache is currently using.
        CacheMaxMemoryActiveKb|cachemaxmemoryactivekb|string|Currently active value of maximum memory
        Cache64MaxMemoryKb|cache64maxmemorykb|string|	Largest amount of memory the Citrix ADC can dedicate to caching, up to 50% of available memory. A 0 value disables caching, but the caching module continues to run.
        CachePercentOriginBandwidthSaved|cachepercentoriginbandwidthsaved|string|Percentage of origin bandwidth saved, expressed as number of bytes served from the integrated cache divided by all bytes served. The assumption is that all compression is done in the Citrix ADC.
        CacheTotalMisses|cachetotmisses|string|Intercepted HTTP requests requiring fetches from origin server.
        CacheMissesRate|cachemissesrate|double|Rate (/s) counter for cachetotmisses
        CacheTotalHits|cachetothits|string|Responses served from the integrated cache. These responses match a policy with a CACHE action.
        CacheHitsRate|cachehitsrate|double|Rate (/s) counter for cachetothits
        SslNumberOfCardsUp|sslnumcardsup|string|Number of SSL cards that are UP. If the number of cards UP is lower than a threshold, a failover is initiated.
        MemoryUsagePercent|memusagepcnt|double|Percentage of memory utilization on Citrix ADC.
        MemoryUseInMb|memuseinmb|string|Main memory currently in use, in megabytes.
        ManagementCpuUsagePercent|mgmtcpuusagepcnt|double|Average Management CPU utilization percentage.
        PacketEngineCpuUsagePercent|pktcpuusagepcnt|double|Average CPU utilization percentage for all packet engines excluding management PE.
        StartTimeLocal|starttimelocal|string|Time (in local timezone format) when the Citrix ADC was last started.
        StartTime|starttime|string|Time when the Citrix ADC was last started.
        TransitionTime|transtime|string|Time when the last master state transition occurred. You can use this statistic for debugging.
        HighAvailabilityCurrentState|hacurstate|string|State of the HA node, based on its health, in a high availability setup. Possible values are: UP - Indicates that the node is accessible and can function as either a primary or secondary node. DISABLED - Indicates that the high availability status of the node has been manually disabled. Synchronization and propagation cannot take place between the peer nodes. INIT - Indicates that the node is in the process of becoming part of the high availability configuration. PARTIALFAIL - Indicates that one of the high availability monitored interfaces has failed because of a card or link failure. This state triggers a failover. COMPLETEFAIL - Indicates that all the interfaces of the node are unusable, because the interfaces on which high availability monitoring is enabled are not connected or are manually disabled. This state triggers a failover. DUMB - Indicates that the node is in listening mode. It does not participate in high availability transitions or transfer configuration from the peer node. This is a configured value, not a statistic. PARTIALFAILSSL - Indicates that the SSL card has failed. This state triggers a failover. ROUTEMONITORFAIL - Indicates that the route monitor has failed. This state triggers a failover.
        HighAvailabilityCurrentMasterState|hacurmasterstate|string|Indicates the high availability state of the node. Possible values are: STAYSECONDARY - Indicates that the selected node remains the secondary node in a high availability setup. In this case a forced failover does not change the state but, instead, returns an appropriate error message. This is a configured value and not a statistic. PRIMARY - Indicates that the selected node is the primary node in a high availability setup. SECONDARY - Indicates that the selected node is the secondary node in a high availability setup. CLAIMING - Indicates that the secondary node is in the process of taking over as the primary node. This is the intermediate state in the transition of the secondary node to primary status. FORCE CHANGE - Indicates that the secondary node is forcibly changing its status to primary due to a forced failover issued on the secondary node.
        SslCards|sslcards|string|Number of SSL crypto cards present on the Citrix ADC.
        DiskFlashPercentUsage|disk0perusage|double|Used space in /flash partition of the disk, as a percentage. This is a critical counter. You can configure /flash Used (%) by using the Set snmp alarm DISK-USAGE-HIGH command.
        DiskVarPercentUsage|disk1perusage|double|Used space in /var partition of the disk, as a percentage. This is a critical counter. You can configure /var Used (%) by using the Set snmp alarm DISK-USAGE-HIGH command.
        DiskFlashAvailable|disk0avail|double|Available space in /flash partition of the hard disk.
        DiskVarAvailable|disk1avail|double|Available space in /var partition of the hard disk.
        TotalReceiveMbits|totrxmbits|string|Number of megabytes received by the Citrix ADC.
        ReceiveMbitsRate|rxmbitsrate|double|Rate (/s) counter for totrxmbits
        TotalTransmitMbits|tottxmbits|string|Number of megabytes transmitted by the Citrix ADC.
        TransmitMbitsRate|txmbitsrate|double|Rate (/s) counter for tottxmbits
        TcpCurrentClientConnections|tcpcurclientconn|string|Client connections, including connections in the Opening, Established, and Closing state.
        TcpCurrentClientConnectionsEstablished|tcpcurclientconnestablished|string|Current client connections in the Established state, which indicates that data transfer can occur between the Citrix ADC and the client.
        TcpCurrentServerConnections|tcpcurserverconn|string|Server connections, including connections in the Opening, Established, and Closing state.
        TcpCurrentServerConnectionsEstablished|tcpcurserverconnestablished|string|Current server connections in the Established state, which indicates that data transfer can occur between the Citrix ADC and the server.
        HttpTotalRequests|httptotrequests|string|Total number of HTTP requests received.
        HttpRequestsRate|httprequestsrate|double|	Rate (/s) counter for httptotrequests
        HttpTotalResponses|httptotresponses|string|Total number of HTTP responses sent.
        HttpResponsesRate|httpresponsesrate|double|Rate (/s) counter for httptotresponses
        HttpTotalReceivedResponseBytes|httptotrxresponsebytes|string|Total number of bytes of HTTP request data received.
        HttpReceivedRequestBytesRate|httprxrequestbytesrate|double|Rate (/s) counter for httptotrxrequestbytes
        HttpTotalReceivedRequestBytes|httptotrxrequestbytes|string|Total number of bytes of HTTP response data received.
        HttpReceivedResponseBytesRate|httprxresponsebytesrate|double|Rate (/s) counter for httptotrxresponsebytes
        SslTotalTransactions|ssltottransactions|string|Number of SSL transactions on the Citrix ADC
        SslTransactionsRate|ssltransactionsrate|double|Rate (/s) counter for ssltottransactions
        SslTotalSessionHits|ssltotsessionhits|string|Number of SSL session reuse hits on the Citrix ADC.
        SslSessionHitsRate|sslsessionhitsrate|double|Rate (/s) counter for ssltotsessionhits
        AppFirewallRequests|appfirewallrequests|string|	HTTP/HTTPS requests sent to your protected web servers via the Application Firewall.
        AppFirewallRequestsRate|appfirewallrequestsrate|double|Rate (/s) counter for appfirewallrequests
        AppFirewallResponses|appfirewallresponses|string|HTTP/HTTPS responses sent by your protected web servers via the Application Firewall.
        AppFirewallResponsesRate|appfirewallresponsesrate|double|Rate (/s) counter for appfirewallresponses
        AppFirewallAborts|appfirewallaborts|string|Incomplete HTTP/HTTPS requests aborted by the client before the Application Firewall could finish processing them.
        AppFirewallAbortsRate|appfirewallabortsrate|double|Rate (/s) counter for appfirewallaborts
        AppFirewallRedirects|appfirewallredirects|string|HTTP/HTTPS requests redirected by the Application Firewall to a different Web page or web server. (HTTP 302)
        AppFirewallRedirectsRate|appfirewallredirectsrate|double|Rate (/s) counter for appfirewallredirects
        MiscellaneousCounter0|misccounter0|double|Miscellaneous Counter 0.
        MiscellaneousCounter1|misccounter1|double|Miscellaneous Counter 1.
        NumberOfCpus|numcpus|string|The number of CPUs on the Citrix ADC.





    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsStatCommand>(INitroServiceClient, New NsStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsStat, that object is <u>NsStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsStats: an array of NsStats-objects returned by the Get-Request, all of which contain the properties mentioned above.

