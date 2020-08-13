### Vpn

#### Vpn

+ Get
    * Properties  

        The following properties van be found in VpnStats "VpnStatistics" inside of a VpnStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        IndexHtmlHit|indexhtmlhit|string|Number of requests for VPN login page.
        IndexHtmlNotServed|indexhtmlnoserved|string|Number of failures to display VPN login page.
        ConfigurationHtmlServed|cfghtmlserved|string|Number of client configuration requests received by VPN server.
        ConfigurationHtmlServedRate|cfghtmlservedrate|double|Rate (/s) counter for cfghtmlserved
        DnsRequestHit|dnsreqhit|string|Number of DNS queries resolved by VPN server.
        DnsRequestHitRate|dnsreqhitrate|double|Rate (/s) counter for dnsreqhit
        WinsRequestHit|winsrequesthit|string|Number of WINS queries resolved by VPN server.
        WinsRequestHitRate|winsrequesthitrate|double|Rate (/s) counter for winsrequesthit
        ClientToServerRequestHit|csrequesthit|string|Number of SSL VPN tunnels formed between VPN server and client.
        ClientToServerRequestHitRate|csrequesthitrate|double|Rate (/s) counter for csrequesthit
        ClientToServerNonHttpProbeHit|csnonhttpprobehit|string|Number of probes from VPN to back-end non-HTTP servers that have been accessed by the VPN client.
        ClientToServerNonHttpProbeHitRate|csnonhttpprobehitrate|double|Rate (/s) counter for csnonhttpprobehit
        ClientToServerHttpProbeHit|cshttpprobehit|string|Number of probes from VPN to back-end HTTP servers that have been accessed by the VPN client.
        ClientToServerHttpProbeHitRate|cshttpprobehitrate|double|Rate (/s) counter for cshttpprobehit
        TotalClientToServerConnectionSuccess|totalcsconnsucc|string|Number of successful probes to all back-end servers.
        ClientToServerConnectionSuccessRate|csconnsuccrate|double|Rate (/s) counter for totalcsconnsucc
        TotalFileSystemRequest|totalfsrequest|string|Number of file system requests received by VPN server.
        FileSystemRequestRate|fsrequestrate|double|Rate (/s) counter for totalfsrequest
        VpnLicenseFail|vpnlicensefail|string|Number of users not able to login because of license unavailability.
        IipDisabledMipUsed|iipdisabledmipused|string|Number of times SNIP is used as IIP is disabled.
        IipDisabledMipUsedRate|iipdisabledmipusedrate|double|Rate (/s) counter for iipdisabledmipused
        IipFailedMipUsed|iipfailedmipused|string|Number of times SNIP is used as IIP assignment failed.
        IipFailedMipUsedRate|iipfailedmipusedrate|double|Rate (/s) counter for iipfailedmipused
        IipSpillOverMipUsed|iipspillovermipused|string|Number of times SNIP is used on IIP Spillover.
        IipSpillOverMipUsedRate|iipspillovermipusedrate|double|Rate (/s) counter for iipspillovermipused
        IipDisabledMipDisabled|iipdisabledmipdisabled|string|Both IIP and SNIP is disabled.
        IipDisabledMipDisabledRate|iipdisabledmipdisabledrate|double|Rate (/s) counter for iipdisabledmipdisabled
        IipFailedMipDisabled|iipfailedmipdisabled|string|Number of times IIP assignment failed and SNIP is disabled.
        IipFailedMipDisabledRate|iipfailedmipdisabledrate|double|Rate (/s) counter for iipfailedmipdisabled
        SocksMethodRequestsReceived|socksmethreqrcvd|string|Number of received SOCKS method request.
        SocksMethodRequestsReceivedRate|socksmethreqrcvdrate|double|Rate (/s) counter for socksmethreqrcvd
        SocksMethodRequestsSent|socksmethreqsent|string|Number of sent SOCKS method request.
        SocksMethodRequestsSentRate|socksmethreqsentrate|double|Rate (/s) counter for socksmethreqsent
        SocksMethodResponseReceived|socksmethresprcvd|string|Number of received SOCKS method response.
        SocksMethodResponseReceivedRate|socksmethresprcvdrate|double|Rate (/s) counter for socksmethresprcvd
        SocksMethodResponseSent|socksmethrespsent|string|Number of sent SOCKS method response.
        SocksMethodResponseSentRate|socksmethrespsentrate|double|Rate (/s) counter for socksmethrespsent
        SocksConnectionRequestsReceived|socksconnreqrcvd|string|Number of received SOCKS connect request.
        SocksConnectionRequestsReceivedRate|socksconnreqrcvdrate|double|Rate (/s) counter for socksconnreqrcvd
        SocksConnectionRequestsSent|socksconnreqsent|string|Number of sent SOCKS connect request.
        SocksConnectionRequestsSentRate|socksconnreqsentrate|double|Rate (/s) counter for socksconnreqsent
        SocksConnectionResponseReceived|socksconnresprcvd|string|Number of received SOCKS connect response.
        SocksConnectionResponseReceivedRate|socksconnresprcvdrate|double|Rate (/s) counter for socksconnresprcvd
        SocksConnectionResponseSent|socksconnrespsent|string|Number of sent SOCKS connect response.
        SocksConnectionResponseSentRate|socksconnrespsentrate|double|Rate (/s) counter for socksconnrespsent
        SocksServerError|socksservererror|string|Number of SOCKS server error.
        SocksServerErrorRate|socksservererrorrate|double|Rate (/s) counter for socksservererror
        SocksClientError|socksclienterror|string|Number of SOCKS client error.
        SocksClientErrorRate|socksclienterrorrate|double|Rate (/s) counter for socksclienterror
        StaConnectionSuccess|staconnsuccess|string|Number of STA connection success.
        StaConnectionSuccessRate|staconnsuccessrate|double|Rate (/s) counter for staconnsuccess
        StaConnectionFailure|staconnfailure|string|Number of STA connection failure.
        StaConnectionFailureRate|staconnfailurerate|double|Rate (/s) counter for staconnfailure
        CpsConnectionSuccess|cpsconnsuccess|string|Number of CPS connection success.
        CpsConnectionSuccessRate|cpsconnsuccessrate|double|	Rate (/s) counter for cpsconnsuccess
        CpsConnectionFailure|cpsconnfailure|string|Number of CPS connection failure.
        CpsConnectionFailureRate|cpsconnfailurerate|double|Rate (/s) counter for cpsconnfailure
        StaRequestSent|starequestsent|string|Number of STA request sent.
        StaRequestSentRate|starequestsentrate|double|Rate (/s) counter for starequestsent
        StaResponseReceived|staresponserecvd|string|Number of STA response received.
        StaResponseReceivedRate|staresponserecvdrate|double|Rate (/s) counter for staresponserecvd
        IcaLicenseFailure|icalicensefailure|string|Number of ICA license failure.
        IcaLicenseFailureRate|icalicensefailurerate|double|Rate (/s) counter for icalicensefailure
        StaMonitorRequestsSent|stamonsent|string|Number of STA monitor requests sent.
        StaMonitorRequestsSentRate|stamonsentrate|double|Rate (/s) counter for stamonsent
        StaMonitorRequestsReceived|stamonrcvd|string|Number of STA monitor responses recieved.
        StaMonitorRequestsReceivedRate|stamonrcvdrate|double|Rate (/s) counter for stamonrcvd
        StaMonitorSuccessfulResponse|stamonsucc|string|Number of STA monitor successful responses.
        StaMonitorSuccessfulResponseRate|stamonsuccrate|double|Rate (/s) counter for stamonsucc
        StaMonitorFailure|stamonfail|string|Number of STA monitor failed responses.
        StaMonitorFailureRate|stamonfailrate|double|Rate (/s) counter for stamonfail
        CitrixSecureGatewayPrimaryTicketValidateNotStarted|csgptktvalidatenotstarted|string|Total number of STA server lookup failures for auth-id in primary ticket
        CitrixSecureGatewayPrimaryTicketValidateNotStartedRate|csgptktvalidatenotstartedrate|double|Rate (/s) counter for csgptktvalidatenotstarted
        CitrixSecureGatewayRedundantTicketValidateNotStarted|csgrtktvalidatenotstarted|string|Total number of STA server lookup failures for auth-id in redundant ticket
        CitrixSecureGatewayRedundantTicketValidateNotStartedRate|csgrtktvalidatenotstartedrate|double|Rate (/s) counter for csgrtktvalidatenotstarted


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<VpnStatCommand>(INitroServiceClient, New VpnStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object VpnStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For VpnStat, that object is <u>VpnStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - VpnStatistics: a VpnStats-object returned by the Get-Request, all of which contain the properties mentioned above.





#### VpnUrlPolicy

+ Get
    * Properties  

        The following properties van be found inan array of VpnUrlPolicyStats "VpnUrlPolicyStatistics" inside of a VpnUrlPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|The name of the vpn urlPolicy for which statistics will be displayed.
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits

        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<VpnUrlPolicyStatCommand>(INitroServiceClient, New VpnUrlPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object VpnUrlPolicyStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For VpnUrlPolicyStat, that object is <u>VpnUrlPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - VpnUrlPolicyStatistics: a VpnUrlPolicyStats-object returned by the Get-Request, all of which contain the properties mentioned above.




#### VpnVserver

+ Get
    * Properties  

        The following properties van be found inan array of VpnVserverStats "VpnVserverStatistics" inside of a VpnVserverStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the virtual server for which to show detailed statistics.
        Type|type|string|Protocol associated with the vserver
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        PrimaryPort|primaryport|int|The port on which the service is running.
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running.
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. (This applies to HTTP/SSL services and servers.)
        ResponsesRate|responsesrate|double|Rate (/s) counter for totalresponses
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server.
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server.
        ResponseBytesRate|responsebytesrate|double|Rate (/s) counter for totalresponsebytes


        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<VpnVserverStatCommand>(INitroServiceClient, New VpnVserverStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object VpnVserverStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For VpnVserverStat, that object is <u>VpnVserverStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - VpnVserverStatistics: a VpnVserverStats-object returned by the Get-Request, all of which contain the properties mentioned above.
