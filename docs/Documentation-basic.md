# Documentation

## Commands

### Basic
#### Server
Commands: Add, Get, Remove, Update 

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description | restrictions
        ---|---|---|---|---
        Name|name| string | Sets the name of the Server| All
        Domain|domain| string | Sets the Domain of the server |ServerAddByDomainRequestData only
        IpAddress |ipaddress| string | Sets the IP of the server |ServerAddByIpRequestData only
        TranslationIp |translationip| string | IP address used to transform the server's DNS-resolved IP address. |ServerAddByDomainRequestData only
        TranslationMask|translationmask| string| The netmask of the translation ip.| ByDomain only
        DomainResolveRetry|domainresolveretry| int | Time, in seconds, for which the NetScaler appliance must wait, after DNS resolution fails, before sending the next DNS query to resolve the domain name. Default value: 5 Minimum value = 5 Maximum value = 20939 | ByDomain only
        State|state| string| Initial State of the server. ENABLED, DISABLED | All
        SupportIpv6Address|ipv6address| string | Support IPv6 addressing mode. If you configure a server with the IPv6 addressing mode, you cannot use the server in the IPv4 addressing mode. Default value: NO, Possible values = YES, NO | Domain only
        Comment|comment| string | Information| All
        TrafficDomain|td| double| Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0. Minimum value = 0, Maximum value = 4094 | All
        QueryType |querytype| string | Specify the type of DNS resolution to be done on the configured domain to get the backend services. Valid query types are A, AAAA and SRV with A being the default querytype. The type of DNS resolution done on the domains in SRV records is inherited from ipv6 argument. Possible values: A, AAAA, SRV, Default value: A | All

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data (ServerAddByDomainRequestData or ServerAddByIpRequestData)  
        The Data-item will ask for the following mandatory parameters on creation: <u>string Name</u>, <u>string Domain</u>(ServerAddByDomainRequestData), <u>string IpAddress</u>(ServerAddByIpRequestData) 
        
            The other possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg.   
            
            ```
            var command = NitroCommandFactory.Create\<ServerAddCommand> (INitroServiceClient, new ServerAddByIpRequestData(){ });
              
            ```  
                  
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for serverAdd, that object is <u>NitroResponse</u>.

        eg.  
        ```
        var response = command.GetResponse(); 

        ```
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each ServerConfiguration found in the array "Servers" inside of a ServerGetResponse.

        Property|citrix doc name|DataType|Description
        ---|---|---
        Name|name|string|The name of the server
        ServiceType|svctype|string|-
        DuplicateServiceType|dup_svctype|string|-
        Port|port|int|port value.
        DuplicatePort|dup_port|int|-
        ServerState|svrstate|string|-
        Internal|internal|bool| server is for internal use
        IpAddress|internal|string|the IpAddress of the server
        State|state|string|-
        Domain|domain|string|domain of the server
        DomainResolveNow|domainresolvenow|string|-
        DomainResolveRetry|domainresolveretry|int|Time, in seconds, for which the NetScaler appliance must wait, after DNS resolution fails, before sending the next DNS query to resolve the domain name. Default value: 5. Minimum value = 5. Maximum value = 20939
        TranslationIp|translationip|string|IP address used to transform the server's DNS-resolved IP address.
        TranslationMask|translationmask|string|NetMask of the translation Ip.
        Comment|comment|string| Any additional information.
        Delay|delay|double|-
        Graceful|graceful|string|-
        StateChangedTimeSec|statechangedtimesec|string|Time when last state change happened. Seconds part.
        TicksSinceLastStateChange|tickssincelastsstatechange|string|Time in 10 millisecond ticks since the last state change.
        SupportIpV6Address|ipv6address|string|Support IPv6 addressing mode. If you configure a server with the IPv6 addressing mode, you cannot use the server in the IPv4 addressing mode. Default value: NO. Possible values = YES, NO
        TrafficDomain|td|string |Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0. Minimum value = 0. Maximum value = 4094
        AutoScale|autoscale|string|Auto scale option for a servicegroup. Default value: DISABLED. Possible values = DISABLED, DNS, POLICY
        UseSourceIp|usip|string| Use the client's IP address as the source IP address when initiating a connection to the server. Possible values = YES, NO
        ClientKeepAlive|cka|string| Enable Client Keep-Alive. Possible Values = YES, NO.
        TcpBuffering|tcpb|string|Enable TCP buffering. Possible Values = YES, NO.
        Compression|cmp|string| Enable Comperssion. Possible Values = YES, NO.
        Cacheable|cacheable| string| Use the transparent cache redirection virtual server to forward the request to the cache server. Default value: NO. Possible values = YES, NO
        SureConnect|sc|string| State of the SureConnect Feature. Default value: OFF. Possible values = ON, OFF
        SurgeProtection|sp|string | Enable Surge Protection. Default value: OFF. Possible values = ON, OFF
        ServerCfgFlags|svrcfgflags|string|-
        MaxRequests|maxreq|string|-
        MaxBandwidth|maxbandwidth|string|-
        ServiceItemActiveServices|svcitmactsvcs|string|-
        ServiceItemBoundServices|svcitemboundsvcs|string|-
        Weight|weight|string|-
        QueryType|querytype|string|-
        Count|__count| double| Number of servers.

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg.  
        ```
        var command = NitroCommandFactory.Create\<ServerGetCommand>(INitroServiceClient, New ServerGetRequestOptions(){ });
        ```
        
        - Options:  
        For Servers, the Options are gathered in an Object ServerGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServerGet, that object is <u>ServerGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Servers: an array of ServerConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg.  
        ```
      var command = NitroCommandFactory.Create\<ServerRemoveCommand>(INitroServiceClient, new ServerRemoveRequestOptions(){ });
        ```
      
      - Options:  
        For Servers, the Options are gathered in an Object ServerRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the Server you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServerRemove, that object is <u>NitroResponse</u>.

        eg.  
        ```
      var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update:
    * Properties:

        Property|citrix doc name|ValueType|Description
        ---|---|---|---
        Name|name|string|The name of the server
        IpAddress|ipaddress|string|the IpAddress of the server
        DomainResolveRetry|domainresolveretry|int|Time, in seconds, for which the NetScaler appliance must wait, after DNS resolution fails, before sending the next DNS query to resolve the domain name. Default value: 5. Minimum value = 5. Maximum value = 20939
        TranslationIp|translationip|string|IP address used to transform the server's DNS-resolved IP address.
        TranslationMask|translationmask|string|NetMask of the translation Ip.
        Comment|comment|string| Any additional information.
        DomainResolveNow|domainresolvenow|bool|Immediately send a DNS query to resolve the server's domain name.

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (ServerUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<ServerUpdateCommand> (INitroServiceClient, new ServerUpdateRequestData(){ });
            ```
          
            Inside the ServerUpdateRequestData-item, the properties mentioned above will be accessible to change.

    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServerUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


        
        
