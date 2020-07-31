### Ssl

#### SslCertFile

Commands: get, Import, remove

+ Import:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|Name to assign to the imported certificate file. Must begin with an ASCII alphanumeric or underscore (_) character, and must contain only ASCII alphanumeric, underscore, hash (#), period (.), space, colon (:), at (@), equals (=), and hyphen (-) characters. The following requirement applies only to the Citrix ADC CLI: If the name includes one or more spaces, enclose the name in double or single quotation marks (for example, "my file" or 'my file'). 
        Source|src|string|URL specifying the protocol, host, and path, including file name, to the certificate file to be imported. For example, http://www.example.com/cert_file. NOTE: The import fails if the object to be imported is on an HTTPS server that requires client certificate authentication for access. 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SslCertFileImportCommand> (INitroServiceClient, new SslCertFileImportRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SslCertFileImport, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each SslCertFileConfiguration found in the array "SslCertFiles" inside of a SslCertFileGetResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Name to assign to the imported certificate file. Must begin with an ASCII alphanumeric or underscore (_) character, and must contain only ASCII alphanumeric, underscore, hash (#), period (.), space, colon (:), at (@), equals (=), and hyphen (-) characters. The following requirement applies only to the Citrix ADC CLI: If the name includes one or more spaces, enclose the name in double or single quotation marks (for example, "my file" or 'my file'). 
        Source|src|string|URL specifying the protocol, host, and path, including file name, to the certificate file to be imported. For example, http://www.example.com/cert_file. NOTE: The import fails if the object to be imported is on an HTTPS server that requires client certificate authentication for access.


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SslCertFileGetCommand>(INitroServiceClient, New SslCertFileGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslCertFileGet, that object is <u>SslCertFileGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SslCertFiles: an array of SslCertFileConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SslCertFileRemoveCommand>(INitroServiceClient, new SslCertFileRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object SslProfileRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove. 
        <u>Arguments</u>: Dictionary<string, string> of extra arguments to be added to the delete command. The following are required to use the command: 
            + name:<name_value> : the name of the certfile to delete.
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslCertFileRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  

#### SslCertLink

Commands: get

+ Get
    * Properties  

        The following properties van be found in each SslCertLinkConfiguration found in the array "SslCertLinks" inside of a SslCertLinkGetResponse.

        Property|citrix doc name|DataType|Description
        ---|---|---|---
        CertificateKeyName|certkeyname|string|Certificate key name. 
        LinkCertificateKeyName|linkcertkeyname|string|Name of the Certificate-Authority. 


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SslCertLinkGetCommand>(INitroServiceClient, New SslCertLinkGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslCertLinkGet, that object is <u>SslCertLinkGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SslCertLinks: an array of SslCertLinkConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.


#### SslProfile

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrx doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|name of the Profile.
        SslProfileType|sslprofiletype|string|Type of profile. Front end profiles apply to the entity that receives requests from a client. Backend profiles apply to the entity that sends client requests to a server. Default value: FrontEnd. Possible values = BackEnd, FrontEnd 
        DhKeyPairInteractionsCount|dhcount|double|Number of interactions, between the client and the Citrix ADC, after which the DH private-public pair is regenerated. A value of zero (0) specifies infinite use (no refresh). This parameter is not applicable when configuring a backend profile. Allowed DH count values are 0 and >= 500. 
        DhKeyExchange|dh|string|State of Diffie-Hellman (DH) key exchange. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        DhFile|dhfile|string|The file name and path for the DH parameter. 
        EphemeralRsa|ersa|string|State of Ephemeral RSA (eRSA) key exchange. Ephemeral RSA allows clients that support only export ciphers to communicate with the secure server even if the server certificate does not support export clients. The ephemeral RSA key is automatically generated when you bind an export cipher to an SSL or TCP-based SSL virtual server or service. When you remove the export cipher, the eRSA key is not deleted. It is reused at a later date when another export cipher is bound to an SSL or TCP-based SSL virtual server or service. The eRSA key is deleted when the appliance restarts. This parameter is not applicable when configuring a backend profile. 
        EphemeralRsaCount|ersacount|double|The refresh count for the re-generation of RSA public-key and private-key pair. 
        SessionReuse|sessreuse|string|State of session reuse. Establishing the initial handshake requires CPU-intensive public key encryption operations. With the ENABLED setting, session key exchange is avoided for session resumption requests received from the client. 
        SessionTimeout|sesstimeout|double|The Session timeout value in seconds. 
        CipherRedirect|cipherredirect|string|State of Cipher Redirect. If this parameter is set to ENABLED, you can configure an SSL virtual server or service to display meaningful error messages if the SSL handshake fails because of a cipher mismatch between the virtual server or service and the client. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED
        CipherUrl|cipherurl|string|The redirect URL to be used with the Cipher Redirect feature. 
        ClientAuthentication|clientauth|string|State of client authentication. In service-based SSL offload, the service terminates the SSL handshake if the SSL client does not provide a valid certificate. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED  
        ClientCertificate|clientcert|string|The rule for client certificate requirement in client authentication. Possible values = Mandatory, Optional 
        DhKeySizeLimit|dhkeyexpsizelimit|string|This option enables the use of NIST recommended (NIST Special Publication 800-56A) bit size for private-key size. For example, for DH params of size 2048bit, the private-key size recommended is 224bits. This is rounded-up to 256bits. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        SslRedirect|sslredirect|string|State of HTTPS redirects for the SSL service. For an SSL session, if the client browser receives a redirect message, the browser tries to connect to the new location. However, the secure SSL session breaks if the object has moved from a secure site (https://) to an unsecure site (http://). Typically, a warning message appears on the screen, prompting the user to continue or disconnect. If SSL Redirect is ENABLED, the redirect message is automatically converted from http:// to https:// and the SSL session does not break. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED
        RedirectPortRewrite|redirectportrewrite|string|State of the port rewrite while performing HTTPS redirect. If this parameter is set to ENABLED, and the URL from the server does not contain the standard port, the port is rewritten to the standard. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Ssl3|ssl3|string|State of SSLv3 protocol support for the SSL profile.Note: On platforms with SSL acceleration chips, if the SSL chip does not support SSLv3, this parameter cannot be set to ENABLED. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        Tls1|tls1|string|State of TLSv1.0 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls11|tls11|string|State of TLSv1.1 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls12|tls12|string|State of TLSv1.2 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls13|tls13|string|State of TLSv1.3 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        ServerNameIndicationEnable|snienable|string|State of the Server Name Indication (SNI) feature on the virtual server and service-based offload. SNI helps to enable SSL encryption on multiple domains on a single virtual server or service if the domains are controlled by the same organization and share the same second-level domain name. For example, *.sports.net can be used to secure domains such as login.sports.net and help.sports.net. Default value: DISABLED Possible values = ENABLED, DISABLED
        OcspStapling|ocspstapling|string|State of OCSP stapling support on the SSL virtual server. Supported only if the protocol used is higher than SSLv3. Possible values: ENABLED: The appliance sends a request to the OCSP responder to check the status of the server certificate and caches the response for the specified time. If the response is valid at the time of SSL handshake with the client, the OCSP-based server certificate status is sent to the client during the handshake. DISABLED: The appliance does not check the status of the server certificate. Default value: DISABLED 
        ServerAuthentication|serverauth|string|State of server authentication support for the SSL Backend profile.
        CommonName|commonname|string|Name to be checked against the CommonName (CN) field in the server certificate bound to the SSL server. 
        PushEncryptionTrigger|pushenctrigger|string|Trigger encryption on the basis of the PUSH flag value. Available settings function as follows: * ALWAYS - Any PUSH packet triggers encryption. * IGNORE - Ignore PUSH packet for triggering encryption. * MERGE - For a consecutive sequence of PUSH packets, the last PUSH packet triggers encryption. * TIMER - PUSH packet triggering encryption is delayed by the time defined in the set ssl parameter command or in the Change Advanced SSL Settings dialog box. 
        SendCloseNotify|sendclosenotify|string|Enable sending SSL Close-Notify at the end of a transaction. Default value: YES 
        ClearTextPort|cleartextport|int|Port on which clear-text data is sent by the appliance to the server. Do not specify this parameter for SSL offloading with end-to-end encryption. 
        InsertionEncoding|insertionencoding|string|Encoding method used to insert the subject or issuer's name in HTTP requests to servers. Default value: Unicode. Possible values = Unicode, UTF-8 
        DenySslRenegotiation|denysslreneg|string|Deny renegotiation in specified circumstances. Available settings function as follows: * NO - Allow SSL renegotiation. * FRONTEND_CLIENT - Deny secure and nonsecure SSL renegotiation initiated by the client. * FRONTEND_CLIENTSERVER - Deny secure and nonsecure SSL renegotiation initiated by the client or the Citrix ADC during policy-based client authentication. * ALL - Deny all secure and nonsecure SSL renegotiation. * NONSECURE - Deny nonsecure SSL renegotiation. Allows only clients that support RFC 5746. Default value: ALL 
        QuantumSize|quantumsize|string|Amount of data to collect before the data is pushed to the crypto hardware for encryption. For large downloads, a larger quantum size better utilizes the crypto resources. Default value: 8192. Possible values = 4096, 8192, 16384 
        StrictCertificateAuthorityCheck|strictcacheck|string|Enable strict CA certificate checks on the appliance. Default value: NO 
        EncryptTriggerPacketCount|encrypttriggerpktcount|double|Maximum number of queued packets after which encryption is triggered. Use this setting for SSL transactions that send small packets from server to Citrix ADC. 
        PushFlag|pushflag|double|Insert PUSH flag into decrypted, encrypted, or all records. If the PUSH flag is set to a value other than 0, the buffered records are forwarded on the basis of the value of the PUSH flag. Available settings function as follows: 0 - Auto (PUSH flag is not set.) 1 - Insert PUSH flag into every decrypted record. 2 -Insert PUSH flag into every encrypted record. 3 - Insert PUSH flag into every decrypted and encrypted record. 
        DropRequestsWithNoHostHeader|dropreqwithnohostheader|string|Host header check for SNI enabled sessions. If this check is enabled and the HTTP request does not contain the host header for SNI enabled sessions(i.e vserver or profile bound to vserver has SNI enabled and 'Client Hello' arrived with SNI extension), the request is dropped. Default value: NO 
        PushEncryptionTriggerTimeout|pushenctriggertimeout|double|PUSH encryption trigger timeout value. The timeout value is applied only if you set the Push Encryption Trigger parameter to Timer in the SSL virtual server settings. 
        SslTriggerTimeout|ssltriggertimeout|double|Time, in milliseconds, after which encryption is triggered for transactions that are not tracked on the Citrix ADC because their length is not known. There can be a delay of up to 10ms from the specified timeout value before the packet is pushed into the queue. 
        ClientAuthenticationUseBoundCertificateAuthorityChain|clientauthuseboundcachain|string|Certficates bound on the VIP are used for validating the client cert. Certficates came along with client cert are not used for validating the client cert. Default value: DISABLED 
        SslInterception|sslinterception|string|Enable or disable transparent interception of SSL sessions. Default value: DISABLED 
        SslIRenegotiation|sslireneg|string|Enable or disable triggering the client renegotiation when renegotiation request is received from the origin server. Default value: ENABLED 
        SslIOcspCheck|ssliocspcheck|string|Enable or disable OCSP check for origin server certificate. Default value: ENABLED 
        SslIMaxSessionPerServer|sslimaxsessperserver|double|Maximum ssl session to be cached per dynamic origin server. A unique ssl session is created for each SNI received from the client on ClientHello and the matching session is used for server session reuse. 
        SessionTicket|sessionticket|string|This option enables the use of session tickets, as per the RFC 5077. Default value: DISABLED 
        SessionTicketLifetime|sessionticketlifetime|double|This option sets the life time of session tickets issued by NS in secs. 
        SessionTicketKeyRefresh|sessionticketkeyrefresh|string|This option enables the use of session tickets, as per the RFC 5077. Default value: ENABLED 
        SessionTicketKeyData|sessionticketkeydata|string|Session ticket enc/dec key , admin can set it. 
        SessionKeyLifetime|sessionkeylifetime|double|This option sets the life time of symm key used to generate session tickets issued by NS in secs. Default value: 3000 
        PreviousSessionKeyLifetime|prevsessionkeylifeime|double|This option sets the life time of symm key used to generate session tickets issued by NS in secs. Default value: 0 
        Hsts|hsts|string|State of HSTS protocol support for the SSL profile. Using HSTS, a server can enforce the use of an HTTPS connection for all communication with a client. Default value: DISABLED 
        MaxAge|maxage|double|Set the maximum time, in seconds, in the strict transport security (STS) header during which the client must send only HTTPS requests to the server. 
        IncludeSubDomains|includesubdomains|string|Enable HSTS for subdomains. If set to Yes, a client must send only HTTPS requests for subdomains. Default value: NO 
        SkipClientCertificatePolicyCheck|skipclientcertpolicycheck|string|This flag controls the processing of X509 certificate policies. If this option is Enabled, then the policy check in Client authentication will be skipped. This option can be used only when Client Authentication is Enabled and ClientCert is set to Mandatory. Default value: DISABLED 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SslProfileAddCommand> (INitroServiceClient, new SslProfileAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for SslProfileAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each SslProfileConfiguration found in the array "SslProfiles" inside of a SslProfileGetResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|name of the IpSet
        SslProfileType|sslprofiletype|string|Type of profile. Front end profiles apply to the entity that receives requests from a client. Backend profiles apply to the entity that sends client requests to a server. Default value: FrontEnd. Possible values = BackEnd, FrontEnd 
        DhKeyPairInteractionsCount|dhcount|double|Number of interactions, between the client and the Citrix ADC, after which the DH private-public pair is regenerated. A value of zero (0) specifies infinite use (no refresh). This parameter is not applicable when configuring a backend profile. Allowed DH count values are 0 and >= 500. 
        DhKeyExchange|dh|string|State of Diffie-Hellman (DH) key exchange. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        DhFile|dhfile|string|The file name and path for the DH parameter. 
        EphemeralRsa|ersa|string|State of Ephemeral RSA (eRSA) key exchange. Ephemeral RSA allows clients that support only export ciphers to communicate with the secure server even if the server certificate does not support export clients. The ephemeral RSA key is automatically generated when you bind an export cipher to an SSL or TCP-based SSL virtual server or service. When you remove the export cipher, the eRSA key is not deleted. It is reused at a later date when another export cipher is bound to an SSL or TCP-based SSL virtual server or service. The eRSA key is deleted when the appliance restarts. This parameter is not applicable when configuring a backend profile. 
        EphemeralRsaCount|ersacount|double|The refresh count for the re-generation of RSA public-key and private-key pair. 
        SessionReuse|sessreuse|string|State of session reuse. Establishing the initial handshake requires CPU-intensive public key encryption operations. With the ENABLED setting, session key exchange is avoided for session resumption requests received from the client. 
        SessionTimeout|sesstimeout|double|The Session timeout value in seconds. 
        CipherRedirect|cipherredirect|string|State of Cipher Redirect. If this parameter is set to ENABLED, you can configure an SSL virtual server or service to display meaningful error messages if the SSL handshake fails because of a cipher mismatch between the virtual server or service and the client. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED
        CipherUrl|cipherurl|string|The redirect URL to be used with the Cipher Redirect feature. 
        ClientAuthentication|clientauth|string|State of client authentication. In service-based SSL offload, the service terminates the SSL handshake if the SSL client does not provide a valid certificate. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED  
        ClientCertificate|clientcert|string|The rule for client certificate requirement in client authentication. Possible values = Mandatory, Optional 
        DhKeySizeLimit|dhkeyexpsizelimit|string|This option enables the use of NIST recommended (NIST Special Publication 800-56A) bit size for private-key size. For example, for DH params of size 2048bit, the private-key size recommended is 224bits. This is rounded-up to 256bits. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        SslRedirect|sslredirect|string|State of HTTPS redirects for the SSL service. For an SSL session, if the client browser receives a redirect message, the browser tries to connect to the new location. However, the secure SSL session breaks if the object has moved from a secure site (https://) to an unsecure site (http://). Typically, a warning message appears on the screen, prompting the user to continue or disconnect. If SSL Redirect is ENABLED, the redirect message is automatically converted from http:// to https:// and the SSL session does not break. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED
        RedirectPortRewrite|redirectportrewrite|string|State of the port rewrite while performing HTTPS redirect. If this parameter is set to ENABLED, and the URL from the server does not contain the standard port, the port is rewritten to the standard. Default value: DISABLED. Possible values = ENABLED, DISABLED
        NonFipsCiphers|nonfipsciphers|string|- 
        Ssl3|ssl3|string|State of SSLv3 protocol support for the SSL profile.Note: On platforms with SSL acceleration chips, if the SSL chip does not support SSLv3, this parameter cannot be set to ENABLED. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        Tls1|tls1|string|State of TLSv1.0 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls11|tls11|string|State of TLSv1.1 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls12|tls12|string|State of TLSv1.2 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls13|tls13|string|State of TLSv1.3 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED
        ServerNameIndicationEnable|snienable|string|State of the Server Name Indication (SNI) feature on the virtual server and service-based offload. SNI helps to enable SSL encryption on multiple domains on a single virtual server or service if the domains are controlled by the same organization and share the same second-level domain name. For example, *.sports.net can be used to secure domains such as login.sports.net and help.sports.net. Default value: DISABLED Possible values = ENABLED, DISABLED
        OcspStapling|ocspstapling|string|State of OCSP stapling support on the SSL virtual server. Supported only if the protocol used is higher than SSLv3. Possible values: ENABLED: The appliance sends a request to the OCSP responder to check the status of the server certificate and caches the response for the specified time. If the response is valid at the time of SSL handshake with the client, the OCSP-based server certificate status is sent to the client during the handshake. DISABLED: The appliance does not check the status of the server certificate. Default value: DISABLED 
        ServerAuthentication|serverauth|string|State of server authentication support for the SSL Backend profile.
        CommonName|commonname|string|Name to be checked against the CommonName (CN) field in the server certificate bound to the SSL server. 
        PushEncyptionTrigger|pushenctrigger|string|Trigger encryption on the basis of the PUSH flag value. Available settings function as follows: * ALWAYS - Any PUSH packet triggers encryption. * IGNORE - Ignore PUSH packet for triggering encryption. * MERGE - For a consecutive sequence of PUSH packets, the last PUSH packet triggers encryption. * TIMER - PUSH packet triggering encryption is delayed by the time defined in the set ssl parameter command or in the Change Advanced SSL Settings dialog box. 
        SendCloseNotify|sendclosenotify|string|Enable sending SSL Close-Notify at the end of a transaction. Default value: YES 
        ClearTextPort|cleartextport|int|Port on which clear-text data is sent by the appliance to the server. Do not specify this parameter for SSL offloading with end-to-end encryption. 
        InsertionEncoding|insertionencoding|string|Encoding method used to insert the subject or issuer's name in HTTP requests to servers. Default value: Unicode. Possible values = Unicode, UTF-8 
        DenySslRenegotiation|denysslreneg|string|Deny renegotiation in specified circumstances. Available settings function as follows: * NO - Allow SSL renegotiation. * FRONTEND_CLIENT - Deny secure and nonsecure SSL renegotiation initiated by the client. * FRONTEND_CLIENTSERVER - Deny secure and nonsecure SSL renegotiation initiated by the client or the Citrix ADC during policy-based client authentication. * ALL - Deny all secure and nonsecure SSL renegotiation. * NONSECURE - Deny nonsecure SSL renegotiation. Allows only clients that support RFC 5746. Default value: ALL 
        QuantumSize|quantumsize|string|Amount of data to collect before the data is pushed to the crypto hardware for encryption. For large downloads, a larger quantum size better utilizes the crypto resources. Default value: 8192. Possible values = 4096, 8192, 16384 
        StrictCerificateAuthorityCheck|strictcacheck|string|Enable strict CA certificate checks on the appliance. Default value: NO 
        EncryptTriggerPacketCount|encrypttriggerpktcount|double|Maximum number of queued packets after which encryption is triggered. Use this setting for SSL transactions that send small packets from server to Citrix ADC. 
        PushFlag|pushflag|double|Insert PUSH flag into decrypted, encrypted, or all records. If the PUSH flag is set to a value other than 0, the buffered records are forwarded on the basis of the value of the PUSH flag. Available settings function as follows: 0 - Auto (PUSH flag is not set.) 1 - Insert PUSH flag into every decrypted record. 2 -Insert PUSH flag into every encrypted record. 3 - Insert PUSH flag into every decrypted and encrypted record. 
        DropRequestWithNoHostHeader|dropreqwithnohostheader|string|Host header check for SNI enabled sessions. If this check is enabled and the HTTP request does not contain the host header for SNI enabled sessions(i.e vserver or profile bound to vserver has SNI enabled and 'Client Hello' arrived with SNI extension), the request is dropped. Default value: NO 
        PushEncryptionTriggerTimeout|pushenctriggertimeout|double|PUSH encryption trigger timeout value. The timeout value is applied only if you set the Push Encryption Trigger parameter to Timer in the SSL virtual server settings. 
        SslTriggerTimeout|ssltriggertimeout|double|Time, in milliseconds, after which encryption is triggered for transactions that are not tracked on the Citrix ADC because their length is not known. There can be a delay of up to 10ms from the specified timeout value before the packet is pushed into the queue. 
        ClientAuthenticationUseBoundCertificateAuthorityChain|clientauthuseboundcachain|string|Certficates bound on the VIP are used for validating the client cert. Certficates came along with client cert are not used for validating the client cert. Default value: DISABLED 
        SslInterception|sslinterception|string|Enable or disable transparent interception of SSL sessions. Default value: DISABLED 
        SslIRenegotiation|sslireneg|string|Enable or disable triggering the client renegotiation when renegotiation request is received from the origin server. Default value: ENABLED 
        SslIocspCheck|ssliocspcheck|string|Enable or disable OCSP check for origin server certificate. Default value: ENABLED 
        SslIMaxSessionPerServer|sslimaxsessperserver|double|Maximum ssl session to be cached per dynamic origin server. A unique ssl session is created for each SNI received from the client on ClientHello and the matching session is used for server session reuse. 
        SessionTicket|sessionticket|string|This option enables the use of session tickets, as per the RFC 5077. Default value: DISABLED 
        SessionTicketLifetime|sessionticketlifetime|double|This option sets the life time of session tickets issued by NS in secs. 
        SessionTicketKeyRefresh|sessionticketkeyrefresh|string|This option enables the use of session tickets, as per the RFC 5077. Default value: ENABLED 
        SessionTicketKeyData|sessionticketkeydata|string|Session ticket enc/dec key , admin can set it. 
        SessionKeyLifetime|sessionkeylifetime|double|This option sets the life time of symm key used to generate session tickets issued by NS in secs. Default value: 3000 
        PreviousSessionKeyLifetime|prevsessionkeylifetime|double|This option sets the life time of symm key used to generate session tickets issued by NS in secs. Default value: 0 
        Hsts|hsts|string|State of HSTS protocol support for the SSL profile. Using HSTS, a server can enforce the use of an HTTPS connection for all communication with a client. Default value: DISABLED 
        MaxAge|maxage|double|Set the maximum time, in seconds, in the strict transport security (STS) header during which the client must send only HTTPS requests to the server. 
        IncludeSubDomains|includesubdomains|string|Enable HSTS for subdomains. If set to Yes, a client must send only HTTPS requests for subdomains. Default value: NO 
        SkipClientCertificatePolicyCheck|skipclientcertpolicycheck|string|This flag controls the processing of X509 certificate policies. If this option is Enabled, then the policy check in Client authentication will be skipped. This option can be used only when Client Authentication is Enabled and ClientCert is set to Mandatory. Default value: DISABLED 
        ZeroRttEarlyData|zerorttearlydata|string|-
        Tls13SessionTicketsPerAuthenticationContext|tls13sessionticketsperauthcontext|string|-
        DheKeyExchangeWithPsk|dhekeyexhangewithpsk|string|-

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SslProfileGetCommand>(INitroServiceClient, New SslProfileGetRequestOptions(){ });
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslProfileGet, that object is <u>SslProfileGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SslProfiles: an array of SslProfileConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SslProfileRemoveCommand>(INitroServiceClient, new SslProfileRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object SslProfileRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslProfileRemove, that object is <u>NitroResponse</u>.

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

        Property|Citrix doc name|ValueType|Description
        ---|---|---|---
        Name|name|string|name of the IpSet
        SslProfileType|sslprofiletype|string|Type of profile. Front end profiles apply to the entity that receives requests from a client. Backend profiles apply to the entity that sends client requests to a server. Default value: FrontEnd. Possible values = BackEnd, FrontEnd 
        DhKeyPairInteractionsCount|dhcount|double|Number of interactions, between the client and the Citrix ADC, after which the DH private-public pair is regenerated. A value of zero (0) specifies infinite use (no refresh). This parameter is not applicable when configuring a backend profile. Allowed DH count values are 0 and >= 500. 
        DhKeyExchange|dh|string|State of Diffie-Hellman (DH) key exchange. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        DhFile|dhfile|string|The file name and path for the DH parameter. 
        EphemeralRsa|ersa|string|State of Ephemeral RSA (eRSA) key exchange. Ephemeral RSA allows clients that support only export ciphers to communicate with the secure server even if the server certificate does not support export clients. The ephemeral RSA key is automatically generated when you bind an export cipher to an SSL or TCP-based SSL virtual server or service. When you remove the export cipher, the eRSA key is not deleted. It is reused at a later date when another export cipher is bound to an SSL or TCP-based SSL virtual server or service. The eRSA key is deleted when the appliance restarts. This parameter is not applicable when configuring a backend profile. 
        EphemeralRsaCount|ersacount|double|The refresh count for the re-generation of RSA public-key and private-key pair. 
        SessionReuse|sessreuse|string|State of session reuse. Establishing the initial handshake requires CPU-intensive public key encryption operations. With the ENABLED setting, session key exchange is avoided for session resumption requests received from the client. 
        SessionTimeout|sesstimeout|double|The Session timeout value in seconds. 
        CipherRedirect|cipherredirect|string|State of Cipher Redirect. If this parameter is set to ENABLED, you can configure an SSL virtual server or service to display meaningful error messages if the SSL handshake fails because of a cipher mismatch between the virtual server or service and the client. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED
        CipherUrl|cipherurl|string|The redirect URL to be used with the Cipher Redirect feature. 
        ClientAuthentication|clientauth|string|State of client authentication. In service-based SSL offload, the service terminates the SSL handshake if the SSL client does not provide a valid certificate. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED  
        ClientCertificate|clientcert|string|The rule for client certificate requirement in client authentication. Possible values = Mandatory, Optional 
        DhKeySizeLimit|dhkeyexpsizelimit|string|This option enables the use of NIST recommended (NIST Special Publication 800-56A) bit size for private-key size. For example, for DH params of size 2048bit, the private-key size recommended is 224bits. This is rounded-up to 256bits. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        SslRedirect|sslredirect|string|State of HTTPS redirects for the SSL service. For an SSL session, if the client browser receives a redirect message, the browser tries to connect to the new location. However, the secure SSL session breaks if the object has moved from a secure site (https://) to an unsecure site (http://). Typically, a warning message appears on the screen, prompting the user to continue or disconnect. If SSL Redirect is ENABLED, the redirect message is automatically converted from http:// to https:// and the SSL session does not break. This parameter is not applicable when configuring a backend profile. Default value: DISABLED. Possible values = ENABLED, DISABLED
        RedirectPortRewrite|redirectportrewrite|string|State of the port rewrite while performing HTTPS redirect. If this parameter is set to ENABLED, and the URL from the server does not contain the standard port, the port is rewritten to the standard. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        Ssl3|ssl3|string|State of SSLv3 protocol support for the SSL profile.Note: On platforms with SSL acceleration chips, if the SSL chip does not support SSLv3, this parameter cannot be set to ENABLED. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        Tls1|tls1|string|State of TLSv1.0 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls11|tls11|string|State of TLSv1.1 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls12|tls12|string|State of TLSv1.2 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Tls13|tls13|string|State of TLSv1.3 protocol support for the SSL profile. Default value: ENABLED Possible values = ENABLED, DISABLED 
        ServerNameIndicationEnable|snienable|string|State of the Server Name Indication (SNI) feature on the virtual server and service-based offload. SNI helps to enable SSL encryption on multiple domains on a single virtual server or service if the domains are controlled by the same organization and share the same second-level domain name. For example, *.sports.net can be used to secure domains such as login.sports.net and help.sports.net. Default value: DISABLED Possible values = ENABLED, DISABLED
        OcspStapling|ocspstapling|string|State of OCSP stapling support on the SSL virtual server. Supported only if the protocol used is higher than SSLv3. Possible values: ENABLED: The appliance sends a request to the OCSP responder to check the status of the server certificate and caches the response for the specified time. If the response is valid at the time of SSL handshake with the client, the OCSP-based server certificate status is sent to the client during the handshake. DISABLED: The appliance does not check the status of the server certificate. Default value: DISABLED 
        ServerAuthentication|serverauth|string|State of server authentication support for the SSL Backend profile.
        CommonName|commonname|string|Name to be checked against the CommonName (CN) field in the server certificate bound to the SSL server. 
        PushEncryptionTrigger|pushenctrigger|string|Trigger encryption on the basis of the PUSH flag value. Available settings function as follows: * ALWAYS - Any PUSH packet triggers encryption. * IGNORE - Ignore PUSH packet for triggering encryption. * MERGE - For a consecutive sequence of PUSH packets, the last PUSH packet triggers encryption. * TIMER - PUSH packet triggering encryption is delayed by the time defined in the set ssl parameter command or in the Change Advanced SSL Settings dialog box. 
        SendCloseNotify|sendclosenotify|string|Enable sending SSL Close-Notify at the end of a transaction. Default value: YES 
        ClearTextPort|cleartextport|int|Port on which clear-text data is sent by the appliance to the server. Do not specify this parameter for SSL offloading with end-to-end encryption. 
        InsertionEncoding|insertionencoding|string|Encoding method used to insert the subject or issuer's name in HTTP requests to servers. Default value: Unicode. Possible values = Unicode, UTF-8 
        DenySslRenegotiation|denysslreneg|string|Deny renegotiation in specified circumstances. Available settings function as follows: * NO - Allow SSL renegotiation. * FRONTEND_CLIENT - Deny secure and nonsecure SSL renegotiation initiated by the client. * FRONTEND_CLIENTSERVER - Deny secure and nonsecure SSL renegotiation initiated by the client or the Citrix ADC during policy-based client authentication. * ALL - Deny all secure and nonsecure SSL renegotiation. * NONSECURE - Deny nonsecure SSL renegotiation. Allows only clients that support RFC 5746. Default value: ALL 
        QuantumSize|quentumsize|string|Amount of data to collect before the data is pushed to the crypto hardware for encryption. For large downloads, a larger quantum size better utilizes the crypto resources. Default value: 8192. Possible values = 4096, 8192, 16384 
        StrictCertificateAuthorityChecks|strictcachecks|string|Enable strict CA certificate checks on the appliance. Default value: NO 
        EncryptTriggerPacketCount|encrypttriggerpktcount|double|Maximum number of queued packets after which encryption is triggered. Use this setting for SSL transactions that send small packets from server to Citrix ADC. 
        PushFlag|pushflag|double|Insert PUSH flag into decrypted, encrypted, or all records. If the PUSH flag is set to a value other than 0, the buffered records are forwarded on the basis of the value of the PUSH flag. Available settings function as follows: 0 - Auto (PUSH flag is not set.) 1 - Insert PUSH flag into every decrypted record. 2 -Insert PUSH flag into every encrypted record. 3 - Insert PUSH flag into every decrypted and encrypted record. 
        DropRequestWithNoHostHeader|dropreqwithnohostheader|string|Host header check for SNI enabled sessions. If this check is enabled and the HTTP request does not contain the host header for SNI enabled sessions(i.e vserver or profile bound to vserver has SNI enabled and 'Client Hello' arrived with SNI extension), the request is dropped. Default value: NO 
        PushEncryptionTriggerTimeout|pushenctriggertimeout|double|PUSH encryption trigger timeout value. The timeout value is applied only if you set the Push Encryption Trigger parameter to Timer in the SSL virtual server settings. 
        SslTriggerTimeout|ssltriggertimeout|double|Time, in milliseconds, after which encryption is triggered for transactions that are not tracked on the Citrix ADC because their length is not known. There can be a delay of up to 10ms from the specified timeout value before the packet is pushed into the queue. 
        ClientAuthUseBoundCaChain|clientauthuseboundcachain|string|Certficates bound on the VIP are used for validating the client cert. Certficates came along with client cert are not used for validating the client cert. Default value: DISABLED 
        SslInterception|sslinterception|string|Enable or disable transparent interception of SSL sessions. Default value: DISABLED 
        SslIRenegotiation|sslireneg|string|Enable or disable triggering the client renegotiation when renegotiation request is received from the origin server. Default value: ENABLED 
        SslIOcspCheck|ssliocspcheck|string|Enable or disable OCSP check for origin server certificate. Default value: ENABLED 
        SslIMaxSessPerServer|sslimaxsessperserver|double|Maximum ssl session to be cached per dynamic origin server. A unique ssl session is created for each SNI received from the client on ClientHello and the matching session is used for server session reuse. 
        SessionTicket|sessionticket|string|This option enables the use of session tickets, as per the RFC 5077. Default value: DISABLED 
        SessionTicketLifetime|sessionticketlifetime|double|This option sets the life time of session tickets issued by NS in secs. 
        SessionTicketKeyRefresh|sessionticketkeyrefresh|string|This option enables the use of session tickets, as per the RFC 5077. Default value: ENABLED 
        SessionTicketKeyData|sessionticketkeydata|string|Session ticket enc/dec key , admin can set it. 
        SessionKeyLifetime|sessionkeylifetime|double|This option sets the life time of symm key used to generate session tickets issued by NS in secs. Default value: 3000 
        PreviousSessionKeyLifetime|prevsessionkeylifetime|double|This option sets the life time of symm key used to generate session tickets issued by NS in secs. Default value: 0 
        Hsts|hsts|string|State of HSTS protocol support for the SSL profile. Using HSTS, a server can enforce the use of an HTTPS connection for all communication with a client. Default value: DISABLED 
        MaxAge|maxage|double|Set the maximum time, in seconds, in the strict transport security (STS) header during which the client must send only HTTPS requests to the server. 
        IncludeSubDomains|includesubdomains|string|Enable HSTS for subdomains. If set to Yes, a client must send only HTTPS requests for subdomains. Default value: NO 
        SkipClientCertificatePolicyCheck|skipclientcertpolicycheck|string|This flag controls the processing of X509 certificate policies. If this option is Enabled, then the policy check in Client authentication will be skipped. This option can be used only when Client Authentication is Enabled and ClientCert is set to Mandatory. Default value: DISABLED 
        CipherName|ciphername|string|-
        CipherPriority|cipherpriority|double|-
        StrictSigDigestCheck|strictsigdigestcheck|string|-

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (SslProfileUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<SslProfileUpdateCommand> (INitroServiceClient, new SslProfileUpdateRequestData(){ });
            ```


    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslProfileUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 
