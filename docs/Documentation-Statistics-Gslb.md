### Gslb

#### GslbDomain

+ Get
    * Properties  

        The following properties can be found in the GslbDomainStats-object inside of a GslbDomainStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the GSLB domain for which to display statistics.
        DnsTotalQueries|dnstotalqueries|string|Total number of DNS queries received.
        DnsQueriesRate|dnsqueriesrate|double|Rate (/s) counter for dnstotalqueries
        GlobalServerLoadBalancingDnsRecordType|gslbdnsrectype|string|Type of DNS record returned

  


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<GslbDomainStatCommand>(INitroServiceClient, New GslbDomainStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object GslbDomainStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")): 
            - key:name, value: string
            - key: dnsrecordtype, value: string 
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For GslbDomainStat, that object is <u>GslbDomainStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - GslbDomainStatistics: a GslbDomainStats-object returned by the Get-Request, containing the properties mentioned above.



#### GslbService

+ Get
    * Properties  

        The following properties can be found in the GslbServiceStats-object inside of a GslbServiceStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        ServiceName|servicename|string|Name of the GSLB service.
        ServiceType|servicetype|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        CurrentLoad|curload|string|Load on the service that is calculated from the bound load based monitor.
        PrimaryPort|primaryport|int|The port on which the service is running.
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running.
        CurrentClientConnections|curclntconnections|string|Number of current client connections.
        CurrentServerConnections|cursrvrconnections|string|Number of current connections to the actual servers behind the virtual server.
        EstablishedConnections|establishedconn|string|Number of client connections in ESTABLISHED state.
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        ResponsesRate|responsesRate|double|Rate (/s) counter for totalresponses
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server.
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server.
        ResponseBytesRate|reponsebytesrate|double|Rate (/s) counter for totalresponsebytes
        VirtualServerServiceHits|vsvrservicehits|string|Number of times that the service has been provided.
        VirtualServerServiceHitsRate|vsvrservicehitsrate|double|Rate (/s) counter for vsvrservicehits


  


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<GslbServiceStatCommand>(INitroServiceClient, New GslbServiceStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object GslbServiceStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")): 
            - key:servicename, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For GslbServiceStat, that object is <u>GslbServiceStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - GslbServiceStatistics: an array of GslbServiceStats-objects returned by the Get-Request, containing the properties mentioned above.



#### GslbServiceGroup

+ Get
    * Properties  

        The following properties can be found in the GslbServiceGroupStats-object inside of a GslbServiceGroupStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        ServiceGroupName|servicegroupname|string|Name of the GSLB service group for which to display settings.
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        ServiceType|servicetype|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<GslbServiceGroupStatCommand>(INitroServiceClient, New GslbServiceGroupStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object GslbServiceGroupStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")): 
            - key:servicegroupname, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For GslbServiceGroupStat, that object is <u>GslbServiceGroupStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - GslbServiceGroupStatistics: an array of GslbServiceGroupStats-objects returned by the Get-Request, containing the properties mentioned above.



#### GslbServiceGroupMember

+ Get
    * Properties  

        The following properties can be found in the GslbServiceGroupMemberStats-object inside of a GslbServiceGroupMemberStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        ServiceGroupName|servicegroupname|string|Name of the GSLB service group. 
        ServiceType|servicetype|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running.
        PrimaryPort|primaryport|int|The port on which the service is running.
        CurrentLoad|curload|string|Load on the service that is calculated from the bound load based monitor.
        CurrentClientConnections|curclntconnections|string|Number of current client connections.
        CurrentServerConnections|cursrvrconnections|string|Number of current connections to the actual servers behind the virtual server.
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        ResponsesRate|responsesrate|double|Rate (/s) counter for totalresponses
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server.
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes
        TotalResponseBytes|totaltresponsebytes|string|Number of response bytes received by this service or virtual server.
        ResponseBytesRate|responsebytesrate|double|Rate (/s) counter for totalresponsebytes
        EstablishedConnections|establishedconn|string|Number of client connections in ESTABLISHED state.



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<GslbServiceGroupMemberStatCommand>(INitroServiceClient, New GslbServiceGroupMemberStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object GslbServiceGroupMemberStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")): 
            - key:servicegroupname, value: string
            - key:ip, value: string
            - key:servername, value: string
            - key:port, value : integer
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For GslbServiceGroupMemberStat, that object is <u>GslbServiceGroupMemberStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - GslbServiceGroupMemberStatistics: an array of GslbServiceGroupMemberStats-objects returned by the Get-Request, containing the properties mentioned above.



#### GslbSite

+ Get
    * Properties  

        The following properties can be found in the GslbSiteStats-object inside of a GslbSiteStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        SiteName|sitename|string|Name of the GSLB site for which to display detailed statistics.
        SitePublicIp|sitepublicip|string|The public IP address of this GSLB site.
        SiteIp|siteip|string|The private IP address of this GSLB site.
        SiteType|sitetype|string|Indicates whether this GSLB site is local or remote.
        SiteMetricExchangePolicyStatus|sitemepstatus|string|Indicates the status of the Metric Exchange Policy at this GSLB site.
        PersistentEntriesExchange|persexchange|string|Indicates whether Persistence entries exchange is enabled or disabled at this GSLB site.
        NetworkMetricExchange|nwmetricexchange|string|Indicates whether network metric exchange is enabled or disabled at this GSLB site.
        SiteMetricExchange|sitemetricexchange|string|Indicates whether metric exchange is enabled or disabled at this GSLB site.
        SiteIpString|siteipstr|string|The private IP address of this GSLB site.
        SitePublicIpString|sitepublicipstr|string|The public IP address of this GSLB site.
        SiteMetricMetricExchangePolicyStatus|sitemetricmepstatus|string|Indicates the status of the site metric Metric Exchange connection at this GSLB site.
        NetworkMetricMetricExchangePolicyStatus|nwmetricmepstatus|string|Indicates the status of the network metric Metric Exchange connection at this GSLB site.
        SiteTotalResponses|sitetotalresponses|string|Number of responses received by the virtual servers represented by all GSLB services associated with this GSLB site.
        SiteResponsesRate|siteresponsesrate|double|Rate (/s) counter for sitetotalresponses
        SiteTotalRequests|sitetotalrequests|string|Total number of requests received by the virtual servers represented by all GSLB services associated with this GSLB site.
        SiteRequestsRate|siterequestsrate|double|Rate (/s) counter for sitetotalrequests
        SiteTotalResponseBytes|sitetotalresponsebytes|string|Number of response bytes received by the virtual servers represented by all GSLB services associated with this GSLB site.
        SiteResponseBytesRate|siteresponsebytesrate|double|Rate (/s) counter for sitetotalresponsebytes
        SiteTotalRequestBytes|sitetotalrequestbytes|string|Total number of request bytes received by the virtual servers represented by all GSLB services associated with this GSLB site.
        SiteRequestBytesRate|siterequestbytesrate|double|Rate (/s) counter for sitetotalrequestbytes
        SiteCurrentClientConnections|sitecurclntconnections|string|Number of current client connections to the virtual servers represented by all GSLB services associated with this GSLB site.
        SiteCurrentServerConnections|sitecursrvrconnections|double|Number of current connections to the real servers behind the virtual servers represented by all GSLB services associated with this GSLB site.




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<GslbSiteStatCommand>(INitroServiceClient, New GslbSiteStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object GslbSiteStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")): 
            - key:sitename, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For GslbSiteStat, that object is <u>GslbSiteStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - GslbSiteStatistics: an array of GslbSiteStats-objects returned by the Get-Request, containing the properties mentioned above.




#### GslbVserver

+ Get
    * Properties  

        The following properties can be found in the GslbVserverStats-object inside of a GslbVserverStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the GSLB virtual server for which to display statistics.
        EstablishedConnections|establishedconn|string|Number of client connections in ESTABLISHED state.
        InactiveServices|inactsvcs|string|number of INACTIVE services bound to a vserver
        VirtualServerLoadBalancingHealth|vslbhealth|string|Health of the vserver. This gives percentage of UP services bound to this vserver.
        Type|type|string|Protocol associated with the vserver
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        ActiveServices|actsvcs|string|number of ACTIVE services bound to a vserver
        TotalHits|tothits|string|Total vserver hits
        HitsRate|hitsrate|double|Rate (/s) counter for tothits
        VirtualServerTotalBackupLoadBalancingMethodHits|vsvrtotbkplbhits|string|Total backup LB method hits
        VirtualServerTotalBackupLoadBalancingMethodFail|vsvrtotbkplbfail|string|Total backup LB method fails
        CurrentPersistenceSessions|curpersistencesessions|string|current vserver owned persistence sessions
        VirtualServerTotalPersistenceHits|vsvrtotpersistencehits|string|Total number of Persistence hits at vserver
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server.
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server.
        ResponseBytesRate|responsebytesrate|double|Rate (/s) counter for totalresponsebytes
        SpillOverThreshold|sothreshold|string|Spill Over Threshold set on the VServer.
        TotalSpillOvers|totspillovers|string|Number of times vserver experienced spill over.
        TotalVirtualServerDownBackupHits|totvserverdownbackuphits|string|Number of times traffic was diverted to backup vserver since primary vserver was DOWN.
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        ResponsesRate|responsesrate|double|Rate (/s) counter for totalresponses
        CurrentClientConnections|curclntconnections|string|Number of current client connections.
        CurrentServerConnections|cursrvrconnections|string|Number of current connections to the actual servers behind the virtual server.

        




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<GslbVserverStatCommand>(INitroServiceClient, New GslbVserverStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object GslbVserverStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For GslbVserverStat, that object is <u>GslbVserverStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - GslbVserverStatistics: an GslbVserverStats-object returned by the Get-Request, containing the properties mentioned above.