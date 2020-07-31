### ContentSwitching

#### Csaction
Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|Name for the content switching action.
        TargetLoadBalancingVirtualServer|targetlbvserver|string|Name of the load balancing virtual server to which the content is switched.
        TargetVirtualServer|targetvserver|string|Name of the VPN virtual server to which the content is switched.
        TargetVirtualServerExpression|targetvserverexpr|string|Information about this content switching action.
        Comment|comment|string|Comments associated with this cs action.


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CsactionAddCommand> (INitroServiceClient, new CsactionAddRequestData(){ });
            ```
          
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for CsactionAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse();  
        ```
     
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each CsactionConfiguration found in the array "Csactions" inside of a CsactionGetResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name for the content switching action. 
        TargetLoadBalancingVirtualServer|targetlbvserver|string|Name of the load balancing virtual server to which the content is switched.
        TargetVirtualServer|targetvserver|string|Name of the VPN virtual server to which the content is switched.
        TargetVirtualServerExpression|targetvserverexpr|string|Information about this content switching action.
        Comment|comment|string|Comments associated with this cs action.
        Hits|hits|string|The number of times the action has been taken.
        ReferrenceCount|referencecount|string|The number of references to the action.
        UndefinedHits|undefhits|string|The number of times the action resulted in UNDEF.
        BuiltIn|builtin|string[]|Possible values = MODIFIABLE, DELETABLE, IMMUTABLE, PARTITION_ALL
        Feature|feature|string|-
        Count|__count|double|Count Parameter.

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<CsactionGetCommand>(INitroServiceClient, New CsactionGetRequestOptions(){ });
        ```
        
      - Options:  
        For this command, the Options are gathered in an Object CsactionGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsactionGet, that object is <u>CsactionGetResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Csactions: an array of CsactionConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<CsactionRemoveCommand>(INitroServiceClient, new CsactionRemoveRequestOptions(){ });
        ```
      
      - Options:  
        For this command, the Options are gathered in an Object CsactionRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsactionRemove, that object is <u>NitroResponse</u>.

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
        Name|name|string|Name for the content switching action. 
        TargetLoadBalancingVirtualServer|targetlbvserver|string|Name of the load balancing virtual server to which the content is switched.
        TargetVirtualServer|targetvserver|string|Name of the VPN virtual server to which the content is switched.
        TargetVirtualServerExpression|targetvserverexpr|string|Information about this content switching action.
        Comment|comment|string|Comments associated with this cs action.


   * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (CsactionUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CsactionUpdateCommand> (INitroServiceClient, new CsactionUpdateRequestData(){ });
            ```
          
            Inside the CsactionUpdateRequestData-item, the properties mentioned above will be accessible to change.

   * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsactionUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse(); 
        ```
     
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


#### Cspolicy

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description
        ---|---|---|---
        PolicyName|policyname|string|Name for the content switching policy. 
        Url|url|string|URL string that is matched with the URL of a request. Can contain a wildcard character. Specify the string value in the following format: [[prefix] [*]] [.suffix].
        Rule|rule|string|Expression, or name of a named expression, against which traffic is evaluated. Written in the classic or default syntax. 
        Domain|domain|string|The domain name. The string value can range to 63 characters.
        Action|action|string|Content switching action that names the target load balancing virtual server to which the traffic is switched.
        LogAction|logaction|string|The log action associated with the content switching policy.


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CspolicyAddCommand> (INitroServiceClient, new CspolicyAddRequestData(){ });
            ```
          
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for CspolicyAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse();  
        ```
     
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each CspolicyConfiguration found in the array "Cspolicies" inside of a CspolicyGetResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---
        PolicyName|policyname|string|Name for the content switching policy. 
        Url|url|string|URL string that is matched with the URL of a request. Can contain a wildcard character. Specify the string value in the following format: [[prefix] [*]] [.suffix].
        Rule|rule|string|Expression, or name of a named expression, against which traffic is evaluated. Written in the classic or default syntax. 
        Domain|domain|string|The domain name. The string value can range to 63 characters.
        Action|action|string|Content switching action that names the target load balancing virtual server to which the traffic is switched.
        LogAction|logaction|string|The log action associated with the content switching policy.
        VirtualServerType|vstype|string|Virtual server type.
        Hits|hits|string|Total number of hits.
        BindHits|bindhits|string|Total number of hits.
        PiHits|pihits|string|-
        PolicyHits|pipolicyhits|string|-
        LabelName|labelname|string|Name of the label invoked.
        LabelType|labeltype|string|The invocation type. Possible values = reqvserver, resvserver, policylabel
        Priority|priority|string|priority of bound policy.
        ActivePolicy|activepolicy|bool|Indicates whether policy is bound or not.
        ContentSwitchingPolicyType|cspolicytype|string|Indicates whether policy is PI or not.(used only during display).Possible values = Classic Policy, Advanced Policy
        Count|__count|double|Count Parameter.

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<CspolicyGetCommand>(INitroServiceClient, New CspolicyGetRequestOptions(){ });
        ```
      
      - Options:  
        For this command, the Options are gathered in an Object CspolicyGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CspolicyGet, that object is <u>CspolicyGetResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Cspolicies: an array of CspolicyConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<CspolicyRemoveCommand>(INitroServiceClient, new CspolicyRemoveRequestOptions(){ });
        ```
      
      - Options:  
        For Servers, the Options are gathered in an Object CspolicyRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CspolicyRemove, that object is <u>NitroResponse</u>.

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
        PolicyName|policyname|string|Name for the content switching policy. 
        Url|url|string|URL string that is matched with the URL of a request. Can contain a wildcard character. Specify the string value in the following format: [[prefix] [*]] [.suffix].
        Rule|rule|string|Expression, or name of a named expression, against which traffic is evaluated. Written in the classic or default syntax. 
        Domain|domain|string|The domain name. The string value can range to 63 characters.
        Action|action|string|Content switching action that names the target load balancing virtual server to which the traffic is switched.
        LogAction|logaction|string|The log action associated with the content switching policy.


   * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (CspolicyUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CspolicyUpdateCommand> (INitroServiceClient, new CspolicyUpdateRequestData(){ });
            ```
          
            Inside the CspolicyUpdateRequestData-item, the properties mentioned above will be accessible to change.

   * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CspolicyUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse(); 
        ```
     
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 

#### Csvserver

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description
        ---|---|---|---
        Name|name|string|Name for the content switching virtual server. 
        ServiceType|servicetype|string|Protocol used by the virtual server. Possible values = HTTP, SSL, TCP, FTP, RTSP, SSL_TCP, UDP, DNS, SIP_UDP, SIP_TCP, SIP_SSL, ANY, RADIUS, RDP, MYSQL, MSSQL, DIAMETER, SSL_DIAMETER, DNS_TCP, ORACLE, SMPP, PROXY. Automatically assigned when choosing which data to add.
        IpVersion4Or6Value|ipv46|string|IP address of the content switching virtual server.
        Port|port|int|Port number for content switching virtual server.
        IpPattern|ippattern|string|IP address pattern, in dotted decimal notation, for identifying packets to be accepted by the virtual server. The IP Mask parameter specifies which part of the destination IP address is matched against the pattern. Mutually exclusive with the IP Address parameter. For example, if the IP pattern assigned to the virtual server is 198.51.100.0 and the IP mask is 255.255.240.0 (a forward mask), the first 20 bits in the destination IP addresses are matched with the first 20 bits in the pattern. The virtual server accepts requests with IP addresses that range from 198.51.96.1 to 198.51.111.254. You can also use a pattern such as 0.0.2.2 and a mask such as 0.0.255.255 (a reverse mask).If a destination IP address matches more than one IP pattern, the pattern with the longest match is selected, and the associated virtual server processes the request. For example, if the virtual servers, vs1 and vs2, have the same IP pattern, 0.0.100.128, but different IP masks of 0.0.255.255 and 0.0.224.255, a destination IP address of 198.51.100.128 has the longest match with the IP pattern of vs1. If a destination IP address matches two or more virtual servers to the same extent, the request is processed by the virtual server whose port number matches the port number in the request.
        IpMask|ipmask|string|IP mask, in dotted decimal notation, for the IP Pattern parameter. Can have leading or trailing non-zero octets (for example, 255.255.240.0 or 0.0.255.255). Accordingly, the mask specifies whether the first n bits or the last n bits of the destination IP address in a client request are to be matched with the corresponding bits in the IP pattern. The former is called a forward mask. The latter is called a reverse mask.
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        TargetType|targettype|string|Virtual server target type. Possible values = GSLB
        DnsRecordType|dnsrecordtype|string|Default value: NSGSLB_IPV4. Possible values = A, AAAA, CNAME, NAPTR
        PersistenceId|persistenceid|double|-
        Range|range|double|Number of consecutive IP addresses, starting with the address specified by the IP Address parameter, to include in a range of addresses assigned to this virtual server.
        State|state|string|Initial state of the load balancing virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        StateUpdate|stateupdate|string|Enable state updates for a specific content switching virtual server. By default, the Content Switching virtual server is always UP, regardless of the state of the Load Balancing virtual servers bound to it. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Cacheable|cacheable|string|Use this option to specify whether a virtual server, used for load balancing or content switching, routes requests to the cache redirection virtual server before sending it to the configured servers. Default value: NO. Possible values = YES, NO
        RedirectUrl|redirecturl|string|URL to which traffic is redirected if the virtual server becomes unavailable. The service type of the virtual server should be either HTTP or SSL. Caution: Make sure that the domain in the URL does not match the domain specified for a content switching policy. If it does, requests are continuously redirected to the unavailable virtual server.
        ClienttTimeout|clttimeout|double|Idle time, in seconds, after which the client connection is terminated. The default values are:180 seconds for HTTP/SSL-based services.9000 seconds for other TCP-based services.120 seconds for DNS-based services.120 seconds for other UDP-based services.
        Precedence|precedence|string|Type of precedence to use for both RULE-based and URL-based policies on the content switching virtual server. With the default (RULE) setting, incoming requests are evaluated against the rule-based content switching policies. If none of the rules match, the URL in the request is evaluated against the URL-based content switching policies.Default value: RULE Possible values = RULE, URL
        CaseSensitive|casesensitive|string|Consider case in URLs (for policies that use URLs instead of RULES). For example, with the ON setting, the URLs /a/1.html and /A/1.HTML are treated differently and can have different targets (set by content switching policies). With the OFF setting, /a/1.html and /A/1.HTML are switched to the same target. Default value: ON. Possible values = ON, OFF
        SpillOverMethod|somethod|string|Type of spillover used to divert traffic to the backup virtual server when the primary virtual server reaches the spillover threshold. Connection spillover is based on the number of connections. Bandwidth spillover is based on the total Kbps of incoming and outgoing traffic. Possible values = CONNECTION, DYNAMICCONNECTION, BANDWIDTH, HEALTH, NONE
        SpillOverPersistence|sopersistence|string|Maintain source-IP based persistence on primary and backup virtual servers. Default value: DISABLED. Possible values = ENABLED, DISABLED
        SpillOverPersistenceTimeout|sopersistencetimeout|double|Time-out value, in minutes, for spillover persistence.
        SpillOverThreshold|sothreshold|double|Depending on the spillover method, the maximum number of connections or the maximum total bandwidth (Kbps) that a virtual server can handle before spillover occurs.
        SpillOverBackupAction|sobackupaction|string|Action to be performed if spillover is to take effect, but no backup chain to spillover is usable or exists. Possible values = DROP, ACCEPT, REDIRECT
        RedirectPortRewrite|redirectportrewrite|string|State of port rewrite while performing HTTP redirect. Default value: DISABLED Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with a virtual server whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        BackupVirtualServer|backupvserver|string|Name of the backup virtual server that you are configuring.
        DisablePrimaryOnDown|disableprimaryondown|string|Continue forwarding the traffic to backup virtual server even after the primary server comes UP from the DOWN state. Default value: DISABLED Possible values = ENABLED, DISABLED
        InsertVirtualServerIpPort|insertvserveripport|string|Insert the virtual server's VIP address and port number in the request header. Available values function as follows: VIPADDR - Header contains the vserver's IP address and port number without any translation. OFF - The virtual IP and port header insertion option is disabled. V6TOV4MAPPING - Header contains the mapped IPv4 address corresponding to the IPv6 address of the vserver and the port number. An IPv6 address can be mapped to a user-specified IPv4 address using the set ns ip6 command.Possible values = OFF, VIPADDR, V6TOV4MAPPING
        VirtualServerIpAndPortHeader|vipheader|string|Name of virtual server IP and port header, for use with the VServer IP Port Insertion parameter.
        Rtspnat|rtspnat|string|Enable network address translation (NAT) for real-time streaming protocol (RTSP) connections. Default value: OFF. Possible values = ON, OFF
        ListenPolicy|listenpolicy|string|String specifying the listen policy for the content switching virtual server. Can be either the name of an existing expression or an in-line expression. Default value: "NONE"
        ListenPriority|listenpriority|double|Integer specifying the priority of the listen policy. A higher number specifies a lower priority. If a request matches the listen policies of more than one virtual server the virtual server whose listen policy has the highest priority (the lowest priority number) accepts the request. Default value: 101. Minimum value = 0. Maximum value = 100
        AuthenticationHost|authenticationhost|string|FQDN of the authentication virtual server. The service type of the virtual server should be either HTTP or SSL.
        Authentication|authentication|string|Authenticate users who request a connection to the content switching virtual server. Default value: OFF. Possible values = ON, OFF
        AuthenticationWithHttp401|authn401|string|Enable HTTP 401-response based authentication. Default value: OFF. Possible values = ON, OFF
        AuthenticationVirtualServerName|authnvsname|string|Name of authentication virtual server that authenticates the incoming user requests to this content switching virtual server.
        Push|push|string|Process traffic with the push virtual server that is bound to this content switching virtual server (specified by the Push VServer parameter). The service type of the push virtual server should be either HTTP or SSL. Default value: DISABLED. Possible values = ENABLED, DISABLED
        PushVirtualServer|pushvserver|string|Name of the load balancing virtual server, of type PUSH or SSL_PUSH, to which the server pushes updates received on the client-facing load balancing virtual server.
        PushLabel|pushlabel|string|Expression for extracting the label from the response received from server. This string can be either an existing rule name or an inline expression. The service type of the virtual server should be either HTTP or SSL. Default value: "none"
        PushMulticlients|pushmulticlients|string|Allow multiple Web 2.0 connections from the same client to connect to the virtual server and expect updates. Default value: NO. Possible values = YES, NO
        TcpProfileName|tcpprofilename|string|Name of the TCP profile containing TCP configuration settings for the virtual server.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile containing HTTP configuration settings for the virtual server.
        DbProfileName|dbprofilename|string|Name of the DB profile.
        OracleServerVersion|oracleserverversion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        Comment|comment|string|Information about this virtual server.
        MsSqlServerVersion|mssqlserverversion|string|The version of the MSSQL server. Default value: 2008R2. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        UseL2ConnectionParameters|l2conn|string|Use L2 Parameters to identify a connection. Possible values = ON, OFF
        MySqlProtocolVersion|mysqlprotocolversion|double|The protocol version returned by the mysql vserver. Default value: 10
        MySqlServerVersion|mysqlserverversion|string|The server version string returned by the mysql vserver.
        MySqlCharacterSet|mysqlcharacterset|double|The character set returned by the mysql vserver. Default value: 8
        MySqlServerCapabilities|mysqlservercapabilities|double|The server capabilities returned by the mysql vserver. Default value: 41613
        AppFlowLogging|appflowlog|string|Enable logging appflow flow information. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|netprofile|string|The name of the network profile.
        IcmpvsrResponse|icmpvsrresponse|string|Can be active or passive. Default value: PASSIVE Possible values = PASSIVE, ACTIVE
        RouteHostInjectionState|rhistate|string|A host route is injected according to the setting on the virtual servers * If set to PASSIVE on all the virtual servers that share the IP address, the appliance always injects the hostroute. * If set to ACTIVE on all the virtual servers that share the IP address, the appliance injects even if one virtual server is UP. * If set to ACTIVE on some virtual servers and PASSIVE on the others, the appliance, injects even if one virtual server set to ACTIVE is UP. Default value: PASSIVE Possible values = PASSIVE, ACTIVE
        AuthenticationProfile|authnprofile|string|Name of the authentication profile to be used when authentication is turned on.
        DnsProfileName|dnsprofilename|string|Name of the DNS profile to be associated with the VServer. DNS profile properties will applied to the transactions processed by a VServer. This parameter is valid only for DNS and DNS-TCP VServers.


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CsvserverAddCommand> (INitroServiceClient, new CsvserverAddRequestData(){ });
            ```
          
            Where CsvserverAddRequestData is one of:
            - CsvserverAddDnsRequestData, CsvserverAddDnsTcpRequestData, CsvserverAddHttpRequestData, CsvserverAddSslRequestData, CsvserverAddSslTcpRequestData, CsvserverAddTcpRequestData, CsvserverAddUdpRequestData


    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for CsvserverAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse();  
        ```
     
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each CsvserverConfiguration found in the array "Csvservers" inside of a CsvserverGetResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name for the content switching virtual server. 
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        ServiceType|servicetype|string|Protocol used by the virtual server. Possible values = HTTP, SSL, TCP, FTP, RTSP, SSL_TCP, UDP, DNS, SIP_UDP, SIP_TCP, SIP_SSL, ANY, RADIUS, RDP, MYSQL, MSSQL, DIAMETER, SSL_DIAMETER, DNS_TCP, ORACLE, SMPP, PROXY
        IpVersion4Or6Value|ipv46|string|IP address of the content switching virtual server.
        TargetType|targettype|string|Virtual server target type. Possible values = GSLB
        DnsRecordType|dnsrecordtype|string|Default value: NSGSLB_IPV4. Possible values = A, AAAA, CNAME, NAPTR
        PersistenceId|persistenceid|double|-
        IpPattern|ippattern|string|IP address pattern, in dotted decimal notation, for identifying packets to be accepted by the virtual server. The IP Mask parameter specifies which part of the destination IP address is matched against the pattern. Mutually exclusive with the IP Address parameter. For example, if the IP pattern assigned to the virtual server is 198.51.100.0 and the IP mask is 255.255.240.0 (a forward mask), the first 20 bits in the destination IP addresses are matched with the first 20 bits in the pattern. The virtual server accepts requests with IP addresses that range from 198.51.96.1 to 198.51.111.254. You can also use a pattern such as 0.0.2.2 and a mask such as 0.0.255.255 (a reverse mask). If a destination IP address matches more than one IP pattern, the pattern with the longest match is selected, and the associated virtual server processes the request. For example, if the virtual servers, vs1 and vs2, have the same IP pattern, 0.0.100.128, but different IP masks of 0.0.255.255 and 0.0.224.255, a destination IP address of 198.51.100.128 has the longest match with the IP pattern of vs1. If a destination IP address matches two or more virtual servers to the same extent, the request is processed by the virtual server whose port number matches the port number in the request.
        IpMask|ipmask|string|IP mask, in dotted decimal notation, for the IP Pattern parameter. Can have leading or trailing non-zero octets (for example, 255.255.240.0 or 0.0.255.255). Accordingly, the mask specifies whether the first n bits or the last n bits of the destination IP address in a client request are to be matched with the corresponding bits in the IP pattern. The former is called a forward mask. The latter is called a reverse mask.
        Range|range|string|Number of consecutive IP addresses, starting with the address specified by the IP Address parameter, to include in a range of addresses assigned to this virtual server.
        Port|port|int|Port number for content switching virtual server.
        State|state|string|Initial state of the load balancing virtual server. Default value: ENABLED  Possible values = ENABLED, DISABLED
        StateUpdate|stateupdate|string|Enable state updates for a specific content switching virtual server. By default, the Content Switching virtual server is always UP, regardless of the state of the Load Balancing virtual servers bound to it. If you want to enable state updates for only some content switching virtual servers, be sure to disable the state update parameter. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Cacheable|cacheable|string|Use this option to specify whether a virtual server, used for load balancing or content switching, routes requests to the cache redirection virtual server before sending it to the configured servers. Default value: NO. Possible values = YES, NO
        RedirectUrl|redirecturl|string|URL to which traffic is redirected if the virtual server becomes unavailable. The service type of the virtual server should be either HTTP or SSL. Caution: Make sure that the domain in the URL does not match the domain specified for a content switching policy. If it does, requests are continuously redirected to the unavailable virtual server.
        ClientTimeout|clttimeout|string|Idle time, in seconds, after which the client connection is terminated. The default values are: 180 seconds for HTTP/SSL-based services. 9000 seconds for other TCP-based services. 120 seconds for DNS-based services. 120 seconds for other UDP-based services.
        Precedence|precedence|string|Type of precedence to use for both RULE-based and URL-based policies on the content switching virtual server. With the default (RULE) setting, incoming requests are evaluated against the rule-based content switching policies. If none of the rules match, the URL in the request is evaluated against the URL-based content switching policies. Default value: RULE. Possible values = RULE, URL
        CaseSensitive|casesensitive|string|Consider case in URLs (for policies that use URLs instead of RULES). For example, with the ON setting, the URLs /a/1.html and /A/1.HTML are treated differently and can have different targets (set by content switching policies). With the OFF setting, /a/1.html and /A/1.HTML are switched to the same target. Default value: ON. Possible values = ON, OFF
        SpillOverMethod|somethod|string|Type of spillover used to divert traffic to the backup virtual server when the primary virtual server reaches the spillover threshold. Connection spillover is based on the number of connections. Bandwidth spillover is based on the total Kbps of incoming and outgoing traffic. Possible values = CONNECTION, DYNAMICCONNECTION, BANDWIDTH, HEALTH, NONE
        SpillOverPersistence|sopersistence|string|Maintain source-IP based persistence on primary and backup virtual servers. Default value: DISABLED. Possible values = ENABLED, DISABLED
        SpillOverPersistenceTimeout|sopersistencetimeout|string|Time-out value, in minutes, for spillover persistence.
        SpillOverThreshold|sothreshold|double|Depending on the spillover method, the maximum number of connections or the maximum total bandwidth (Kbps) that a virtual server can handle before spillover occurs.
        SpillOverBackupAction|sobackupaction|string|Action to be performed if spillover is to take effect, but no backup chain to spillover is usable or exists. Possible values = DROP, ACCEPT, REDIRECT
        RedirectPortRewrite|redirectportrewrite|string|State of port rewrite while performing HTTP redirect. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with a virtual server whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        BackupVirtualServer|backupvserver|string|Name of the backup virtual server that you are configuring.
        DisablePrimaryOnDown|disableprimaryondown|string|Continue forwarding the traffic to backup virtual server even after the primary server comes UP from the DOWN state. Default value: DISABLED. Possible values = ENABLED, DISABLED
        InsertVirtualServerIpPort|insertvserveripport|string|Insert the virtual server's VIP address and port number in the request header. Available values function as follows: VIPADDR - Header contains the vserver's IP address and port number without any translation. OFF - The virtual IP and port header insertion option is disabled. V6TOV4MAPPING - Header contains the mapped IPv4 address corresponding to the IPv6 address of the vserver and the port number. An IPv6 address can be mapped to a user-specified IPv4 address using the set ns ip6 command. Possible values = OFF, VIPADDR, V6TOV4MAPPING
        VirtualServerIpAndPortHeader|vipheader|string|Name of virtual server IP and port header, for use with the VServer IP Port Insertion parameter.
        RealTimeStreamingProtocolNetworkAddressTranslation|rtspnat|string|Enable network address translation (NAT) for real-time streaming protocol (RTSP) connections. Default value: OFF Possible values = ON, OFF
        AuthenticationnHost|authenticationhost|string|FQDN of the authentication virtual server. The service type of the virtual server should be either HTTP or SSL.
        Authentiction|authentication|string|Authenticate users who request a connection to the content switching virtual server. Default value: OFF. Possible values = ON, OFF
        ListenPolicy|listenpolicy|string|String specifying the listen policy for the content switching virtual server. Can be either the name of an existing expression or an in-line expression. Default value: "NONE"
        ListenPriority|listenpriority|double|Integer specifying the priority of the listen policy. A higher number specifies a lower priority. If a request matches the listen policies of more than one virtual server the virtual server whose listen policy has the highest priority (the lowest priority number) accepts the request. Default value: 101
        AuthenticationWithHttp401|authn401|string|Enable HTTP 401-response based authentication. Default value: OFF. Possible values = ON, OFF
        AuthenticationVirtualServerName|authnvsname|string|Name of authentication virtual server that authenticates the incoming user requests to this content switching virtual server.
        Push|push|string|Process traffic with the push virtual server that is bound to this content switching virtual server (specified by the Push VServer parameter). The service type of the push virtual server should be either HTTP or SSL. Default value: DISABLED. Possible values = ENABLED, DISABLED
        PushVirtualServer|pushvserver|string|Name of the load balancing virtual server, of type PUSH or SSL_PUSH, to which the server pushes updates received on the client-facing load balancing virtual server.
        PushLabel|pushlabel|string|Expression for extracting the label from the response received from server. This string can be either an existing rule name or an inline expression. The service type of the virtual server should be either HTTP or SSL. Default value: "none"
        PushMultiClients|pushmulticlients|string|Allow multiple Web 2.0 connections from the same client to connect to the virtual server and expect updates. Default value: NO. Possible values = YES, NO
        TcpProfileName|tcpprofilename|string|Name of the TCP profile containing TCP configuration settings for the virtual server.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile containing HTTP configuration settings for the virtual server. The service type of the virtual server should be either HTTP or SSL.
        DbProfileName|dbprofilename|string|Name of the DB profile.
        OracleServerVersion|oracleserverversion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        Comment|comment|string|Information about this virtual server.
        MsSqlServerVersion|mssqlserverversion|string|The version of the MSSQL server. Default value: 2008R2. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        UseL2ConnectionParameters|l2conn|string|Use L2 Parameters to identify a connection. Possible values = ON, OFF
        MySqlProtocolVersion|mysqlprotocolversion|string|The protocol version returned by the mysql vserver. Default value: 10
        MySqlServerVersion|mysqlserverversion|string|The server version string returned by the mysql vserver.
        MySqlCharacterSet|mysqlcharacterset|string|The character set returned by the mysql vserver. Default value: 8
        MySqlServerCapabilities|mysqlservercapabilities|string|The server capabilities returned by the mysql vserver.
        AppFlowLogging|appflowlog|string|Enable logging appflow flow information. Default value: ENABLED Possible values = ENABLED, DISABLED
        NetProfile|netprofile|string|The name of the network profile.
        IcmpVirtualServerResponse|icmpvsrresponse|string|Can be active or passive. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        RouteHostInjectionState|rhistate|string|A host route is injected according to the setting on the virtual servers * If set to PASSIVE on all the virtual servers that share the IP address, the appliance always injects the hostroute. * If set to ACTIVE on all the virtual servers that share the IP address, the appliance injects even if one virtual server is UP. * If set to ACTIVE on some virtual servers and PASSIVE on the others, the appliance, injects even if one virtual server set to ACTIVE is UP. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        AuthenticationProfile|authnprofile|string|Name of the authentication profile to be used when authentication is turned on.
        DnsProfileName|dnsprofilename|string|Name of the DNS profile to be associated with the VServer. DNS profile properties will applied to the transactions processed by a VServer. This parameter is valid only for DNS and DNS-TCP VServers.
        DomainName|domainname|string|Domain name for which to change the time to live (TTL) and/or backup service IP address.
        TimeToLive|ttl|double|-
        BackupIp|backupip|string|-
        CookieDomain|cookiedomain|string|-
        CookieTimeout|cookietimeout|double|-
        SiteDomainTimeToLive|sitedomainttl|double|-
        Ip|ip|string|The IP address of the virtual server.
        Value|value|string|The ssl card status for the transparent ssl cs vserver. Possible values = Certkey not bound, SSL feature disabled
        NodeGroupName|ngname|string|Nodegroup devno to which this csvserver belongs to.
        Type|type|string|Virtual server type. Possible values = CONTENT, ADDRESS
        CurrentState|curstate|string|The state of the cs vserver. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        SureConnect|sc|string|The state of SureConnect the specified virtual server. Possible values = ON, OFF
        Status|status|int|Status.
        CacheType|cachetype|string|Cache type. Possible values = TRANSPARENT, REVERSE, FORWARD
        Redirect|redirect|string|Redirect URL string. Possible values = CACHE, POLICY, ORIGIN
        HomePage|homepage|string|Home page.
        DnsVirtualServerName|dnsvservername|string|DNS vserver name.
        Domain|domain|string|Domain.
        PolicyName|policyname|string|Policies bound to this vserver.
        ServiceName|servicename|string|Service name.
        Weight|weight|string|Weight of this server.
        CacheVirtualServer|cachevserver|string|Cache vserver name.
        TargetVirtualServer|targetvserver|string|target vserver name.
        Priority|priority|string|Priority for the policy.
        Url|url|string|URL string.
        GoToPriorityExpression|gotopriorityexpression|string|Expression specifying the priority of the next policy which will get evaluated if the current policy rule evaluates to TRUE.
        BindPoint|bindpoint|string|The bindpoint to which the policy is bound. Possible values = REQUEST, RESPONSE
        Invoke|invoke|bool|Invoke flag.
        LabelType|labeltype|string|The invocation type. Possible values = reqvserver, resvserver, policylabel
        LabelName|string|labelname|Name of the label invoked.
        GreaterThan2GigaBytes|gt2gb|string|This argument has no effect. Default value: DISABLED Possible values = ENABLED, DISABLED
        StateChangeTimeSec|statechangetimesec|string|Time when last state change happened. Seconds part.
        StateChangeTimeMSec|statechangetimemsec|double|Time at which last state change happened. Milliseconds part.
        TicksSinceLastStateChange|tickssincelaststatechange|double|Time in 10 millisecond ticks since the last state change.
        RuleType|ruletype|string|Rule type.
        LoadBalancingVirtualServer|lbvserver|string|Name of the default lb vserver bound. Use this param for Default binding only. 
        TargetLoadBalancingVirtualServer|targetlbvserver|string|target vserver name.
        Count|__count|int|Count Parameter.

     * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
       var command = NitroCommandFactory.Create\<CsvserverGetCommand>(INitroServiceClient, New CsvserverGetRequestOptions(){ });
        ```
       
       - Options:  
        For this command, the Options are gathered in an Object CsvserverGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsvserverGet, that object is <u>CsvserverGetResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Cspolicies: an array of CspolicyConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<CsvserverRemoveCommand>(INitroServiceClient, new CsvserverRemoveRequestOptions(){ });
        ```
      
      - Options:  
        For Servers, the Options are gathered in an Object CsvserverRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsvserverRemove, that object is <u>NitroResponse</u>.

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
        Name|name|string|Name for the content switching virtual server. 
        ServiceType|servicetype|string|Protocol used by the virtual server. Possible values = HTTP, SSL, TCP, FTP, RTSP, SSL_TCP, UDP, DNS, SIP_UDP, SIP_TCP, SIP_SSL, ANY, RADIUS, RDP, MYSQL, MSSQL, DIAMETER, SSL_DIAMETER, DNS_TCP, ORACLE, SMPP, PROXY. Automatically assigned when choosing which data to add.
        IpVersion4Or6Value|ipv46|string|IP address of the content switching virtual server.
        Port|port|int|Port number for content switching virtual server.
        IpPattern|ippattern|string|IP address pattern, in dotted decimal notation, for identifying packets to be accepted by the virtual server. The IP Mask parameter specifies which part of the destination IP address is matched against the pattern. Mutually exclusive with the IP Address parameter. For example, if the IP pattern assigned to the virtual server is 198.51.100.0 and the IP mask is 255.255.240.0 (a forward mask), the first 20 bits in the destination IP addresses are matched with the first 20 bits in the pattern. The virtual server accepts requests with IP addresses that range from 198.51.96.1 to 198.51.111.254. You can also use a pattern such as 0.0.2.2 and a mask such as 0.0.255.255 (a reverse mask).If a destination IP address matches more than one IP pattern, the pattern with the longest match is selected, and the associated virtual server processes the request. For example, if the virtual servers, vs1 and vs2, have the same IP pattern, 0.0.100.128, but different IP masks of 0.0.255.255 and 0.0.224.255, a destination IP address of 198.51.100.128 has the longest match with the IP pattern of vs1. If a destination IP address matches two or more virtual servers to the same extent, the request is processed by the virtual server whose port number matches the port number in the request.
        IpMask|ipmask|string|IP mask, in dotted decimal notation, for the IP Pattern parameter. Can have leading or trailing non-zero octets (for example, 255.255.240.0 or 0.0.255.255). Accordingly, the mask specifies whether the first n bits or the last n bits of the destination IP address in a client request are to be matched with the corresponding bits in the IP pattern. The former is called a forward mask. The latter is called a reverse mask.
        TrafficDomain|td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        TargetType|targettype|string|Virtual server target type. Possible values = GSLB
        DnsRecordType|dnsrecordtype|string|Default value: NSGSLB_IPV4. Possible values = A, AAAA, CNAME, NAPTR
        PersistenceId|persistenceid|double|-
        Range|range|double|Number of consecutive IP addresses, starting with the address specified by the IP Address parameter, to include in a range of addresses assigned to this virtual server.
        State|state|string|Initial state of the load balancing virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        StateUpdate|stateupdate|string|Enable state updates for a specific content switching virtual server. By default, the Content Switching virtual server is always UP, regardless of the state of the Load Balancing virtual servers bound to it. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Cacheable|cacheable|string|Use this option to specify whether a virtual server, used for load balancing or content switching, routes requests to the cache redirection virtual server before sending it to the configured servers. Default value: NO. Possible values = YES, NO
        RedirectUrl|redirecturl|string|URL to which traffic is redirected if the virtual server becomes unavailable. The service type of the virtual server should be either HTTP or SSL. Caution: Make sure that the domain in the URL does not match the domain specified for a content switching policy. If it does, requests are continuously redirected to the unavailable virtual server.
        ClientTimeout|clttimeout|double|Idle time, in seconds, after which the client connection is terminated. The default values are:180 seconds for HTTP/SSL-based services.9000 seconds for other TCP-based services.120 seconds for DNS-based services.120 seconds for other UDP-based services.
        Precedence|precedence|string|Type of precedence to use for both RULE-based and URL-based policies on the content switching virtual server. With the default (RULE) setting, incoming requests are evaluated against the rule-based content switching policies. If none of the rules match, the URL in the request is evaluated against the URL-based content switching policies.Default value: RULE Possible values = RULE, URL
        CaseSensitive|casesensitive|string|Consider case in URLs (for policies that use URLs instead of RULES). For example, with the ON setting, the URLs /a/1.html and /A/1.HTML are treated differently and can have different targets (set by content switching policies). With the OFF setting, /a/1.html and /A/1.HTML are switched to the same target. Default value: ON. Possible values = ON, OFF
        SpillOverMethod|somethod|string|Type of spillover used to divert traffic to the backup virtual server when the primary virtual server reaches the spillover threshold. Connection spillover is based on the number of connections. Bandwidth spillover is based on the total Kbps of incoming and outgoing traffic. Possible values = CONNECTION, DYNAMICCONNECTION, BANDWIDTH, HEALTH, NONE
        SpillOverPersistence|sopersistence|string|Maintain source-IP based persistence on primary and backup virtual servers. Default value: DISABLED. Possible values = ENABLED, DISABLED
        SpillOverPersistenceTimeout|sopersistencetimeout|double|Time-out value, in minutes, for spillover persistence.
        SpillOverThreshold|sothreshold|double|Depending on the spillover method, the maximum number of connections or the maximum total bandwidth (Kbps) that a virtual server can handle before spillover occurs.
        SpillOverBackupAction|sobackupaction|string|Action to be performed if spillover is to take effect, but no backup chain to spillover is usable or exists. Possible values = DROP, ACCEPT, REDIRECT
        RedirectPortRewrite|redirectportrewrite|string|State of port rewrite while performing HTTP redirect. Default value: DISABLED Possible values = ENABLED, DISABLED
        DownStateFlush|downstateflush|string|Flush all active transactions associated with a virtual server whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        BackupVirtualServer|backupvserver|string|Name of the backup virtual server that you are configuring.
        DisablePrimaryOnDown|disableprimaryondown|string|Continue forwarding the traffic to backup virtual server even after the primary server comes UP from the DOWN state. Default value: DISABLED Possible values = ENABLED, DISABLED
        InsertVirtualServerIpPort|inservserveripport|string|Insert the virtual server's VIP address and port number in the request header. Available values function as follows: VIPADDR - Header contains the vserver's IP address and port number without any translation. OFF - The virtual IP and port header insertion option is disabled. V6TOV4MAPPING - Header contains the mapped IPv4 address corresponding to the IPv6 address of the vserver and the port number. An IPv6 address can be mapped to a user-specified IPv4 address using the set ns ip6 command.Possible values = OFF, VIPADDR, V6TOV4MAPPING
        VirtualServerIpAndPortHeader|vipheader|string|Name of virtual server IP and port header, for use with the VServer IP Port Insertion parameter.
        RealTimeStreamingProtocolNetworkAddressTranslation|rtspnat|string|Enable network address translation (NAT) for real-time streaming protocol (RTSP) connections. Default value: OFF. Possible values = ON, OFF
        ListenPolicy|listenpolicy|string|String specifying the listen policy for the content switching virtual server. Can be either the name of an existing expression or an in-line expression. Default value: "NONE"
        ListenPriority|listenpriority|double|Integer specifying the priority of the listen policy. A higher number specifies a lower priority. If a request matches the listen policies of more than one virtual server the virtual server whose listen policy has the highest priority (the lowest priority number) accepts the request. Default value: 101. Minimum value = 0. Maximum value = 100
        AuthenticationHost|authenticationhost|string|FQDN of the authentication virtual server. The service type of the virtual server should be either HTTP or SSL.
        Authentication|authentication|string|Authenticate users who request a connection to the content switching virtual server. Default value: OFF. Possible values = ON, OFF
        AuthenticationWithHttp401|authn401|string|Enable HTTP 401-response based authentication. Default value: OFF. Possible values = ON, OFF
        AuthenticationVirtualServerName|authnvsname|string|Name of authentication virtual server that authenticates the incoming user requests to this content switching virtual server.
        Push|push|string|Process traffic with the push virtual server that is bound to this content switching virtual server (specified by the Push VServer parameter). The service type of the push virtual server should be either HTTP or SSL. Default value: DISABLED. Possible values = ENABLED, DISABLED
        PushVirtualServer|pushvserver|string|Name of the load balancing virtual server, of type PUSH or SSL_PUSH, to which the server pushes updates received on the client-facing load balancing virtual server.
        PushLabel|pushlabel|string|Expression for extracting the label from the response received from server. This string can be either an existing rule name or an inline expression. The service type of the virtual server should be either HTTP or SSL. Default value: "none"
        PushMulticlients|pushmulticlients|string|Allow multiple Web 2.0 connections from the same client to connect to the virtual server and expect updates. Default value: NO. Possible values = YES, NO
        TcpProfileName|tcpprofilename|string|Name of the TCP profile containing TCP configuration settings for the virtual server.
        HttpProfileName|httpprofilename|string|Name of the HTTP profile containing HTTP configuration settings for the virtual server.
        DbProfileName|dbprofilename|string|Name of the DB profile.
        OracleServerVersion|oracleserverversion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        Comment|comment|string|Information about this virtual server.
        MsSqlServerVersion|mssqlserverversion|string|The version of the MSSQL server. Default value: 2008R2. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        UseL2ConnectionParameters|l2conn|string|Use L2 Parameters to identify a connection. Possible values = ON, OFF
        MySqlProtocolVersion|mysqlprotocolversion|double|The protocol version returned by the mysql vserver. Default value: 10
        MySqlServerVersion|mysqlserverversion|string|The server version string returned by the mysql vserver.
        MySqlCharacterSet|mysqlcharacterset|double|The character set returned by the mysql vserver. Default value: 8
        MySqlServerCapabilities|mysqlservercapabilities|double|The server capabilities returned by the mysql vserver. Default value: 41613
        AppFlowLogging|appflowlog|string|Enable logging appflow flow information. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|netprofile|string|The name of the network profile.
        IcmpvsrResponse|icmpvsrresponse|string|Can be active or passive. Default value: PASSIVE Possible values = PASSIVE, ACTIVE
        RouteHostInjectionState|rhistate|string|A host route is injected according to the setting on the virtual servers * If set to PASSIVE on all the virtual servers that share the IP address, the appliance always injects the hostroute. * If set to ACTIVE on all the virtual servers that share the IP address, the appliance injects even if one virtual server is UP. * If set to ACTIVE on some virtual servers and PASSIVE on the others, the appliance, injects even if one virtual server set to ACTIVE is UP. Default value: PASSIVE Possible values = PASSIVE, ACTIVE
        AuthenticationProfile|authnprofile|string|Name of the authentication profile to be used when authentication is turned on.
        DnsProfileName|dnsprofilename|string|Name of the DNS profile to be associated with the VServer. DNS profile properties will applied to the transactions processed by a VServer. This parameter is valid only for DNS and DNS-TCP VServers.


   * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (CsvserverUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CspolicyUpdateCommand> (INitroServiceClient, new CsvserverUpdateRequestData(){ });
            ```
          
            Where CsvserverUpdateRequestData is one of:
            - CsvserverUpdateDnsRequestData, CsvserverUpdateDnsTcpRequestData, CsvserverUpdateHttpRequestData, CsvserverUpdateSslRequestData, CsvserverUpdateSslTcpRequestData, CsvserverUpdateTcpRequestData, CsvserverUpdateUdpRequestData

   * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsvserverUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse(); 
        ```
     
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


#### CsvserverBinding

##### CsvserverBindingCspolicy

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description
        ---|---|---|---
        Name|name|string|Name of the content switching virtual server to which the content switching policy applies.
        PolicyName|policyname|string|Policies bound to this vserver.
        TargetLoadBalancingVirtualServer|targetlbvserver|string|target vserver name.
        Priority|priority|double|Priority for the policy.
        GoToPriorityExpression|gotopriorityexpression|string|Expression specifying the priority of the next policy which will get evaluated if the current policy rule evaluates to TRUE.
        BindPoint|bindpoint|string|The bindpoint to which the policy is bound. Possible values = REQUEST, RESPONSE
        Invoke|invoke|bool|Invoke flag.
        LabelType|labeltype|string|The invocation type. Possible values = reqvserver, resvserver, policylabel
        LabelName|labelname|string|Name of the label invoked.


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CsvserverAddCommand> (INitroServiceClient, new CsvserverBindingAddCspolicyRequestData(){ });
            ```


    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for CsvserverBindingAddCspolicy, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse();  
        ```
     
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get: NYI

+ Remove:
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. var command = NitroCommandFactory.Create\<CsvserverBindingRemoveCspolicyCommand>(INitroServiceClient, new CsvserverBindingRemoveCspolicyRequestOptions(){ });
        - Options:  
        For this command, the Options are gathered in an Object CsvserverBindingRemoveCspolicyRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove from.
        <u>Arguments</u>: a dictionary<string, string> that requires the following data based on what you wish to remove. policyname: <policyname_value> ,bindpoint: <bindpoint_value> ,priority: <priority_value> .

    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsvserverBindingRemoveCspolicy, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update: NYI

##### CsvserverBindingLbvserver

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix dov name| DataType |  Description
        ---|---|---|---
        Name|name|string|Name of the content switching virtual server to which the content switching policy applies.
        LoadBalancingVirtualServer|lbvserver|string|The virtual server name (created with the add lb vserver command) to which content will be switched.
        TargetVirtualServer|targetvserver|string|Name of the default lb vserver bound. Use this param for Default binding only. 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
          var command = NitroCommandFactory.Create\<CsvserverAddCommand> (INitroServiceClient, new CsvserverBindingAddLbvserverRequestData(){ });
            ```


    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for CsvserverBindingAddLbvserver, that object is <u>NitroResponse</u>.

        eg. 
        ```
     var response = command.GetResponse();  
        ```
     
        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get: NYI

+ Remove:
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
      var command = NitroCommandFactory.Create\<CsvserverBindingRemoveLbvserverCommand>(INitroServiceClient, new CsvserverBindingRemoveLbvserverRequestOptions(){ });
        ```
      
      - Options:  
        For this command, the Options are gathered in an Object CsvserverBindingRemoveLbvserverRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove from.  
        <u>Arguments</u>: a dictionary<string, string> that requires the following data based on what you wish to remove. lbvserver: <lbvservername_value> 

    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsvserverBindingRemoveLbvserver, that object is <u>NitroResponse</u>.

        eg. 
        ```
      var response = command.GetResponse(); 
        ```
      
        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update: NYI