#### Service
Commands: Add, Get, Remove, Update 

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description | Applicable to
        ---|---|---|---|---
        Name|name|string|Name of the service|all
        Ip|ip|string|Ip of the targetserver|mutually exclusive with ServerName
        ServerName|servername|string|name of the targetserver|mutually exclusive with Ip
        Port|port|int|port on which the service runs|all
        ClearTextPort|cleartextport|string|- | SSL, SSLTCP
        CacheType|cachetype|string|- | SSL, SSLTCP
        MaxClient|maxclient|double|- |all
        HealthMonitor|healthmonitor|string|-|all
        MaxRequests|maxreq|double|-|all
        Cacheable|cacheable|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, SYSLOG_UDP, TCP, UDP
        InjectClientIp|cip|string|-|all
        ClientIpHeader|cipheader|string|-|all
        UseSourceIp|usip|string|-|all
        PathMonitor|pathmonitor|string|-|-
        PathMonitorIndividual|pathmonitorindv|string|-|-
        UseProxyPort|useproxyport|string|-|all
        SureConnect|sc|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, SYSLOG_UDP, TCP, UDP
        SurgeProtection|sp|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, SYSLOG_UDP, TCP, UDP, DNS_TCP
        RtspSessionIdRemap|rtspsessionidremap|string|-|-
        ClientTimeOut|clttimeout|double|-|all
        ServerTimeout|svrtimeout|double|-|all
        CustomServerId|customserverid|string|-|all
        ServerId|serverid|string|-|all
        ClientKeepAlive|cka|string|-|all
        TcpBuffering|tcpb|string|-|all
        Compression|cmp|string|-|HTTP, SSL
        MaxBandwidth|maxbandwidth|double|-|all
        AccessDown|accessdown|string|-|all
        MonitorWeightThreshold|monthreshold|double|-|all
        State|state|string|-|all
        DownStateFlush|downstateflush|string|-|all
        TcpProfileName|tcpprofilename|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, TCP, DNS_TCP
        HttpProfileName|httpprofilename|string|-|HTTP, SSL
        HashId|hashid|double|-|all
        Comment|comment|string|-|all
        AppFlowLogging|appflowlog|string|-|all
        NetProfile|netprofile|string|-|all
        TrafficDomain|td|double|TrafficDomain|all
        ProcessLocal|processlocal|string|-|all
        MonitorConnectionClose|monconnectionclose|string|-|all
        ContentInspectionProfileName|contentinspectionprofilename|string|-|all


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data

            Eg.
            ```
            var command = NitroCommandFactory.Create\<ServiceAddCommand> (INitroServiceClient, new \<ServiceAddRequestData>(){ });
            ```
          
            Where \<ServiceAddRequestData> is one of types:
             - ServiceAddHttpRequestData, ServiceAddTcpRequestData, ServiceAddDnsRequestData, ServiceAddDnsTcpRequestData, ServiceAddSslBridgeRequestData, ServiceAddSslRequestData, ServiceAddSslTcpRequestData, ServiceAddSyslogTcpRequestData, ServiceAddSyslogUdpRequestData, ServiceAddUdpRequestData  
            
            These are the premade DataObjects to be used. The applicable properties will be accessible, list above.
    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceAdd, that object is <u>NitroResponse</u>.

        eg.  
        ```
     var response = command.GetResponse();  
        ```
     
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each ServiceConfiguration found in the array "Services" inside of a ServiceGetResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the service
        Ip|ip|string|Ip of the targetserver
        ServerName|servername|string|name of the targetserver
        Port|port|int|port on which the service runs
        ClearTextPort|cleartextport|int|Port to which clear text data must be sent after the appliance decrypts incoming SSL traffic. Applicable to transparent SSL services.
        CacheType|cachetype|string|Cache type supported by the cache server. Possible values = TRANSPARENT, REVERSE, FORWARD
        MaxClient|maxclient|double|Maximum number of simultaneous open connections to the service.
        HealthMonitor|healthmonitor|string|Monitor the health of this service. Available settings function as. Default value: YES. Possible values = YES, NO
        MaxRequests|maxreq|double|Maximum number of requests that can be sent on a persistent connection to the service. 
        Cacheable|cacheable|string|Use the transparent cache redirection virtual server to forward requests to the cache server. Default value: NO. Possible values = YES, NO
        InjectClientIp|cip|string|Before forwarding a request to the service, insert an HTTP header with the client's IPv4 or IPv6 address as its value. Used if the server needs the client's IP address for security, accounting, or other purposes, and setting the Use Source IP parameter is not a viable option. Possible values = ENABLED, DISABLED
        ClientIpHeader|cipheader|string|Name for the HTTP header whose value must be set to the IP address of the client. 
        UseSourceIp|usip|string|Use the client's IP address as the source IP address when initiating a connection to the server. Possible values = YES, NO
        PathMonitor|pathmonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndividual|pathmonitorindv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|useproxyport|string|Use the proxy port as the source port when initiating connections with the server. Possible values = YES, NO
        SureConnect|sc|string|State of SureConnect for the service. Default value: OFF. Possible values = ON, OFF
        SurgeProtection|sp|string|Enable surge protection for the service. Possible values = ON, OFF
        RtspSessionIdRemapping|rtspsessionidremap|string|Enable RTSP session ID mapping for the service. Default value: OFF. Possible values = ON, OFF
        ClientTimeout|clttimeout|double|Time, in seconds, after which to terminate an idle client connection.
        ServerTimeout|svrtimeout|double|Time, in seconds, after which to terminate an idle server connection.
        CustomServerId|customserverid|string|Unique identifier for the service. Used when the persistency type for the virtual server is set to Custom Server ID. Default value: "None"
        ServerId|serverid|string|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        ClientKeepAlive|cka|string|Enable client keep-alive for the service. Possible values = YES, NO
        TcpBuffering|tcpb|string|Enable TCP buffering for the service. Possible values = YES, NO
        Compression|cmp|string|Enable compression for the service. Possible values = YES, NO
        MaxBandwidth|maxbandwidth|double|Maximum bandwidth, in Kbps, allocated to the service.
        AccessDown|accessdown|string|Use Layer 2 mode to bridge the packets sent to this service if it is marked as DOWN. If the service is DOWN, and this parameter is disabled, the packets are dropped. Default value: NO. Possible values = YES, NO
        MonitorWeightThreshold|monthreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|state|string|Initial state of the service. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with a service whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|tcpprofilename|string|Name of the TCP profile that contains TCP configuration settings for the service.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile that contains HTTP configuration settings for the service.
        HashId|hashid|double|A numerical identifier that can be used by hash based load balancing methods. Must be unique for each service.
        Comment|comment|string|Any information about the service.
        AppFlowLogging|appflowlog|string|Enable logging of AppFlow information. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|netprofile|string|Network profile to use for the service.
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        ProcessLocal|processlocal|string|By turning on this option packets destined to a service in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DnsProfileName|dnsprofilename|string|Name of the DNS profile to be associated with the service. DNS profile properties will applied to the transactions processed by a service. This parameter is valid only for ADNS and ADNS-TCP services.
        MonitorConnectionClose|monconnectionclose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        RiseApbrStatusMessageCode|riseapbrstatsmsgcode|int|The code indicating the rise apbr status.
        IpAdress|ipaddress|string|The new IP address of the service.
        Weight|weight|double|Weight to assign to the monitor-service binding. When a monitor is UP, the weight assigned to its binding with the service determines how much the monitor contributes toward keeping the health of the service above the value configured for the Monitor Threshold parameter.
        MonitorNameService|monitor_name_svc|string|Name of the monitor bound to the specified service.
        Delay|delay|double|Time, in seconds, allocated to the NetScaler appliance for a graceful shutdown of the service. 
        Graceful|graceful|string|Shut down gracefully, not accepting any new connections, and disabling the service when all of its connections are closed. Default value: NO. Possible values = YES, NO
        All|all|bool|Display both user-configured and dynamically learned services.
        Internal|internal|bool|Display only dynamically learned services.
        NewName|newname|string|New name for the service. 
        NumberOfConnections|numofconnections|int|This will tell the number of client side connections are still open.
        PolicyName|policyname|string|The name of the policyname for which this service is bound.
        ServiceConfigurationType|serviceconftype|bool|The configuration type of the service.
        ServiceConfigurationType2|serviceconftype2|string|The configuration type of the service (Internal/Dynamic/Configured). Possible values = Configured, Dynamic, Internal
        Value|value|string|SSL status. Possible values = Certkey not bound, SSL feature disabled
        Gslb|gslb|string|The GSLB option for the corresponding virtual server. Possible values = REMOTE, LOCAL
        DublicateState|dup_state|string|Added this field for getting state value from table. Possible values = ENABLED, DISABLED
        DublicateWeight|dup_weight|string|-
        PublicIp|publicip|string|public ip.
        PublicPort|publicport|int|public port.
        ServerState|svrstate|string|The state of the service. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        MonitorState|monitor_state|string|The running state of the monitor on this service. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        MonitorStatCode|monstatcode|int|The code indicating the monitor response.
        LastResponse|lastresponse|string|The string form of monstatcode.
        ResponseTime|responsetime|string|Response time of this monitor.
        RiseApbrStatusMessageCode2|riseapbrstatsmsgcode2|int|The code indicating other rise stats.
        MonitorStatParameter1|monstatparam1|int|First parameter for use with message code.
        MonitorStatParameter2|monstatparam2|int|Second parameter for use with message code.
        MonitorStatParameter3|monstatparam3|int|Third parameter for use with message code.
        StateChangeTimeSec|statechangetimesec|string|Time when last state change happened. Seconds part.
        StateChangeTimeMSec|statechangetimemsec|string|Time at which last state change happened. Milliseconds part.
        TicksSinceLastStateChange|tickssincelaststatechange|string|Time in 10 millisecond ticks since the last state change.
        StateUpdateReason|stateupdatereason|string|Checks state update reason on the secondary node.
        MonitorView|clmonview|string|Tells the mon owner of the service.
        MonitorOwner|clmonowner|string|Tells the view id of the monitoring owner.
        ServiceIp|serviceipstr|string|This field has been intorduced to show the dbs services ip.
        OracleServerVersion|oracleserverversion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        FailedProbes|failedprobes|string|-
        TotalProbes|totalprobes|string|-
        TotalFailedProbes|totalfailedprobes|string|-
        MonitorTotalFailedProbes|monitortotalfailedprobes|string|-
        MonitorTotalProbes|monitortotalprobes|string|-
        MonitorCurrentFailedProbes|monitorcurrentfailedprobes|string|-
        Passive|passive|bool|-
        MonitorUserStatusMessage|monuserstatusmesg|string|-
        Count|__count|double|-

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg.  
        ```
      var command = NitroCommandFactory.Create\<ServiceGetCommand>(INitroServiceClient, New ServiceGetRequestOptions(){ });
        ```
      
        - Options:  
        For Services, the Options are gathered in an Object ServiceGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceGet, that object is <u>ServiceResponse</u>.

        eg. 
         ```
      var response = command.GetResponse(); 
         ```
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Services: an array of ServiceConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg.  
        ```
        var command = NitroCommandFactory.Create\<ServiceRemoveCommand>(INitroServiceClient, new ServiceRemoveRequestOptions(){ });
        ```
      
      - Options:  
        For this command, the Options are gathered in an Object ServiceRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceRemove, that object is <u>NitroResponse</u>.

        eg. 
         ```
      var response = command.GetResponse(); 
         ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update:
    * Properties:

        Property|Citrix doc name|ValueType|Description
        ---|---|---|---
        Name|name|string|The name of the service
        MaxClient|maxclient|double|Maximum number of simultaneous open connections to the service.
        HealthMonitor|healthmonitor|string|Monitor the health of this service. Available settings function as. Default value: YES. Possible values = YES, NO
        MaxRequests|maxreq|double|Maximum number of requests that can be sent on a persistent connection to the service. 
        IpAdress|ipaddress|string|New IpAdress to assign to service.
        InjectClientIp|cip|string|Before forwarding a request to the service, insert an HTTP header with the client's IPv4 or IPv6 address as its value. Used if the server needs the client's IP address for security, accounting, or other purposes, and setting the Use Source IP parameter is not a viable option. Possible values = ENABLED, DISABLED
        ClientIpHeader|cipheader|string|Name for the HTTP header whose value must be set to the IP address of the client. 
        UseSourceIp|usip|string|Use the client's IP address as the source IP address when initiating a connection to the server. Possible values = YES, NO
        PathMonitor|pathmonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndividual|pathmonitorindv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|useproxyport|string|Use the proxy port as the source port when initiating connections with the server. Possible values = YES, NO
        RtspSessionIdRemap|rtspsessionsidremap|string|Enable RTSP session ID mapping for the service. Default value: OFF. Possible values = ON, OFF
        ClientTimeout|clttimeout|double|Time, in seconds, after which to terminate an idle client connection.
        ServerTimeout|svrtimeout|double|Time, in seconds, after which to terminate an idle server connection.
        CustomServerId|customserverid|string|Unique identifier for the service. Used when the persistency type for the virtual server is set to Custom Server ID. Default value: "None"
        ServerId|serverid|string|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        ClientKeepAlive|cka|string|Enable client keep-alive for the service. Possible values = YES, NO
        TcpBuffering|tcpb|string|Enable TCP buffering for the service. Possible values = YES, NO
        MaxBandwidth|maxbandwidth|double|Maximum bandwidth, in Kbps, allocated to the service.
        AccessDown|accessdown|string|Use Layer 2 mode to bridge the packets sent to this service if it is marked as DOWN. If the service is DOWN, and this parameter is disabled, the packets are dropped. Default value: NO. Possible values = YES, NO
        MonitorWeightThreshold|monthreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|state|string|Initial state of the service. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with a service whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|tcpprofilename|string|Name of the TCP profile that contains TCP configuration settings for the service.
        Weight|weight|double|Weight to assign to the monitor-service binding. When a monitor is UP, the weight assigned to its binding with the service determines how much the monitor contributes toward keeping the health of the service above the value configured for the Monitor Threshold parameter.
        MonitorNameService|monitor_name_svc|string|Name of the monitor bound to the specified service. 
        HashId|hashid|double|A numerical identifier that can be used by hash based load balancing methods. Must be unique for each service.
        Comment|comment|string|Any information about the service.
        AppFlowLogging|appflowlog|string|Enable logging of AppFlow information. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetworkProfile|netprofile|string|Network profile to use for the service.
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        ProcessLocal|processlocal|string|By turning on this option packets destined to a service in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        MonitorConnectionClose|monconnectionclose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        ContentInspectionProfileName|contentinspectionprofilename|string|-

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data

            Eg. 
             ```
          var command = NitroCommandFactory.Create\<ServiceUpdateCommand> (INitroServiceClient, new \<ServiceUpdateRequestData>(){ });
            ```
          
            Where \<ServiceUpdateRequestData> is one of types:
             - ServiceUpdateHttpRequestData, ServiceUpdateTcpRequestData, ServiceUpdateDnsRequestData, ServiceUpdateDnsTcpRequestData, ServiceUpdateSslBridgeRequestData, ServiceUpdateSslRequestData, ServiceUpdateSslTcpRequestData, ServiceUpdateSyslogTcpRequestData, ServiceUpdateSyslogUdpRequestData, ServiceUpdateUdpRequestData  
            
            These are the premade DataObjects to be used. The applicable properties will be accessible, list above.

    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for UpdateServices, that object is <u>NitroResponse</u>.

        eg. 
         ```
      var response = command.GetResponse(); 
         ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 

        

