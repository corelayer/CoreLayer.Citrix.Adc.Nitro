### Authentication

#### AuthenticationLoginSchemaPolicy

+ Get
    * Properties  

        The following properties can be found in the AuthenticationLoginSchemaPolicyStats-objects in the array "AuthenticationLoginSchemaPolicyStatistics" inside of a AuthenticationLoginSchemaPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|The name of the LoginSchema policy for which statistics will be displayed. 
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AuthenticationLoginSchemaPolicyStatCommand>(INitroServiceClient, New AuthenticationLoginSchemaPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object AuthenticationLoginSchemaPolicyStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:name, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For AuthenticationLoginSchemaPolicyStat, that object is <u>AuthenticationLoginSchemaPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - AuthenticationLoginSchemaPolicyStatistics: an array of AuthenticationLoginSchemaPolicyStats-objects returned by the Get-Request, each containing the properties mentioned above.




#### AuthenticationOAuthIdPPolicy

+ Get
    * Properties  

        The following properties can be found in the AuthenticationOAuthIdPPolicyStats-objects in the array "AuthenticationOAuthIdPPolicyStatistics" inside of a AuthenticationOAuthIdPPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|The name of the OAuth Identity Provider (IdP) policy for which statistics will be displayed. 
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AuthenticationOAuthIdPPolicyStatCommand>(INitroServiceClient, New AuthenticationOAuthIdPPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object AuthenticationOAuthIdPPolicyStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the properties matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are: (even if a bool or double is required, they will be passed as string (so true => "true"))  
            - key:name, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For AuthenticationOAuthIdPPolicyStat, that object is <u>AuthenticationOAuthIdPPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - AuthenticationOAuthIdPPolicyStatistics: an array of AuthenticationOAuthIdPPolicyStats-objects returned by the Get-Request, each containing the properties mentioned above.




#### AuthenticationPolicy

+ Get
    * Properties  

        The following properties can be found in the AuthenticationPolicyStats-objects in the array "AuthenticationPolicyStatistics" inside of a AuthenticationPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the advanced authentication policy for which to display statistics.
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AuthenticationPolicyStatCommand>(INitroServiceClient, New AuthenticationPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object AuthenticationPolicyStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the properties matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are: (even if a bool or double is required, they will be passed as string (so true => "true"))  
            - key:name, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For AuthenticationPolicyStat, that object is <u>AuthenticationPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - AuthenticationPolicyStatistics: an array of AuthenticationPolicyStats-objects returned by the Get-Request, each containing the properties mentioned above.



#### AuthenticationPolicyLabel

+ Get
    * Properties  

        The following properties can be found in the AuthenticationPolicyLabelStats-objects in the array "AuthenticationPolicyLabelStatistics" inside of a AuthenticationPolicyLabelStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        LabelName|labelname|string|Name of the authentication policy label.
        PolicyLabelHits|pipolicylabelhits|string|Number of times policy label was invoked.
        PolicyLabelHitsRate|pipolicylabelhitsrate|double|Rate (/s) counter for pipolicylabelhits



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AuthenticationPolicyLabelStatCommand>(INitroServiceClient, New AuthenticationPolicyLabelStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object AuthenticationPolicyLabelStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the properties matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are: (even if a bool or double is required, they will be passed as string (so true => "true"))  
            - key:labelname, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For AuthenticationPolicyLabelStat, that object is <u>AuthenticationPolicyLabelStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - AuthenticationPolicyLabelStatistics: an array of AuthenticationPolicyLabelStats-objects returned by the Get-Request, each containing the properties mentioned above.



#### AuthenticationSamlIdPPolicy

+ Get
    * Properties  

        The following properties can be found in the AuthenticationSamlIdPPolicyStats-objects in the array "AuthenticationSamlIdPPolicyStatistics" inside of a AuthenticationSamlIdPPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|labelname|string|The name of the SAML Identity Provider (IdP) policy for which statistics will be displayed.
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AuthenticationSamlIdPPolicyStatCommand>(INitroServiceClient, New AuthenticationSamlIdPPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object AuthenticationSamlIdPPolicyStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the properties matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are: (even if a bool or double is required, they will be passed as string (so true => "true"))  
            - key:name, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For AuthenticationSamlIdPPolicyStat, that object is <u>AuthenticationSamlIdPPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - AuthenticationSamlIdPPolicyStatistics: an array of AuthenticationSamlIdPPolicyStats-objects returned by the Get-Request, each containing the properties mentioned above.




#### AuthenticationVserver

+ Get
    * Properties  

        The following properties can be found in the AuthenticationVserverStats-objects in the array "AuthenticationVserverStatistics" inside of a AuthenticationVserverStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the authentication virtual server.
        Type|type|string|Protocol associated with the vserver
        PrimaryIpAddress|primaryipaddress|string|The IP address on which the service is running.
        State|state|string|Current state of the server. There are seven possible values: UP(7), DOWN(1), UNKNOWN(2), BUSY(3), OFS(Out of Service)(4), TROFS(Transition Out of Service)(5), TROFS_DOWN(Down When going Out of Service)(8)
        PrimaryPort|primaryport|int|The port on which the service is running.
        TotalRequests|totalrequests|string|Total number of requests received on this service or virtual server. 
        RequestsRate|requestsrate|double|Rate (/s) counter for totalrequests
        TotalResponses|totalresponses|string|Number of responses received on this service or virtual server. 
        ResponsesRate|responsesrate|double|Rate (/s) counter for totalresponses
        TotalRequestBytes|totalrequestbytes|string|Total number of request bytes received on this service or virtual server.
        RequestBytesRate|requestbytesrate|double|Rate (/s) counter for totalrequestbytes
        TotalResponseBytes|totalresponsebytes|string|Number of response bytes received by this service or virtual server.
        ResponseBytesRate|responsebytesrate|double|Rate (/s) counter for totalresponsebytes



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<AuthenticationVserverStatCommand>(INitroServiceClient, New AuthenticationVserverStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object AuthenticationVserverStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the properties matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are: (even if a bool or double is required, they will be passed as string (so true => "true"))  
            - key:name, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For AuthenticationVserverStat, that object is <u>AuthenticationVserverStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - AuthenticationVserverStatistics: an array of AuthenticationVserverStats-objects returned by the Get-Request, each containing the properties mentioned above.