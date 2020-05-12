### System

#### SystemBackup

Commands: Add, Create, Delete, Get

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        FileName|string|Name of the backup file(*.tgz) to be restored. 

   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SystemBackupAddCommand> (INitroServiceClient, new SystemBackupAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SystemBackupAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Create:
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        FileName|string|Name of the backup file(*.tgz) to be restored. 
        Comment|string|Comment.
        Level|string|Level of data to be backed up. Default value: basic. Possible values = basic, full 

   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SystemBackupCreateCommand> (INitroServiceClient, new SystemBackupCreateRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SystemBackupCreate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors). 

+ Get
    * Properties  

        The following properties van be found in each SystemBackupConfiguration found in the array "SystemBackups" inside of a SystemBackupGetResponse.

        Property|DataType|Description
        ---|---|---
        FileName|string|Name of the backup file(*.tgz) to be restored. 
        Level|string|Level of data to be backed up. Default value: basic. Possible values = basic, full 
        IncludeKernel|string|Use this option to add kernel in the backup file. Default value: NO. Possible values = NO, YES 
        Comment|string|Comment specified at the time of creation of the backup file(*.tgz). 
        Size|double|Size of the backup file(*.tgz) in KB.
        UseLocalTimezone|bool|This option will create backup file with local timezone timestamp. 
        CreationTime|string|Creation time of the backup file(*.tgz). 
        Version|string|Build version of the backup file(*.tgz). 
        CreatedBy|string|Name of user who created the backup file(*.tgz). 
        IpAddress|string|Ip of Citrix ADC box where the backup file(*.tgz) was created. 
        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemBackupGetCommand>(INitroServiceClient, New SystemBackupGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemBackupGet, that object is <u>SystemBackupGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemBackups: an array of SystemBackupConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemBackupRemoveCommand>(INitroServiceClient, new SystemBackupRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object SystemBackupRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemBackupRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

#### SystemFile

Commands: Add, Delete, Get

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        FileName|string| Name of the file. It should not include filepath. 
        FileContent|string|file content in Base64 format. 
        FileLocation|string|location of the file on Citrix ADC. 
        FileEncoding|string|encoding type of the file content. Default value: "BASE64" 

   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SystemFileAddCommand> (INitroServiceClient, new SystemFileAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SystemFileAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each SystemFileConfiguration found in the array "SystemFiles" inside of a SystemFileGetResponse.

        Property|DataType|Description
        ---|---|---
        FileName|string| Name of the file. It should not include filepath. 
        FileContent|string|file content in Base64 format. 
        FileLocation|string|location of the file on Citrix ADC. 
        FileEncoding|string|encoding type of the file content. Default value: "BASE64" 
        FileAccessTime|string|Last access time of the file. 
        FileModifiedTime|string|last modified time of the file. 
        FileMode|string|file mode. Possible values = DIRECTORY 
        FileSize|double|Size of the file in BYTES. 
        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemFileGetCommand>(INitroServiceClient, New SystemFileGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemFileGet, that object is <u>SystemFileGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemFiles: an array of SystemFileConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemFileRemoveCommand>(INitroServiceClient, new SystemFileRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object SystemFileRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.
        <u>Arguments</u>: a dictionary<string, string> to which you will have to add the following data of the object you wish to remove. filelocation:<Filelocation_value>
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemFileRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

#### SystemSshKey

Commands: Import, Delete, Get

+ Import:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|Name of the SshKey.
        SshKeyType|string|The type of the ssh key whether public or private key. Possible values = PRIVATE, PUBLIC 
        Src|string|URL \(protocol, host, path, and file name\) from where the location file will be imported. NOTE: The import fails if the object to be imported is on an HTTPS server that requires client certificate authentication for access. 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SystemSshKeyImportCommand> (INitroServiceClient, new SystemSshKeyImportRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SystemSshKeyImport, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each SystemSshKeyConfiguration found in the array "SystemSshKeys" inside of a SystemSshKeyGetResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|Name of the SshKey.
        SshKeyType|string|The type of the ssh key whether public or private key. Possible values = PRIVATE, PUBLIC 
        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemSshKeyGetCommand>(INitroServiceClient, New SystemSshKeyGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemSshKeyGet, that object is <u>SystemSshKeyGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemSshKeys: an array of SystemSshKeyConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemSshKeyRemoveCommand>(INitroServiceClient, new SystemSshKeyRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object SystemSshKeyRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.
        <u>Arguments</u>: a dictionary<string, string> to which you will have to add the following data of the object you wish to remove. sshkeytype:<sshkeytype_value>
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemSshKeyRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

#### SystemUser

Commands: Add, Delete, Get, Update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        UserName|string|Name for a user. Must begin with a letter, number, or the underscore (_) character, and must contain only alphanumeric, hyphen (-), period (.), hash (#), space ( ), at (@), equal (=), colon (:), and underscore characters. Cannot be changed after the user is added. 
        Password|string|Password for the system user. Can include any ASCII character. 
        ExternalAuth|string|Whether to use external authentication servers for the system user authentication or not. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        PromptString|string|String to display at the command-line prompt. Can consist of letters, numbers, hyphen (-), period (.), hash (#), space ( ), at (@), equal (=), colon (:), underscore (_), and the following variables: %u - Will be replaced by the user name. %h - Will be replaced by the hostname of the Citrix ADC. %t - Will be replaced by the current time in 12-hour format. %T - Will be replaced by the current time in 24-hour format. %d - Will be replaced by the current date. %s - Will be replaced by the state of the Citrix ADC. 
        Timeout|double|CLI session inactivity timeout, in seconds. If Restrictedtimeout argument of system parameter is enabled, Timeout can have values in the range [300-86400] seconds. If Restrictedtimeout argument of system parameter is disabled, Timeout can have values in the range [0, 10-100000000] seconds. Default value is 900 seconds. 
        Logging|string|Users logging privilege. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MaxSession|string|Maximum number of client connection allowed per user. 
        AllowedManagementInterface|string[ ]|Allowed Management interfaces to the system user. By default user is allowed from both API and CLI interfaces. If management interface for a user is set to API, then user is not allowed to access NS through CLI. GUI interface will come under API interface. Default value: NS_INTERFACE_ALL. Possible values = CLI, API 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SystemUserAddCommand> (INitroServiceClient, new SystemUserAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SystemUserAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).

+ Get
    * Properties  

        The following properties van be found in each SystemUserConfiguration found in the array "SystemUsers" inside of a SystemUserGetResponse.

        Property|DataType|Description
        ---|---|---
        UserName|string|Name for a user. Must begin with a letter, number, or the underscore (_) character, and must contain only alphanumeric, hyphen (-), period (.), hash (#), space ( ), at (@), equal (=), colon (:), and underscore characters. Cannot be changed after the user is added. 
        Password|string|Password for the system user. Can include any ASCII character. 
        ExternalAuth|string|Whether to use external authentication servers for the system user authentication or not. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        PromptString|string|String to display at the command-line prompt. Can consist of letters, numbers, hyphen (-), period (.), hash (#), space ( ), at (@), equal (=), colon (:), underscore (_), and the following variables: %u - Will be replaced by the user name. %h - Will be replaced by the hostname of the Citrix ADC. %t - Will be replaced by the current time in 12-hour format. %T - Will be replaced by the current time in 24-hour format. %d - Will be replaced by the current date. %s - Will be replaced by the state of the Citrix ADC. 
        Timeout|double|CLI session inactivity timeout, in seconds. If Restrictedtimeout argument of system parameter is enabled, Timeout can have values in the range [300-86400] seconds. If Restrictedtimeout argument of system parameter is disabled, Timeout can have values in the range [0, 10-100000000] seconds. Default value is 900 seconds. 
        Logging|string|Users logging privilege. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MaxSession|string|Maximum number of client connection allowed per user. 
        AllowedManagementInterface|string[ ]|Allowed Management interfaces to the system user. By default user is allowed from both API and CLI interfaces. If management interface for a user is set to API, then user is not allowed to access NS through CLI. GUI interface will come under API interface. Default value: NS_INTERFACE_ALL. Possible values = CLI, API 
        Encrypted|bool|-
        HashMethod|string|-
        PromptInheritedFrom|string|From where the prompt has been inherited. Possible values = User, Group, Global, Climode 
        TimeoutKind|string|From where the timeout has been inherited. Possible values = User, Group, Global, Climode 
        AllowedManagementInterfaceKind|string|Value of allowed interface which can be inherited from Global, Group or User. Possible values = User, Group, Global, Climode 
        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemUserGetCommand>(INitroServiceClient, New SystemUserGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemUserGet, that object is <u>SystemUserGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemUsers: an array of SystemUserConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemUserRemoveCommand>(INitroServiceClient, new SystemUserRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object SystemUserRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemUserRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 

#### SystemUserBinding

Commands: Get

+ Get
    * Properties  

        The following properties van be found in each SystemUserBindingConfiguration found in the array "SystemUserBindings" inside of a SystemUserBindingGetResponse.

        Property|DataType|Description
        ---|---|---
        UserName|string|Name for a user. Must begin with a letter, number, or the underscore (_) character, and must contain only alphanumeric, hyphen (-), period (.), hash (#), space ( ), at (@), equal (=), colon (:), and underscore characters. Cannot be changed after the user is added. 
        SystemUserSystemGroupBinding|SystemUserSystemGroupBindingConfiguration[]|systemgroup that can be bound to systemuser. 
        SystemUserNsPartition|SystemUserNsPartitionBindingConfiguration[]|nspartition that can be bound to systemuser. 
        SystemUserSystemCmdPolicy|SystemUserSystemCmdPolicyBindingConfiguration[]|systemcmdpolicy that can be bound to systemuser.

        

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemUserBindingGetCommand>(INitroServiceClient, New SystemUserGetBindingRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemUserBindingGet, that object is <u>SystemUserBindingGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemUserBindings: an array of SystemUserBindingConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

#### SystemUserNsPartitionBinding

Commands: Get

+ Get -NYI
    * Properties  

        The following properties van be found in each SystemUserNsPartitionBindingConfiguration found in the array "SystemUserNsPartitionBindings" inside of a SystemUserNsPartitionBindingGetResponse.

        Property|DataType|Description
        ---|---|---
        UserName|string|name of the user.
        PartitionName|string|name of the partition.

#### SystemUserSystemGroupBinding

Commands: Get

+ Get -NYI
    * Properties  

        The following properties van be found in each SystemUserSystemGroupBindingConfiguration found in the array "SystemUserSystemGroupBindings" inside of a SystemUserSystemGroupBindingGetResponse.

        Property|DataType|Description
        ---|---|---
        UserName|string|name of the user.
        GroupName|string|name of the partition.

#### SystemUserSystemCmdPolicyBinding

Commands: Get

+ Get -NYI
    * Properties  

        The following properties van be found in each SystemUserSystemCmdPolicyBindingConfiguration found in the array "SystemUserSystemCmdPolicyBindings" inside of a SystemUserSystemCmdPolicyBindingGetResponse.

        Property|DataType|Description
        ---|---|---
        UserName|string|name of the user.
        Priority|string|-
        PolicyName|string|-