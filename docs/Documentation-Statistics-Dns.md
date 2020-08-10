### Dns

#### Dns

+ Get
    * Properties  

        The following properties can be found in the DnsStats-object inside of a DnsStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        DnsTotalQueries|dnstotqueries|string|Total number of DNS queries received.
        DnsQueriesRate|dnsqueriesrate|double|Rate (/s) counter for dnstotqueries
        DnsTotalMultiQuery|dnstotmultiquery|string|Total number of Multi Query request received.
        DnsTotalAnswers|dnstotanswers|string|Total number of DNS responses received.
        DnsAnswersRate|dnsanswersrate|double|Rate (/s) counter for dnstotanswers
        DnsTotalServerResponse|dnstotserverresponse|string|Total number of Server responses received.
        DnsServerResponseRate|dnsserverresponserate|double|Rate (/s) counter for dnstotserverresponse
        DnsTotalRecordUpdate|dnstotrecupdate|string|Total number of record updates.
        DnsCurrentCacheSize|dnscurcachesize|string|Current DNS cache size
        DnsCurrentNegativeCacheSize|dnscurnegcachesize|string|Current Negative DNS cache size
        DnsTotalJumboQueries|dnstotjumboqueries|string|Total number of Jumbo DNS queries received over UDP.
        DnsJumboQueriesRate|dnsjumboqueriesrate|double|Rate (/s) counter for dnstotjumboqueries
        DnsTotalJumboAnswers|dnstotjumboanswers|string|Total number of Jumbo DNS responses sent over UDP.
        DnsJumboAnswersRate|dnsjumboanswersrate|double|Rate (/s) counter for dnstotjumboanswers
        DnsTotalJumboServerResponses|dnstotjumboserverresponses|string|Total number of Jumbo DNS responses received over UDP.
        DnsJumboServerResponsesRate|dnsjumboserverresponsesrate|double|Rate (/s) counter for dnstotjumboserverresponses
        DnsTotalAuthoritativeAnswers|dnstotauthans|string|Number of queries which were authoritatively answered.
        DnsTotalServerQuery|dnstotserverquery|string|Total number of Server queries sent.
        DnsServerQueryRate|dnsserverqueryrate|double|Rate (/s) counter for dnstotserverquery
        DnsTotalCacheFlush|dnstotcacheflush|string|Total number of times cache was flushed.
        DnsTotalCacheEntriesFlush|dnstotcacheentriesflush|string|Total number of cache entries flushed.
        DnsCurrentNonAuthoritativeEntries|dnscurnoauthentries|string|Total number of non-authoritative entries.
        DnsCurrentAuthoritativeEntries|dnscurauthentries|string|Total number of authoritative entries.
        DnsTotalQueriesNoRecords|dnstotauthnonames|string|Number of queries for which no record was found.
        DnsTotalUnsupportedResponseClass|dnstotunsupportedresponseclass|string|Total number of responses for which response types were unsupported.
        DnsTotalInvalidQueryFormat|dnstotinvalidqueryformat|string|Total number of queries whose format was invalid.
        DnsTotalStrayAnswer|dnstotstrayanswer|string|Total number of stray answers.
        DnsTotalResponseBadLength|dnstotresponsebadlen|string|Number of DNS responses received with invalid resoure data length.
        DnsTotalRequestRefusals|dnstotreqrefusals|string|Number of DNS requests refused.
        DnsErrorNullAttack|dnserrnullattack|string|Total number of queries received where all the counts are 0.
        DnsTotalUnsupportedResponseType|dnstotunsupportedresponsetype|string|Total number of responses for which response type requested was unsupported.
        DnsTotalUnsupportedQueryClass|dnstotunsupportedqueryclass|string|Total number of queries for which query class was unsupported.
        DnsTotalResponsesFormatError|dnstotnonauthnodatas|string|	Total number of responses for which there was a format error.
        DnsTotalNoDataResponses|dnstotnodataresps|string|Number of DNS responses received without answer.
        DnsTotalMultiQueryDisableError|dnstotmultiquerydisableerror|string|Total number of times a multi query was disabled and received a multi query.
        DnsTotalOtherErrors|dnstotothererrors|string|Total number of other errors.
        Dns64TotalQueries|dns64totqueries|string|Total number of DNS64 queries recieved.
        Dns64QueriesRate|dns64queriesrate|double|Rate (/s) counter for dns64totqueries
        Dns64TotalAnswers|dns64totanswers|string|Total number of DNS64 answers served.
        Dns64AnswersRate|dns64answersrate|double|Rate (/s) counter for dns64totanswers
        Dns64TotalReWriteAnswers|dns64totrwanswers|string|Total number of DNS64 answers served after rewriting the response.
        Dns64ReWriteAnswersRate|dns64rwanswersrate|double|Rate (/s) counter for dns64totrwanswers
        Dns64TotalResponses|dns64totresponses|string|Total number of responses recieved from backend in DNS64 context.
        Dns64ResponsesRate|dns64responsesrate|double|Rate (/s) counter for dns64totresponses
        Dns64TotalGlobalServerLoadBalancingQueries|dns64totgslbqueries|string|Total number of DNS64 queries for GSLB domain
        Dns64GlobalServerLoadBalancingQueriesRate|dns64gslbqueriesrate|double|Rate (/s) counter for dns64totgslbqueries
        Dns64TotalGlobalServerLoadBalancingAnswers|dns64totgslbanswers|string|Total number of DNS64 queries served.
        Dns64GlobalServerLoadBalancingAnswersRate|dns64gslbanswersrate|double|Rate (/s) counter for dns64totgslbanswers
        Dns64TotalTcAnswers|dns64tottcanswers|string|Total number of Answers served with TC bit set in DNS64 context.
        Dns64TcAnswersRate|dns64tcanswersrate|double|Rate (/s) counter for dns64tottcanswers
        Dns64TotalServerAQueries|dns64totsvraqueries|string|Total number of Queries sent by DNS64 module to backend.
        Dns64ServerAQueriesRate|dns64svraqueriesrate|double|Rate (/s) counter for dns64totsvraqueries
        Dns64TotalAaaaBypass|dns64totaaaabypass|string|Total number of times AAAA query has been bypassed in DNS64 trnsaction.
        Dns64AaaaBypassRate|dns64aaaabypassrate|double|Rate (/s) counter for dns64totaaaabypass
        Dns64TotalTcpQueries|dns64tottcpqueries|string|Total number of dns64 queries over TCP
        Dns64TcpQueriesRate|dns64tcpqueriesrate|double|Rate (/s) counter for dns64tottcpqueries
        Dns64ActivePolicies|dns64activepolicies|string|Total number of active dns64 policies
        Dns64TotalNoDataResponse|dns64totnodataresp|string|Total number of responses recieved from backend with ancount 0
        Dns64NoDataResponseRate|dns64nodataresprate|double|Rate (/s) counter for dns64totnodataresp
        DnsTotalNsReceivedQueries|dnstotnsrecqueries|string|Total number of NS queries received.
        DnsNsReceivedQueriesRate|dnsnsrecqueriesrate|double|Rate (/s) counter for dnstotnsrecqueries
        DnsTotalSoaReceivedQueries|dnstotsoarecqueries|string|Total number of SOA queries received.
        DnsSoaReceivedQueriesRate|dnssoarecqueriesrate|double|Rate (/s) counter for dnstotsoarecqueries
        DnsTotalPtrReceivedQueries|dnstotptrrecqueries|string|Total number of PTR queries received.
        DnsPtrReceivedQueriesRate|dnsptrrecqueriesrate|double|Rate (/s) counter for dnstotptrrecqueries
        DnsTotalSrvReceivedQueries|dnstotsrvrecqueries|string|Total number of SRV queries received.
        DnsSrvReceivedQueriesRate|dnssrvrecqueriesrate|double|Rate (/s) counter for dnstotsrvrecqueries
        DnsTotalAResponse|dnstotaresponse|string|Total number of A responses received.
        DnsAResponseRate|dnsaresponserate|double|Rate (/s) counter for dnstotaresponse
        DnsTotalCnameResponse|dnstotcnameresponse|string|Total number of CNAME responses received.
        DnsCnameResponseRate|dnscnameresponserate|double|Rate (/s) counter for dnstotcnameresponse
        DnsTotMxResponse|dnstotmxresponse|string|Total number of MX responses received.
        DnsMxResponseRate|dnsmxresponserate|double|Rate (/s) counter for dnstotmxresponse
        DnsTotalAnyResponse|dnstotanyresponse|string|Total number of ANY responses received.
        DnsAnyResponseRate|dnsanyresponserate|double|Rate (/s) counter for dnstotanyresponse
        DnsTotalNsReceivedUpdate|dnstotnsrecupdate|string|Total number of NS record updates.
        DnsTotalSoaReceivedUpdate|dnstotsoarecupdate|string|Total number of SOA record updates.
        DnsTotalPtrReceivedUpdate|dnstotptrrecupdate|string|Total number of PTR record updates.
        DnsTotalSrvReceivedUpdate|dnstotsrvrecupdate|string|Total number of SRV record updates.
        DnsTotalAaaaReceivedQueries|dnstotaaaarecqueries|string|Total number of AAAA queries received.
        DnsAaaaReceivedQueriesRate|dnsaaaarecqueriesrate|double|Rate (/s) counter for dnstotaaaarecqueries
        DnsTotalAReceivedQueries|dnstotarecqueries|string|Total number of A queries received.
        DnsAReceivedQueriesRate|dnsarecqueriesrate|double|Rate (/s) counter for dnstotarecqueries
        DnsTotalCnameReceivedQueries|dnstotcnamerecqueries|string|Total number of CNAME queries received.
        DnsCnameReceivedQueriesRate|dnscnamerecqueriesrate|double|Rate (/s) counter for dnstotcnamerecqueries
        DnsTotalMxReceivedQueries|dnstotmxrecqueries|string|Total number of MX queries received.
        DnsMxReceivedQueriesRate|dnsmxrecqueriesrate|double|Rate (/s) counter for dnstotmxrecqueries
        DnsTotalAnyQueries|dnstotanyqueries|string|Total number of ANY queries received.
        DnsAnyQueriesRate|dnsanyqueriesrate|double|Rate (/s) counter for dnstotanyqueries
        DnsTotalAaaaResponse|dnstotaaaaresponse|string|Total number of AAAA responses received.
        DnsAaaaResponseRate|dnsaaaaresponserate|double|Rate (/s) counter for dnstotaaaaresponse
        DnsTotalNsResponse|dnstotnsresponse|string|Total number of NS responses received.
        DnsNsResponseRate|dnsnsresponserate|double|Rate (/s) counter for dnstotnsresponse
        DnsTotalSoaResponse|dnstotsoaresponse|string|Total number of SOA responses received.
        DnsSoaResponseRate|dnssoaresponserate|double|Rate (/s) counter for dnstotsoaresponse
        DnsTotalPtrResponse|dnstotptrresponse|string|Total number of PTR responses received.
        DnsPtrResponseRate|dnsptrresponserate|double|Rate (/s) counter for dnstotptrresponse
        DnsTotalSrvResponse|dnstotsrvresponse|string|Total number of SRV responses received.
        DnsSrvResponseRate|dnssrvresponserate|double|Rate (/s) counter for dnstotsrvresponse
        DnsTotalAaaaReceivedUpdate|dnstotaaaarecupdate|string|Total number of AAAA record updates.
        DnsTotalAReceivedUpdate|dnstotarecupdate|string|Total number of A record updates.
        DnsTotalMxReceivedUpdate|dnstotmxrecupdate|string|Total number of MX record updates.
        DnsTotalCnameReceivedUpdate|dnstotcnamerecupdate|string|Total number of CNAME record updates.
        DnsCurrentAaaaRecord|dnscuraaaarecord|string|Total number of AAAA records.
        DnsCurrentARecord|dnscurarecord|string|Total number of A records.
        DnsCurrentMxRecord|dnscurmxrecord|string|Total number of MX records.
        DnsCurrentCnameRecord|dnscurcnamerecord|string|Total number of CNAME records.
        DnsCurrentNsRecord|dnscurnsrecord|string|Total number of NS records.
        DnsCurrentSoaRecord|dnscursoarecord|string|Total number of SOA records.
        DnsCurrentPtrRecord|dnscurptrrecord|string|Total number of PTR records.
        DnsCurSrvRecord|dnscursrvrecord|string|Total number of SRV records.
        DnsTotalAaaaRecordFailed|dnstotaaaarecfailed|string|Total number of times AAAA record lookup failed.
        DnsTotalARecordFailed|dnstotarecfailed|string|Total number of times A record lookup failed.
        DnsTotalMxRecordFailed|dnstotmxrecfailed|string|Total number of times MX record lookup failed.
        DnsTotalPtrRecordFailed|dnstotptrrecfailed|string|Total number of times PTR record lookup failed.
        DnsTotalNsRecordFailed|dnstotnsrecfailed|string|Total number of times NS record lookup failed.
        DnsTotalCnameRecordFailed|dnstotcnamerecfailed|string|Total number of times CNAME record lookup failed.
        DnsTotalSoaRecordFailed|dnstotsoarecfailed|string|Total number of times SOA record lookup failed.
        DnsTotalSrvRecordFailed|dnstotsrvrecfailed|string|Total number of times SRV record lookup failed.
        DnsTotalAnyRecordFailed|dnstotanyrecfailed|string|Total number of times ANY query lookup failed.
        DnsTotalUnsupportedQueries|dnstotunsupportedqueries|string|Total number of requests for which query type requested was unsupported.


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<DnsStatCommand>(INitroServiceClient, New DnsStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object DnsStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For DnsStat, that object is <u>DnsStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - DnsStatistics: a DnsStats-object returned by the Get-Request, containing the properties mentioned above.




#### DnsPolicyLabel

+ Get
    * Properties  

        The following properties can be found in the DnsPolicyLabelStats-object inside of an array "DnsPolicyLabelStatics" inside of a DnsPolicyLabelStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        LabelName|labelname|string|The name of the dns policy label for which statistics will be displayed.
        PolicyLabelHits|pipolicylabelhits|string|Number of times policy label was invoked.
        PolicyLabelHitsRate|pipolicylabelhitsrate|double|Rate (/s) counter for pipolicylabelhits
        


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<DnsPolicyLabelStatCommand>(INitroServiceClient, New DnsPolicyLabelStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object DnsPolicyLabelStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:labelname, value: string
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For DnsPolicyLabelStat, that object is <u>DnsPolicyLabelStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - DnsPolicyLabelStatistics: an array of DnsPolicyLabelStats-objects returned by the Get-Request, containing the properties mentioned above.




#### DnsRecords

+ Get
    * Properties  

        The following properties can be found in the DnsRecordsStats-object inside of an array "DnsRecordsStatics" inside of a DnsRecordsStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        DnsRecordType|dnsrecordtype|string|Display statistics for the specified DNS record or query type or
        DnsCurrentEntries|dnscurentries|string|Current number of DNS entries
        DnsTotalUpdates|dnstotupdates|string|Total number of DNS proactive updates
        DnsTotalRequests|dnstotrequests|string|Total number of DNS queries recieved
        DnsTotalErrorAliasExists|dnstoterraliasex|string|Total number of times we have recieved non-cname record for a domain for which an alias exists
        DnsTotalErrorResponseForm|dnstoterrrespform|string|Total number of times we have recieved malformed responses from the backend
        DnsTotalEntries|dnstotentries|string|Total number of DNS record entries
        DnsCurrentRecords|dnscurrecords|string|Current number of DNS Records
        DnsTotalErrorNoDomains|dnstoterrnodomains|string|Total number of cache misses
        DnsTotalErrorLimits|dnstoterrlimits|string|Total number of times we have recieved dns record with more entries than we support
        DnsTotalResponses|dnstotresponses|string|Total number of DNS server responses
        


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<DnsRecordsStatCommand>(INitroServiceClient, New DnsRecordsStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object DnsRecordsStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:dnsrecordtype, value: string
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For DnsRecordsStat, that object is <u>DnsRecordsStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - DnsRecordsStatistics: an array of DnsRecordsStats-objects returned by the Get-Request, containing the properties mentioned above.