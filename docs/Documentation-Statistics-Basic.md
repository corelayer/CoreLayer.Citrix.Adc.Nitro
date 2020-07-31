## Statistics

### Basic

#### Service

+ Get
    * Properties  

        The following properties van be found in each ServiceStatistics found in the array "ServiceStats" inside of a ServiceStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the service. 
        ServerEstablishedConnections|svrestablishedconn|string|Number of server connections in ESTABLISHED state. 
        CurrentClientConnections|curcltconnections|string|Number of current client connections. 
        ServiceType|servicetype|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP 
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        SurgeCount|surgecount|string|Number of requests in the surge queue. 
        ResponseBytesRate|responsebytesrate|double|Rate (/s) counter for totalresponsebytes.
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes 
        ThroughPut|throughput|string|-
        ThroughPutRate|throughputrate|double|-
        CurrentFlags|curtflags|string|Current flags on the service for internal use in display handlers. 
        CurrentServerConnections|cursvrconnections|string|Number of current connections to the actual servers behind the virtual server. 
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running. 
        ActiveTransactions|activetransactions|string|Number of active transactions handled by this service. (Including those in the surge queue.) Active Transaction means number of transactions currently served by the server including those waiting in the SurgeQ 
        ToleratingTimeToLastByteTransactions|toleratingttlbtransactions|string|Tolerable transactions based on APDEX threshold (>T ;; <4T). 
        ResponsesRate|responsesrate|double|Rate (/s) counter for totalresponses 
        MaxClients|maxclients|string|Maximum open connections allowed on this service. 
        AverageServerTimeToFirstByte|avgsvrttfb|string|-
        CurrentLoad|curload|string|Load on the service that is calculated from the bound load based monitor. 
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server. 
        CurrentReusePool|curreusepool|string|Number of requests in the idle queue/reuse pool. 
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8) 
        VirtualServerServiceHits|vsvrservicehits|string|Number of times that the service has been provided. 
        TotalServerTimeToLastByteTransactions|totsvrttlbtransactions|string|Total transactions where server TTLB is calculated. 
        FrustratingTimeToLastByteTransactions|frustratingttlbtransactions|string|Frustrating transactions based on APDEX threshold (>4T). 
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server. 
        PrimaryPort|primaryport|int|The port on which the service is running. 
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests 
        VirtualServerServiceHitsRate|vsvrservicehitsrate|double|Rate (/s) counter for vsvrservicehits 
        TotalConnectionReassemblyQueue75|totalconnreassemblyqueue75|string|-
        TotalConnectionReassemblyQueueFlush|totalconnreassemblyqueueflush|string|-
        HttpMaxHeaderSizePackets|httpmaxhdrszpkts|string|-
        TcpMaxOooPackets|tcpmaxooopkts|string|-

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

        Property|citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the service.
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8) 
        ServiceType|servicetype|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP 
        

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


#### ServicegroupMember

+ Get
    * Properties  

        The following properties van be found in each ServicegroupMemberStatistics found in the array "ServicegroupMemberStats" inside of a ServicegroupMemberStatResponse.

        Property|citrix doc name|DataType|Description
        ---|---|---|---
        ServicegroupName|servicegroupname|string|Name of the Servicegroup.
        AverageServerTimeToFirstByte|avgsvrttfb|string|Average TTFB between the Citrix ADC and the server. TTFB is the time interval between sending the request packet to a service and receiving the first response from the service
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running.
        PrimaryPort|primaryport|int|The Port on which the service is running.
        ServiceType|servicetype|string|The service type of this service.Possible values are ADNS, DNS, MYSQL, RTSP, SSL_DIAMETER, ADNS_TCP, DNS_TCP, NNTP, SIP_UDP, SSL_TCP, ANY, FTP, RADIUS, SNMP, TCP, DHCPRA, HTTP, RDP, SSL, TFTP, DIAMETER, MSSQL, RPCSVR, SSL_BRIDGE, UDP
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        RequestsRate|requestsrate|double|Rate for TotalRequests. (/s)
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        ResponsesRate|responsesrate|double|Rate for TotalResponses. (/s)
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server.
        RequestBytesRate|requestbytesrate|double|Rate for TotalRequestBytes. (/s)
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server.
        ResponseBytesRate|responsebytesrate|double|Rate for TotalResponseBytes. (/s)
        CurrentClientConnections|curcltconnections|string|Number of current client connections.
        SurgeCount|surgecount|string|Number of requests in the surge queue.
        CurrentServerConnections|cursrvrconnections|string|Number of current connections to the actual servers behind the virtual server.
        ServerEstablishedConnections|svrestablishedconn|string|Number of server connections in ESTABLISHED state.
        CurrentReusePool|curreusepool|string|Number of requests in the idle queue/reuse pool.
        MaxClients|maxclients|string|Maximum open connections allowed on this service.
        TotalConnectionReassemblyQueue75|totalconnreassemblyqueue75|string|Total no of connections with 75% TCP reassembly queue
        TotalConnectionReassemblyQueueFlush|totalconnreassemblyqueueflush|string|Total no of connections incurred TCP reassembly queue flush
        TotalServerTimeToLastByteTransactions|totsvrttlbtransactions|string|Total transactions where server TTLB is calculated.
        ToleratingTimeToLastByteTransactions|toleratingttlbtransactions|string|Tolerable transactions based on APDEX threshold (>T ;; <4T).
        FrustratingTimeToLastByteTransactions|frustratingttlbtransactions|string|Frustrating transactions based on APDEX threshold (>4T).
        CurrentLoad|curload|string|Load on the service that is calculated from the bound load based monitor.
        HttpMaxHeaderSizePacketsParseFailure|httpmaxhdrszpkts|string|Number of http max header size packet parsing failures
        TcpMaxOutOfOrderPackets|tcpmaxooopkts|string|No of times max out of order packets reached

        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<ServicegroupMemberStatCommand>(INitroServiceClient, New ServicegroupMemberStatRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ServicegroupStat, that object is <u>ServicegroupMemberStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - ServicegroupMemberStats: an array of ServicegroupMemberStatistics-objects returned by the Get-Request, all of which contain the properties mentioned above.   