### Rewrite

#### RewritePolicy

+ Get
    * Properties  

        The following properties van be found in each RewritePolicyStats found in the array "RewritePolicyStatistics" inside of a RewritePolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the rewrite policy.
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<RewritePolicyStatCommand>(INitroServiceClient, New RewritePolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object RewritePolicyStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For RewritePolicyStat, that object is <u>RewritePolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - RewritePolicyStatistics: an array of RewritePolicyStats-objects returned by the Get-Request, all of which contain the properties mentioned above.




#### RewritePolicyLabel

+ Get
    * Properties  

        The following properties van be found in each RewritePolicyLabelStats found in the array "RewritePolicyLabelStatistics" inside of a RewritePolicyLabelStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        LabelName|labelname|string|Name of the rewrite policy label.
        PolicyLabelHits|pipolicylabelhits|Number of times policy label was invoked.
        PolicyLabelHitsRate|pipolicylabelhitsrate|double|Rate (/s) counter for pipolicylabelhits


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<RewritePolicyLabelStatCommand>(INitroServiceClient, New RewritePolicyLabelStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object RewritePolicyLabelStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For RewritePolicyLabelStat, that object is <u>RewritePolicyLabelStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - RewritePolicyLabelStatistics: an array of RewritePolicyLabelStats-objects returned by the Get-Request, all of which contain the properties mentioned above.