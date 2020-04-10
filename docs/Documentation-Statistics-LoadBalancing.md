### Loadbalancing

#### Lbvserver

+ Get
    * Properties  

        The following properties van be found in each CsvserverStatistics found in the array "CsvserverStats" inside of a CsvserverStatResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|Name of the virtual server. If no name is provided, statistical data of all configured virtual servers is displayed. 
        AverageClientTimeToLastByte|string|Average TTLB between the client and the server. TTLB is the time interval between sending the request packet to a service and receiving the ACK for response from client. 
        ClientResponseTimeApdexIndex|double|Vserver APDEX index based on client response times. 
        VirtualServerSurgeCount|string|Number of requests waiting on this vserver. 
        EstablishedConn|string|Number of client connections in ESTABLISHED state. 
        InactiveServices|string|number of INACTIVE services bound to a vserver 
        VirtualServerHealth|string|Health of the vserver. This gives percentage of UP services bound to this vserver. 
        PrimaryIpAddress|string|IP address of the vserver 
        PrimaryPort|int|The port on which the service is running. 
        Type|string|Protocol associated with the vserver 
        State|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8) 
        ActiveServices|string|number of ACTIVE services bound to a vserver 
        TotalHits|string|Total vserver hits 
        HitsRate|double|Rate (/s) counter for tothits 
        TotalRequest|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        RequestsRate|double|Rate (/s) counter for totalrequests 
        TotalResponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        ResponsesRate|double|Rate (/s) counter for totalresponses 
        TotalRequestBytes|string|Total number of request bytes received on this service or virtual server. 
        RequestBytesRate|double|Rate (/s) counter for totalrequestbytes 
        TotalResponseBytes|string|Number of response bytes received by this service or virtual server. 
        ResponseBytesRate|double|Rate (/s) counter for totalresponsebytes 
        TotalPacketsReceived|string|Total number of packets received by this service or virtual server. 
        PacketsReceivedRate|double|Rate (/s) counter for totalpktsrecvd 
        TotalPacketsSent|string|Total number of packets sent. 
        PacketsSentRate|double|Rate (/s) counter for totalpktssent 
        CurrentClientConnections|string|Number of current client connections. 
        CurrentServerConnections|string|Number of current connections to the actual servers behind the virtual server.
        CurrentPersistenceSessions|string|current vserver owned persistence sessions 
        SurgeCount|string|Number of requests in the surge queue. 
        ServicesSurgeCount|string|Total number of requests in the surge queues of all the services bound to this LB-vserver. 
        SpillOverThreshold|string|Spill Over Threshold set on the VServer. 
        TotalSpillOvers|string|Number of times vserver experienced spill over. 
        LabelledConnections|string|Number of Labeled connection on this vserver 
        PushLabels|string|Number of labels for this push vserver. 
        DeferredRequests|string|Number of deferred request on this vserver 
        DeferredRequestRate|double|Rate (/s) counter for deferredreq 
        InvalidRequestResponse|string|Number invalid requests/responses on this vserver 
        InvalidRequestResponseDropped|string|Number invalid requests/responses dropped on this vserver 
        TotalVirtualserverDownBackupHits|string|Number of times traffic was diverted to backup vserver since primary vserver was DOWN. 
        CurrentMultiPathTcpSessions|string|Current Multipath TCP sessions 
        CurrentMultiPathTcpSubFlowConnections|string|Current Multipath TCP subflows 
        TotalClientTimeToLastByteTransactions|string|Total transactions where client TTLB is calculated. 
        TotalClientTimeToLastByteTransactionsRate|double|-
        ToleratingTtlbTransactions|string|Tolerable transactions based on APDEX threshold (>T ;; <4T). 
        ToleratingTtlbTransactionsRate|double|-
        FrustratingTtlbTransactions|string|Frustrating transactions based on APDEX threshold (>4T). 
        FrustratingTtlbTransactionsRate|double|-
        TotalConnReassemblyQueue75|string|Total no of connections with 75% TCP reassembly queue 
        TotalConnReassemblyQueueFlush|string|Total no of connections incurred TCP reassembly queue flush 
        TotalSvrBusyerr|string|Total no of server busy error 
        SvrBusyerrRate|double|Rate (/s) counter for totalsvrbusyerr 
        HttpMaxHdrszPkts|string|Number of http max header size packet parsing failures 
        TcpMaxOooPkts|string|No of times max out of order packets reached 


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LbvserverStatCommand>(INitroServiceClient, New LbvserverStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object LbvserverStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverStat, that object is <u>LbvStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - LbvserverStats: an array of LbvserverStatistics-objects returned by the Get-Request, all of which contain the properties mentioned above.