#### ServiceBinding

##### service_lbmonitor_binding

Commands: Add, Get, Remove, Update 

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|name of the service
        MonitorName|monitor_name|string|name of the monitor to bind.
        MonitorState|monstate|string|The configured state (enable/disable) of the monitor on this server. Possible values = ENABLED, DISABLED
        Weight|weight|double|The weight of the monitor.
        Passive|passive|bool|Indicates if load monitor is passive. A passive load monitor does not remove service from LB decision when threshold is breached.

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<ServiceBindingAddLbmonitorCommand> (INitroServiceClient, new \<ServiceBindingAddLbmonitorRequestData>(){ });
            ```
            
            The applicable properties will be accessible, list above.
    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceBindingAddLbmonitor, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse();  
        ```
      
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get - NYI
    * Properties  
        
+ Remove: 

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<ServiceBindingRemoveLbmonitorCommand>(INitroServiceClient, new ServiceBindingRemoveLbmonitorRequestOptions(){ });
        ```
      
      - Options:  
        For this command, the Options are gathered in an Object ServiceBindingRemoveLbmonitorRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.
        <u>Arguments</u>: a dictionary of strings in which you will need to add "monitor_name" as key and the name of the monitor you wish to remove as value.
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceBindingRemoveLbmonitor, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update -NYI
    * Properties:


#### Servicegroup

Commands: Add, Get, Remove, Update 

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description
        ---|---|---|---
        ServiceGroupName|servicegroupname|string|name of the servicegroup
        ServiceType|servicetype|string|Protocol used to exchange data with the service. Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, RPCSVR, DNS, ADNS, SNMP, RTSP, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, ADNS_TCP, MYSQL, MSSQL, ORACLE, RADIUS, RADIUSListener, RDP, DIAMETER, SSL_DIAMETER, TFTP, SMPP, PPTP, GRE, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, USER_TCP, USER_SSL_TCP, QUIC. Gets automatically assigned when choosing which data to use.
        CacheType|cachetype|string|Cache type supported by the cache server. Possible values = TRANSPARENT, REVERSE, FORWARD
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        MaxClient|maxclient|double|Maximum number of simultaneous open connections for the service group.
        MaxRequests|maxreq|double|Maximum number of requests that can be sent on a persistent connection to the service group. Note: Connection requests beyond this value are rejected.
        Cacheable|cacheable|string|Use the transparent cache redirection virtual server to forward the request to the cache server. Note: Do not set this parameter if you set the Cache Type. Default value: NO. Possible values = YES, NO
        InjectClientIp|cip|string|Insert the Client IP header in requests forwarded to the service. Possible values = ENABLED, DISABLED
        ClientIpHeader|cipheader|string|Name of the HTTP header whose value must be set to the IP address of the client. Used with the Client IP parameter. If client IP insertion is enabled, and the client IP header is not specified, the value of Client IP Header parameter or the value set by the set ns config command is used as client's IP header name.
        UseSourceIp|usip|string|Use client's IP address as the source IP address when initiating connection to the server. With the NO setting, which is the default, a mapped IP (MIP) address or subnet IP (SNIP) address is used as the source IP address to initiate server side connections. Possible values = YES, NO
        PathMonitor|pathmonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndv|pathmonitorindv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|useproxyport|string|Use the proxy port as the source port when initiating connections with the server. With the NO setting, the client-side connection port is used as the source port for the server-side connection. Note: This parameter is available only when the Use Source IP (USIP) parameter is set to YES. Possible values = YES, NO
        HealthMonitor|healthmonitor|string|Monitor the health of this service. Available settings function as follows: YES - Send probes to check the health of the service. NO - Do not send probes to check the health of the service. With the NO option, the appliance shows the service as UP at all times. Default value: YES. Possible values = YES, NO
        SureConnect|sc|string|State of the SureConnect feature for the service group. Default value: OFF. Possible values = ON, OFF
        SurgeProtection|sp|string|Enable surge protection for the service group. Default value: OFF. Possible values = ON, OFF
        RtspSessionIdRemap|rtspsessionidremap|string|Enable RTSP session ID mapping for the service group. Default value: OFF. Possible values = ON, OFF
        ClientTimeout|clttimeout|double|Time, in seconds, after which to terminate an idle client connection.
        ServerTimeout|svrtimeout|double|Time, in seconds, after which to terminate an idle server connection.
        ClientKeepAlive|cka|string|Enable client keep-alive for the service group. Possible values = YES, NO
        TcpBuffering|tcpb|string|Enable TCP buffering for the service group. Possible values = YES, NO
        Compression|cmp|string|Enable compression for the service group. Possible values = YES, NO
        MaxBandwidth|maxbandwidth|double|Maximum bandwidth, in Kbps, allocated for all the services in the service group.
        MonitorWeightThreshold|monthreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|state|string|Initial state of the service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with all the services in the service group whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|tcpprofilename|string|Name of the TCP profile that contains TCP configuration settings for the service group.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile that contains HTTP configuration settings for the service group.
        Comment|comment|string|Any information about the service group.
        AppFlowLogging|appflowlog|string|Enable logging of AppFlow information for the specified service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|netprofile|string|Network profile for the service group.
        AutoScale|autoscale|string|Auto scale option for a servicegroup. Default value: DISABLED. Possible values = DISABLED, DNS, POLICY
        MemberPort|memberpport|int|member port.
        MonitorConnectionClose|monconnectionclose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        AutoDisableDelay|autodisabledelay|double|-
        AutoDisableGraceful|autodisablegraceful|string|-

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<ServicegroupAddCommand> (INitroServiceClient, new \<ServicegroupAddRequestData>(){ });
            ```
          
            Where \<ServicegroupAddRequestData> is one of types:
             - ServicegroupAddHttpRequestData, ServicegroupAddTcpRequestData, ServicegroupAddDnsRequestData, ServicegroupAddDnsTcpRequestData, ServicegroupAddSslBridgeRequestData, ServicegroupAddSslRequestData, ServicegroupAddSslTcpRequestData, ServicegroupAddSyslogTcpRequestData, ServicegroupAddSyslogUdpRequestData, ServicegroupAddUdpRequestData  
            
            These are the premade DataObjects to be used. The applicable properties will be accessible, list above.
    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for servicegroupsAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse();  
        ```
      
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each ServicegroupConfiguration found in the array "Servicegroups" inside of a ServicegroupGetResponse.

        Property|citrix doc name|DataType|Description
        ---|---|---|---
        ServiceGroupName|servicegroupname|string|name of the servicegroup
        ServiceType|servicetype|string|Protocol used to exchange data with the service. Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, RPCSVR, DNS, ADNS, SNMP, RTSP, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, ADNS_TCP, MYSQL, MSSQL, ORACLE, RADIUS, RADIUSListener, RDP, DIAMETER, SSL_DIAMETER, TFTP, SMPP, PPTP, GRE, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, USER_TCP, USER_SSL_TCP, QUIC. Gets automatically assigned when choosing which data to use.
        CacheType|cachetype|string|Cache type supported by the cache server. Possible values = TRANSPARENT, REVERSE, FORWARD
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        MaxClient|maxclient|double|Maximum number of simultaneous open connections for the service group.
        MaxRequests|maxreq|double|Maximum number of requests that can be sent on a persistent connection to the service group. Note: Connection requests beyond this value are rejected.
        Cacheable|cacheable|string|Use the transparent cache redirection virtual server to forward the request to the cache server. Note: Do not set this parameter if you set the Cache Type. Default value: NO. Possible values = YES, NO
        InjectClientIp|cip|string|Insert the Client IP header in requests forwarded to the service. Possible values = ENABLED, DISABLED
        ClientIpHeader|cipheader|string|Name of the HTTP header whose value must be set to the IP address of the client. Used with the Client IP parameter. If client IP insertion is enabled, and the client IP header is not specified, the value of Client IP Header parameter or the value set by the set ns config command is used as client's IP header name.
        UseSourceIp|usip|string|Use client's IP address as the source IP address when initiating connection to the server. With the NO setting, which is the default, a mapped IP (MIP) address or subnet IP (SNIP) address is used as the source IP address to initiate server side connections. Possible values = YES, NO
        PathMonitor|pathmonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndividual|pathmonitorindv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|useproxyport|string|Use the proxy port as the source port when initiating connections with the server. With the NO setting, the client-side connection port is used as the source port for the server-side connection. Note: This parameter is available only when the Use Source IP (USIP) parameter is set to YES. Possible values = YES, NO
        HealthMonitor|healthmonitor|string|Monitor the health of this service. Available settings function as follows: YES - Send probes to check the health of the service. NO - Do not send probes to check the health of the service. With the NO option, the appliance shows the service as UP at all times. Default value: YES. Possible values = YES, NO
        SureConnect|sc|string|State of the SureConnect feature for the service group. Default value: OFF. Possible values = ON, OFF
        SurgeProtection|sp|string|Enable surge protection for the service group. Default value: OFF. Possible values = ON, OFF
        RtspSessionIdRemap|rtspsessionidremap|string|Enable RTSP session ID mapping for the service group. Default value: OFF. Possible values = ON, OFF
        ClientTimeout|clttimeout|double|Time, in seconds, after which to terminate an idle client connection.
        ServerTimeout|svrtimeout|double|Time, in seconds, after which to terminate an idle server connection.
        ClientKeepAlive|cka|string|Enable client keep-alive for the service group. Possible values = YES, NO
        TcpBuffering|tcpb|string|Enable TCP buffering for the service group. Possible values = YES, NO
        Compression|cmp|string|Enable compression for the service group. Possible values = YES, NO
        MaxBandwidth|maxbandwidth|double|Maximum bandwidth, in Kbps, allocated for all the services in the service group.
        MonitorWeightThreshold|monthreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|state|string|Initial state of the service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with all the services in the service group whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|tcpprofilename|string|Name of the TCP profile that contains TCP configuration settings for the service group.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile that contains HTTP configuration settings for the service group.
        Comment|comment|string|Any information about the service group.
        AppFlowLogging|appflowlog|string|Enable logging of AppFlow information for the specified service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfileName|netprofilename|string|Network profile for the service group.
        AutoScale|autoscale|string|Auto scale option for a servicegroup. Default value: DISABLED. Possible values = DISABLED, DNS, POLICY
        MemberPort|memberport|int|member port.
        MonitorConnectionClose|monconnectionclose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        AutoDisableDelay|autodisabledelay|double|-
        AutoDisableGraceful|autodisablegraceful|string|-
        ServerName|servername|string|Name of the server to which to bind the service group.
        Port|port|int|Server port number.
        Weight|weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service. Minimum value = 1. Maximum value = 100
        CustomServerId|customserverid|string|The identifier for this IP:Port pair. Used when the persistency type is set to Custom Server ID. Default value: "None"
        ServerId|serverid|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        HashId|hashid|double|The hash identifier for the service. This must be unique for each service. This parameter is used by hash based load balancing methods.
        MonitorNameService|monitor_name_svc|string|Name of the monitor bound to the service group. Used to assign a weight to the monitor.
        DuplicateWeight|dup_weight|double|weight of the monitor that is bound to servicegroup.
        RiseApbrStatusMessageCode|riseapbrstatsmsgcode|int|The code indicating the rise apbr status.
        Delay|delay|double|Time, in seconds, allocated for a shutdown of the services in the service group. During this period, new requests are sent to the service only for clients who already have persistent sessions on the appliance. Requests from new clients are load balanced among other available services. After the delay time expires, no requests are sent to the service, and the service is marked as unavailable (OUT OF SERVICE).
        Graceful|graceful|string|Wait for all existing connections to the service to terminate before shutting down the service. Default value: NO. Possible values = YES, NO
        IncludeMembers|includemembers|bool|Display the members of the listed service groups in addition to their settings. Can be specified when no service group name is provided in the command. In that case, the details displayed for each service group are identical to the details displayed when a service group name is provided, except that bound monitors are not displayed.
        NumberOfConnections|numofconnections|int|This will tell the number of client side connections are still open.
        ServiceConfigurationType|serviceconftype|bool|The configuration type of the service group.
        Value|value|string|SSL Status. Possible values = Certkey not bound, SSL feature disabled
        ServerState|svrstate|string|The state of the service. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        Ip|ip|string|IP Address.
        MonitorStatCode|monstatcode|int|The code indicating the monitor response.
        MonitorStatParameter1|monstatparam1|int|First parameter for use with message code.
        MonitorStatParameter2|monstatparam2|int|Second parameter for use with message code.
        MonitorStatParameter3|monstatparam3|int|Third parameter for use with message code.
        StateChangeTimeMSec|statechangetimesec|string|Time when last state change occurred. Milliseconds part.
        StateUpdateReason|stateupdatereason|string|Checks state update reason on the secondary node.
        MonitoOwner|clmonowner|string|Tells the mon owner of the service.
        MonitorView|clmonview|string|Tells the view id of the monitoring owner.
        GroupCount|groupcount|string|Servicegroup Count.
        RiseApbrStatusMessageCode2|riseapbrstatsmsgcode2|int|The code indicating other rise stats.
        ServiceIp|serviceipstr|string|This field has been intorduced to show the dbs services ip.
        ServicegroupEffectiveState|servicegroupeffectivestate|string|Indicates the effective servicegroup state based on the state of the bound service items.If all services are UP the effective state is UP, if all are DOWN its DOWN,if all are OFS its OFS.If atleast one serviceis UP and rest are either DOWN or OFS, the effective state is PARTIAL-UP.If atleast one bound service is DOWN and rest are OFS the effective state is PARTIAL DOWN. Possible values = UP, DOWN, OUT OF SERVICE, PARTIAL-UP, PARTIAL-DOWN
        MonitorWeight|monweight|string|-
        MonitorState|monitorstate|string|-
        MonitorTotalProbes|monitortotalprobes|string|-
        MonitorTotalFailedProbes|monitortotalfailedprobes|string|-
        MonitorCurrentFailedProbes|monitorcurrentfailedprobes|string|-
        StateChangeTimeSec|statechangetimesec|string|-
        NoDefaultBindings|nodefaultbindings|string|-
        NameServer|nameserver|string|-
        DomainBasedServiceTtl|dbsttl|double|-
        ServiceItemActive|svcitmactsvcs|string|-
        ServiceItemBound|svcitmboundsvcs|string|-
        ResponseTime|responsetime|string|-
        MonitorUserStatusMessage|monuserstatusmesg|string|-
        Count|__count|int|-

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<ServiceGetCommand>(INitroServiceClient, New ServiceGetRequestOptions(){ });
        ```
      
        - Options:  
        For Services, the Options are gathered in an Object ServiceGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceGet, that object is <u>ServiceResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Servicegroups: an array of ServicegroupConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<ServicegroupRemoveCommand>(INitroServiceClient, new ServicegroupRemoveRequestOptions(){ });
        ```
        
      - Options:  
        For this command, the Options are gathered in an Object ServicegroupRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServicegroupRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  


+ Update:
    * Properties:

        Property|Citrix doc name|ValueType|Description
        ---|---|---|---
        ServicegroupName|servicegroupname|string|Name of the Servicegroup
        ServerName|servername|string|Name of the server to which to bind the service group.
        Port|port|int|Server port number.
        Weight|weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service. Minimum value = 1. Maximum value = 100
        CustomServerId|custonserverid|string|The identifier for this IP:Port pair. Used when the persistency type is set to Custom Server ID. Default value: "None"
        ServerId|serverid|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        HashId|hashid|double|The hash identifier for the service. This must be unique for each service. This parameter is used by hash based load balancing methods.
        MonitorNameService|monitor_name_svc|string|Name of the monitor bound to the service group. Used to assign a weight to the monitor.
        DuplicateWeight|dup_weight|double|weight of the monitor that is bound to servicegroup.
        MaxClient|maxclient|double|Maximum number of simultaneous open connections for the service group.
        MaxRequests|maxreq|double|Maximum number of requests that can be sent on a persistent connection to the service group. Note: Connection requests beyond this value are rejected.
        InjectClientIp|cip|string|Insert the Client IP header in requests forwarded to the service. Possible values = ENABLED, DISABLED
        ClientIpHeader|cipheader|string|Name of the HTTP header whose value must be set to the IP address of the client. Used with the Client IP parameter. If client IP insertion is enabled, and the client IP header is not specified, the value of Client IP Header parameter or the value set by the set ns config command is used as client's IP header name.
        UseSourceIp|usip|string|Use client's IP address as the source IP address when initiating connection to the server. With the NO setting, which is the default, a mapped IP (MIP) address or subnet IP (SNIP) address is used as the source IP address to initiate server side connections.
        PathMonitor|pathmonitor|string|Path monitoring for clustering.Possible values = YES, NO
        PathMonitorIndividual|pathmonitorindv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|useproxyport|string|Use the proxy port as the source port when initiating connections with the server. With the NO setting, the client-side connection port is used as the source port for the server-side connection. Note: This parameter is available only when the Use Source IP (USIP) parameter is set to YES. Possible values = YES, NO
        HealthMonitor|healthmonitor|string|Monitor the health of this service. Available settings function as follows:YES - Send probes to check the health of the service. NO - Do not send probes to check the health of the service. With the NO option, the appliance shows the service as UP at all times. Default value: YES. Possible values = YES, NO
        SureConnect|sc|string|State of the SureConnect feature for the service group. Default value: OFF. Possible values = ON, OFF
        SurgeProtection|sp|string|Enable surge protection for the service group. Default value: OFF. Possible values = ON, OFF
        RtspSessionIdRemap|rtspsessionidremap|string|Enable RTSP session ID mapping for the service group. Default value: OFF. Possible values = ON, OFF
        ClientTimeout|clttimeout|double|Time, in seconds, after which to terminate an idle client connection.
        ServerTimeout|svrtimeout|double|Time, in seconds, after which to terminate an idle server connection.
        ClientKeepAlive|cka|string|Enable client keep-alive for the service group. Possible values = YES, NO
        TcpBuffering|tcpb|string|Enable TCP buffering for the service group. Possible values = YES, NO
        Compression|cmp|string|Enable compression for the specified service. Possible values = YES, NO
        MaxBandwidth|maxbandwidth|double|Maximum bandwidth, in Kbps, allocated for all the services in the service group.
        MonitorWeightThreshold|monthreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        DownStateFlush|downstateflush|string|Flush all active transactions associated with all the services in the service group whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|tcpprofilename|string|Name of the TCP profile that contains TCP configuration settings for the service group.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile that contains HTTP configuration settings for the service group.
        Comment|comment|string|Any information about the service group.
        AppFlowLogging|appflowlog|string|Enable logging of AppFlow information for the specified service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|netprofile|string|Network profile for the service group.
        MonConnectionClose|monconnectionclose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN


   * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data

            Eg.
             ```
          var command = NitroCommandFactory.Create\<ServicegroupUpdateCommand> (INitroServiceClient, new \<ServicegroupUpdateRequestData>(){ });
            ```
          
            Where \<ServicegroupUpdateRequestData> is one of types:
             - ServicegroupUpdateHttpRequestData, ServicegroupUpdateTcpRequestData, ServicegroupUpdateDnsRequestData, ServicegroupUpdateDnsTcpRequestData, ServicegroupUpdateSslBridgeRequestData, ServicegroupUpdateSslRequestData, ServicegroupUpdateSslTcpRequestData, ServicegroupUpdateSyslogTcpRequestData, ServicegroupUpdateSyslogUdpRequestData, ServicegroupUpdateUdpRequestData  
            
            These are the premade DataObjects to be used. The applicable properties will be accessible, list above.

   * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for UpdateServicegroups, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 
        

#### ServicegroupBinding

##### general
commands: get

+ Get
    * Properties  

        The following properties van be found in each ServicegroupBindingConfiguration found in the array "ServicegroupBindings" inside of a ServicegroupBindingGetResponse.

        NYI

        Property|DataType|Description
        ---|---|---

##### Servicegroup_Lbmonitor_Binding
Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description
        ---|---|---|---
        ServicegroupName|servicegroupname|string|Name of the Servicegroup.
        Port|port|int|Port number of the service. Each service must have a unique port number.
        MonitorName|montor_name|string|Monitor name.
        MonitorState|monstate|string|Monitor state. Possible values = ENABLED, DISABLED
        Passive|passive|string|Indicates if load monitor is passive. A passive load monitor does not remove service from LB decision when threshold is breached.
        Weight|weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service.
        CustomServerId|customserverid|string|Unique service identifier. Used when the persistency type for the virtual server is set to Custom Server ID. Default value: "None"
        ServerId|serverid|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        State|state|string|Initial state of the service after binding. Default value: ENABLED. Possible values = ENABLED, DISABLED
        HashId|hashid|double|Unique numerical identifier used by hash based load balancing methods to identify a service. Minimum value = 1

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<ServicegroupBindingAddLbmonitorCommand> (INitroServiceClient, new \<ServicegroupBindingAddLbmonitorRequestData>(){ }); 
            ```
            
            These are the premade DataObjects to be used. The applicable properties will be accessible, list above.
    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for servicegroupBindingAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse();  
        ```
      
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each ServicegroupBindingLbmonitorConfiguration found in the array "ServicegroupBindingLbmonitor" inside of a ServicegroupBindingGetLbmonitorResponse.

        NYI

        Property|DataType|Description
        ---|---|---

+ Remove: 

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<ServicegroupBindingRemoveLbmonitorCommand>(INitroServiceClient, new ServicegroupBindingRemoveLbmonitorRequestOptions(){ });
        ```
      
        - Options:  
        For this command, the Options are gathered in an Object ServicegroupBindingRemoveLbmonitorRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove. 
        <u>Arguments</u>: a dictionary of strings in which you will need to add "monitor_name" as key and the name of the monitor you wish to remove as value, and "port":portNumber in the same fashion.
     
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServicegroupBindingRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update:

        NYI

    * Properties:

        Property|ValueType|Description
        ---|---|---

