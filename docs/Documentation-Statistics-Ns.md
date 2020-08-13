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



#### NsAcl

+ Get
    * Properties  

        The following properties can be found in the NsAclStats-objects-array inside of a NsAclStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        AclName|aclname|string|Name of the extended ACL rule whose statistics you want the Citrix ADC to display.
        AclTotalPacketsBridged|acltotpktsbridged|string|Packets matching a bridge ACL, which is in transparent mode and bypasses service processing.
        AclPacketsBridgedRate|aclpktsbridgedrate|double|Rate (/s) counter for acltotpktsbridged
        AclTotalPacketsDenied|acltotpktsdenied|string|Packets dropped because they match ACLs with processing mode set to DENY.
        AclPacketsDeniedRate|aclpktsdeniedrate|double|Rate (/s) counter for acltotpktsdenied
        AclTotalPacketsAllowed|acltotpktsallowed|string|Packets matching ACLs with processing mode set to ALLOW. Citrix ADC processes these packets.
        AclPacketsAllowedRate|aclpktsallowedrate|double|Rate (/s) counter for acltotpktsallowed
        AclTotalPacketsNat|acltotpktsnat|string|Packets matching a NAT ACL, resulting in a NAT session.
        AclPacketsNatRate|aclpktsnatrate|double|Rate (/s) counter for acltotpktsnat
        AclTotalHits|acltothits|string|Packets matching an ACL.
        AclHitsRate|aclhitsrate|double|Rate (/s) counter for acltothits
        AclTotalMisses|acltotmisses|string|Packets not matching any ACL.
        AclMissesRate|aclmissesrate|double|Rate (/s) counter for acltotmisses
        AclTotalCount|acltotcount|string|Total number of ACL rules configured.
        DfAclTotalHits|dfdacltothits|string|Packets matching an dfd ACL.
        DfAclHitsRate|dfdaclhitsrate|double|Rate (/s) counter for dfdacltothits
        DfAclTotalMisses|dfdacltotmisses|string|Packets not matching any DFD ACL.
        DfAclMissesRate|dfdaclmissesrate|double|Rate (/s) counter for dfdacltotmisses
        DfAclTotalCount|dfdacltotcount|string|Total number of DFD ACL rules configured.
        AclPerHits|aclperhits|string|Number of times the acl was hit
        AclPerHitsRate|aclperhitsrate|double|Rate (/s) counter for aclperhits
        



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsAclStatCommand>(INitroServiceClient, New NsAclStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsAclStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:aclname, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsAclStat, that object is <u>NsAclStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsAclStatistics: a NsAclStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### NsAcl6

+ Get
    * Properties  

        The following properties can be found in the NsAcl6Stats-objects-array inside of a NsAcl6StatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Acl6Name|acl6name|string|Name of the extended ACL6 rule whose statistics you want the Citrix ADC to display.
        Acl6TotalPacketsBridged|acl6totpktsbridged|string|Packets matching a bridge ACL6, which is in transparent mode and bypasses service processing.
        Acl6PacketsBridgedRate|acl6pktsbridgedrate|double|Rate (/s) counter for acl6totpktsbridged
        Acl6TotalPacketsDenied|acl6totpktsdenied|string|Packets dropped because they match ACL6s with processing mode set to DENY.
        Acl6PacketsDeniedRate|acl6pktsdeniedrate|double|Rate (/s) counter for acl6totpktsdenied
        Acl6TotalPacketsAllowed|acl6totpktsallowed|string|Packets matching ACL6s with processing mode set to ALLOW. Citrix ADC processes these packets.
        Acl6PacketsAllowedRate|acl6pktsallowedrate|double|Rate (/s) counter for acl6totpktsallowed
        Acl6TotalPacketsNat|acl6totpktsnat|string|Packets matching a NAT ACL6, resulting in a NAT session.
        Acl6PacketsNatRate|acl6pktsnatrate|double|Rate (/s) counter for acl6totpktsnat
        Acl6TotalHits|acl6tothits|string|Packets matching an ACL6.
        Acl6HitsRate|acl6hitsrate|double|Rate (/s) counter for acl6tothits
        Acl6TotalMisses|acl6totmisses|string|Packets not matching any ACL6.
        Acl6MissesRate|acl6missesrate|double|Rate (/s) counter for acl6totmisses
        Acl6TotalCount|acl6totcount|string|Total number of ACL6 rules configured.
        DfAcl6TotalHits|dfdacl6tothits|string|Packets matching an dfd ACL6.
        DfAcl6HitsRate|dfdacl6hitsrate|double|Rate (/s) counter for dfdacl6tothits
        DfAcl6TotalMisses|dfdacl6totmisses|string|Packets not matching any DFD ACL6.
        DfAcl6MissesRate|dfdacl6missesrate|double|Rate (/s) counter for dfdacl6totmisses
        DfAcl6TotalCount|dfdacl6totcount|string|Total number of DFD ACL6 rules configured.
        Acl6PerHits|acl6perhits|string|Number of times the acl6 was hit
        Acl6PerHitsRate|acl6perhitsrate|double|Rate (/s) counter for acl6perhits
        



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsAcl6StatCommand>(INitroServiceClient, New NsAcl6StatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsAcl6StatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:acl6name, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsAcl6Stat, that object is <u>NsAcl6StatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsAcl6Statistics: a NsAcl6Stats-object-array returned by the Get-Request, containing the properties mentioned above.



#### NsLimitIdentifier

+ Get
    * Properties  

        The following properties can be found in the NsLimitIdentifierStats-objects-array inside of a NsLimitIdentifierStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|The name of the identifier.
        RateLimitObjectHits|ratelmtobjhits|string|Total hits.
        RateLimitObjectDrops|ratelmtobjdrops|string|Total drops
        RateLimitSessionObjectHits|ratelmtsessionobjhits|string|Total hits.




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsLimitIdentifierStatCommand>(INitroServiceClient, New NsLimitIdentifierStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsLimitIdentiefierStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:name, value: string
            - key:pattern, value: string[]

            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsLimitIdentifierStat, that object is <u>NsLimitIdentifierStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsLimitIdentifierStatistics: a NsLimitIdentifierStats-object-array returned by the Get-Request, containing the properties mentioned above.




#### NsMemory

+ Get
    * Properties  

        The following properties can be found in the NsMemoryStats-objects-array inside of a NsMemoryStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Pool|pool|string|Feature name for which to display memory statistics.
        MemoryCurrentAvailableInKb|memcurinkb|string|Total current Citrix ADC memory available for use by the feature, in kilobytes.
        AllocationFailure|allocf|double|Memory allocation failure for particular feature.
        MemoryCurrentFeatureAllocatedPercent|memcurallocper|double|Percentage of Citrix ADC memory used by the feature.




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsMemoryStatCommand>(INitroServiceClient, New NsMemoryStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsMemoryStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:pool, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsMemoryStat, that object is <u>NsMemoryStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsMemoryStatistics: a NsMemoryStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### NsPartition

+ Get
    * Properties  

        The following properties can be found in the NsPartitionStats-objects-array inside of a NsPartitionStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        PartitionName|partitionname|string|Name of the partition.
        TotalTokenDrops|totaltokendrops|string|Total drops(KB) for the partition.
        TokenDropsRate|tokendropsrate|double|Rate (/s) counter for totaltokendrops
        TotalDrops|totaldrops|string|Total packet drops for the partition.
        DropsRate|dropsrate|double|Rate (/s) counter for totaldrops
        TotalConnectionDrops|totalconnectiondrops|string|Total connection drops for the partition.
        ConnectionDropsRate|connectiondropsrate|double|Rate (/s) counter for totalconnectiondrops
        CurrentConnections|currentconnections|string|Current Connections on this partition.
        CurrentBandwidth|currentbandwidth|string|Current Bandwidth usage for the partition.
        MaxConnection|maxconnection|string|Maximum Connection allowed for the partition.
        MaxBandwidth|maxbandwidth|string|Maximum Banwidth allowed for the partition.
        MaxMemory|maxmemory|string|Maximum memory limit for the partition.
        MemoryUsagePercent|memoryusagepcnt|double|Memory usage(%) on this partition.





    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsPartitionStatCommand>(INitroServiceClient, New NsPartitionStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsPartitionStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:partitionname, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsPartitionStat, that object is <u>NsPartitionStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsPartitionStatistics: a NsPartitionStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### NsPbr

+ Get
    * Properties  

        The following properties can be found in the NsPbrStats-objects-array inside of a NsPbrStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the PBR whose statistics you want the Citrix ADC to display.
        PbrTotalPacketsAllowed|pbrtotpktsallowed|string|Total packets that matched the PBR (Policy-Based Routes) with action ALLOW
        PbrPacketsAllowedRate|pbrpktsallowedrate|double|Rate (/s) counter for pbrtotpktsallowed
        PbrTotalPacketsDenied|pbrtotpktsdenied|string|Total packets that matched the PBR with action DENY
        PbrPacketsDeniedRate|pbrpktsdeniedrate|double|Rate (/s) counter for pbrtotpktsdenied
        PbrTotalHits|pbrtothits|string|Total packets that matched one of the configured PBR
        PbrTotalHitsRate|pbrhitsrate|double|Rate (/s) counter for pbrtothits
        PbrTotalMisses|pbrtotmisses|string|Total packets that did not match any PBR
        PbrMissesRate|pbrmissesrate|double|Rate (/s) counter for pbrtotmisses
        PbrTotalNullDrop|pbrtotnulldrop|string|Total packets that are dropped due to null nexthop
        PbrNullDropRate|pbrnulldroprate|double|Rate (/s) counter for pbrtotnulldrop
        PbrHits|pbrperhits|string|Number of times the pbr was hit
        PbrHitsRate|pbrperhitsrate|double|Rate (/s) counter for pbrperhits





    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsPbrStatCommand>(INitroServiceClient, New NsPbrStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsPbrStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:name, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsPbrStat, that object is <u>NsPbrStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsPbrStatistics: a NsPbrStats-object-array returned by the Get-Request, containing the properties mentioned above.




#### NsPbr6

+ Get
    * Properties  

        The following properties can be found in the NsPbr6Stats-objects-array inside of a NsPbr6StatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the PBR6 whose statistics you want the Citrix ADC to display.
        Pbr6TotalPacketsAllowed|pbr6totpktsallowed|string|Total packets that matched the PBR6 (Policy-Based Routes) with action ALLOW
        Pbr6PacketsAllowedRate|pbr6pktsallowedrate|double|Rate (/s) counter for pbr6totpktsallowed
        Pbr6TotalPacketsDenied|pbr6totpktsdenied|string|Total packets that matched the PBR6 with action DENY
        Pbr6PacketsDeniedRate|pbr6pktsdeniedrate|double|Rate (/s) counter for pbr6totpktsdenied
        Pbr6TotalHits|pbr6tothits|string|Total packets that matched one of the configured PBR6
        Pbr6TotalHitsRate|pbr6hitsrate|double|Rate (/s) counter for pbr6tothits
        Pbr6TotalMisses|pbr6totmisses|string|Total packets that did not match any PBR6
        Pbr6MissesRate|pbr6missesrate|double|Rate (/s) counter for pbr6totmisses
        Pbr6TotalNullDrop|pbr6totnulldrop|string|Total packets that are dropped due to null nexthop
        Pbr6NullDropRate|pbr6nulldroprate|double|Rate (/s) counter for pbr6totnulldrop
        Pbr6Hits|pbr6perhits|string|Number of times the pbr6 was hit
        Pbr6HitsRate|pbr6perhitsrate|double|Rate (/s) counter for pbr6perhits





    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsPbr6StatCommand>(INitroServiceClient, New NsPbr6StatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsPbr6StatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:name, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsPbr6Stat, that object is <u>NsPbr6StatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsPbr6Statistics: a NsPbr6Stats-object-array returned by the Get-Request, containing the properties mentioned above.




#### NsSimpleAcl

+ Get
    * Properties  

        The following properties can be found in the NsSimpleAclStats-objects inside of a NsSimpleAclStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        SimpleAclTotalHits|sacltothits|string|Packets matching a SimpleACL.
        SimpleAclHitsRate|saclhitsrate|double|Rate (/s) counter for sacltothits
        SimpleAclTotalMisses|sacltotmisses|string|Packets not matching any SimpleACL.
        SimpleAclMissesRate|saclmissesrate|double|Rate (/s) counter for sacltotmisses
        SimpleAclsCount|saclscount|string|Number of SimpleACLs configured.
        SimpleAclTotalPacketsAllowed|sacltotpktsallowed|string|Total packets that matched a SimpleACL with action ALLOW and got consumed by Citrix ADC.
        SimpleAclPacketsAllowedRate|saclpktsallowedrate|double|Rate (/s) counter for sacltotpktsallowed
        SimpleAclTotalPacketsBridged|sacltotpktsbridged|string|Total packets that matched a SimpleACL with action BRIDGE and got bridged by Citrix ADC.
        SimpleAclPacketsBridgedRate|saclpktsbridgedrate|double|	Rate (/s) counter for sacltotpktsbridged
        SimpleAclTotalPacketsDenied|sacltotpktsdenied|string|Packets dropped because they match SimpleACL (Access Control List) with processing mode set to DENY.
        SimpleAclPacketsDeniedRate|saclpktsdeniedrate|double|Rate (/s) counter for sacltotpktsdenied



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsSimpleAclStatCommand>(INitroServiceClient, New NsSimpleAclStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsSimpleAclStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsSimpleAclStat, that object is <u>NsSimpleAclStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsSimpleAclStatistics: a NsSimpleAclStats-object returned by the Get-Request, containing the properties mentioned above.



#### NsSimpleAcl6

+ Get
    * Properties  

        The following properties can be found in the NsSimpleAcl6Stats-objects inside of a NsSimpleAcl6StatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        SimpleAcl6TotalHits|sacl6tothits|string|Packets matching a SimpleACL6.
        SimpleAcl6HitsRate|sacl6hitsrate|double|Rate (/s) counter for sacl6tothits
        SimpleAcl6TotalMisses|sacl6totmisses|string|Packets not matching any SimpleACL6.
        SimpleAcl6MissesRate|sacl6missesrate|double|Rate (/s) counter for sacl6totmisses
        SimpleAcl6sCount|sacl6scount|string|Number of SimpleACL6s configured.
        SimpleAcl6TotalPacketsAllowed|sacl6totpktsallowed|string|Total packets that matched a SimpleACL6 with action ALLOW and got consumed by Citrix ADC.
        SimpleAcl6PacketsAllowedRate|sacl6pktsallowedrate|double|Rate (/s) counter for sacl6totpktsallowed
        SimpleAcl6TotalPacketsBridged|sacl6totpktsbridged|string|Total packets that matched a SimpleACL6 with action BRIDGE and got bridged by Citrix ADC.
        SimpleAcl6PacketsBridgedRate|sacl6pktsbridgedrate|double|Rate (/s) counter for sacl6totpktsbridged
        SimpleAcl6TotalPacketsDenied|sacl6totpktsdenied|string|Packets dropped because they match SimpleACL6 (Access Control List) with processing mode set to DENY.
        SimpleAcl6PacketsDeniedRate|sacl6pktsdeniedrate|double|Rate (/s) counter for sacl6totpktsdenied



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsSimpleAcl6StatCommand>(INitroServiceClient, New NsSimpleAcl6StatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsSimpleAcl6StatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsSimpleAcl6Stat, that object is <u>NsSimpleAcl6StatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsSimpleAcl6Statistics: a NsSimpleAcl6Stats-object returned by the Get-Request, containing the properties mentioned above.




#### NsTrafficDomain

+ Get
    * Properties  

        The following properties can be found in the NsTrafficDomainStats-objects-array inside of a NsTrafficDomainStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        TrafficDomain|td|string|An integer specifying the Traffic Domain ID. 
        NsTrafficDomainTotalReceivePackets|nstdtotrxpkts|string|Packets received on this TD.
        NsTrafficDomainReceivePacketsRate|nstdrxpktsrate|double|Rate (/s) counter for nstdtotrxpkts
        NsTrafficDomainTotalTransmitPackets|nstdtottxpkts|string|Packets transmitted from this TD.
        NsTrafficDomainTransmitPacketsRate|nstdtxpktsrate|double|Rate (/s) counter for nstdtottxpkts
        NsTrafficDomainTotalDroppedPackets|nstdtotdroppedpkts|string|Inbound packets dropped on this TD by reception.
        NsTrafficDomainDroppedPacketsRate|nstddroppedpktsrate|double|Rate (/s) counter for nstdtotdroppedpkts




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsTrafficDomainStatCommand>(INitroServiceClient, New NsTrafficDomainStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NsTrafficDomainStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:td, value: double
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsTrafficDomainStat, that object is <u>NsTrafficDomainStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NsTrafficDomainStatistics: a NsTrafficDomainStats-object-arrays returned by the Get-Request, containing the properties mentioned above.