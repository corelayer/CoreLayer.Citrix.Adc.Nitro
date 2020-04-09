## Statistics

### Basic

#### Service

+ Get
    * Properties  

        The following properties van be found in each ServiceStatistics found in the array "ServiceStats" inside of a ServiceStatResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|Name of the service. 
        ServerEstablishedConnections|string|Number of server connections in ESTABLISHED state. 
        CurrentClientConnections|string|Number of current client connections. 
        ServiceType|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP 
        TotalRequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        SurgeCount|string|Number of requests in the surge queue. 
        ResponseBytesRate|double|Rate (/s) counter for totalresponsebytes.
        TotalResponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        RequestBytesRate|double|Rate (/s) counter for totalrequestbytes 
        ThroughPut|string|-
        ThroughPutRate|double|-
        CurrentFlags|string|Current flags on the service for internal use in display handlers. 
        CurrentServerConnections|string|Number of current connections to the actual servers behind the virtual server. 
        PrimaryIpAddress|string|The IP address on which the service is running. 
        ActiveTransactions|string|Number of active transactions handled by this service. (Including those in the surge queue.) Active Transaction means number of transactions currently served by the server including those waiting in the SurgeQ 
        ToleratingTimeToLastByteTransactions|string|Tolerable transactions based on APDEX threshold (>T ;; <4T). 
        ResponsesRate|double|Rate (/s) counter for totalresponses 
        MaxClients|string|Maximum open connections allowed on this service. 
        AverageServerTimeToFirstByte|string|-
        CurrentLoad|string|Load on the service that is calculated from the bound load based monitor. 
        TotalRequestBytes|string|Total number of request bytes received on this service or virtual server. 
        CurrentReusePool|string|Number of requests in the idle queue/reuse pool. 
        State|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8) 
        VirtualServerServiceHits|string|Number of times that the service has been provided. 
        TotalServerTimeToLastByteTransactions|string|Total transactions where server TTLB is calculated. 
        FrustratingTimeToLastByteTransactions|string|Frustrating transactions based on APDEX threshold (>4T). 
        TotalResponseBytes|string|Number of response bytes received by this service or virtual server. 
        PrimaryPort|int|The port on which the service is running. 
        RequestsRate|double|Rate (/s) counter for totalrequests 
        VirtualServerServiceHitsRate|double|Rate (/s) counter for vsvrservicehits 
        TotalConnReassemblyQueue75|string|-
        TotalConnReassemblyQueueFlush|string|-
        HttpMaxHeaderSizePackets|string|-
        TcpMaxOooPackets|string|-

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<ServiceStatCommand>(INitroServiceClient, New ServiceStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object ServiceStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServiceStat, that object is <u>ServiceStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - ServiceStats: an array of ServiceStatistics-objects returned by the Get-Request, all of which contain the properties mentioned above.

#### Servicegroup

+ Get
    * Properties  

        The following properties van be found in each ServicegroupStatistics found in the array "ServicegroupStats" inside of a ServicegroupStatResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|Name of the service.
        State|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8) 
        ServiceType|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP 
        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<ServicegroupStatCommand>(INitroServiceClient, New ServicegroupStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object ServicegroupStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServicegroupStat, that object is <u>ServicegroupStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - ServicegroupStats: an array of ServicegroupStatistics-objects returned by the Get-Request, all of which contain the properties mentioned above.