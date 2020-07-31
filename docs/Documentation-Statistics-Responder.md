### Responder

#### ResponderPolicy

+ Get
    * Properties  

        The following properties van be found in each ResponderPolicyStats found in the array "ResponderPolicyStatistics" inside of a ResponderPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the responder policy for which to show detailed statistics.
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<ResponderPolicyStatCommand>(INitroServiceClient, New ResponderPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object ResponderPolicyStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ResponderPolicyStat, that object is <u>ResponderPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - ResponderPolicyStatistics: an array of ResponderPolicyStats-objects returned by the Get-Request, all of which contain the properties mentioned above.




#### ResponderPolicyLabel

+ Get
    * Properties  

        The following properties van be found in each ResponderPolicyLabelStats found in the array "ResponderPolicyLabelStatistics" inside of a ResponderPolicyLabelStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        LabelName|labelname|string|Name of the responder policy label.
        PolicyLabelHits|pipolicylabelhits|Number of times policy label was invoked.
        PolicyLabelHitsRate|pipolicylabelhitsrate|double|Rate (/s) counter for pipolicylabelhits


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<ResponderPolicyLabelStatCommand>(INitroServiceClient, New ResponderPolicyLabelStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object ResponderPolicyLabelStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For ResponderPolicyLabelStat, that object is <u>ResponderPolicyLabelStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - ResponderPolicyLabelStatistics: an array of ResponderPolicyLabelStats-objects returned by the Get-Request, all of which contain the properties mentioned above.