##### Servicegroup_servicegroupmember_Binding

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description
        ---|---|---|---
        ServicegroupName|servicegroupname|string|Name of the Servicegroup.
        Ip|ip|string|IP Address.
        ServerName|servername|string|Name of the server to which to bind the service group.
        Port|port|int|Server port number.
        Weight|weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service. Minimum value = 1. Maximum value = 100
        CustomServerId|customserverid|string|The identifier for this IP:Port pair. Used when the persistency type is set to Custom Server ID. Default value: "None"
        ServerId|serverid|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        State|state|string|Initial state of the service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        HashId|hashid|double|The hash identifier for the service. This must be unique for each service. This parameter is used by hash based load balancing methods.

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<ServicegroupBindingAddServicegroupMemberCommand> (INitroServiceClient, new \<ServicegroupBindingAddServicegroupMemberRequestData>(){ }); 
            ```
            
            These are the premade DataObjects to be used. The applicable properties will be accessible, list above.
    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for servicegroupBindingAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse();  
        ```
      
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each ServicegroupBindingServicegroupMemberConfiguration found in the array "ServicegroupBindingServicegroupMember" inside of a ServicegroupBindingGetServicegroupMemberResponse.

        NYI

        Property|DataType|Description
        ---|---|---

+ Remove: 

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<ServicegroupBindingRemoveServicegroupMemberCommand>(INitroServiceClient, new ServicegroupBindingRemoveServicegroupMemberRequestOptions(){ });
        ```
      
      - Options:  
        For this command, the Options are gathered in an Object ServicegroupBindingRemoveServicegroupMemberRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove from.  
        <u>Arguments</u>: a dictionary<string, string> in which you will need to add some data to specify what to remove. The data to add is as follows: ip: <ip_value> ,servername: <servername_value> ,port: <port_value> 
    
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServicegroupBindingRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update:

        NYI

    * Properties:

        Property|ValueType|Description
        ---|---|---


#### ServicegroupBindings

