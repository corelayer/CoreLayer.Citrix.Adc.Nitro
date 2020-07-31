### ContentSwitching

#### Csvserver

+ Get
    * Properties  

        The following properties van be found in each CsvserverStatistics found in the array "CsvserverStats" inside of a CsvserverStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the content switching virtual server for which to display statistics. To display statistics for all configured Content Switching virtual servers, do not specify a value for this parameter. 
        CurrentClientConnections|curclntconnections|string|Number of current client connections. 
        EstablishedConnections|establishedconn|string|Number of client connections in ESTABLISHED state. 
        TotalPacketsSent|totalpktssent|string|Total number of packets sent
        LabelledConnections|labelledconn|string|Number of Labeled connection on this vserver 
        TotalHits|tothits|string|Total vserver hits 
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        SpillOverThreshold|sothreshold|string|Spill Over Threshold set on the VServer. 
        CurrentSubFlowConnections|cursubflowconn|string|cursubflowconn 
        ResponseBytesRate|responsebytesrate|double|Rate (/s) counter for totalresponsebytes 
        InvalidRequestResponseDropped|invalidrequestresponsedropped|string|Number invalid requests/responses dropped on this vserver 
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.) 
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes 
        AverageClientTimeToLastByte|avgcltttlb|string|Average TTLB between the client and the server. TTLB is the time interval between sending the request packet to a service and receiving the ACK for response from client. 
        Type|type|string|Protocol associated with the vserver 
        HitsRate|hitsrate|double|Rate (/s) counter for tothits 
        CurrentserverConnections|cursvrconnections|string|Number of current connections to the actual servers behind the virtual server. 
        ClientResponseTimeApdex|cltresponsetimeapdex|double|Vserver APDEX index based on client response times. 
        TotalClientTimeToLastByteTransactions|totcltttlbtransactions|string|Total transactions where client TTLB is calculated. 
        PacketsReceivedRate|pktsrecvdrate|double|Rate (/s) counter for totalpktsrecvd 
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running. 
        PushLabel|pushlabel|string|Number of labels for this push vserver. 
        ToleratingTimeToLastByteTransactions|toleratingttlbtransactions|string|Tolerable transactions based on APDEX threshold (>T ;; <4T). 
        ResponsesRate|responsesrate|double|Rate (/s) counter for totalresponses 
        DeferredRequests|deferredreq|string|Number of deferred request on this vserver 
        CurrentMultipathTcpSessions|curmptcpsessions|string|Current Multipath TCP sessions 
        TotalSpillovers|totspillovers|string|Number of times vserver experienced spill over. 
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server. 
        InvalidRequestResponse|invalidrequestresponse|string|Number invalid requests/responses on this vserver 
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8) 
        DeferredRequestsRate|deferredreqrate|double|Rate (/s) counter for deferredreq 
        TotalPacketsReceived|totalpktsrecvd|string|Total number of packets received by this service or virtual server. 
        PacketsSentRate|pktssentrate|double|Rate (/s) counter for totalpktssent 
        FrustratingTimeToLastByteTransactions|frustratingttlbtransactions|string|Frustrating transactions based on APDEX threshold (>4T). 
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server. 
        PrimaryPort|primaryport|int|The port on which the service is running
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests 
        TotalVirtualServerDownBackupHits|totvserverdownbackuphits|string|Number of times traffic was diverted to backup vserver since primary vserver was DOWN. 
        HttpMaxHeaderSizePackets|httpmaxhdrszpkts|string|-
        TcpMaxOooPackets|tcpmaxooopkts|string|-
        FrustratingTimeToLastByteTransactionsRate|frustratingttlbtransactionsrate|double|-
        ToleratingTimeToLastByteTransactionsRate|toleratingttlbtransactionsrate|double|-

        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<CsvserverStatCommand>(INitroServiceClient, New CsvserverStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object CsvserverStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For CsvserverStat, that object is <u>CsvserverStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - CsvserverStats: an array of CsvserverStatistics-objects returned by the Get-Request, all of which contain the properties mentioned above.
