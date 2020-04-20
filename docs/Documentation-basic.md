# Documentation

## Commands

### Basic
#### Server
Commands: Add, Get, Remove, Update 

+ Add:  
    * Properties:

        Property   | DataType |  Description | restrictions
        ---|---|---|---
        Name| string | Sets the name of the Server| All
        Domain| string | Sets the Domain of the server |ServerAddByDomainRequestData only
        IpAddress | string | Sets the IP of the server |ServerAddByIpRequestData only
        TranslationIp | string | IP address used to transform the server's DNS-resolved IP address. |ServerAddByDomainRequestData only
        TranslationMask| string| The netmask of the translation ip.| ByDomain only
        DomainResolveRetry| int | Time, in seconds, for which the NetScaler appliance must wait, after DNS resolution fails, before sending the next DNS query to resolve the domain name. Default value: 5 Minimum value = 5 Maximum value = 20939 | ByDomain only
        State| string| Initial State of the server. ENABLED, DISABLED | All
        Ipv6Address| string | Support IPv6 addressing mode. If you configure a server with the IPv6 addressing mode, you cannot use the server in the IPv4 addressing mode. Default value: NO, Possible values = YES, NO | Domain only
        Comment| string | Information| All
        Td| double| Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0. Minimum value = 0, Maximum value = 4094 | All
        QueryType | string | Specify the type of DNS resolution to be done on the configured domain to get the backend services. Valid query types are A, AAAA and SRV with A being the default querytype. The type of DNS resolution done on the domains in SRV records is inherited from ipv6 argument. Possible values: A, AAAA, SRV, Default value: A | All

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

        Property|DataType|Description
        ---|---|---
        Name|string|The name of the server
        Internal|bool| server is for internal use
        IpAddress|string|the IpAddress of the server
        Domain|string|domain of the server
        DomainResolveRetry|int|Time, in seconds, for which the NetScaler appliance must wait, after DNS resolution fails, before sending the next DNS query to resolve the domain name. Default value: 5. Minimum value = 5. Maximum value = 20939
        TranslationIp|string|IP address used to transform the server's DNS-resolved IP address.
        TranslationMask|string|NetMask of the translation Ip.
        Comment|string| Any additional information.
        StateChangedTimeSec|string|Time when last state change happened. Seconds part.
        TicksSinceLastStateChange|string|Time in 10 millisecond ticks since the last state change.
        IpV6Address|string|Support IPv6 addressing mode. If you configure a server with the IPv6 addressing mode, you cannot use the server in the IPv4 addressing mode. Default value: NO. Possible values = YES, NO
        Td|string |Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0. Minimum value = 0. Maximum value = 4094
        AutoScale|string|Auto scale option for a servicegroup. Default value: DISABLED. Possible values = DISABLED, DNS, POLICY
        Usip|string| Use the client's IP address as the source IP address when initiating a connection to the server. Possible values = YES, NO
        Cka|string| Enable Client Keep-Alive. Possible Values = YES, NO.
        TcpB|string|Enable TCP buffering. Possible Values = YES, NO.
        Cmp|string| Enable Comperssion. Possible Values = YES, NO.
        Cacheable| string| Use the transparent cache redirection virtual server to forward the request to the cache server. Default value: NO. Possible values = YES, NO
        Sc|string| State of the SureConnect Feature. Default value: OFF. Possible values = ON, OFF
        Sp|string | Enable Surge Protection. Default value: OFF. Possible values = ON, OFF
        Count| double| Number of servers.

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

        Property|ValueType|Description
        ---|---|---
        Name|string|The name of the server
        IpAddress|string|the IpAddress of the server
        DomainResolveRetry|int|Time, in seconds, for which the NetScaler appliance must wait, after DNS resolution fails, before sending the next DNS query to resolve the domain name. Default value: 5. Minimum value = 5. Maximum value = 20939
        TranslationIp|string|IP address used to transform the server's DNS-resolved IP address.
        TranslationMask|string|NetMask of the translation Ip.
        Comment|string| Any additional information.
        DomainResolveNow|bool|Immediately send a DNS query to resolve the server's domain name.

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

        Property   | DataType |  Description | Applicable to
        ---|---|---|---
        Name|string|Name of the service|all
        Ip|string|Ip of the targetserver|mutually exclusive with ServerName
        ServerName|string|name of the targetserver|mutually exclusive with Ip
        Port|int|port on which the service runs|all
        ClearTextPort|string|- | SSL, SSLTCP
        CacheType|string|- | SSL, SSLTCP
        MaxClient|double|- |all
        HealthMonitor|string|-|all
        MaxReq|double|-|all
        Cacheable|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, SYSLOG_UDP, TCP, UDP
        Cip|string|-|all
        CipHeader|string|-|all
        Usip|string|-|all
        PathMonitor|string|-|-
        PathMonitorIndv|string|-|-
        UseProxyPort|string|-|all
        Sc|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, SYSLOG_UDP, TCP, UDP
        Sp|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, SYSLOG_UDP, TCP, UDP, DNS_TCP
        RtspSessionIdRemap|string|-|-
        CltTimeOut|double|-|all
        SvrTimeout|double|-|all
        CustomServerId|string|-|all
        ServerId|string|-|all
        Cka|string|-|all
        Tcpb|string|-|all
        Cmp|string|-|HTTP, SSL
        MaxBandwidth|double|-|all
        AccessDown|string|-|all
        MonThreshold|double|-|all
        State|string|-|all
        DownStateFlush|string|-|all
        TcpProfileName|string|-|HTTP, SSLBridge, SSL, SSLTCP, SYSLOG_TCP, TCP, DNS_TCP
        HttpProfileName|string|-|HTTP, SSL
        HashId|double|-|all
        Comment|string|-|all
        AppFlowLog|string|-|all
        NetProfile|string|-|all
        Td|double|TrafficDomain|all
        ProcessLocal|string|-|all
        MonConnectionClose|string|-|all
        ContentInspectionProfileName|string|-|all


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

        Property|DataType|Description
        ---|---|---
        Name|string|Name of the service
        Ip|string|Ip of the targetserver
        ServerName|string|name of the targetserver
        Port|int|port on which the service runs
        ClearTextPort|int|Port to which clear text data must be sent after the appliance decrypts incoming SSL traffic. Applicable to transparent SSL services.
        CacheType|string|Cache type supported by the cache server. Possible values = TRANSPARENT, REVERSE, FORWARD
        MaxClient|double|Maximum number of simultaneous open connections to the service.
        HealthMonitor|string|Monitor the health of this service. Available settings function as. Default value: YES. Possible values = YES, NO
        MaxReq|double|Maximum number of requests that can be sent on a persistent connection to the service. 
        Cacheable|string|Use the transparent cache redirection virtual server to forward requests to the cache server. Default value: NO. Possible values = YES, NO
        Cip|string|Before forwarding a request to the service, insert an HTTP header with the client's IPv4 or IPv6 address as its value. Used if the server needs the client's IP address for security, accounting, or other purposes, and setting the Use Source IP parameter is not a viable option. Possible values = ENABLED, DISABLED
        CipHeader|string|Name for the HTTP header whose value must be set to the IP address of the client. 
        Usip|string|Use the client's IP address as the source IP address when initiating a connection to the server. Possible values = YES, NO
        PathMonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|string|Use the proxy port as the source port when initiating connections with the server. Possible values = YES, NO
        Sc|string|State of SureConnect for the service. Default value: OFF. Possible values = ON, OFF
        Sp|string|Enable surge protection for the service. Possible values = ON, OFF
        RtspSessionIdRemap|string|Enable RTSP session ID mapping for the service. Default value: OFF. Possible values = ON, OFF
        CltTimeout|double|Time, in seconds, after which to terminate an idle client connection.
        SvrTimeout|double|Time, in seconds, after which to terminate an idle server connection.
        CustomServerId|string|Unique identifier for the service. Used when the persistency type for the virtual server is set to Custom Server ID. Default value: "None"
        ServerId|string|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        Cka|string|Enable client keep-alive for the service. Possible values = YES, NO
        TcpB|string|Enable TCP buffering for the service. Possible values = YES, NO
        Cmp|string|Enable compression for the service. Possible values = YES, NO
        MaxBandwidth|double|Maximum bandwidth, in Kbps, allocated to the service.
        AccessDown|string|Use Layer 2 mode to bridge the packets sent to this service if it is marked as DOWN. If the service is DOWN, and this parameter is disabled, the packets are dropped. Default value: NO. Possible values = YES, NO
        MonThreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|string|Initial state of the service. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with a service whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|string|Name of the TCP profile that contains TCP configuration settings for the service.
        HttpProfileName|string|Name of the HTTP profile that contains HTTP configuration settings for the service.
        HashId|double|A numerical identifier that can be used by hash based load balancing methods. Must be unique for each service.
        Comment|string|Any information about the service.
        AppFlowLog|string|Enable logging of AppFlow information. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|string|Network profile to use for the service.
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        ProcessLocal|string|By turning on this option packets destined to a service in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DnsProfileName|string|Name of the DNS profile to be associated with the service. DNS profile properties will applied to the transactions processed by a service. This parameter is valid only for ADNS and ADNS-TCP services.
        MonConnectionClose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        RiseApbrStatsMsgCode|int|The code indicating the rise apbr status.
        IpAdress|string|The new IP address of the service.
        Weight|double|Weight to assign to the monitor-service binding. When a monitor is UP, the weight assigned to its binding with the service determines how much the monitor contributes toward keeping the health of the service above the value configured for the Monitor Threshold parameter.
        MonitorNameService|string|Name of the monitor bound to the specified service.
        Delay|double|Time, in seconds, allocated to the NetScaler appliance for a graceful shutdown of the service. 
        Graceful|string|Shut down gracefully, not accepting any new connections, and disabling the service when all of its connections are closed. Default value: NO. Possible values = YES, NO
        All|bool|Display both user-configured and dynamically learned services.
        Internal|bool|Display only dynamically learned services.
        NewName|string|New name for the service. 
        NumOfConnections|int|This will tell the number of client side connections are still open.
        PolicyName|string|The name of the policyname for which this service is bound.
        ServiceConfType|bool|The configuration type of the service.
        ServiceConfType2|string|The configuration type of the service (Internal/Dynamic/Configured). Possible values = Configured, Dynamic, Internal
        Value|string|SSL status. Possible values = Certkey not bound, SSL feature disabled
        Gslb|string|The GSLB option for the corresponding virtual server. Possible values = REMOTE, LOCAL
        DubState|string|Added this field for getting state value from table. Possible values = ENABLED, DISABLED
        DubWeight|string|-
        PublicIp|string|public ip.
        PublicPort|int|public port.
        SvrState|string|The state of the service. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        MonitorState|string|The running state of the monitor on this service. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        MonStatCode|int|The code indicating the monitor response.
        LastResponse|string|The string form of monstatcode.
        ResponseTime|string|Response time of this monitor.
        RiseApbrStatsMsgCode2|int|The code indicating other rise stats.
        MonStatParam1|int|First parameter for use with message code.
        MonStatParam2|int|Second parameter for use with message code.
        MonStatParam3|int|Third parameter for use with message code.
        StateChangeTimeSec|string|Time when last state change happened. Seconds part.
        StateChangeTimeMSec|string|Time at which last state change happened. Milliseconds part.
        TicksSinceLastStateChange|string|Time in 10 millisecond ticks since the last state change.
        StateUpdateReason|string|Checks state update reason on the secondary node.
        ClMonView|string|Tells the mon owner of the service.
        ClMonOwner|string|Tells the view id of the monitoring owner.
        ServiceIpStr|string|This field has been intorduced to show the dbs services ip.
        OracleServerVersion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        FailedProbes|string|-
        TotalProbes|string|-
        TotalFailedProbes|string|-
        MonitorTotalFailedProbes|string|-
        MonitorTotalProbes|string|-
        MonitorCurrentFailedProbes|string|-
        Passive|bool|-
        Count|double|-

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

        Property|ValueType|Description
        ---|---|---
        Name|string|The name of the service
        MaxClient|double|Maximum number of simultaneous open connections to the service.
        HealthMonitor|string|Monitor the health of this service. Available settings function as. Default value: YES. Possible values = YES, NO
        MaxReq|double|Maximum number of requests that can be sent on a persistent connection to the service. 
        IpAdress|string|New IpAdress to assign to service.
        Cip|string|Before forwarding a request to the service, insert an HTTP header with the client's IPv4 or IPv6 address as its value. Used if the server needs the client's IP address for security, accounting, or other purposes, and setting the Use Source IP parameter is not a viable option. Possible values = ENABLED, DISABLED
        CipHeader|string|Name for the HTTP header whose value must be set to the IP address of the client. 
        Usip|string|Use the client's IP address as the source IP address when initiating a connection to the server. Possible values = YES, NO
        PathMonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndividual|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|string|Use the proxy port as the source port when initiating connections with the server. Possible values = YES, NO
        RtspSessionIdRemap|string|Enable RTSP session ID mapping for the service. Default value: OFF. Possible values = ON, OFF
        CltTimeout|double|Time, in seconds, after which to terminate an idle client connection.
        SvrTimeout|double|Time, in seconds, after which to terminate an idle server connection.
        CustomServerId|string|Unique identifier for the service. Used when the persistency type for the virtual server is set to Custom Server ID. Default value: "None"
        ServerId|string|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        Cka|string|Enable client keep-alive for the service. Possible values = YES, NO
        Tcpb|string|Enable TCP buffering for the service. Possible values = YES, NO
        MaxBandwidth|double|Maximum bandwidth, in Kbps, allocated to the service.
        AccessDown|string|Use Layer 2 mode to bridge the packets sent to this service if it is marked as DOWN. If the service is DOWN, and this parameter is disabled, the packets are dropped. Default value: NO. Possible values = YES, NO
        MonitorWeightThreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|string|Initial state of the service. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with a service whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|string|Name of the TCP profile that contains TCP configuration settings for the service.
        Weight|double|Weight to assign to the monitor-service binding. When a monitor is UP, the weight assigned to its binding with the service determines how much the monitor contributes toward keeping the health of the service above the value configured for the Monitor Threshold parameter.
        Monitor_Name_Svc|string|Name of the monitor bound to the specified service. 
        HashId|double|A numerical identifier that can be used by hash based load balancing methods. Must be unique for each service.
        Comment|string|Any information about the service.
        AppFlowLog|string|Enable logging of AppFlow information. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetworkProfile|string|Network profile to use for the service.
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        ProcessLocal|string|By turning on this option packets destined to a service in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        MonConnectionClose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        ContentInspectionProfileName|string|-

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

        Property   | DataType |  Description 
        ---|---|---
        Name|string|name of the service
        Monitor_Name|string|name of the monitor to bind.
        MonState|string|The configured state (enable/disable) of the monitor on this server. Possible values = ENABLED, DISABLED
        Weight|double|The weight of the monitor.
        Passive|bool|Indicates if load monitor is passive. A passive load monitor does not remove service from LB decision when threshold is breached.

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

        Property   | DataType |  Description
        ---|---|---
        ServiceGroupName|string|name of the servicegroup
        ServiceType|string|Protocol used to exchange data with the service. Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, RPCSVR, DNS, ADNS, SNMP, RTSP, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, ADNS_TCP, MYSQL, MSSQL, ORACLE, RADIUS, RADIUSListener, RDP, DIAMETER, SSL_DIAMETER, TFTP, SMPP, PPTP, GRE, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, USER_TCP, USER_SSL_TCP, QUIC. Gets automatically assigned when choosing which data to use.
        CacheType|string|Cache type supported by the cache server. Possible values = TRANSPARENT, REVERSE, FORWARD
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        MaxClient|double|Maximum number of simultaneous open connections for the service group.
        MaxReq|double|Maximum number of requests that can be sent on a persistent connection to the service group. Note: Connection requests beyond this value are rejected.
        Cacheable|string|Use the transparent cache redirection virtual server to forward the request to the cache server. Note: Do not set this parameter if you set the Cache Type. Default value: NO. Possible values = YES, NO
        Cip|string|Insert the Client IP header in requests forwarded to the service. Possible values = ENABLED, DISABLED
        CipHeader|string|Name of the HTTP header whose value must be set to the IP address of the client. Used with the Client IP parameter. If client IP insertion is enabled, and the client IP header is not specified, the value of Client IP Header parameter or the value set by the set ns config command is used as client's IP header name.
        Usip|string|Use client's IP address as the source IP address when initiating connection to the server. With the NO setting, which is the default, a mapped IP (MIP) address or subnet IP (SNIP) address is used as the source IP address to initiate server side connections. Possible values = YES, NO
        PathMonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|string|Use the proxy port as the source port when initiating connections with the server. With the NO setting, the client-side connection port is used as the source port for the server-side connection. Note: This parameter is available only when the Use Source IP (USIP) parameter is set to YES. Possible values = YES, NO
        HealthMonitor|string|Monitor the health of this service. Available settings function as follows: YES - Send probes to check the health of the service. NO - Do not send probes to check the health of the service. With the NO option, the appliance shows the service as UP at all times. Default value: YES. Possible values = YES, NO
        Sc|string|State of the SureConnect feature for the service group. Default value: OFF. Possible values = ON, OFF
        Sp|string|Enable surge protection for the service group. Default value: OFF. Possible values = ON, OFF
        RtspSessionIdRemap|string|Enable RTSP session ID mapping for the service group. Default value: OFF. Possible values = ON, OFF
        CltTimeout|double|Time, in seconds, after which to terminate an idle client connection.
        SvrTimeout|double|Time, in seconds, after which to terminate an idle server connection.
        Cka|string|Enable client keep-alive for the service group. Possible values = YES, NO
        Tcpb|string|Enable TCP buffering for the service group. Possible values = YES, NO
        Cmp|string|Enable compression for the service group. Possible values = YES, NO
        MaxBandwidth|double|Maximum bandwidth, in Kbps, allocated for all the services in the service group.
        MonThreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|string|Initial state of the service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with all the services in the service group whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|string|Name of the TCP profile that contains TCP configuration settings for the service group.
        HttpProfileName|string|Name of the HTTP profile that contains HTTP configuration settings for the service group.
        Comment|string|Any information about the service group.
        AppFlowLog|string|Enable logging of AppFlow information for the specified service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|string|Network profile for the service group.
        AutoScale|string|Auto scale option for a servicegroup. Default value: DISABLED. Possible values = DISABLED, DNS, POLICY
        MemberPort|int|member port.
        MonConnectionClose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        AutoDisableDelay|double|-
        AutoDisableGraceful|string|-

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

        Property|DataType|Description
        ---|---|---
        ServiceGroupName|string|name of the servicegroup
        ServiceType|string|Protocol used to exchange data with the service. Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, RPCSVR, DNS, ADNS, SNMP, RTSP, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, ADNS_TCP, MYSQL, MSSQL, ORACLE, RADIUS, RADIUSListener, RDP, DIAMETER, SSL_DIAMETER, TFTP, SMPP, PPTP, GRE, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, USER_TCP, USER_SSL_TCP, QUIC. Gets automatically assigned when choosing which data to use.
        CacheType|string|Cache type supported by the cache server. Possible values = TRANSPARENT, REVERSE, FORWARD
        TrafficDomain|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        MaxClient|double|Maximum number of simultaneous open connections for the service group.
        MaxReq|double|Maximum number of requests that can be sent on a persistent connection to the service group. Note: Connection requests beyond this value are rejected.
        Cacheable|string|Use the transparent cache redirection virtual server to forward the request to the cache server. Note: Do not set this parameter if you set the Cache Type. Default value: NO. Possible values = YES, NO
        Cip|string|Insert the Client IP header in requests forwarded to the service. Possible values = ENABLED, DISABLED
        CipHeader|string|Name of the HTTP header whose value must be set to the IP address of the client. Used with the Client IP parameter. If client IP insertion is enabled, and the client IP header is not specified, the value of Client IP Header parameter or the value set by the set ns config command is used as client's IP header name.
        Usip|string|Use client's IP address as the source IP address when initiating connection to the server. With the NO setting, which is the default, a mapped IP (MIP) address or subnet IP (SNIP) address is used as the source IP address to initiate server side connections. Possible values = YES, NO
        PathMonitor|string|Path monitoring for clustering. Possible values = YES, NO
        PathMonitorIndv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|string|Use the proxy port as the source port when initiating connections with the server. With the NO setting, the client-side connection port is used as the source port for the server-side connection. Note: This parameter is available only when the Use Source IP (USIP) parameter is set to YES. Possible values = YES, NO
        HealthMonitor|string|Monitor the health of this service. Available settings function as follows: YES - Send probes to check the health of the service. NO - Do not send probes to check the health of the service. With the NO option, the appliance shows the service as UP at all times. Default value: YES. Possible values = YES, NO
        Sc|string|State of the SureConnect feature for the service group. Default value: OFF. Possible values = ON, OFF
        Sp|string|Enable surge protection for the service group. Default value: OFF. Possible values = ON, OFF
        RtspSessionIdRemap|string|Enable RTSP session ID mapping for the service group. Default value: OFF. Possible values = ON, OFF
        CltTimeout|double|Time, in seconds, after which to terminate an idle client connection.
        SvrTimeout|double|Time, in seconds, after which to terminate an idle server connection.
        Cka|string|Enable client keep-alive for the service group. Possible values = YES, NO
        TcpB|string|Enable TCP buffering for the service group. Possible values = YES, NO
        Cmp|string|Enable compression for the service group. Possible values = YES, NO
        MaxBandwidth|double|Maximum bandwidth, in Kbps, allocated for all the services in the service group.
        MonThreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        State|string|Initial state of the service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with all the services in the service group whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|string|Name of the TCP profile that contains TCP configuration settings for the service group.
        HttpProfileName|string|Name of the HTTP profile that contains HTTP configuration settings for the service group.
        Comment|string|Any information about the service group.
        AppFlowLog|string|Enable logging of AppFlow information for the specified service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfileName|string|Network profile for the service group.
        AutoScale|string|Auto scale option for a servicegroup. Default value: DISABLED. Possible values = DISABLED, DNS, POLICY
        MemberPort|int|member port.
        MonConnectionClose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN
        AutoDisableDelay|double|-
        AutoDisableGraceful|string|-
        ServerName|string|Name of the server to which to bind the service group.
        Port|int|Server port number.
        Weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service. Minimum value = 1. Maximum value = 100
        CustomServerId|string|The identifier for this IP:Port pair. Used when the persistency type is set to Custom Server ID. Default value: "None"
        ServerId|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        HashId|double|The hash identifier for the service. This must be unique for each service. This parameter is used by hash based load balancing methods.
        MonitorNameService|string|Name of the monitor bound to the service group. Used to assign a weight to the monitor.
        DupWeight|double|weight of the monitor that is bound to servicegroup.
        RiseApbrStatsMsgCode|int|The code indicating the rise apbr status.
        Delay|double|Time, in seconds, allocated for a shutdown of the services in the service group. During this period, new requests are sent to the service only for clients who already have persistent sessions on the appliance. Requests from new clients are load balanced among other available services. After the delay time expires, no requests are sent to the service, and the service is marked as unavailable (OUT OF SERVICE).
        Graceful|string|Wait for all existing connections to the service to terminate before shutting down the service. Default value: NO. Possible values = YES, NO
        IncludeMembers|bool|Display the members of the listed service groups in addition to their settings. Can be specified when no service group name is provided in the command. In that case, the details displayed for each service group are identical to the details displayed when a service group name is provided, except that bound monitors are not displayed.
        NumOfConnections|int|This will tell the number of client side connections are still open.
        ServiceConfType|bool|The configuration type of the service group.
        Value|string|SSL Status. Possible values = Certkey not bound, SSL feature disabled
        SvrState|string|The state of the service. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        Ip|string|IP Address.
        MonStatCode|int|The code indicating the monitor response.
        MonStatParam1|int|First parameter for use with message code.
        MonStatParam2|int|Second parameter for use with message code.
        MonStatParam3|int|Third parameter for use with message code.
        StateChangeTimeMSec|string|Time when last state change occurred. Milliseconds part.
        StateUpdateReason|string|Checks state update reason on the secondary node.
        ClMonOwner|string|Tells the mon owner of the service.
        ClMonView|string|Tells the view id of the monitoring owner.
        GroupCount|string|Servicegroup Count.
        RiseApbrStatsMsgCode2|int|The code indicating other rise stats.
        ServiceIpStr|string|This field has been intorduced to show the dbs services ip.
        ServicegroupEffectiveState|string|Indicates the effective servicegroup state based on the state of the bound service items.If all services are UP the effective state is UP, if all are DOWN its DOWN,if all are OFS its OFS.If atleast one serviceis UP and rest are either DOWN or OFS, the effective state is PARTIAL-UP.If atleast one bound service is DOWN and rest are OFS the effective state is PARTIAL DOWN. Possible values = UP, DOWN, OUT OF SERVICE, PARTIAL-UP, PARTIAL-DOWN
        MonitorWeight|string|-
        MonitorState|string|-
        MonitorTotalProbes|string|-
        MonitorTotalFailedProbes|string|-
        MonitorCurrentFailedProbes|string|-
        StateChangeTimeSec|string|-
        NoDefaultBindings|string|-
        NameServer|string|-
        Dbsttl|double|-
        SvcItmactscvs|string|-
        SvcitmBoundSvcs|string|-
        ResponseTime|string|-
        Count|int|-

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

        Property|ValueType|Description
        ---|---|---
        ServicegroupName|string|Name of the Servicegroup
        ServerName|string|Name of the server to which to bind the service group.
        Port|int|Server port number.
        Weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service. Minimum value = 1. Maximum value = 100
        CustomServerId|string|The identifier for this IP:Port pair. Used when the persistency type is set to Custom Server ID. Default value: "None"
        ServerId|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        HashId|double|The hash identifier for the service. This must be unique for each service. This parameter is used by hash based load balancing methods.
        Monitor_Name_Svc|string|Name of the monitor bound to the service group. Used to assign a weight to the monitor.
        Dup_Weight|double|weight of the monitor that is bound to servicegroup.
        MaxClient|double|Maximum number of simultaneous open connections for the service group.
        MaxReq|double|Maximum number of requests that can be sent on a persistent connection to the service group. Note: Connection requests beyond this value are rejected.
        Cip|string|Insert the Client IP header in requests forwarded to the service. Possible values = ENABLED, DISABLED
        CipHeader|string|Name of the HTTP header whose value must be set to the IP address of the client. Used with the Client IP parameter. If client IP insertion is enabled, and the client IP header is not specified, the value of Client IP Header parameter or the value set by the set ns config command is used as client's IP header name.
        Usip|string|Use client's IP address as the source IP address when initiating connection to the server. With the NO setting, which is the default, a mapped IP (MIP) address or subnet IP (SNIP) address is used as the source IP address to initiate server side connections.
        PathMonitor|string|Path monitoring for clustering.Possible values = YES, NO
        PathMonitorIndv|string|Individual Path monitoring decisions. Possible values = YES, NO
        UseProxyPort|string|Use the proxy port as the source port when initiating connections with the server. With the NO setting, the client-side connection port is used as the source port for the server-side connection. Note: This parameter is available only when the Use Source IP (USIP) parameter is set to YES. Possible values = YES, NO
        HealthMonitor|string|Monitor the health of this service. Available settings function as follows:YES - Send probes to check the health of the service. NO - Do not send probes to check the health of the service. With the NO option, the appliance shows the service as UP at all times. Default value: YES. Possible values = YES, NO
        Sc|string|State of the SureConnect feature for the service group. Default value: OFF. Possible values = ON, OFF
        Sp|string|Enable surge protection for the service group. Default value: OFF. Possible values = ON, OFF
        RtspSessionIdRemap|string|Enable RTSP session ID mapping for the service group. Default value: OFF. Possible values = ON, OFF
        CltTimeout|double|Time, in seconds, after which to terminate an idle client connection.
        SvrTimeout|double|Time, in seconds, after which to terminate an idle server connection.
        Cka|string|Enable client keep-alive for the service group. Possible values = YES, NO
        Tcpb|string|Enable TCP buffering for the service group. Possible values = YES, NO
        Cmp|string|Enable compression for the specified service. Possible values = YES, NO
        MaxBandwidth|double|Maximum bandwidth, in Kbps, allocated for all the services in the service group.
        MonThreshold|double|Minimum sum of weights of the monitors that are bound to this service. Used to determine whether to mark a service as UP or DOWN.
        DownStateFlush|string|Flush all active transactions associated with all the services in the service group whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        TcpProfileName|string|Name of the TCP profile that contains TCP configuration settings for the service group.
        HttpProfileName|string|Name of the HTTP profile that contains HTTP configuration settings for the service group.
        Comment|string|Any information about the service group.
        AppFlowLog|string|Enable logging of AppFlow information for the specified service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|string|Network profile for the service group.
        MonConnectionClose|string|Close monitoring connections by sending the service a connection termination message with the specified bit set. Default value: NONE. Possible values = RESET, FIN


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

        Property   | DataType |  Description
        ---|---|---
        ServicegroupName|string|Name of the Servicegroup.
        Port|int|Port number of the service. Each service must have a unique port number.
        Monitor_Name|string|Monitor name.
        MonState|string|Monitor state. Possible values = ENABLED, DISABLED
        Passive|string|Indicates if load monitor is passive. A passive load monitor does not remove service from LB decision when threshold is breached.
        Weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service.
        CustomServerId|string|Unique service identifier. Used when the persistency type for the virtual server is set to Custom Server ID. Default value: "None"
        ServerId|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        State|string|Initial state of the service after binding. Default value: ENABLED. Possible values = ENABLED, DISABLED
        HashId|double|Unique numerical identifier used by hash based load balancing methods to identify a service. Minimum value = 1

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

        Property   | DataType |  Description
        ---|---|---
        ServicegroupName|string|Name of the Servicegroup.
        Ip|string|IP Address.
        ServerName|string|Name of the server to which to bind the service group.
        Port|int|Server port number.
        Weight|double|Weight to assign to the servers in the service group. Specifies the capacity of the servers relative to the other servers in the load balancing configuration. The higher the weight, the higher the percentage of requests sent to the service. Minimum value = 1. Maximum value = 100
        CustomServerId|string|The identifier for this IP:Port pair. Used when the persistency type is set to Custom Server ID. Default value: "None"
        ServerId|double|The identifier for the service. This is used when the persistency type is set to Custom Server ID.
        State|string|Initial state of the service group. Default value: ENABLED. Possible values = ENABLED, DISABLED
        HashId|double|The hash identifier for the service. This must be unique for each service. This parameter is used by hash based load balancing methods.

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
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
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

