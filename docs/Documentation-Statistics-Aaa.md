### Aaa

#### Aaa

+ Get
    * Properties  

        The following properties van be found in each AaaStats found in the array "AaaStats" inside of a AaaStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        AaaAuthenticationSuccesses|aaaauthsuccess|string|Count of authentication successes.
        AaaAuthenticationSuccessesRate|aaaauthsuccessrate|double|Rate (/s) counter for aaaauthsuccess
        AaaAuthenticationFailures|aaaauthfail|string|Count of authentication failures.
        AaaAuthenticationFailuresRate|aaaauthfailrate|double|Rate (/s) counter for aaaauthfail
        AaaAuthenticationOnlyHttpSuccess|aaaauthonlyhttpsuccess|string|Count of HTTP connections that succeeded authorization.
        AaaAuthenticationOnlyHttpSuccessRate|aaaauthonlyhttpsuccessrate|double|Rate (/s) counter for aaaauthonlyhttpsuccess
        AaaAuthenticationOnlyHttpFail|aaaauthonlyhttpfail|string|Count of HTTP connections that failed authorization.
        AaaAuthenticationOnlyHttpFailRate|aaaauthonlyhttpfailrate|double|Rate (/s) counter for aaaauthonlyhttpfail
        AaaAuthenticationNonHttpSuccess|aaaauthnonhttpsuccess|string|Count of non HTTP connections that succeeded authorization.
        AaaAuthenticationNonHttpSuccessRate|aaaauthnonhttpsuccessrate|double|Rate (/s) counter for aaaauthnonhttpsuccess
        AaaAuthenticationNonHttpFail|aaaauthnonhttpfail|string|Count of non HTTP connections that failed authorization.
        AaaAuthenticationNonHttpFailRate|aaaauthnonhttpfailrate|double|Rate (/s) counter for aaaauthnonhttpfail
        AaaCurrentSessions|aaacursessions|string|Count of current SmartAccess AAA sessions.
        AaaCurrentSessionsRate|aaacursessionsrate|double|Rate (/s) counter for aaacursessions
        AaaTotalSessions|aaatotsessions|string|Count of all SmartAccess AAA sessions.
        AaaSessionsRate|aaasessionsrate|double|Rate (/s) counter for aaatotsessions
        AaaTotalSessionsTimedOut|aaatotsessiontimeout|string|Count of AAA sessions that have timed out.
        AaaSessionsTimedOutRate|aaasessiontimeoutrate|double|Rate (/s) counter for aaatotsessiontimeout
        AaaCurrentIcaSessions|aaacuricasessions|string|Count of current Basic ICA only sessions.
        AaaCurrentIcaSessionsRate|aaacuricasessionsrate|double|Rate (/s) counter for aaacuricasessions
        AaaCurrentIcaOnlyConnections|aaacuricaonlyconn|string|Count of current Basic ICA only connections.
        AaaCurrentIcaOnlyConnectionsRate|aaacuricaonlyconnrate|double|Rate (/s) counter for aaacuricaonlyconn
        AaaCurrentIcaConnections|aaacuricaconn|string|Count of current SmartAccess ICA connections.
        AaaCurrentIcaConnectionsRate|aaacuricaconnrate|double|Rate (/s) counter for aaacuricaconn
        AaaCurrentTmSessions|aaacurtmsessions|string|Count of current AAATM sessions.
        AaaCurrentTmSessionsRate|aaacurtmsessionsrate|string|Rate (/s) counter for aaacurtmsessions
        AaaTotalTmSessions|aaatottmsessions|string|Count of all AAATM sessions.
        AaaTmSessionsRate|aaatmsessionsrate|double|Rate (/s) counter for aaatottmsessions



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AaaStatCommand>(INitroServiceClient, New AaaStatRequestOptions(){ });
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
        - AaaStats: an array of AaaStats-objects returned by the Get-Request, all of which contain the properties mentioned above.
