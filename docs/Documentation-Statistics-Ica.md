### Ica

#### IcaPolicy

+ Get
    * Properties  

        The following properties can be found in the IcaPolicyStats-objects-array inside of a IcaPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the ica policy.
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits


  


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<IcaPolicyStatCommand>(INitroServiceClient, New IcaPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object IcaPolicyStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For IcaPolicyStat, that object is <u>IcaPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - IcaPolicyStatistics: a IcaPolicyStats-object returned by the Get-Request, containing the properties mentioned above.