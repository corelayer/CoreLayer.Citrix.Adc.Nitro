### Bot

#### Bot

+ Get
    * Properties  

        The following properties can be found in the BotStats-object inside of a BotStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        BotRequests|botrequests|string|HTTP/HTTPS requests sent to your protected web servers via the Bot Management.
        BotRequestsRate|botrequestsrate|double|Rate (/s) counter for botrequests
        BotRequestBytes|botreqbytes|string|Number of bytes transfered for requests
        BotRequestBytesRate|botreqbytesrate|double|Rate (/s) counter for botreqbytes
        BotResponses|botresponses|string|HTTP/HTTPS responses sent by your protected web servers via the Bot Management.
        BotResponsesRate|botresponsesrate|double|Rate (/s) counter for botresponses
        BotResponseBytes|botresbytes|string|Number of bytes transfered for responses
        BotResponseBytesRate|botresbytesrate|double|Rate (/s) counter for botresbytes
        BotViolationsDeviceFingerprint|botvioldevicefingerprint|string|Number of device fingerprint violations seen by the Bot Management.
        BotViolationsDeviceFingerprintRate|botvioldevicefingerprintrate|double|Rate (/s) counter for botvioldevicefingerprint
        BotViolationsDeviceFingerprintLog|botvioldevicefingerprintlog|string|Number of device fingerprint violations logged by the Bot Management.
        BotViolationsDeviceFingerprintLogRate|botvioldevicefingerprintlograte|double|Rate (/s) counter for botvioldevicefingerprintlog
        BotViolationsDeviceFingerprintDrop|botvioldevicefingerprintdrop|string|Number of device fingerprint violations dropped by the Bot Management.
        BotViolationsDeviceFingerprintDropRate|botvioldevicefingerprintdroprate|double|Rate (/s) counter for botvioldevicefingerprintdrop
        BotViolationsDeviceFingerprintRedirect|botvioldevicefingerprintredirect|string|Number of device fingerprint violations requests redirected by the Bot Management to a different Web page or web server.
        BotViolationsDeviceFingerprintRedirectRate|botvioldevicefingerprintredirectrate|double|Rate (/s) counter for botvioldevicefingerprintredirect
        BotViolationsDeviceFingerprintCaptcha|botvioldevicefingerprintcaptcha|string|-
        BotViolationsDeviceFingerprintCaptchaRate|botvioldevicefingerprintcaptcharate|double|-
        BotViolationIpReputation|botviolipreputation|string|Number of ip reputation violations seen by the Bot Management.
        BotViolationIpReputationRate|botviolipreputationrate|double|Rate (/s) counter for botviolipreputation
        BotViolationIpReputationLog|botviolipreputationlog|string|Number of ip reputation violations logged by the Bot Management.
        BotViolationIpReputationLogRate|botviolipreputationlograte|double|Rate (/s) counter for botviolipreputationlog
        BotViolationIpReputationDrop|botviolipreputationdrop|string|Number of ip reputation violations dropped by the Bot Management.
        BotViolationIpReputationDropRate|botviolipreputationdroprate|double|Rate (/s) counter for botviolipreputationdrop
        BotViolationIpReputationRedirect|botviolipreputationredirect|string|Number of ip reputation violations requests redirected by the Bot Management to a different Web page or web server.
        BotViolationIpReputationRedirectRate|botviolipreputationredirectrate|double|Rate (/s) counter for botviolipreputationredirect
        BotViolationIpReputationCaptcha|botviolipreputationcaptcha|string|-
        BotViolationIpReputationCaptchaRate|botviolipreputationcaptcharate|double|-
        BotViolationWhitelist|botviolwhitelist|string|Number of white list violations seen by the Bot Management.
        BotViolationWhitelistRate|botviolwhitelistrate|double|Rate (/s) counter for botviolwhitelist
        BotViolationWhitelistLog|botviolwhitelistlog|string|Number of white list violations logged by the Bot Management.
        BotViolationWhitelistLogRate|botviolwhitelistlograte|double|Rate (/s) counter for botviolwhitelistlog
        BotViolationBlacklist|botviolblacklist|string|Number of black list violations seen by the Bot Management.
        BotViolationBlacklistRate|botviolblacklistrate|double|Rate (/s) counter for botviolblacklist
        BotViolationBlacklistLog|botviolblacklistlog|string|Number of black list violations logged by the Bot Management.
        BotViolationBlacklistLogRate|botviolblacklistlograte|double|Rate (/s) counter for botviolblacklistlog
        BotViolationBlacklistDrop|botviolblacklistdrop|string|Number of black list violations dropped by the Bot Management.
        BotViolationBlacklistDropRate|botviolblacklistdroprate|double|Rate (/s) counter for botviolblacklistdrop
        BotViolationBlacklistRedirect|botviolblacklistredirect|string|Number of black list violations redirected by the Bot Management to a different Web page or web server.
        BotViolationBlacklistRedirectRate|botviolblacklistredirectrate|double|Rate (/s) counter for botviolblacklistredirect
        BotViolationRateLimit|botviolratelimit|string|Number of rate limiting violations seen by the Bot Management.
        BotViolationRateLimitRate|botviolratelimitrate|double|Rate (/s) counter for botviolratelimit
        BotViolationRateLimitLog|botviolratelimitlog|string|Number of rate limiting violations logged by the Bot Management.
        BotViolationRateLimitLogRate|botviolratelimitlograte|double|Rate (/s) counter for botviolratelimitlog
        BotViolationRateLimitDrop|botviolratelimitdrop|string|Number of rate limiting violations dropped by the Bot Management.
        BotViolationRateLimitDropRate|botviolratelimitdroprate|double|Rate (/s) counter for botviolratelimitdrop
        BotViolationRateLimitRedirect|botviolratelimitredirect|string|Number of rate limiting violations requests redirected by the Bot Management to a different Web page or web server.
        BotViolationRateLimitRedirectRate|botviolratelimitredirectrate|double|Rate (/s) counter for botviolratelimitredirect
        BotViolationStaticSignature|botviolstaticsignature|string|Number of static signature violations seen by the Bot Management.
        BotViolationStaticSignatureRate|botviolstaticsignaturerate|double|Rate (/s) counter for botviolstaticsignature
        BotViolationStaticSignatureLog|botviolstaticsignaturelog|string|Number of static signature violations logged by the Bot Management.
        BotViolationStaticSignatureLogRate|botviolstaticsignaturelograte|double|Rate (/s) counter for botviolstaticsignaturelog
        BotViolationStaticSignatureDrop|botviolstaticsignaturedrop|string|Number of static signature violations dropped by the Bot Management.
        BotViolationStaticSignatureDropRate|botviolstaticsignaturedroprate|double|Rate (/s) counter for botviolstaticsignaturedrop
        BotViolationStaticSignatureRedirect|botviolstaticsignatureredirect|string|Number of static signature violations requests redirected by the Bot Management to a different Web page or web server.
        BotViolationStaticSignatureRedirectRate|botviolstaticsignatureredirectrate|double|Rate (/s) counter for botviolstaticsignatureredirect




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<BotStatCommand>(INitroServiceClient, New BotStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object BotStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For BotStat, that object is <u>BotStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - BotStatistics: a BotStats-object returned by the Get-Request, containing the properties mentioned above.




#### BotPolicy

+ Get
    * Properties  

        The following properties can be found in each BotPolicyStats-object inside of an array "BotPolicyStatistics" of a BotPolicyStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the bot policy for which to show detailed statistics.
        PolicyUndefinedHits|pipolicyundefhits|string|Number of undef hits on the policy
        PolicyUndefinedHitsRate|pipolicyundefhitsrate|double|Rate (/s) counter for pipolicyundefhits
        PolicyHits|pipolicyhits|string|Number of hits on the policy
        PolicyHitsRate|pipolicyhitsrate|double|Rate (/s) counter for pipolicyhits




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<BotPolicyStatCommand>(INitroServiceClient, New BotPolicyStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object BotPolicyStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For BotPolicyStat, that object is <u>BotPolicyStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - BotPolicyStatistics: an array of BotPolicyStats-objects returned by the Get-Request, containing the properties mentioned above.



#### BotPolicyLabel

+ Get
    * Properties  

        The following properties can be found in each BotPolicyLabelStats-object inside of an array "BotPolicyLabelStatistics" of a BotPolicyLabelStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        LabelName|labelname|string|Name of the bot policy label.
        PolicyLabelHits|pipolicylabelhits|string|Number of times policy label was invoked.
        PolicyLabelHitsRate|pipolicylabelhitsrate|double|Rate (/s) counter for pipolicylabelhits



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<BotPolicyLabelStatCommand>(INitroServiceClient, New BotPolicyLabelStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object BotPolicyLabelStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:labelname, value: string   (if not given, will return all)
            - key:detail, value: bool  
            - key: fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For BotPolicyLabelStat, that object is <u>BotPolicyLabelStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - BotPolicyLabelStatistics: an array of BotPolicyLabelStats-objects returned by the Get-Request, containing the properties mentioned above.
    



#### BotProfile

+ Get
    * Properties  

        The following properties can be found in each BotProfileStats-object inside of an array "BotProfileStatistics" of a BotProfileStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name of the bot profile.

        BotViolationDeviceFingerprintLogProfile|botvioldevicefingerprintlogprofile|string|Number of device fingerprint violations seen by the Bot profile.
        BotViolationDeviceFingerPrintLogProfileRate|botvioldevicefingerprintlogprofilerate|double|Rate (/s) counter for botvioldevicefingerprintprofile
        BotViolationDeviceFingerPrintRedirectProfile|botvioldevicefingerprintredirectprofile|string|Number of device fingerprint violations requests redirected by the Bot profile to a different Web page or web server.
        BotViolationDeviceFingerPrintRedirectProfileRate|botvioldevicefingerprintredirectprofilerate|double|Rate (/s) counter for botvioldevicefingerprintredirectprofile
        BotViolationIpReputationLogProfile|botviolipreputationlogprofile|string|Number of ip reputation violations logged by the Bot Profile.
        BotViolationIpReputationLogProfileRate|botviolipreputationlogprofilerate|double|Rate (/s) counter for botviolipreputationlogprofile
        BotViolationIpReputationRedirectProfile|botviolipreputationredirectprofile|string|Number of ip reputation violations requests redirected by the Bot profile to a different Web page or web server.
        BotViolationIpReputationRedirectProfileRate|botviolipreputationredirectprofilerate|double|Rate (/s) counter for botviolipreputationredirectprofile
        BotViolationStaticSignatureDropProfile|botviolstaticsignaturedropprofile|string|Number of static signatutre violations dropped by the Bot profile.
        BotViolationStaticSignatureDropProfileRate|botviolstaticsignaturedropprofilerate|double|Rate (/s) counter for botviolstaticsignaturedropprofile
        BotViolationBlacklistLogProfile|botviolblacklistlogprofile|string|Number of black list violations logged by the Bot profile.
        BotViolationBlacklistLogProfileRate|botviolblacklistlogprofilerate|double|Rate (/s) counter for botviolblacklistlogprofile
        BotViolationRateLimitLogProfile|botviolratelimitlogprofile|string|Number of rate limiting violations seen by the Bot profile.
        BotViolationRateLimitLogProfileRate|botviolratelimitlogprofilerate|double|Rate (/s) counter for botviolratelimitprofile
        BotViolationStaticSignatureProfile|botviolstaticsignatureprofile|string|Number of static signatutre violations seen by the Bot profile.
        BotViolationStaticSignatureProfileRate|botviolstaticsignatureprofilerate|double|Rate (/s) counter for botviolstaticsignatureprofile
        BotViolationBlacklistRedirectProfile|botviolblacklistredirectprofile|string|Number of black list violations redirected by the Bot profile to a different Web page or web server.
        BotViolationBlacklistRedirectProfileRate|botviolblacklistredirectprofilerate|double|Rate (/s) counter for botviolblacklistredirectprofile
        BotViolationRateLimitProfile|botviolratelimitprofile|string|Number of rate limiting violations seen by the Bot profile.
        BotViolationRateLimitProfileRate|botviolratelimitprofilerate|double|Rate (/s) counter for botviolratelimitprofile
        BotViolationBlacklistDropProfile|botviolblacklistdropprofile|string|Number of black list violations dropped by the Bot profile.
        BotViolationBlacklistDropProfileRate|botviolblacklistdropprofilerate|double|Rate (/s) counter for botviolblacklistdropprofile
        BotViolationIpReputationProfile|botviolipreputationprofile|string|Number of ip reputation violations seen by the Bot profile.
        BotViolationIpReputationProfileRate|botviolipreputationprofilerate|double|Rate (/s) counter for botviolipreputationprofile
        BotViolationStaticSignatureLogProfile|botviolstaticsignaturelogprofile|string|
        BotViolationStaticSignatureLogProfileRate|botviolstaticsignaturelogprofilerate|double|
        BotViolationDeviceFingerprintDropProfile|botvioldevicefingerprintdropprofile|string|
        BotViolationDeviceFingerprintDropProfileRate|botvioldevicefingerprintdropprofilerate|double|
        BotViolationBlacklistProfile|botviolblacklistprofile|string|Number of static signatutre violations logged by the Bot profile.
        BotViolationBlacklistProfileRate|botviolblacklistprofilerate|double|Rate (/s) counter for botviolstaticsignaturelogprofile
        BotViolationIpReputationDropProfile|botviolipreputationdropprofile|string|
        BotViolationIpReputationDropProfileRate|botviolipreputationdropprofilerate|double|
        BotResponsesPerProfile|botresponsesperprofile|string|Number of ip reputation violations dropped by the Bot profile.
        BotResponsesPerProfileRate|botresponsesperprofilerate|double|Rate (/s) counter for botviolipreputationdropprofile
        BotViolationStaticSignatureRedirectProfile|botviolstaticsignatureredirectprofile|string|Number of static signatutre violations redirected by the Bot profile to a different Web page or web server.
        BotViolationStaticSignatureRedirectProfileRate|botviolstaticsignatureredirectprofilerate|double|Rate (/s) counter for botviolstaticsignatureredirectprofile
        BotViolationDeviceFingerprintProfile|botvioldevicefingerprintprofile|string|Number of device fingerprint violations dropped by the Bot profile.
        BotViolationDeviceFingerprintProfileRate|botvioldevicefingerprintprofilerate|double|Rate (/s) counter for botvioldevicefingerprintdropprofile
        BotResponseBytesPerProfile|botresbytesperprofile|string|Number of bytes transfered for responses
        BotResponseBytesPerProfileRate|botresbytesperprofilerate|rate|Rate (/s) counter for botresbytesperprofile
        BotViolationRateLimitDropProfile|botviolratelimitdropprofile|string|Number of rate limiting violations dropped by the Bot profile.
        BotViolationRateLimitDropProfileRate|botviolratelimitdropprofilerate|double|Rate (/s) counter for botviolratelimitdropprofile
        BotRequestsPerProfile|botrequestsperprofile|string|HTTP/HTTPS requests sent to your protected web servers via the Bot profile.
        BotRequestsPerProfileRate|botrequestsperprofilerate|double|Rate (/s) counter for botrequestsperprofile
        BotViolationWhitelistProfile|botviolwhitelistprofile|string|Number of white list violations seen by the Bot profile.
        BotViolationWhitelistProfileRate|botviolwhitelistprofilerate|double|Rate (/s) counter for botviolwhitelistprofile
        BotViolationRateLimitRedirectProfile|botviolratelimitredirectprofile|string|Number of rate limiting violations requests redirected by the Bot profile to a different Web page or web server.
        BotViolationRateLimitRedirectProfileRate|botviolratelimitredirectprofilerate|double|Rate (/s) counter for botviolratelimitredirectprofile
        BotRequestBytesPerProfile|botreqbytesperprofile|string|Number of bytes transfered for requests
        BotRequestBytesPerProfileRate|botreqbytesperprofilerate|double|Rate (/s) counter for botreqbytesperprofile
        BotViolationWhitelistLogProfile|botviolwhitelistlogprofile|string|Number of white list violations logged by the Bot profile.
        BotViolationWhitelistLogProfileRate|botviolwhitelistlogprofilerate|double|Rate (/s) counter for botviolwhitelistlogprofile



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<BotProfileStatCommand>(INitroServiceClient, New BotProfileStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object BotProfileStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For BotProfileStat, that object is <u>BotProfileStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - BotProfileStatistics: an array of BotProfileStats-objects returned by the Get-Request, containing the properties mentioned above.