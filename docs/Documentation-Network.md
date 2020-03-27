### Network

#### IpSet

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|name of the IpSet
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.

   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<IpSetAddCommand> (INitroServiceClient, new IpSetAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for IpSetAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each IpSetConfiguration found in the array "IpSets" inside of a IpSetGetResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|name of the IpSet
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<IpSetGetCommand>(INitroServiceClient, New IpSetGetRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object IpSetGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For IpSetGet, that object is <u>IpSetGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - IpSets: an array of IpsetConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<IpSetRemoveCommand>(INitroServiceClient, new IpSetRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object IpSetRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For IpSetRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update:
    * Properties:

        Property|ValueType|Description
        ---|---|---
        Name|string|name of the IpSet
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (IpSetUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<IpSetUpdateCommand> (INitroServiceClient, new IpSetUpdateRequestData(){ });
            ```


    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For IpsetUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


#### NetProfile

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|name of the NetProfile
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        SrcIp|string|IP address or the name of an IP set.
        SrcIpPersitency|string|When the net profile is associated with a virtual server or its bound services, this option enables the NetScaler appliance to use the same address, specified in the net profile, to communicate to servers for all sessions initiated from a particular client to the virtual server. Default value: DISABLED. Possible values = ENABLED, DISABLED
        OverrideLsn|string|USNIP/USIP settings override LSN settings for configured service/virtual server traffic.. . Default value: DISABLED Possible values = ENABLED, DISABLED

   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<NetProfileAddCommand> (INitroServiceClient, new NetProfileAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for NetProfile, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each IpSetConfiguration found in the array "IpSets" inside of a IpSetGetResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|name of the NetProfile
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        SrcIp|string|IP address or the name of an IP set.
        SrcIpPersitency|string|When the net profile is associated with a virtual server or its bound services, this option enables the NetScaler appliance to use the same address, specified in the net profile, to communicate to servers for all sessions initiated from a particular client to the virtual server. Default value: DISABLED. Possible values = ENABLED, DISABLED
        OverrideLsn|string|USNIP/USIP settings override LSN settings for configured service/virtual server traffic.. . Default value: DISABLED Possible values = ENABLED, DISABLED
        Count|double|Count Parameter.

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NetProfileGetCommand>(INitroServiceClient, New NetProfileGetRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object NetProfileGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NetProfileGet, that object is <u>NetProfileGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - NetProfiles: an array of NetProfileConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NetProfileRemoveCommand>(INitroServiceClient, new NetProfileRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object NetProfileRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NetProfileRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

+ Update:
    * Properties:

        Property|ValueType|Description
        ---|---|---
        Name|string|name of the NetProfile
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        SrcIp|string|IP address or the name of an IP set.
        SrcIpPersitency|string|When the net profile is associated with a virtual server or its bound services, this option enables the NetScaler appliance to use the same address, specified in the net profile, to communicate to servers for all sessions initiated from a particular client to the virtual server. Default value: DISABLED. Possible values = ENABLED, DISABLED
        OverrideLsn|string|USNIP/USIP settings override LSN settings for configured service/virtual server traffic.. . Default value: DISABLED Possible values = ENABLED, DISABLED


    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (NetProfileUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<NetProfileUpdateCommand> (INitroServiceClient, new NetProfileUpdateRequestData(){ });
            ```


    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NetProfileUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 
