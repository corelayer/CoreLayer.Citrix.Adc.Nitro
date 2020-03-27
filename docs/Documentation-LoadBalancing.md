### LoadBalancing

#### Lbmonitor

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        MonitorName|string|Name for the monitor.
        Type|string|Type of monitor that you want to create. Possible values = PING, TCP, HTTP, TCP-ECV, HTTP-ECV, UDP-ECV, DNS, FTP, LDNS-PING, LDNS-TCP, LDNS-DNS, RADIUS, USER, HTTP-INLINE, SIP-UDP, SIP-TCP, LOAD, FTP-EXTENDED, SMTP, SNMP, NNTP, MYSQL, MYSQL-ECV, MSSQL-ECV, ORACLE-ECV, LDAP, POP3, CITRIX-XML-SERVICE, CITRIX-WEB-INTERFACE, DNS-TCP, RTSP, ARP, CITRIX-AG, CITRIX-AAC-LOGINPAGE, CITRIX-AAC-LAS, CITRIX-XD-DDC, ND6, CITRIX-WI-EXTENDED, DIAMETER, RADIUS_ACCOUNTING, STOREFRONT, APPC, SMPP, CITRIX-XNC-ECV, CITRIX-XDM, CITRIX-STA-SERVICE, CITRIX-STA-SERVICE-NHOP. Automatically assigned when choosing Data to add.
        Action|string|Action to perform when the response to an inline monitor (a monitor of type HTTP-INLINE) indicates that the service is down. A service monitored by an inline monitor is considered DOWN if the response code is not one of the codes that have been specified for the Response Code parameter. Available settings function as follows: * NONE - Do not take any action. However, the show service command and the show lb monitor command indicate the total number of responses that were checked and the number of consecutive error responses received after the last successful probe. * LOG - Log the event in NSLOG or SYSLOG. * DOWN - Mark the service as being down, and then do not direct any traffic to the service until the configured down time has expired. Persistent connections to the service are terminated as soon as the service is marked as DOWN. Also, log the event in NSLOG or SYSLOG. Default value: DOWN. Possible values = NONE, LOG, DOWN
        RespCode|string[ ]|Response codes for which to mark the service as UP. For any other response code, the action performed depends on the monitor type. HTTP monitors and RADIUS monitors mark the service as DOWN, while HTTP-INLINE monitors perform the action indicated by the Action parameter.
        HttpRequest|string|HTTP request to send to the server (for example, "HEAD /file.html").
        RtspRequest|string|RTSP request to send to the server (for example, "OPTIONS *").
        CustomHeaders|string|Custom header string to include in the monitoring probes.
        MaxForwards|double|Maximum number of hops that the SIP request used for monitoring can traverse to reach the server. Applicable only to monitors of type SIP-UDP.
        SipMethod|string|SIP method to use for the query. Applicable only to monitors of type SIP-UDP. Possible values = OPTIONS, INVITE, REGISTER
        SipUri|string|SIP URI string to send to the service (for example, sip:sip.test). Applicable only to monitors of type SIP-UDP.
        SipRegUri|string|SIP user to be registered. Applicable only if the monitor is of type SIP-UDP and the SIP Method parameter is set to REGISTER.
        Send|string|String to send to the service. Applicable to TCP-ECV, HTTP-ECV, and UDP-ECV monitors.
        Recv|string|String expected from the server for the service to be marked as UP. Applicable to TCP-ECV, HTTP-ECV, and UDP-ECV monitors.
        Query|string|Domain name to resolve as part of monitoring the DNS service (for example, example.com).
        QueryType|string|Type of DNS record for which to send monitoring queries. Set to Address for querying A records, AAAA for querying AAAA records, and Zone for querying the SOA record. Possible values = Address, Zone, AAAA
        Script|string|Path and name of the script to execute. The script must be available on the NetScaler appliance, in the /nsconfig/monitors/ directory.
        ScriptArgs|string|String of arguments for the script. The string is copied verbatim into the request.
        DispatcherIp|string|IP address of the dispatcher to which to send the probe.
        DisaptcherPort|string|Port number on which the dispatcher listens for the monitoring probe.
        UserName|string|User name with which to probe the RADIUS, NNTP, FTP, FTP-EXTENDED, MYSQL, MSSQL, POP3, CITRIX-AG, CITRIX-XD-DDC, CITRIX-WI-EXTENDED, CITRIX-XNC or CITRIX-XDM server.
        Password|string|Password that is required for logging on to the RADIUS, NNTP, FTP, FTP-EXTENDED, MYSQL, MSSQL, POP3, CITRIX-AG, CITRIX-XD-DDC, CITRIX-WI-EXTENDED, CITRIX-XNC-ECV or CITRIX-XDM server. Used in conjunction with the user name specified for the User Name parameter.
        SecondaryPassword|string|Secondary password that users might have to provide to log on to the Access Gateway server. Applicable to CITRIX-AG monitors.
        LogonPointName|string|Name of the logon point that is configured for the Citrix Access Gateway Advanced Access Control software. Required if you want to monitor the associated login page or Logon Agent. Applicable to CITRIX-AAC-LAS and CITRIX-AAC-LOGINPAGE monitors.
        LasVersion|string|Version number of the Citrix Advanced Access Control Logon Agent. Required by the CITRIX-AAC-LAS monitor.
        RadKey|string|Authentication key (shared secret text string) for RADIUS clients and servers to exchange. Applicable to monitors of type RADIUS and RADIUS_ACCOUNTING.
        RadnasId|string|NAS-Identifier to send in the Access-Request packet. Applicable to monitors of type RADIUS. Minimum length = 1
        RadnasIp|string|Network Access Server (NAS) IP address to use as the source IP address when monitoring a RADIUS server. Applicable to monitors of type RADIUS and RADIUS_ACCOUNTING.
        RadAccountType|double|Account Type to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadFrameDip|string|Source ip with which the packet will go out . Applicable to monitors of type RADIUS_ACCOUNTING.
        RadApn|string|Called Station Id to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadMsisdn|string|Calling Stations Id to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadAccountSession|string|Account Session ID to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        Lrtm|string|Calculate the least response times for bound services. If this parameter is not enabled, the appliance does not learn the response times of the bound services. Also used for LRTM load balancing. Possible values = ENABLED, DISABLED
        Deviation|double|Time value added to the learned average response time in dynamic response time monitoring (DRTM). When a deviation is specified, the appliance learns the average response time of bound services and adds the deviation to the average. The final value is then continually adjusted to accommodate response time variations over time. Specified in milliseconds, seconds, or minutes.
        Units1|string|Unit of measurement for the Deviation parameter. Cannot be changed after the monitor is created. Default value: SEC. Possible values = SEC, MSEC, MIN
        Interval|int|Time interval between two successive probes. Must be greater than the value of Response Time-out.
        Units3|string|monitor interval units. Default value: SEC. Possible values = SEC, MSEC, MIN
        RespTimeout|int|Amount of time for which the appliance must wait before it marks a probe as FAILED. Must be less than the value specified for the Interval parameter.
        Units4|string|monitor response timeout units. Default value: SEC. Possible values = SEC, MSEC, MIN
        ResponseTimeoutThresh|double|Response time threshold, specified as a percentage of the Response Time-out parameter. If the response to a monitor probe has not arrived when the threshold is reached, the appliance generates an SNMP trap called monRespTimeoutAboveThresh. After the response time returns to a value below the threshold, the appliance generates a monRespTimeoutBelowThresh SNMP trap. For the traps to be generated, the "MONITOR-RTO-THRESHOLD" alarm must also be enabled.
        Retries|int|Maximum number of probes to send to establish the state of a service for which a monitoring probe failed. Default value: 3
        FailureRetries|int|Number of retries that must fail, out of the number specified for the Retries parameter, for a service to be marked as DOWN. For example, if the Retries parameter is set to 10 and the Failure Retries parameter is set to 6, out of the ten probes sent, at least six probes must fail if the service is to be marked as DOWN. The default value of 0 means that all the retries must fail if the service is to be marked as DOWN.
        AlertRetries|int|Number of consecutive probe failures after which the appliance generates an SNMP trap called monProbeFailed.
        SuccessRetries|int|Number of consecutive successful probes required to transition a service's state from DOWN to UP. Default value: 1
        DownTime|int|Time duration for which to wait before probing a service that has been marked as DOWN. Expressed in milliseconds, seconds, or minutes. Default value: 30
        Units2|string|Unit of measurement for the Down Time parameter. Cannot be changed after the monitor is created. Default value: SEC. Possible values = SEC, MSEC, MIN
        DestIp|string|IP address of the service to which to send probes. If the parameter is set to 0, the IP address of the server to which the monitor is bound is considered the destination IP address.
        DestPort|int|TCP or UDP port to which to send the probe. If the parameter is set to 0, the port number of the service to which the monitor is bound is considered the destination port. For a monitor of type USER, however, the destination port is the port number that is included in the HTTP request sent to the dispatcher. Does not apply to monitors of type PING.
        State|string|State of the monitor. The DISABLED setting disables not only the monitor being configured, but all monitors of the same type, until the parameter is set to ENABLED. If the monitor is bound to a service, the state of the monitor is not taken into account when the state of the service is determined. Default value: ENABLED. Possible values = ENABLED, DISABLED
        Reverse|string|Mark a service as DOWN, instead of UP, when probe criteria are satisfied, and as UP instead of DOWN when probe criteria are not satisfied. Default value: NO. Possible values = YES, NO
        Transparent|string|The monitor is bound to a transparent device such as a firewall or router. The state of a transparent device depends on the responsiveness of the services behind it. If a transparent device is being monitored, a destination IP address must be specified. The probe is sent to the specified IP address by using the MAC address of the transparent device. Default value: NO. Possible values = YES, NO
        IpTunnel|string|Send the monitoring probe to the service through an IP tunnel. A destination IP address must be specified. Default value: NO. Possible values = YES, NO
        Tos|string|Probe the service by encoding the destination IP address in the IP TOS (6) bits. Possible values = YES, NO
        TosId|double|The TOS ID of the specified destination IP. Applicable only when the TOS parameter is set.
        Secure|string|Use a secure SSL connection when monitoring a service. Applicable only to TCP based monitors. The secure option cannot be used with a CITRIX-AG monitor, because a CITRIX-AG monitor uses a secure connection by default. Default value: NO. Possible values = YES, NO
        ValidateCred|string|Validate the credentials of the Xen Desktop DDC server user. Applicable to monitors of type CITRIX-XD-DDC. Default value: NO. Possible values = YES, NO
        Domain|string|Domain in which the XenDesktop Desktop Delivery Controller (DDC) servers or Web Interface servers are present. Required by CITRIX-XD-DDC and CITRIX-WI-EXTENDED monitors for logging on to the DDC servers and Web Interface servers, respectively.
        IpAddress|string|Set of IP addresses expected in the monitoring response from the DNS server, if the record type is A or AAAA. Applicable to DNS monitors.
        Group|string|Name of a newsgroup available on the NNTP service that is to be monitored. The appliance periodically generates an NNTP query for the name of the newsgroup and evaluates the response. If the newsgroup is found on the server, the service is marked as UP. If the newsgroup does not exist or if the search fails, the service is marked as DOWN. Applicable to NNTP monitors.
        FileName|string|Name of a file on the FTP server. The appliance monitors the FTP service by periodically checking the existence of the file on the server. Applicable to FTP-EXTENDED monitors.
        BaseDn|string|The base distinguished name of the LDAP service, from where the LDAP server can begin the search for the attributes in the monitoring query. Required for LDAP service monitoring.
        BindDn|string|The distinguished name with which an LDAP monitor can perform the Bind operation on the LDAP server. Optional. Applicable to LDAP monitors.
        Filter|string|Filter criteria for the LDAP query. Optional.
        Attribute|string|Attribute to evaluate when the LDAP server responds to the query. Success or failure of the monitoring probe depends on whether the attribute exists in the response. Optional.
        Database|string|Name of the database to connect to during authentication.
        OracledsId|string|Name of the service identifier that is used to connect to the Oracle database during authentication.
        SqlQuery|string|SQL query for a MYSQL-ECV or MSSQL-ECV monitor. Sent to the database server after the server authenticates the connection.
        EvalRule|string|Default syntax expression that evaluates the database server's response to a MYSQL-ECV or MSSQL-ECV monitoring query. Must produce a Boolean result. The result determines the state of the server. If the expression returns TRUE, the probe succeeds. For example, if you want the appliance to evaluate the error message to determine the state of the server, use the rule MYSQL.RES.ROW(10) .TEXT_ELEM(2).EQ("MySQL").
        MsSqlProtocolVersion|string|Version of MSSQL server that is to be monitored. Default value: 70. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        SnmpOid|string|SNMP OID for SNMP monitors.
        SnmpCommunity|string|Community name for SNMP monitors.
        SnmpThreshold|string|Threshold for SNMP monitors.
        SnmpVersion|string|SNMP version to be used for SNMP monitors.
        MetricTable|string|Metric table to which to bind metrics.
        Application|string|Name of the application used to determine the state of the service. Applicable to monitors of type CITRIX-XML-SERVICE.
        SitePath|string|URL of the logon page. For monitors of type CITRIX-WEB-INTERFACE, to monitor a dynamic page under the site path, terminate the site path with a slash (/). Applicable to CITRIX-WEB-INTERFACE, CITRIX-WI-EXTENDED and CITRIX-XDM monitors.
        StoreName|string|Store Name. For monitors of type STOREFRONT, STORENAME is an optional argument defining storefront service store name. Applicable to STOREFRONT monitors.
        StorefrontAcctService|string|Enable/Disable probing for Account Service. Applicable only to Store Front monitors. For multi-tenancy configuration users my skip account service. Default value: YES
        Hostname|string|Hostname in the FQDN format (Example: porche.cars.org). Applicable to STOREFRONT monitors.
        NetProfile|string|Name of the network profile.
        OriginHost|string|Origin-Host value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        OriginRealm|string|Origin-Realm value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        HostIpAddress|string|Host-IP-Address value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. If Host-IP-Address is not specified, the appliance inserts the mapped IP (MIP) address or subnet IP (SNIP) address from which the CER request (the monitoring probe) is sent.
        VendorId|string|Vendor-Id value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        ProductName|string|Product-Name value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        FirmwareVersion|double|Firmware-Revision value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        AuthApplicationId|double[ ]|List of Auth-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring CER message.
        AcctApplicationId|double[ ]|List of Acct-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message.
        InbandSecurityId|string|Inband-Security-Id for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. Possible values = NO_INBAND_SECURITY, TLS
        SupportedVendorIds|double[ ]|List of Supported-Vendor-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum eight of these AVPs are supported in a monitoring message.
        VendorSpecificVendorId|double|Vendor-Id to use in the Vendor-Specific-Application-Id grouped attribute-value pair (AVP) in the monitoring CER message. To specify Auth-Application-Id or Acct-Application-Id in Vendor-Specific-Application-Id, use vendorSpecificAuthApplicationIds or vendorSpecificAcctApplicationIds, respectively. Only one Vendor-Id is supported for all the Vendor-Specific-Application-Id AVPs in a CER monitoring message.
        VendorSpecificAuthApplicationIds|double[ ]|List of Vendor-Specific-Auth-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message. The specified value is combined with the value of vendorSpecificVendorId to obtain the Vendor-Specific-Application-Id AVP in the CER monitoring message.
        VendorSpecificAcctApplicationIds|double[ ]|List of Vendor-Specific-Acct-Application-Id attribute value pairs (AVPs) to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message. The specified value is combined with the value of vendorSpecificVendorId to obtain the Vendor-Specific-Application-Id AVP in the CER monitoring message.
        KcdAccount|string|KCD Account used by MSSQL monitor.
        StoreDb|string|Store the database list populated with the responses to monitor probes. Used in database specific load balancing if MSSQL-ECV/MYSQL-ECV monitor is configured. Default value: DISABLED. Possible values = ENABLED, DISABLED
        StorefrontCheckBackendServices|string|This option will enable monitoring of services running on storefront server. Storefront services are monitored by probing to a Windows service that runs on the Storefront server and exposes details of which storefront services are running. Default value: NO. Possible values = YES, NO
        TrofsCode|double|Code expected when the server is under maintenance.
        TrofsString|string|String expected from the server for the service to be marked as trofs. Applicable to HTTP-ECV/TCP-ECV monitors.
        SslProfile|string|SSL Profile associated with the monitor.

   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<LbmonitorAddCommand> (INitroServiceClient, new LbmonitorAddRequestData(){ });
            ```

            Where LbmonitorAddRequestData is one of:
            LbmonitorHttpEcvAddRequestData, LbmonitorHttpInlineAddRequestData, LbmonitorHttpAddRequestData, LbmonitorTcpEcvAddRequestData, LbmonitorTcpAddRequestData

    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for LbmonitorAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each LbmonitorConfiguration found in the array "Lbmonitors" inside of a LbmonitorGetResponse.

        Property|DataType|Description
        ---|---|---
        MonitorName|string|Name of the monitor.
        Type|string|Type of monitor that you want to create. Possible values = PING, TCP, HTTP, TCP-ECV, HTTP-ECV, UDP-ECV, DNS, FTP, LDNS-PING, LDNS-TCP, LDNS-DNS, RADIUS, USER, HTTP-INLINE, SIP-UDP, SIP-TCP, LOAD, FTP-EXTENDED, SMTP, SNMP, NNTP, MYSQL, MYSQL-ECV, MSSQL-ECV, ORACLE-ECV, LDAP, POP3, CITRIX-XML-SERVICE, CITRIX-WEB-INTERFACE, DNS-TCP, RTSP, ARP, CITRIX-AG, CITRIX-AAC-LOGINPAGE, CITRIX-AAC-LAS, CITRIX-XD-DDC, ND6, CITRIX-WI-EXTENDED, DIAMETER, RADIUS_ACCOUNTING, STOREFRONT, APPC, SMPP, CITRIX-XNC-ECV, CITRIX-XDM, CITRIX-STA-SERVICE, CITRIX-STA-SERVICE-NHOP. Automatically assigned when choosing Data to add.
        Action|string|Action to perform when the response to an inline monitor (a monitor of type HTTP-INLINE) indicates that the service is down. A service monitored by an inline monitor is considered DOWN if the response code is not one of the codes that have been specified for the Response Code parameter. Available settings function as follows: * NONE - Do not take any action. However, the show service command and the show lb monitor command indicate the total number of responses that were checked and the number of consecutive error responses received after the last successful probe. * LOG - Log the event in NSLOG or SYSLOG. * DOWN - Mark the service as being down, and then do not direct any traffic to the service until the configured down time has expired. Persistent connections to the service are terminated as soon as the service is marked as DOWN. Also, log the event in NSLOG or SYSLOG. Default value: DOWN. Possible values = NONE, LOG, DOWN
        ResponseCodes|string[ ]|Response codes for which to mark the service as UP. For any other response code, the action performed depends on the monitor type. HTTP monitors and RADIUS monitors mark the service as DOWN, while HTTP-INLINE monitors perform the action indicated by the Action parameter.
        HttpRequest|string|HTTP request to send to the server (for example, "HEAD /file.html").
        RtspRequest|string|RTSP request to send to the server (for example, "OPTIONS *").
        CustomHeaders|string|Custom header string to include in the monitoring probes.
        MaxForwards|double|Maximum number of hops that the SIP request used for monitoring can traverse to reach the server. Applicable only to monitors of type SIP-UDP.
        SipMethod|string|SIP method to use for the query. Applicable only to monitors of type SIP-UDP. Possible values = OPTIONS, INVITE, REGISTER
        SipUri|string|SIP URI string to send to the service (for example, sip:sip.test). Applicable only to monitors of type SIP-UDP.
        SipRegisterUri|string|SIP user to be registered. Applicable only if the monitor is of type SIP-UDP and the SIP Method parameter is set to REGISTER.
        Send|string|String to send to the service. Applicable to TCP-ECV, HTTP-ECV, and UDP-ECV monitors.
        Receive|string|String expected from the server for the service to be marked as UP. Applicable to TCP-ECV, HTTP-ECV, and UDP-ECV monitors.
        Query|string|Domain name to resolve as part of monitoring the DNS service (for example, example.com).
        QueryType|string|Type of DNS record for which to send monitoring queries. Set to Address for querying A records, AAAA for querying AAAA records, and Zone for querying the SOA record. Possible values = Address, Zone, AAAA
        Script|string|Path and name of the script to execute. The script must be available on the NetScaler appliance, in the /nsconfig/monitors/ directory.
        ScriptArgs|string|String of arguments for the script. The string is copied verbatim into the request.
        DispatcherIp|string|IP address of the dispatcher to which to send the probe.
        DisaptcherPort|string|Port number on which the dispatcher listens for the monitoring probe.
        UserName|string|User name with which to probe the RADIUS, NNTP, FTP, FTP-EXTENDED, MYSQL, MSSQL, POP3, CITRIX-AG, CITRIX-XD-DDC, CITRIX-WI-EXTENDED, CITRIX-XNC or CITRIX-XDM server.
        Password|string|Password that is required for logging on to the RADIUS, NNTP, FTP, FTP-EXTENDED, MYSQL, MSSQL, POP3, CITRIX-AG, CITRIX-XD-DDC, CITRIX-WI-EXTENDED, CITRIX-XNC-ECV or CITRIX-XDM server. Used in conjunction with the user name specified for the User Name parameter.
        SecondaryPassword|string|Secondary password that users might have to provide to log on to the Access Gateway server. Applicable to CITRIX-AG monitors.
        LogonPointName|string|Name of the logon point that is configured for the Citrix Access Gateway Advanced Access Control software. Required if you want to monitor the associated login page or Logon Agent. Applicable to CITRIX-AAC-LAS and CITRIX-AAC-LOGINPAGE monitors.
        LasVersion|string|Version number of the Citrix Advanced Access Control Logon Agent. Required by the CITRIX-AAC-LAS monitor.
        RadKey|string|Authentication key (shared secret text string) for RADIUS clients and servers to exchange. Applicable to monitors of type RADIUS and RADIUS_ACCOUNTING.
        RadNetworkAccessServerId|string|NAS-Identifier to send in the Access-Request packet. Applicable to monitors of type RADIUS. Minimum length = 1
        RadNerwordAccessServerIp|string|Network Access Server (NAS) IP address to use as the source IP address when monitoring a RADIUS server. Applicable to monitors of type RADIUS and RADIUS_ACCOUNTING.
        RadAccountType|double|Account Type to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadFrameDip|string|Source ip with which the packet will go out . Applicable to monitors of type RADIUS_ACCOUNTING.
        RadApn|string|Called Station Id to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadMsisdn|string|Calling Stations Id to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadAccountSession|string|Account Session ID to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        LeastResponseTimes|string|Calculate the least response times for bound services. If this parameter is not enabled, the appliance does not learn the response times of the bound services. Also used for LRTM load balancing. Possible values = ENABLED, DISABLED
        Deviation|double|Time value added to the learned average response time in dynamic response time monitoring (DRTM). When a deviation is specified, the appliance learns the average response time of bound services and adds the deviation to the average. The final value is then continually adjusted to accommodate response time variations over time. Specified in milliseconds, seconds, or minutes.
        UnitsDeviation|string|Unit of measurement for the Deviation parameter. Cannot be changed after the monitor is created. Default value: SEC. Possible values = SEC, MSEC, MIN
        Interval|int|Time interval between two successive probes. Must be greater than the value of Response Time-out.
        UnitsInterval|string|monitor interval units. Default value: SEC. Possible values = SEC, MSEC, MIN
        ResponseTimeout|int|Amount of time for which the appliance must wait before it marks a probe as FAILED. Must be less than the value specified for the Interval parameter.
        UnitsResponseTimeout|string|monitor response timeout units. Default value: SEC. Possible values = SEC, MSEC, MIN
        ResponseTimeoutThreshold|double|Response time threshold, specified as a percentage of the Response Time-out parameter. If the response to a monitor probe has not arrived when the threshold is reached, the appliance generates an SNMP trap called monRespTimeoutAboveThresh. After the response time returns to a value below the threshold, the appliance generates a monRespTimeoutBelowThresh SNMP trap. For the traps to be generated, the "MONITOR-RTO-THRESHOLD" alarm must also be enabled.
        Retries|int|Maximum number of probes to send to establish the state of a service for which a monitoring probe failed. Default value: 3
        FailureRetries|int|Number of retries that must fail, out of the number specified for the Retries parameter, for a service to be marked as DOWN. For example, if the Retries parameter is set to 10 and the Failure Retries parameter is set to 6, out of the ten probes sent, at least six probes must fail if the service is to be marked as DOWN. The default value of 0 means that all the retries must fail if the service is to be marked as DOWN.
        AlertRetries|int|Number of consecutive probe failures after which the appliance generates an SNMP trap called monProbeFailed.
        SuccessRetries|int|Number of consecutive successful probes required to transition a service's state from DOWN to UP. Default value: 1
        DownTime|int|Time duration for which to wait before probing a service that has been marked as DOWN. Expressed in milliseconds, seconds, or minutes. Default value: 30
        UnitsDownTime|string|Unit of measurement for the Down Time parameter. Cannot be changed after the monitor is created. Default value: SEC. Possible values = SEC, MSEC, MIN
        DestinationIp|string|IP address of the service to which to send probes. If the parameter is set to 0, the IP address of the server to which the monitor is bound is considered the destination IP address.
        DestinationPort|int|TCP or UDP port to which to send the probe. If the parameter is set to 0, the port number of the service to which the monitor is bound is considered the destination port. For a monitor of type USER, however, the destination port is the port number that is included in the HTTP request sent to the dispatcher. Does not apply to monitors of type PING.
        State|string|State of the monitor. The DISABLED setting disables not only the monitor being configured, but all monitors of the same type, until the parameter is set to ENABLED. If the monitor is bound to a service, the state of the monitor is not taken into account when the state of the service is determined. Default value: ENABLED. Possible values = ENABLED, DISABLED
        Reverse|string|Mark a service as DOWN, instead of UP, when probe criteria are satisfied, and as UP instead of DOWN when probe criteria are not satisfied. Default value: NO. Possible values = YES, NO
        Transparent|string|The monitor is bound to a transparent device such as a firewall or router. The state of a transparent device depends on the responsiveness of the services behind it. If a transparent device is being monitored, a destination IP address must be specified. The probe is sent to the specified IP address by using the MAC address of the transparent device. Default value: NO. Possible values = YES, NO
        IpTunnel|string|Send the monitoring probe to the service through an IP tunnel. A destination IP address must be specified. Default value: NO. Possible values = YES, NO
        TypeOfService|string|Probe the service by encoding the destination IP address in the IP TOS (6) bits. Possible values = YES, NO
        TypeOfServiceId|double|The TOS ID of the specified destination IP. Applicable only when the TOS parameter is set.
        Secure|string|Use a secure SSL connection when monitoring a service. Applicable only to TCP based monitors. The secure option cannot be used with a CITRIX-AG monitor, because a CITRIX-AG monitor uses a secure connection by default. Default value: NO. Possible values = YES, NO
        ValidateCred|string|Validate the credentials of the Xen Desktop DDC server user. Applicable to monitors of type CITRIX-XD-DDC. Default value: NO. Possible values = YES, NO
        Domain|string|Domain in which the XenDesktop Desktop Delivery Controller (DDC) servers or Web Interface servers are present. Required by CITRIX-XD-DDC and CITRIX-WI-EXTENDED monitors for logging on to the DDC servers and Web Interface servers, respectively.
        IpAddress|string|Set of IP addresses expected in the monitoring response from the DNS server, if the record type is A or AAAA. Applicable to DNS monitors.
        Group|string|Name of a newsgroup available on the NNTP service that is to be monitored. The appliance periodically generates an NNTP query for the name of the newsgroup and evaluates the response. If the newsgroup is found on the server, the service is marked as UP. If the newsgroup does not exist or if the search fails, the service is marked as DOWN. Applicable to NNTP monitors.
        FileName|string|Name of a file on the FTP server. The appliance monitors the FTP service by periodically checking the existence of the file on the server. Applicable to FTP-EXTENDED monitors.
        BaseDistinguishedName|string|The base distinguished name of the LDAP service, from where the LDAP server can begin the search for the attributes in the monitoring query. Required for LDAP service monitoring.
        BindDistinguishedName|string|The distinguished name with which an LDAP monitor can perform the Bind operation on the LDAP server. Optional. Applicable to LDAP monitors.
        Filter|string|Filter criteria for the LDAP query. Optional.
        Attribute|string|Attribute to evaluate when the LDAP server responds to the query. Success or failure of the monitoring probe depends on whether the attribute exists in the response. Optional.
        Database|string|Name of the database to connect to during authentication.
        OracledServiceId|string|Name of the service identifier that is used to connect to the Oracle database during authentication.
        SqlQuery|string|SQL query for a MYSQL-ECV or MSSQL-ECV monitor. Sent to the database server after the server authenticates the connection.
        EvaluationRule|string|Default syntax expression that evaluates the database server's response to a MYSQL-ECV or MSSQL-ECV monitoring query. Must produce a Boolean result. The result determines the state of the server. If the expression returns TRUE, the probe succeeds. For example, if you want the appliance to evaluate the error message to determine the state of the server, use the rule MYSQL.RES.ROW(10) .TEXT_ELEM(2).EQ("MySQL").
        MsSqlProtocolVersion|string|Version of MSSQL server that is to be monitored. Default value: 70. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        SnmpOid|string|SNMP OID for SNMP monitors.
        SnmpCommunity|string|Community name for SNMP monitors.
        SnmpThreshold|string|Threshold for SNMP monitors.
        SnmpVersion|string|SNMP version to be used for SNMP monitors.
        MetricTable|string|Metric table to which to bind metrics.
        Application|string|Name of the application used to determine the state of the service. Applicable to monitors of type CITRIX-XML-SERVICE.
        SitePath|string|URL of the logon page. For monitors of type CITRIX-WEB-INTERFACE, to monitor a dynamic page under the site path, terminate the site path with a slash (/). Applicable to CITRIX-WEB-INTERFACE, CITRIX-WI-EXTENDED and CITRIX-XDM monitors.
        StoreName|string|Store Name. For monitors of type STOREFRONT, STORENAME is an optional argument defining storefront service store name. Applicable to STOREFRONT monitors.
        StorefrontAcctService|string|Enable/Disable probing for Account Service. Applicable only to Store Front monitors. For multi-tenancy configuration users my skip account service. Default value: YES
        Hostname|string|Hostname in the FQDN format (Example: porche.cars.org). Applicable to STOREFRONT monitors.
        NetProfile|string|Name of the network profile.
        OriginHost|string|Origin-Host value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        OriginRealm|string|Origin-Realm value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        HostIpAddress|string|Host-IP-Address value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. If Host-IP-Address is not specified, the appliance inserts the mapped IP (MIP) address or subnet IP (SNIP) address from which the CER request (the monitoring probe) is sent.
        VendorId|string|Vendor-Id value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        ProductName|string|Product-Name value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        FirmwareVersion|double|Firmware-Revision value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        AuthenticationApplicationId|double[ ]|List of Auth-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring CER message.
        AccountApplicationId|double[ ]|List of Acct-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message.
        InbandSecurityId|string|Inband-Security-Id for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. Possible values = NO_INBAND_SECURITY, TLS
        SupportedVendorIds|double[ ]|List of Supported-Vendor-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum eight of these AVPs are supported in a monitoring message.
        VendorSpecificVendorId|double|Vendor-Id to use in the Vendor-Specific-Application-Id grouped attribute-value pair (AVP) in the monitoring CER message. To specify Auth-Application-Id or Acct-Application-Id in Vendor-Specific-Application-Id, use vendorSpecificAuthApplicationIds or vendorSpecificAcctApplicationIds, respectively. Only one Vendor-Id is supported for all the Vendor-Specific-Application-Id AVPs in a CER monitoring message.
        VendorSpecificAuthApplicationIds|double[ ]|List of Vendor-Specific-Auth-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message. The specified value is combined with the value of vendorSpecificVendorId to obtain the Vendor-Specific-Application-Id AVP in the CER monitoring message.
        VendorSpecificAcctApplicationIds|double[ ]|List of Vendor-Specific-Acct-Application-Id attribute value pairs (AVPs) to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message. The specified value is combined with the value of vendorSpecificVendorId to obtain the Vendor-Specific-Application-Id AVP in the CER monitoring message.
        KcdAccount|string|KCD Account used by MSSQL monitor.
        StoreDatabase|string|Store the database list populated with the responses to monitor probes. Used in database specific load balancing if MSSQL-ECV/MYSQL-ECV monitor is configured. Default value: DISABLED. Possible values = ENABLED, DISABLED
        StorefrontCheckBackendServices|string|This option will enable monitoring of services running on storefront server. Storefront services are monitored by probing to a Windows service that runs on the Storefront server and exposes details of which storefront services are running. Default value: NO. Possible values = YES, NO
        TrofsCode|double|Code expected when the server is under maintenance.
        TrofsString|string|String expected from the server for the service to be marked as trofs. Applicable to HTTP-ECV/TCP-ECV monitors.
        SslProfile|string|SSL Profile associated with the monitor.
        Metric|string|-
        MetricThreshold|string|-
        MetricWeight|string|-
        ServiceName|string|-
        ServiceGroupName|string|-
        LeastResponseTimesConfigurationState|int|-
        LeastResponseTimesConfigurationString|string|-
        DynamicResponseTimeout|int|-
        DynamicInterval|int|-
        MultiMetricTable|string[ ]|-
        DupState|string|-
        DupWeight|string|-
        Weight|string|-
        Ca|string|-
        Count|int|Count Parameter

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LbmonitorGetCommand>(INitroServiceClient, New LbmonitorGetRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object LbmonitorGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbmonitorGet, that object is <u>LbmonitorGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Lbmonitors: an array of LbmonitorConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LbmonitorRemoveCommand>(INitroServiceClient, new LbmonitorRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object LbmonitorRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbmonitorRemove, that object is <u>NitroResponse</u>.

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
        MonitorName|string|Name for the monitor.
        Type|string|Type of monitor that you want to create. Possible values = PING, TCP, HTTP, TCP-ECV, HTTP-ECV, UDP-ECV, DNS, FTP, LDNS-PING, LDNS-TCP, LDNS-DNS, RADIUS, USER, HTTP-INLINE, SIP-UDP, SIP-TCP, LOAD, FTP-EXTENDED, SMTP, SNMP, NNTP, MYSQL, MYSQL-ECV, MSSQL-ECV, ORACLE-ECV, LDAP, POP3, CITRIX-XML-SERVICE, CITRIX-WEB-INTERFACE, DNS-TCP, RTSP, ARP, CITRIX-AG, CITRIX-AAC-LOGINPAGE, CITRIX-AAC-LAS, CITRIX-XD-DDC, ND6, CITRIX-WI-EXTENDED, DIAMETER, RADIUS_ACCOUNTING, STOREFRONT, APPC, SMPP, CITRIX-XNC-ECV, CITRIX-XDM, CITRIX-STA-SERVICE, CITRIX-STA-SERVICE-NHOP. Automatically assigned when choosing Data to add.
        Action|string|Action to perform when the response to an inline monitor (a monitor of type HTTP-INLINE) indicates that the service is down. A service monitored by an inline monitor is considered DOWN if the response code is not one of the codes that have been specified for the Response Code parameter. Available settings function as follows: * NONE - Do not take any action. However, the show service command and the show lb monitor command indicate the total number of responses that were checked and the number of consecutive error responses received after the last successful probe. * LOG - Log the event in NSLOG or SYSLOG. * DOWN - Mark the service as being down, and then do not direct any traffic to the service until the configured down time has expired. Persistent connections to the service are terminated as soon as the service is marked as DOWN. Also, log the event in NSLOG or SYSLOG. Default value: DOWN. Possible values = NONE, LOG, DOWN
        RespCode|string[ ]|Response codes for which to mark the service as UP. For any other response code, the action performed depends on the monitor type. HTTP monitors and RADIUS monitors mark the service as DOWN, while HTTP-INLINE monitors perform the action indicated by the Action parameter.
        HttpRequest|string|HTTP request to send to the server (for example, "HEAD /file.html").
        RtspRequest|string|RTSP request to send to the server (for example, "OPTIONS *").
        CustomHeaders|string|Custom header string to include in the monitoring probes.
        MaxForwards|double|Maximum number of hops that the SIP request used for monitoring can traverse to reach the server. Applicable only to monitors of type SIP-UDP.
        SipMethod|string|SIP method to use for the query. Applicable only to monitors of type SIP-UDP. Possible values = OPTIONS, INVITE, REGISTER
        SipUri|string|SIP URI string to send to the service (for example, sip:sip.test). Applicable only to monitors of type SIP-UDP.
        SipRegUri|string|SIP user to be registered. Applicable only if the monitor is of type SIP-UDP and the SIP Method parameter is set to REGISTER.
        Send|string|String to send to the service. Applicable to TCP-ECV, HTTP-ECV, and UDP-ECV monitors.
        Recv|string|String expected from the server for the service to be marked as UP. Applicable to TCP-ECV, HTTP-ECV, and UDP-ECV monitors.
        Query|string|Domain name to resolve as part of monitoring the DNS service (for example, example.com).
        QueryType|string|Type of DNS record for which to send monitoring queries. Set to Address for querying A records, AAAA for querying AAAA records, and Zone for querying the SOA record. Possible values = Address, Zone, AAAA
        Script|string|Path and name of the script to execute. The script must be available on the NetScaler appliance, in the /nsconfig/monitors/ directory.
        ScriptArgs|string|String of arguments for the script. The string is copied verbatim into the request.
        DispatcherIp|string|IP address of the dispatcher to which to send the probe.
        DisaptcherPort|string|Port number on which the dispatcher listens for the monitoring probe.
        UserName|string|User name with which to probe the RADIUS, NNTP, FTP, FTP-EXTENDED, MYSQL, MSSQL, POP3, CITRIX-AG, CITRIX-XD-DDC, CITRIX-WI-EXTENDED, CITRIX-XNC or CITRIX-XDM server.
        Password|string|Password that is required for logging on to the RADIUS, NNTP, FTP, FTP-EXTENDED, MYSQL, MSSQL, POP3, CITRIX-AG, CITRIX-XD-DDC, CITRIX-WI-EXTENDED, CITRIX-XNC-ECV or CITRIX-XDM server. Used in conjunction with the user name specified for the User Name parameter.
        SecondaryPassword|string|Secondary password that users might have to provide to log on to the Access Gateway server. Applicable to CITRIX-AG monitors.
        LogonPointName|string|Name of the logon point that is configured for the Citrix Access Gateway Advanced Access Control software. Required if you want to monitor the associated login page or Logon Agent. Applicable to CITRIX-AAC-LAS and CITRIX-AAC-LOGINPAGE monitors.
        LasVersion|string|Version number of the Citrix Advanced Access Control Logon Agent. Required by the CITRIX-AAC-LAS monitor.
        RadKey|string|Authentication key (shared secret text string) for RADIUS clients and servers to exchange. Applicable to monitors of type RADIUS and RADIUS_ACCOUNTING.
        RadnasId|string|NAS-Identifier to send in the Access-Request packet. Applicable to monitors of type RADIUS. Minimum length = 1
        RadnasIp|string|Network Access Server (NAS) IP address to use as the source IP address when monitoring a RADIUS server. Applicable to monitors of type RADIUS and RADIUS_ACCOUNTING.
        RadAccountType|double|Account Type to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadFrameDip|string|Source ip with which the packet will go out . Applicable to monitors of type RADIUS_ACCOUNTING.
        RadApn|string|Called Station Id to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadMsisdn|string|Calling Stations Id to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        RadAccountSession|string|Account Session ID to be used in Account Request Packet. Applicable to monitors of type RADIUS_ACCOUNTING.
        Lrtm|string|Calculate the least response times for bound services. If this parameter is not enabled, the appliance does not learn the response times of the bound services. Also used for LRTM load balancing. Possible values = ENABLED, DISABLED
        Deviation|double|Time value added to the learned average response time in dynamic response time monitoring (DRTM). When a deviation is specified, the appliance learns the average response time of bound services and adds the deviation to the average. The final value is then continually adjusted to accommodate response time variations over time. Specified in milliseconds, seconds, or minutes.
        Units1|string|Unit of measurement for the Deviation parameter. Cannot be changed after the monitor is created. Default value: SEC. Possible values = SEC, MSEC, MIN
        Interval|int|Time interval between two successive probes. Must be greater than the value of Response Time-out.
        Units3|string|monitor interval units. Default value: SEC. Possible values = SEC, MSEC, MIN
        RespTimeout|int|Amount of time for which the appliance must wait before it marks a probe as FAILED. Must be less than the value specified for the Interval parameter.
        Units4|string|monitor response timeout units. Default value: SEC. Possible values = SEC, MSEC, MIN
        ResponseTimeoutThresh|double|Response time threshold, specified as a percentage of the Response Time-out parameter. If the response to a monitor probe has not arrived when the threshold is reached, the appliance generates an SNMP trap called monRespTimeoutAboveThresh. After the response time returns to a value below the threshold, the appliance generates a monRespTimeoutBelowThresh SNMP trap. For the traps to be generated, the "MONITOR-RTO-THRESHOLD" alarm must also be enabled.
        Retries|int|Maximum number of probes to send to establish the state of a service for which a monitoring probe failed. Default value: 3
        FailureRetries|int|Number of retries that must fail, out of the number specified for the Retries parameter, for a service to be marked as DOWN. For example, if the Retries parameter is set to 10 and the Failure Retries parameter is set to 6, out of the ten probes sent, at least six probes must fail if the service is to be marked as DOWN. The default value of 0 means that all the retries must fail if the service is to be marked as DOWN.
        AlertRetries|int|Number of consecutive probe failures after which the appliance generates an SNMP trap called monProbeFailed.
        SuccessRetries|int|Number of consecutive successful probes required to transition a service's state from DOWN to UP. Default value: 1
        DownTime|int|Time duration for which to wait before probing a service that has been marked as DOWN. Expressed in milliseconds, seconds, or minutes. Default value: 30
        Units2|string|Unit of measurement for the Down Time parameter. Cannot be changed after the monitor is created. Default value: SEC. Possible values = SEC, MSEC, MIN
        DestIp|string|IP address of the service to which to send probes. If the parameter is set to 0, the IP address of the server to which the monitor is bound is considered the destination IP address.
        DestPort|int|TCP or UDP port to which to send the probe. If the parameter is set to 0, the port number of the service to which the monitor is bound is considered the destination port. For a monitor of type USER, however, the destination port is the port number that is included in the HTTP request sent to the dispatcher. Does not apply to monitors of type PING.
        State|string|State of the monitor. The DISABLED setting disables not only the monitor being configured, but all monitors of the same type, until the parameter is set to ENABLED. If the monitor is bound to a service, the state of the monitor is not taken into account when the state of the service is determined. Default value: ENABLED. Possible values = ENABLED, DISABLED
        Reverse|string|Mark a service as DOWN, instead of UP, when probe criteria are satisfied, and as UP instead of DOWN when probe criteria are not satisfied. Default value: NO. Possible values = YES, NO
        Transparent|string|The monitor is bound to a transparent device such as a firewall or router. The state of a transparent device depends on the responsiveness of the services behind it. If a transparent device is being monitored, a destination IP address must be specified. The probe is sent to the specified IP address by using the MAC address of the transparent device. Default value: NO. Possible values = YES, NO
        IpTunnel|string|Send the monitoring probe to the service through an IP tunnel. A destination IP address must be specified. Default value: NO. Possible values = YES, NO
        Tos|string|Probe the service by encoding the destination IP address in the IP TOS (6) bits. Possible values = YES, NO
        TosId|double|The TOS ID of the specified destination IP. Applicable only when the TOS parameter is set.
        Secure|string|Use a secure SSL connection when monitoring a service. Applicable only to TCP based monitors. The secure option cannot be used with a CITRIX-AG monitor, because a CITRIX-AG monitor uses a secure connection by default. Default value: NO. Possible values = YES, NO
        ValidateCred|string|Validate the credentials of the Xen Desktop DDC server user. Applicable to monitors of type CITRIX-XD-DDC. Default value: NO. Possible values = YES, NO
        Domain|string|Domain in which the XenDesktop Desktop Delivery Controller (DDC) servers or Web Interface servers are present. Required by CITRIX-XD-DDC and CITRIX-WI-EXTENDED monitors for logging on to the DDC servers and Web Interface servers, respectively.
        IpAddress|string|Set of IP addresses expected in the monitoring response from the DNS server, if the record type is A or AAAA. Applicable to DNS monitors.
        Group|string|Name of a newsgroup available on the NNTP service that is to be monitored. The appliance periodically generates an NNTP query for the name of the newsgroup and evaluates the response. If the newsgroup is found on the server, the service is marked as UP. If the newsgroup does not exist or if the search fails, the service is marked as DOWN. Applicable to NNTP monitors.
        FileName|string|Name of a file on the FTP server. The appliance monitors the FTP service by periodically checking the existence of the file on the server. Applicable to FTP-EXTENDED monitors.
        BaseDn|string|The base distinguished name of the LDAP service, from where the LDAP server can begin the search for the attributes in the monitoring query. Required for LDAP service monitoring.
        BindDn|string|The distinguished name with which an LDAP monitor can perform the Bind operation on the LDAP server. Optional. Applicable to LDAP monitors.
        Filter|string|Filter criteria for the LDAP query. Optional.
        Attribute|string|Attribute to evaluate when the LDAP server responds to the query. Success or failure of the monitoring probe depends on whether the attribute exists in the response. Optional.
        Database|string|Name of the database to connect to during authentication.
        OracledsId|string|Name of the service identifier that is used to connect to the Oracle database during authentication.
        SqlQuery|string|SQL query for a MYSQL-ECV or MSSQL-ECV monitor. Sent to the database server after the server authenticates the connection.
        EvalRule|string|Default syntax expression that evaluates the database server's response to a MYSQL-ECV or MSSQL-ECV monitoring query. Must produce a Boolean result. The result determines the state of the server. If the expression returns TRUE, the probe succeeds. For example, if you want the appliance to evaluate the error message to determine the state of the server, use the rule MYSQL.RES.ROW(10) .TEXT_ELEM(2).EQ("MySQL").
        MsSqlProtocolVersion|string|Version of MSSQL server that is to be monitored. Default value: 70. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        SnmpOid|string|SNMP OID for SNMP monitors.
        SnmpCommunity|string|Community name for SNMP monitors.
        SnmpThreshold|string|Threshold for SNMP monitors.
        SnmpVersion|string|SNMP version to be used for SNMP monitors.
        MetricTable|string|Metric table to which to bind metrics.
        Application|string|Name of the application used to determine the state of the service. Applicable to monitors of type CITRIX-XML-SERVICE.
        SitePath|string|URL of the logon page. For monitors of type CITRIX-WEB-INTERFACE, to monitor a dynamic page under the site path, terminate the site path with a slash (/). Applicable to CITRIX-WEB-INTERFACE, CITRIX-WI-EXTENDED and CITRIX-XDM monitors.
        StoreName|string|Store Name. For monitors of type STOREFRONT, STORENAME is an optional argument defining storefront service store name. Applicable to STOREFRONT monitors.
        StorefrontAcctService|string|Enable/Disable probing for Account Service. Applicable only to Store Front monitors. For multi-tenancy configuration users my skip account service. Default value: YES
        Hostname|string|Hostname in the FQDN format (Example: porche.cars.org). Applicable to STOREFRONT monitors.
        NetProfile|string|Name of the network profile.
        OriginHost|string|Origin-Host value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        OriginRealm|string|Origin-Realm value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        HostIpAddress|string|Host-IP-Address value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. If Host-IP-Address is not specified, the appliance inserts the mapped IP (MIP) address or subnet IP (SNIP) address from which the CER request (the monitoring probe) is sent.
        VendorId|string|Vendor-Id value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        ProductName|string|Product-Name value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        FirmwareVersion|double|Firmware-Revision value for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers.
        AuthApplicationId|double[ ]|List of Auth-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring CER message.
        AcctApplicationId|double[ ]|List of Acct-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message.
        InbandSecurityId|string|Inband-Security-Id for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. Possible values = NO_INBAND_SECURITY, TLS
        SupportedVendorIds|double[ ]|List of Supported-Vendor-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum eight of these AVPs are supported in a monitoring message.
        VendorSpecificVendorId|double|Vendor-Id to use in the Vendor-Specific-Application-Id grouped attribute-value pair (AVP) in the monitoring CER message. To specify Auth-Application-Id or Acct-Application-Id in Vendor-Specific-Application-Id, use vendorSpecificAuthApplicationIds or vendorSpecificAcctApplicationIds, respectively. Only one Vendor-Id is supported for all the Vendor-Specific-Application-Id AVPs in a CER monitoring message.
        VendorSpecificAuthApplicationIds|double[ ]|List of Vendor-Specific-Auth-Application-Id attribute value pairs (AVPs) for the Capabilities-Exchange-Request (CER) message to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message. The specified value is combined with the value of vendorSpecificVendorId to obtain the Vendor-Specific-Application-Id AVP in the CER monitoring message.
        VendorSpecificAcctApplicationIds|double[ ]|List of Vendor-Specific-Acct-Application-Id attribute value pairs (AVPs) to use for monitoring Diameter servers. A maximum of eight of these AVPs are supported in a monitoring message. The specified value is combined with the value of vendorSpecificVendorId to obtain the Vendor-Specific-Application-Id AVP in the CER monitoring message.
        KcdAccount|string|KCD Account used by MSSQL monitor.
        StoreDb|string|Store the database list populated with the responses to monitor probes. Used in database specific load balancing if MSSQL-ECV/MYSQL-ECV monitor is configured. Default value: DISABLED. Possible values = ENABLED, DISABLED
        StorefrontCheckBackendServices|string|This option will enable monitoring of services running on storefront server. Storefront services are monitored by probing to a Windows service that runs on the Storefront server and exposes details of which storefront services are running. Default value: NO. Possible values = YES, NO
        TrofsCode|double|Code expected when the server is under maintenance.
        TrofsString|string|String expected from the server for the service to be marked as trofs. Applicable to HTTP-ECV/TCP-ECV monitors.
        SslProfile|string|SSL Profile associated with the monitor.

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (LbmonitorUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<LbmonitorUpdateCommand> (INitroServiceClient, new LbmonitorUpdateRequestData(){ });
            ```

            Where LbMonitorUpdateRequestData is one of:
            - LbmonitorHttpEcvUpdateRequestData, LbmonitorHttpInlineUpdateRequestData, LbmonitorHttpUpdateRequestData, LbmonitorTcpEcvUpdateRequestData, LbmonitorTcpUpdateRequestData

    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbmonitorUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


#### Lbvserver

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|Name for the virtual server. 
        ServiceType|string|Protocol used by the service (also called the service type). Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, DNS, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, RTSP, PUSH, SSL_PUSH, RADIUS, RDP, MYSQL, MSSQL, DIAMETER, SSL_DIAMETER, TFTP, ORACLE, SMPP, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, PROXY, USER_TCP, USER_SSL_TCP, QUIC. Automatically assigned when choosing Data to use.
        IpV46|string|IPv4 or IPv6 address to assign to the virtual server.
        IpPattern|string|IP address pattern, in dotted decimal notation, for identifying packets to be accepted by the virtual server. The IP Mask parameter specifies which part of the destination IP address is matched against the pattern. Mutually exclusive with the IP Address parameter. For example, if the IP pattern assigned to the virtual server is 198.51.100.0 and the IP mask is 255.255.240.0 (a forward mask), the first 20 bits in the destination IP addresses are matched with the first 20 bits in the pattern. The virtual server accepts requests with IP addresses that range from 198.51.96.1 to 198.51.111.254. You can also use a pattern such as 0.0.2.2 and a mask such as 0.0.255.255 (a reverse mask). If a destination IP address matches more than one IP pattern, the pattern with the longest match is selected, and the associated virtual server processes the request. For example, if virtual servers vs1 and vs2 have the same IP pattern, 0.0.100.128, but different IP masks of 0.0.255.255 and 0.0.224.255, a destination IP address of 198.51.100.128 has the longest match with the IP pattern of vs1. If a destination IP address matches two or more virtual servers to the same extent, the request is processed by the virtual server whose port number matches the port number in the request.
        IpMask|string|IP mask, in dotted decimal notation, for the IP Pattern parameter. Can have leading or trailing non-zero octets (for example, 255.255.240.0 or 0.0.255.255). Accordingly, the mask specifies whether the first n bits or the last n bits of the destination IP address in a client request are to be matched with the corresponding bits in the IP pattern. The former is called a forward mask. The latter is called a reverse mask.
        Port|int|Port number for the virtual server.
        Range|double|Number of IP addresses that the appliance must generate and assign to the virtual server. The virtual server then functions as a network virtual server, accepting traffic on any of the generated IP addresses. The IP addresses are generated automatically, as follows: * For a range of n, the last octet of the address specified by the IP Address parameter increments n-1 times. * If the last octet exceeds 255, it rolls over to 0 and the third octet increments by 1.Note: The Range parameter assigns multiple IP addresses to one virtual server. To generate an array of virtual servers, each of which owns only one IP address, use brackets in the IP Address and Name parameters to specify the range. For example: add lb vserver my_vserver[1-3] HTTP 192.0.2.[1-3] 80. Default value: 1
        PersistenceType|string|Type of persistence for the virtual server. Available settings function as follows: * SOURCEIP - Connections from the same client IP address belong to the same persistence session. * COOKIEINSERT - Connections that have the same HTTP Cookie, inserted by a Set-Cookie directive from a server, belong to the same persistence session. * SSLSESSION - Connections that have the same SSL Session ID belong to the same persistence session. * CUSTOMSERVERID - Connections with the same server ID form part of the same session. For this persistence type, set the Server ID (CustomServerID) parameter for each service and configure the Rule parameter to identify the server ID in a request. * RULE - All connections that match a user defined rule belong to the same persistence session. * URLPASSIVE - Requests that have the same server ID in the URL query belong to the same persistence session. The server ID is the hexadecimal representation of the IP address and port of the service to which the request must be forwarded. This persistence type requires a rule to identify the server ID in the request. * DESTIP - Connections to the same destination IP address belong to the same persistence session. * SRCIPDESTIP - Connections that have the same source IP address and destination IP address belong to the same persistence session. * CALLID - Connections that have the same CALL-ID SIP header belong to the same persistence session. * RTSPSID - Connections that have the same RTSP Session ID belong to the same persistence session. * FIXSESSION - Connections that have the same SenderCompID and TargetCompID values belong to the same persistence session. * USERSESSION - Persistence session is created based on the persistence parameter value provided from an extension. Possible values = SOURCEIP, COOKIEINSERT, SSLSESSION, RULE, URLPASSIVE, CUSTOMSERVERID, DESTIP, SRCIPDESTIP, CALLID, RTSPSID, DIAMETER, FIXSESSION, USERSESSION, NONE
        Timeout|double|Time period for which a persistence session is in effect.
        PersistenceBackup|string|Backup persistence type for the virtual server. Becomes operational if the primary persistence mechanism fails. Possible values = SOURCEIP, NONE
        BackupPersistenceTimeout|double|Time period for which backup persistence is in effect. Default value: 2
        LbMethod|string|Load balancing method. The available settings function as follows:        * ROUNDROBIN - Distribute requests in rotation, regardless of the load. Weights can be assigned to services to enforce weighted round robin distribution. * LEASTCONNECTION (default) - Select the service with the fewest connections. * LEASTRESPONSETIME - Select the service with the lowest average response time. * LEASTBANDWIDTH - Select the service currently handling the least traffic. * LEASTPACKETS - Select the service currently serving the lowest number of packets per second. * CUSTOMLOAD - Base service selection on the SNMP metrics obtained by custom load monitors. * LRTM - Select the service with the lowest response time. Response times are learned through monitoring probes. This method also takes the number of active connections into account. Also available are a number of hashing methods, in which the appliance extracts a predetermined portion of the request, creates a hash of the portion, and then checks whether any previous requests had the same hash value. If it finds a match, it forwards the request to the service that served those previous requests. Following are the hashing methods: * URLHASH - Create a hash of the request URL (or part of the URL). * DOMAINHASH - Create a hash of the domain name in the request (or part of the domain name). The domain name is taken from either the URL or the Host header. If the domain name appears in both locations, the URL is preferred. If the request does not contain a domain name, the load balancing method defaults to LEASTCONNECTION. * DESTINATIONIPHASH - Create a hash of the destination IP address in the IP header. * SOURCEIPHASH - Create a hash of the source IP address in the IP header. * TOKEN - Extract a token from the request, create a hash of the token, and then select the service to which any previous requests with the same token hash value were sent. * SRCIPDESTIPHASH - Create a hash of the string obtained by concatenating the source IP address and destination IP address in the IP header. * SRCIPSRCPORTHASH - Create a hash of the source IP address and source port in the IP header. * CALLIDHASH - Create a hash of the SIP Call-ID header. * USER_TOKEN - Same as TOKEN LB method but token needs to be provided from an extension. Default value: LEASTCONNECTION. Possible values = ROUNDROBIN, LEASTCONNECTION, LEASTRESPONSETIME, URLHASH, DOMAINHASH, DESTINATIONIPHASH, SOURCEIPHASH, SRCIPDESTIPHASH, LEASTBANDWIDTH, LEASTPACKETS, TOKEN, SRCIPSRCPORTHASH, LRTM, CALLIDHASH, CUSTOMLOAD, LEASTREQUEST, AUDITLOGHASH, STATICPROXIMITY, USER_TOKEN
        HashLenght|double|Number of bytes to consider for the hash value used in the URLHASH and DOMAINHASH load balancing methods. Default value: 80
        NetMask|string|IPv4 subnet mask to apply to the destination IP address or source IP address when the load balancing method is DESTINATIONIPHASH or SOURCEIPHASH.
        V6NetMaskLen|double|Number of bits to consider in an IPv6 destination or source IP address, for creating the hash that is required by the DESTINATIONIPHASH and SOURCEIPHASH load balancing methods. Default value: 128
        BackupLbMethod|string|Backup load balancing method. Becomes operational if the primary load balancing method fails or cannot be used. Valid only if the primary method is based on static proximity. Default value: ROUNDROBIN. Possible values = ROUNDROBIN, LEASTCONNECTION, LEASTRESPONSETIME, SOURCEIPHASH, LEASTBANDWIDTH, LEASTPACKETS, CUSTOMLOAD
        CookieName|string|Use this parameter to specify the cookie name for COOKIE peristence type. It specifies the name of cookie with a maximum of 32 characters. If not specified, cookie name is internally generated.
        Rule|string|Expression, or name of a named expression, against which traffic is evaluated. Written in the classic or default syntax. Note: Maximum length of a string literal in the expression is 255 characters. A longer string can be split into smaller strings of up to 255 characters each, and the smaller strings concatenated with the + operator. For example, you can create a 500-character string as follows: '"<string of 255 characters>" + "<string of 245 characters>"' The following requirements apply only to the NetScaler CLI: * If the expression includes one or more spaces, enclose the entire expression in double quotation marks. * If the expression itself includes double quotation marks, escape the quotations by using the \ character. * Alternatively, you can use single quotation marks to enclose the rule, in which case you do not have to escape the double quotation marks. Default value: "none"
        ListenPolicy|string|Default syntax expression identifying traffic accepted by the virtual server. Can be either an expression (for example, CLIENT.IP.DST.IN_SUBNET(192.0.2.0/24) or the name of a named expression. In the above example, the virtual server accepts all requests whose destination IP address is in the 192.0.2.0/24 subnet. Default value: "NONE"
        ListenPriority|double|Integer specifying the priority of the listen policy. A higher number specifies a lower priority. If a request matches the listen policies of more than one virtual server the virtual server whose listen policy has the highest priority (the lowest priority number) accepts the request. Default value: 101
        ResRule|string|Default syntax expression specifying which part of a server's response to use for creating rule based persistence sessions (persistence type RULE). Can be either an expression or the name of a named expression. Example: HTTP.RES.HEADER("setcookie").VALUE(0).TYPECAST_NVLIST_T('=',';').VALUE("server1"). Default value: "none"
        PersistMask|string|Persistence mask for IP based persistence types, for IPv4 virtual servers.
        V6PersistMaskLen|double|Persistence mask for IP based persistence types, for IPv6 virtual servers. Default value: 128
        Pq|string|Use priority queuing on the virtual server. based persistence types, for IPv6 virtual servers. Default value: OFF Possible values = ON, OFF
        Sc|string|Use SureConnect on the virtual server. Default value: OFF. Possible values = ON, OFF
        RtspNat|string|Use network address translation (NAT) for RTSP data connections. Default value: OFF Possible values = ON, OFF
        M|string|Redirection mode for load balancing. Available settings function as follows: * IP - Before forwarding a request to a server, change the destination IP address to the server's IP address. * MAC - Before forwarding a request to a server, change the destination MAC address to the server's MAC address. The destination IP address is not changed. MAC-based redirection mode is used mostly in firewall load balancing deployments. * IPTUNNEL - Perform IP-in-IP encapsulation for client IP packets. In the outer IP headers, set the destination IP address to the IP address of the server and the source IP address to the subnet IP (SNIP). The client IP packets are not modified. Applicable to both IPv4 and IPv6 packets. * TOS - Encode the virtual server's TOS ID in the TOS field of the IP header. You can use either the IPTUNNEL or the TOS option to implement Direct Server Return (DSR). Default value: IP. Possible values = IP, MAC, IPTUNNEL, TOS
        TosId|double|TOS ID of the virtual server. Applicable only when the load balancing redirection mode is set to TOS.
        DataLenght|double|Length of the token to be extracted from the data segment of an incoming packet, for use in the token method of load balancing. The length of the token, specified in bytes, must not be greater than 24 KB. Applicable to virtual servers of type TCP.
        DataOffset|double|Offset to be considered when extracting a token from the TCP payload. Applicable to virtual servers, of type TCP, using the token method of load balancing. Must be within the first 24 KB of the TCP payload.
        Sessionless|string|Perform load balancing on a per-packet basis, without establishing sessions. Recommended for load balancing of intrusion detection system (IDS) servers and scenarios involving direct server return (DSR), where session information is unnecessary. Default value: DISABLED. Possible values = ENABLED, DISABLED
        TrofsPersistence|string|When value is ENABLED, Trofs persistence is honored. When value is DISABLED, Trofs persistence is not honored. Default value: ENABLED. Possible values = ENABLED, DISABLED
        State|string|State of the load balancing virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        ConnFailover|string|Mode in which the connection failover feature must operate for the virtual server. After a failover, established TCP connections and UDP packet flows are kept active and resumed on the secondary appliance. Clients remain connected to the same servers. Available settings function as follows: * STATEFUL - The primary appliance shares state information with the secondary appliance, in real time, resulting in some runtime processing overhead. * STATELESS - State information is not shared, and the new primary appliance tries to re-create the packet flow on the basis of the information contained in the packets it receives. * DISABLED - Connection failover does not occur. Default value: DISABLED. Possible values = DISABLED, STATEFUL, STATELESS
        RedirUrl|string|URL to which to redirect traffic if the virtual server becomes unavailable. WARNING! Make sure that the domain in the URL does not match the domain specified for a content switching policy. If it does, requests are continuously redirected to the unavailable virtual server.
        Cacheable|string|Route cacheable requests to a cache redirection virtual server. The load balancing virtual server can forward requests only to a transparent cache redirection virtual server that has an IP address and port combination of *:80, so such a cache redirection virtual server must be configured on the appliance. Default value: NO. Possible values = YES, NO
        CltTimeout|double|Idle time, in seconds, after which a client connection is terminated.
        SoMethod|string|Type of threshold that, when exceeded, triggers spillover. Available settings function as follows: * CONNECTION - Spillover occurs when the number of client connections exceeds the threshold. * DYNAMICCONNECTION - Spillover occurs when the number of client connections at the virtual server exceeds the sum of the maximum client (Max Clients) settings for bound services. Do not specify a spillover threshold for this setting, because the threshold is implied by the Max Clients settings of bound services. * BANDWIDTH - Spillover occurs when the bandwidth consumed by the virtual server's incoming and outgoing traffic exceeds the threshold. * HEALTH - Spillover occurs when the percentage of weights of the services that are UP drops below the threshold. For example, if services svc1, svc2, and svc3 are bound to a virtual server, with weights 1, 2, and 3, and the spillover threshold is 50%, spillover occurs if svc1 and svc3 or svc2 and svc3 transition to DOWN. * NONE - Spillover does not occur. Possible values = CONNECTION, DYNAMICCONNECTION, BANDWIDTH, HEALTH, NONE
        SoPersistence|string|If spillover occurs, maintain source IP address based persistence for both primary and backup virtual servers. Default value: DISABLED. Possible values = ENABLED, DISABLED
        SoPersistenceTimeout|double|Timeout for spillover persistence, in minutes. Default value: 2
        HealthThreshold|double|Threshold in percent of active services below which vserver state is made down. If this threshold is 0, vserver state will be up even if one bound service is up. Default value: 0
        SoThreshold|double|Threshold at which spillover occurs. Specify an integer for the CONNECTION spillover method, a bandwidth value in kilobits per second for the BANDWIDTH method (do not enter the units), or a percentage for the HEALTH method (do not enter the percentage symbol).
        SoBackupAction|string|Action to be performed if spillover is to take effect, but no backup chain to spillover is usable or exists. Possible values = DROP, ACCEPT, REDIRECT
        RedirectPortRewrite|string|Rewrite the port and change the protocol to ensure successful HTTP redirects from services. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with a virtual server whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        BackupVserver|string|Name of the backup virtual server to which to forward requests if the primary virtual server goes DOWN or reaches its spillover threshold.
        DisablePrimaryOnDown|string|If the primary virtual server goes down, do not allow it to return to primary status until manually enabled. Default value: DISABLED. Possible values = ENABLED, DISABLED
        InsertVserverIpPort|string|Insert an HTTP header, whose value is the IP address and port number of the virtual server, before forwarding a request to the server. The format of the header is <vipHeader>: <virtual server IP address>_<port number >, where vipHeader is the name that you specify for the header. If the virtual server has an IPv6 address, the address in the header is enclosed in brackets ([ and ]) to separate it from the port number. If you have mapped an IPv4 address to a virtual server's IPv6 address, the value of this parameter determines which IP address is inserted in the header, as follows: * VIPADDR - Insert the IP address of the virtual server in the HTTP header regardless of whether the virtual server has an IPv4 address or an IPv6 address. A mapped IPv4 address, if configured, is ignored. * V6TOV4MAPPING - Insert the IPv4 address that is mapped to the virtual server's IPv6 address. If a mapped IPv4 address is not configured, insert the IPv6 address. * OFF - Disable header insertion. Possible values = OFF, VIPADDR, V6TOV4MAPPING
        VipHeader|string|Name for the inserted header. The default name is vip-header.
        AuthenticationHost|string|Fully qualified domain name (FQDN) of the authentication virtual server to which the user must be redirected for authentication. Make sure that the Authentication parameter is set to ENABLED.
        Authentication|string|Enable or disable user authentication. Default value: OFF. Possible values = ON, OFF
        Authn401|string|Enable or disable user authentication with HTTP 401 responses. Default value: OFF. Possible values = ON, OFF
        AuthnVsName|string|Name of an authentication virtual server with which to authenticate users.
        Push|string|Process traffic with the push virtual server that is bound to this load balancing virtual server. Default value: DISABLED. Possible values = ENABLED, DISABLED
        PushVserver|string|Name of the load balancing virtual server, of type PUSH or SSL_PUSH, to which the server pushes updates received on the load balancing virtual server that you are configuring.
        PushLabel|string|Expression for extracting a label from the server's response. Can be either an expression or the name of a named expression. Default value: "none"
        PushMultiClients|string|Allow multiple Web 2.0 connections from the same client to connect to the virtual server and expect updates. Default value: NO. Possible values = YES, NO
        TcpProfileName|string|Name of the TCP profile whose settings are to be applied to the virtual server.
        HttpProfileName|string|Name of the Http profile whose settings are to be applied to the virtual server.
        DbProfileName|string|Name of the DB profile whose settings are to be applied to the virtual server.
        Comment|string|Any comments that you might want to associate with the virtual server.
        L2Conn|string|Use Layer 2 parameters (channel number, MAC address, and VLAN ID) in addition to the 4-tuple (<source IP>:<source port>::<destination IP>:<destination port>) that is used to identify a connection. Allows multiple TCP and non-TCP connections with the same 4-tuple to co-exist on the NetScaler appliance. Possible values = ON, OFF
        OracleServerVersion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        MsSqlServerVersion|string|For a load balancing virtual server of type MSSQL, the Microsoft SQL Server version. Set this parameter if you expect some clients to run a version different from the version of the database. This setting provides compatibility between the client-side and server-side connections by ensuring that all communication conforms to the server's version. Default value: 2008R2. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        MySqlProtocolVersion|double|MySQL protocol version that the virtual server advertises to clients.
        MySqlServerVersion|string|MySQL server version string that the virtual server advertises to clients.
        MySqlCharacterSet|double|Character set that the virtual server advertises to clients.
        MySqlServerCapabilities|double|Server capabilities that the virtual server advertises to clients.
        AppFlowLog|string|Apply AppFlow logging to the virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|string|Name of the network profile to associate with the virtual server. If you set this parameter, the virtual server uses only the IP addresses in the network profile as source IP addresses when initiating connections with servers.
        IcmpVsrResponse|string|How the NetScaler appliance responds to ping requests received for an IP address that is common to one or more virtual servers. Available settings function as follows: * If set to PASSIVE on all the virtual servers that share the IP address, the appliance always responds to the ping requests. * If set to ACTIVE on all the virtual servers that share the IP address, the appliance responds to the ping requests if at least one of the virtual servers is UP. Otherwise, the appliance does not respond. * If set to ACTIVE on some virtual servers and PASSIVE on the others, the appliance responds if at least one virtual server with the ACTIVE setting is UP. Otherwise, the appliance does not respond. Note: This parameter is available at the virtual server level. A similar parameter, ICMP Response, is available at the IP address level, for IPv4 addresses of type VIP. To set that parameter, use the add ip command in the CLI or the Create IP dialog box in the GUI. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        RhiState|string|Route Health Injection (RHI) functionality of the NetSaler appliance for advertising the route of the VIP address associated with the virtual server. When Vserver RHI Level (RHI) parameter is set to VSVR_CNTRLD, the following are different RHI behaviors for the VIP address on the basis of RHIstate (RHI STATE) settings on the virtual servers associated with the VIP address: * If you set RHI STATE to PASSIVE on all virtual servers, the NetScaler ADC always advertises the route for the VIP address. * If you set RHI STATE to ACTIVE on all virtual servers, the NetScaler ADC advertises the route for the VIP address if at least one of the associated virtual servers is in UP state. * If you set RHI STATE to ACTIVE on some and PASSIVE on others, the NetScaler ADC advertises the route for the VIP address if at least one of the associated virtual servers, whose RHI STATE set to ACTIVE, is in UP state. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        NewServiceRequest|double|Number of requests, or percentage of the load on existing services, by which to increase the load on a new service at each interval in slow-start mode. A non-zero value indicates that slow-start is applicable. A zero value indicates that the global RR startup parameter is applied. Changing the value to zero will cause services currently in slow start to take the full traffic as determined by the LB method. Subsequently, any new services added will use the global RR factor.
        NewServiceRequestUnit|string|Units in which to increment load at each interval in slow-start mode. Default value: PER_SECOND. Possible values = PER_SECOND, PERCENT
        NewServiceRequestIncrementInterval|double|Interval, in seconds, between successive increments in the load on a new service or a service whose state has just changed from DOWN to UP. A value of 0 (zero) specifies manual slow start. Default value: 0
        MinAutoScaleMembers|double|Minimum number of members expected to be present when vserver is used in Autoscale. Default value: 0
        MaxAutoScaleMembers|double|Maximum number of members expected to be present when vserver is used in Autoscale. Default value: 0
        PersistAvpno|double[ ]|Persist AVP number for Diameter Persistency. In case this AVP is not defined in Base RFC 3588 and it is nested inside a Grouped AVP, define a sequence of AVP numbers (max 3) in order of parent to child. So say persist AVP number X is nested inside AVP Y which is nested in Z, then define the list as Z Y X.
        SkipPersistency|string|This argument decides the behavior incase the service which is selected from an existing persistence session has reached threshold. Default value: None Possible values = Bypass, ReLb, None
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        AuthnProfile|string|Name of the authentication profile to be used when authentication is turned on.
        MacModerateInVlan|string|This option is used to retain vlan information of incoming packet when macmode is enabled. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Dbslb|string|Enable database specific load balancing for MySQL and MSSQL service types. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Dns64|string|This argument is for enabling/disabling the dns64 on lbvserver. Possible values = ENABLED, DISABLED
        Bypassaaaa|string|If this option is enabled while resolving DNS64 query AAAA queries are not sent to back end dns server. Default value: NO. Possible values = YES, NO
        RecursionAvailable|string|When set to YES, this option causes the DNS replies from this vserver to have the RA bit turned on. Typically one would set this option to YES, when the vserver is load balancing a set of DNS servers thatsupport recursive queries. Default value: NO. Possible values = YES, NO
        ProcessLocal|string|By turning on this option packets destined to a vserver in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DnsProfileName|string|Name of the DNS profile to be associated with the VServer. DNS profile properties will be applied to the transactions processed by a VServer. This parameter is valid only for DNS and DNS-TCP VServers.
        LbProfileName|string|Name of the LB profile which is associated to the vserver.
        RedirectFromPort|int|Port number for the virtual server, from which we absorb the traffic for http redirect. Minimum value = 1
        HttpsRedirectUrl|string|URL to which to redirect traffic if the traffic is recieved from redirect port.
        RetainConnectionsOnCluster|string|This option enables you to retain existing connections on a node joining a Cluster system or when a node is being configured for passive timeout. By default, this option is disabled. Default value: NO. Possible values = YES, NO

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<LbvserverAddCommand> (INitroServiceClient, new LbvserverAddRequestData(){ });
            ```

            Where LbvserverAddRequestData is one of:
            LbmonitorDnsAddRequestData, LbmonitorDnsTcpAddRequestData, LbmonitorHttpAddRequestData, LbmonitorSslAddRequestData, LbmonitorSslBridgeAddRequestData, LbmonitorSslTcpBridgeAddRequestData, LbmonitorSyslogTcpAddRequestData, LbmonitorSyslogUdpBridgeAddRequestData, LbmonitorTcpAddRequestData, LbmonitorUdpAddRequestData, 

    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for LbvserverAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get
    * Properties  

        The following properties van be found in each LbvserverConfiguration found in the array "Lbservers" inside of a LbvserverGetResponse.

        Property|DataType|Description
        ---|---|---
        Name|string|Name for the virtual server. 
        ServiceType|string|Protocol used by the service (also called the service type). Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, DNS, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, RTSP, PUSH, SSL_PUSH, RADIUS, RDP, MYSQL, MSSQL, DIAMETER, SSL_DIAMETER, TFTP, ORACLE, SMPP, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, PROXY, USER_TCP, USER_SSL_TCP, QUIC. Automatically assigned when choosing Data to use.
        IpVersion4Or6|string|IPv4 or IPv6 address to assign to the virtual server.
        IpPattern|string|IP address pattern, in dotted decimal notation, for identifying packets to be accepted by the virtual server. The IP Mask parameter specifies which part of the destination IP address is matched against the pattern. Mutually exclusive with the IP Address parameter. For example, if the IP pattern assigned to the virtual server is 198.51.100.0 and the IP mask is 255.255.240.0 (a forward mask), the first 20 bits in the destination IP addresses are matched with the first 20 bits in the pattern. The virtual server accepts requests with IP addresses that range from 198.51.96.1 to 198.51.111.254. You can also use a pattern such as 0.0.2.2 and a mask such as 0.0.255.255 (a reverse mask). If a destination IP address matches more than one IP pattern, the pattern with the longest match is selected, and the associated virtual server processes the request. For example, if virtual servers vs1 and vs2 have the same IP pattern, 0.0.100.128, but different IP masks of 0.0.255.255 and 0.0.224.255, a destination IP address of 198.51.100.128 has the longest match with the IP pattern of vs1. If a destination IP address matches two or more virtual servers to the same extent, the request is processed by the virtual server whose port number matches the port number in the request.
        IpMask|string|IP mask, in dotted decimal notation, for the IP Pattern parameter. Can have leading or trailing non-zero octets (for example, 255.255.240.0 or 0.0.255.255). Accordingly, the mask specifies whether the first n bits or the last n bits of the destination IP address in a client request are to be matched with the corresponding bits in the IP pattern. The former is called a forward mask. The latter is called a reverse mask.
        Port|int|Port number for the virtual server.
        Range|double|Number of IP addresses that the appliance must generate and assign to the virtual server. The virtual server then functions as a network virtual server, accepting traffic on any of the generated IP addresses. The IP addresses are generated automatically, as follows: * For a range of n, the last octet of the address specified by the IP Address parameter increments n-1 times. * If the last octet exceeds 255, it rolls over to 0 and the third octet increments by 1.Note: The Range parameter assigns multiple IP addresses to one virtual server. To generate an array of virtual servers, each of which owns only one IP address, use brackets in the IP Address and Name parameters to specify the range. For example: add lb vserver my_vserver[1-3] HTTP 192.0.2.[1-3] 80. Default value: 1
        PersistenceType|string|Type of persistence for the virtual server. Available settings function as follows: * SOURCEIP - Connections from the same client IP address belong to the same persistence session. * COOKIEINSERT - Connections that have the same HTTP Cookie, inserted by a Set-Cookie directive from a server, belong to the same persistence session. * SSLSESSION - Connections that have the same SSL Session ID belong to the same persistence session. * CUSTOMSERVERID - Connections with the same server ID form part of the same session. For this persistence type, set the Server ID (CustomServerID) parameter for each service and configure the Rule parameter to identify the server ID in a request. * RULE - All connections that match a user defined rule belong to the same persistence session. * URLPASSIVE - Requests that have the same server ID in the URL query belong to the same persistence session. The server ID is the hexadecimal representation of the IP address and port of the service to which the request must be forwarded. This persistence type requires a rule to identify the server ID in the request. * DESTIP - Connections to the same destination IP address belong to the same persistence session. * SRCIPDESTIP - Connections that have the same source IP address and destination IP address belong to the same persistence session. * CALLID - Connections that have the same CALL-ID SIP header belong to the same persistence session. * RTSPSID - Connections that have the same RTSP Session ID belong to the same persistence session. * FIXSESSION - Connections that have the same SenderCompID and TargetCompID values belong to the same persistence session. * USERSESSION - Persistence session is created based on the persistence parameter value provided from an extension. Possible values = SOURCEIP, COOKIEINSERT, SSLSESSION, RULE, URLPASSIVE, CUSTOMSERVERID, DESTIP, SRCIPDESTIP, CALLID, RTSPSID, DIAMETER, FIXSESSION, USERSESSION, NONE
        Timeout|double|Time period for which a persistence session is in effect.
        PersistenceBackup|string|Backup persistence type for the virtual server. Becomes operational if the primary persistence mechanism fails. Possible values = SOURCEIP, NONE
        BackupPersistenceTimeout|double|Time period for which backup persistence is in effect. Default value: 2
        LoqdBalancingMethod|string|Load balancing method. The available settings function as follows:        * ROUNDROBIN - Distribute requests in rotation, regardless of the load. Weights can be assigned to services to enforce weighted round robin distribution. * LEASTCONNECTION (default) - Select the service with the fewest connections. * LEASTRESPONSETIME - Select the service with the lowest average response time. * LEASTBANDWIDTH - Select the service currently handling the least traffic. * LEASTPACKETS - Select the service currently serving the lowest number of packets per second. * CUSTOMLOAD - Base service selection on the SNMP metrics obtained by custom load monitors. * LRTM - Select the service with the lowest response time. Response times are learned through monitoring probes. This method also takes the number of active connections into account. Also available are a number of hashing methods, in which the appliance extracts a predetermined portion of the request, creates a hash of the portion, and then checks whether any previous requests had the same hash value. If it finds a match, it forwards the request to the service that served those previous requests. Following are the hashing methods: * URLHASH - Create a hash of the request URL (or part of the URL). * DOMAINHASH - Create a hash of the domain name in the request (or part of the domain name). The domain name is taken from either the URL or the Host header. If the domain name appears in both locations, the URL is preferred. If the request does not contain a domain name, the load balancing method defaults to LEASTCONNECTION. * DESTINATIONIPHASH - Create a hash of the destination IP address in the IP header. * SOURCEIPHASH - Create a hash of the source IP address in the IP header. * TOKEN - Extract a token from the request, create a hash of the token, and then select the service to which any previous requests with the same token hash value were sent. * SRCIPDESTIPHASH - Create a hash of the string obtained by concatenating the source IP address and destination IP address in the IP header. * SRCIPSRCPORTHASH - Create a hash of the source IP address and source port in the IP header. * CALLIDHASH - Create a hash of the SIP Call-ID header. * USER_TOKEN - Same as TOKEN LB method but token needs to be provided from an extension. Default value: LEASTCONNECTION. Possible values = ROUNDROBIN, LEASTCONNECTION, LEASTRESPONSETIME, URLHASH, DOMAINHASH, DESTINATIONIPHASH, SOURCEIPHASH, SRCIPDESTIPHASH, LEASTBANDWIDTH, LEASTPACKETS, TOKEN, SRCIPSRCPORTHASH, LRTM, CALLIDHASH, CUSTOMLOAD, LEASTREQUEST, AUDITLOGHASH, STATICPROXIMITY, USER_TOKEN
        HashLenght|double|Number of bytes to consider for the hash value used in the URLHASH and DOMAINHASH load balancing methods. Default value: 80
        NetMask|string|IPv4 subnet mask to apply to the destination IP address or source IP address when the load balancing method is DESTINATIONIPHASH or SOURCEIPHASH.
        V6NetMaskLen|double|Number of bits to consider in an IPv6 destination or source IP address, for creating the hash that is required by the DESTINATIONIPHASH and SOURCEIPHASH load balancing methods. Default value: 128
        BackupLbMethod|string|Backup load balancing method. Becomes operational if the primary load balancing method fails or cannot be used. Valid only if the primary method is based on static proximity. Default value: ROUNDROBIN. Possible values = ROUNDROBIN, LEASTCONNECTION, LEASTRESPONSETIME, SOURCEIPHASH, LEASTBANDWIDTH, LEASTPACKETS, CUSTOMLOAD
        CookieName|string|Use this parameter to specify the cookie name for COOKIE peristence type. It specifies the name of cookie with a maximum of 32 characters. If not specified, cookie name is internally generated.
        TrafficRule|string|Expression, or name of a named expression, against which traffic is evaluated. Written in the classic or default syntax. Note: Maximum length of a string literal in the expression is 255 characters. A longer string can be split into smaller strings of up to 255 characters each, and the smaller strings concatenated with the + operator. For example, you can create a 500-character string as follows: '"<string of 255 characters>" + "<string of 245 characters>"' The following requirements apply only to the NetScaler CLI: * If the expression includes one or more spaces, enclose the entire expression in double quotation marks. * If the expression itself includes double quotation marks, escape the quotations by using the \ character. * Alternatively, you can use single quotation marks to enclose the rule, in which case you do not have to escape the double quotation marks. Default value: "none"
        ListenPolicy|string|Default syntax expression identifying traffic accepted by the virtual server. Can be either an expression (for example, CLIENT.IP.DST.IN_SUBNET(192.0.2.0/24) or the name of a named expression. In the above example, the virtual server accepts all requests whose destination IP address is in the 192.0.2.0/24 subnet. Default value: "NONE"
        ListenPriority|double|Integer specifying the priority of the listen policy. A higher number specifies a lower priority. If a request matches the listen policies of more than one virtual server the virtual server whose listen policy has the highest priority (the lowest priority number) accepts the request. Default value: 101
        ResponseRule|string|Default syntax expression specifying which part of a server's response to use for creating rule based persistence sessions (persistence type RULE). Can be either an expression or the name of a named expression. Example: HTTP.RES.HEADER("setcookie").VALUE(0).TYPECAST_NVLIST_T('=',';').VALUE("server1"). Default value: "none"
        PersistMask|string|Persistence mask for IP based persistence types, for IPv4 virtual servers.
        V6PersistMaskLen|double|Persistence mask for IP based persistence types, for IPv6 virtual servers. Default value: 128
        PriorityQueuing|string|Use priority queuing on the virtual server. based persistence types, for IPv6 virtual servers. Default value: OFF Possible values = ON, OFF
        SureConnect|string|Use SureConnect on the virtual server. Default value: OFF. Possible values = ON, OFF
        RtspNetworkAddressTranslation|string|Use network address translation (NAT) for RTSP data connections. Default value: OFF Possible values = ON, OFF
        LoadbalancingRedirectMode|string|Redirection mode for load balancing. Available settings function as follows: * IP - Before forwarding a request to a server, change the destination IP address to the server's IP address. * MAC - Before forwarding a request to a server, change the destination MAC address to the server's MAC address. The destination IP address is not changed. MAC-based redirection mode is used mostly in firewall load balancing deployments. * IPTUNNEL - Perform IP-in-IP encapsulation for client IP packets. In the outer IP headers, set the destination IP address to the IP address of the server and the source IP address to the subnet IP (SNIP). The client IP packets are not modified. Applicable to both IPv4 and IPv6 packets. * TOS - Encode the virtual server's TOS ID in the TOS field of the IP header. You can use either the IPTUNNEL or the TOS option to implement Direct Server Return (DSR). Default value: IP. Possible values = IP, MAC, IPTUNNEL, TOS
        TosId|double|TOS ID of the virtual server. Applicable only when the load balancing redirection mode is set to TOS.
        DataLenght|double|Length of the token to be extracted from the data segment of an incoming packet, for use in the token method of load balancing. The length of the token, specified in bytes, must not be greater than 24 KB. Applicable to virtual servers of type TCP.
        DataOffset|double|Offset to be considered when extracting a token from the TCP payload. Applicable to virtual servers, of type TCP, using the token method of load balancing. Must be within the first 24 KB of the TCP payload.
        Sessionless|string|Perform load balancing on a per-packet basis, without establishing sessions. Recommended for load balancing of intrusion detection system (IDS) servers and scenarios involving direct server return (DSR), where session information is unnecessary. Default value: DISABLED. Possible values = ENABLED, DISABLED
        TrofsPersistence|string|When value is ENABLED, Trofs persistence is honored. When value is DISABLED, Trofs persistence is not honored. Default value: ENABLED. Possible values = ENABLED, DISABLED
        State|string|State of the load balancing virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        ConnectionFailoverMode|string|Mode in which the connection failover feature must operate for the virtual server. After a failover, established TCP connections and UDP packet flows are kept active and resumed on the secondary appliance. Clients remain connected to the same servers. Available settings function as follows: * STATEFUL - The primary appliance shares state information with the secondary appliance, in real time, resulting in some runtime processing overhead. * STATELESS - State information is not shared, and the new primary appliance tries to re-create the packet flow on the basis of the information contained in the packets it receives. * DISABLED - Connection failover does not occur. Default value: DISABLED. Possible values = DISABLED, STATEFUL, STATELESS
        RedirectUrl|string|URL to which to redirect traffic if the virtual server becomes unavailable. WARNING! Make sure that the domain in the URL does not match the domain specified for a content switching policy. If it does, requests are continuously redirected to the unavailable virtual server.
        Cacheable|string|Route cacheable requests to a cache redirection virtual server. The load balancing virtual server can forward requests only to a transparent cache redirection virtual server that has an IP address and port combination of *:80, so such a cache redirection virtual server must be configured on the appliance. Default value: NO. Possible values = YES, NO
        ClientTimeout|double|Idle time, in seconds, after which a client connection is terminated.
        SpillOverMethod|string|Type of threshold that, when exceeded, triggers spillover. Available settings function as follows: * CONNECTION - Spillover occurs when the number of client connections exceeds the threshold. * DYNAMICCONNECTION - Spillover occurs when the number of client connections at the virtual server exceeds the sum of the maximum client (Max Clients) settings for bound services. Do not specify a spillover threshold for this setting, because the threshold is implied by the Max Clients settings of bound services. * BANDWIDTH - Spillover occurs when the bandwidth consumed by the virtual server's incoming and outgoing traffic exceeds the threshold. * HEALTH - Spillover occurs when the percentage of weights of the services that are UP drops below the threshold. For example, if services svc1, svc2, and svc3 are bound to a virtual server, with weights 1, 2, and 3, and the spillover threshold is 50%, spillover occurs if svc1 and svc3 or svc2 and svc3 transition to DOWN. * NONE - Spillover does not occur. Possible values = CONNECTION, DYNAMICCONNECTION, BANDWIDTH, HEALTH, NONE
        SpillOverPersistence|string|If spillover occurs, maintain source IP address based persistence for both primary and backup virtual servers. Default value: DISABLED. Possible values = ENABLED, DISABLED
        SpillOverPersistenceTimeout|double|Timeout for spillover persistence, in minutes. Default value: 2
        HealthThreshold|double|Threshold in percent of active services below which vserver state is made down. If this threshold is 0, vserver state will be up even if one bound service is up. Default value: 0
        SpillOverThreshold|double|Threshold at which spillover occurs. Specify an integer for the CONNECTION spillover method, a bandwidth value in kilobits per second for the BANDWIDTH method (do not enter the units), or a percentage for the HEALTH method (do not enter the percentage symbol).
        SpillOverBackupAction|string|Action to be performed if spillover is to take effect, but no backup chain to spillover is usable or exists. Possible values = DROP, ACCEPT, REDIRECT
        RedirectPortRewrite|string|Rewrite the port and change the protocol to ensure successful HTTP redirects from services. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with a virtual server whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        BackupVirtualServer|string|Name of the backup virtual server to which to forward requests if the primary virtual server goes DOWN or reaches its spillover threshold.
        DisablePrimaryOnDown|string|If the primary virtual server goes down, do not allow it to return to primary status until manually enabled. Default value: DISABLED. Possible values = ENABLED, DISABLED
        InsertVirtualServerIpPort|string|Insert an HTTP header, whose value is the IP address and port number of the virtual server, before forwarding a request to the server. The format of the header is <vipHeader>: <virtual server IP address>_<port number >, where vipHeader is the name that you specify for the header. If the virtual server has an IPv6 address, the address in the header is enclosed in brackets ([ and ]) to separate it from the port number. If you have mapped an IPv4 address to a virtual server's IPv6 address, the value of this parameter determines which IP address is inserted in the header, as follows: * VIPADDR - Insert the IP address of the virtual server in the HTTP header regardless of whether the virtual server has an IPv4 address or an IPv6 address. A mapped IPv4 address, if configured, is ignored. * V6TOV4MAPPING - Insert the IPv4 address that is mapped to the virtual server's IPv6 address. If a mapped IPv4 address is not configured, insert the IPv6 address. * OFF - Disable header insertion. Possible values = OFF, VIPADDR, V6TOV4MAPPING
        VipHeader|string|Name for the inserted header. The default name is vip-header.
        AuthenticationHost|string|Fully qualified domain name (FQDN) of the authentication virtual server to which the user must be redirected for authentication. Make sure that the Authentication parameter is set to ENABLED.
        Authentication|string|Enable or disable user authentication. Default value: OFF. Possible values = ON, OFF
        AuthenticationWith401|string|Enable or disable user authentication with HTTP 401 responses. Default value: OFF. Possible values = ON, OFF
        AuthnVirtualServerName|string|Name of an authentication virtual server with which to authenticate users.
        Push|string|Process traffic with the push virtual server that is bound to this load balancing virtual server. Default value: DISABLED. Possible values = ENABLED, DISABLED
        PushVirtualServer|string|Name of the load balancing virtual server, of type PUSH or SSL_PUSH, to which the server pushes updates received on the load balancing virtual server that you are configuring.
        PushLabelExpression|string|Expression for extracting a label from the server's response. Can be either an expression or the name of a named expression. Default value: "none"
        PushMultiClients|string|Allow multiple Web 2.0 connections from the same client to connect to the virtual server and expect updates. Default value: NO. Possible values = YES, NO
        TcpProfileName|string|Name of the TCP profile whose settings are to be applied to the virtual server.
        HttpProfileName|string|Name of the Http profile whose settings are to be applied to the virtual server.
        DbProfileName|string|Name of the DB profile whose settings are to be applied to the virtual server.
        Comment|string|Any comments that you might want to associate with the virtual server.
        UseLayer2Parameters|string|Use Layer 2 parameters (channel number, MAC address, and VLAN ID) in addition to the 4-tuple (<source IP>:<source port>::<destination IP>:<destination port>) that is used to identify a connection. Allows multiple TCP and non-TCP connections with the same 4-tuple to co-exist on the NetScaler appliance. Possible values = ON, OFF
        OracleServerVersion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        MsSqlServerVersion|string|For a load balancing virtual server of type MSSQL, the Microsoft SQL Server version. Set this parameter if you expect some clients to run a version different from the version of the database. This setting provides compatibility between the client-side and server-side connections by ensuring that all communication conforms to the server's version. Default value: 2008R2. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        MySqlProtocolVersion|double|MySQL protocol version that the virtual server advertises to clients.
        MySqlServerVersion|string|MySQL server version string that the virtual server advertises to clients.
        MySqlCharacterSet|double|Character set that the virtual server advertises to clients.
        MySqlServerCapabilities|double|Server capabilities that the virtual server advertises to clients.
        AppFlowLogging|string|Apply AppFlow logging to the virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetworkProfile|string|Name of the network profile to associate with the virtual server. If you set this parameter, the virtual server uses only the IP addresses in the network profile as source IP addresses when initiating connections with servers.
        PingRequestForCommonIpResponse|string|How the NetScaler appliance responds to ping requests received for an IP address that is common to one or more virtual servers. Available settings function as follows: * If set to PASSIVE on all the virtual servers that share the IP address, the appliance always responds to the ping requests. * If set to ACTIVE on all the virtual servers that share the IP address, the appliance responds to the ping requests if at least one of the virtual servers is UP. Otherwise, the appliance does not respond. * If set to ACTIVE on some virtual servers and PASSIVE on the others, the appliance responds if at least one virtual server with the ACTIVE setting is UP. Otherwise, the appliance does not respond. Note: This parameter is available at the virtual server level. A similar parameter, ICMP Response, is available at the IP address level, for IPv4 addresses of type VIP. To set that parameter, use the add ip command in the CLI or the Create IP dialog box in the GUI. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        RouteHealthInjectionState|string|Route Health Injection (RHI) functionality of the NetSaler appliance for advertising the route of the VIP address associated with the virtual server. When Vserver RHI Level (RHI) parameter is set to VSVR_CNTRLD, the following are different RHI behaviors for the VIP address on the basis of RHIstate (RHI STATE) settings on the virtual servers associated with the VIP address: * If you set RHI STATE to PASSIVE on all virtual servers, the NetScaler ADC always advertises the route for the VIP address. * If you set RHI STATE to ACTIVE on all virtual servers, the NetScaler ADC advertises the route for the VIP address if at least one of the associated virtual servers is in UP state. * If you set RHI STATE to ACTIVE on some and PASSIVE on others, the NetScaler ADC advertises the route for the VIP address if at least one of the associated virtual servers, whose RHI STATE set to ACTIVE, is in UP state. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        NewServiceRequest|double|Number of requests, or percentage of the load on existing services, by which to increase the load on a new service at each interval in slow-start mode. A non-zero value indicates that slow-start is applicable. A zero value indicates that the global RR startup parameter is applied. Changing the value to zero will cause services currently in slow start to take the full traffic as determined by the LB method. Subsequently, any new services added will use the global RR factor.
        NewServiceRequestUnit|string|Units in which to increment load at each interval in slow-start mode. Default value: PER_SECOND. Possible values = PER_SECOND, PERCENT
        NewServiceRequestIncrementInterval|double|Interval, in seconds, between successive increments in the load on a new service or a service whose state has just changed from DOWN to UP. A value of 0 (zero) specifies manual slow start. Default value: 0
        MinAutoScaleMembers|double|Minimum number of members expected to be present when vserver is used in Autoscale. Default value: 0
        MaxAutoScaleMembers|double|Maximum number of members expected to be present when vserver is used in Autoscale. Default value: 0
        PersistAvpNumber|double[ ]|Persist AVP number for Diameter Persistency. In case this AVP is not defined in Base RFC 3588 and it is nested inside a Grouped AVP, define a sequence of AVP numbers (max 3) in order of parent to child. So say persist AVP number X is nested inside AVP Y which is nested in Z, then define the list as Z Y X.
        SkipPersistency|string|This argument decides the behavior incase the service which is selected from an existing persistence session has reached threshold. Default value: None Possible values = Bypass, ReLb, None
        TrafficDomain|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        AuthenticationProfile|string|Name of the authentication profile to be used when authentication is turned on.
        MacModerateInVlan|string|This option is used to retain vlan information of incoming packet when macmode is enabled. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DatabaseSpecificLoadBalancing|string|Enable database specific load balancing for MySQL and MSSQL service types. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Dns64|string|This argument is for enabling/disabling the dns64 on lbvserver. Possible values = ENABLED, DISABLED
        Bypassaaaa|string|If this option is enabled while resolving DNS64 query AAAA queries are not sent to back end dns server. Default value: NO. Possible values = YES, NO
        RecursionAvailable|string|When set to YES, this option causes the DNS replies from this vserver to have the RA bit turned on. Typically one would set this option to YES, when the vserver is load balancing a set of DNS servers thatsupport recursive queries. Default value: NO. Possible values = YES, NO
        ProcessLocal|string|By turning on this option packets destined to a vserver in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DnsProfileName|string|Name of the DNS profile to be associated with the VServer. DNS profile properties will be applied to the transactions processed by a VServer. This parameter is valid only for DNS and DNS-TCP VServers.
        LoadBalancingProfileName|string|Name of the LB profile which is associated to the vserver.
        RedirectFromPort|int|Port number for the virtual server, from which we absorb the traffic for http redirect. Minimum value = 1
        HttpsRedirectUrl|string|URL to which to redirect traffic if the traffic is recieved from redirect port.
        RetainConnectionsOnCluster|string|This option enables you to retain existing connections on a node joining a Cluster system or when a node is being configured for passive timeout. By default, this option is disabled. Default value: NO. Possible values = YES, NO
        Weight|string|Weight to assign to the specified service.
        DynamicWeight|string|-
        ServiceName|string|Service to bind to the virtual server.
        RedirectUrlFlags|string|The redirect URL to be unset.
        ValueSslStatus|string|SSL status. Possible values = Certkey not bound, SSL feature disabled
        IpMapping|string|The permanent mapping for the V6 Address.
        NodeGroupName|string|Nodegroup name to which this lbvsever belongs to.
        Type|string|Type of LB vserver. Possible values = CONTENT, ADDRESS
        CurrentState|string|Current LB vserver state. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        EffectiveState|string|Effective state of the LB vserver , based on the state of backup vservers. Possible values = UP, DOWN, UNKNOWN, BUSY, OUT OF SERVICE, GOING OUT OF SERVICE, DOWN WHEN GOING OUT OF SERVICE, NS_EMPTY_STR, Unknown, DISABLED
        Status|string|Current status of the lb vserver. During the initial phase if the configured lb method is not round robin , the vserver will adopt round robin to distribute traffic for a predefined number of requests.
        LoadBalancerRoundRobinReason|string|Reason why a vserver is in RR. The following are the reasons: 1 - MEP is DOWN (GSLB) 2 - LB method has changed 3 - Bound service's state changed to UP 4 - A new service is bound 5 - Startup RR factor has changed 6 - LB feature is enabled 7 - Load monitor is not active on a service 8 - Vserver is Enabled 9 - SSL feature is Enabled 10 - All bound services have reached threshold. Using effective state to load balance (GSLB) 11 - Primary state of bound services are not UP. Using effective state to load balance (GSLB) 12 - No LB decision can be made as all bound services have either reached threshold or are not UP (GSLB) 13 - All load monitors are active
        CacheRedirectType|string|Cache redirect type. Possible values = CACHE, POLICY, ORIGIN
        Precedence|string|Precedence. Possible values = RULE, URL
        HomePage|string|Home page.
        DnsVserverName|string|DNS vserver name.
        Domain|string|Domain.
        PolicyName|string|Name of the policy bound to the LB vserver.
        CacheVServer|string|Cache virtual server.
        Health|string|Health of vserver based on percentage of weights of active svcs/all svcs. This does not consider administratively disabled svcs.
        GoToPriorityExpression|string|Expression specifying the priority of the next policy which will get evaluated if the current policy rule evaluates to TRUE.
        RuleType|string|Rule type.
        GroupName|string|LB group to which the lb vserver is to be bound.
        CookieDomain|string|Domain name to be used in the set cookie header in case of cookie persistence.
        Map|string|Map. Possible values = ON, OFF
        GreaterThan2Gb|string|Allow for greater than 2 GB transactions on this vserver. Default value: DISABLED Possible values = ENABLED, DISABLED
        ConsolidatedLeastConnection|string|Use consolidated stats for LeastConnection. Default value: GLOBAL Possible values = GLOBAL, NO, YES
        ConsolidatedLeastConnectionGlobal|string|Fetches Global setting. Possible values = YES, NO
        ThresholdValue|int|Tells whether threshold exceeded for this service participating in CUSTOMLB.
        BindPoint|string|The bindpoint to which the policy is bound. Possible values = REQUEST, RESPONSE
        Invoke|bool|Invoke policies bound to a virtual server or policy label.
        LabelType|string|The invocation type. Possible values = reqvserver, resvserver, policylabel
        LabelName|string|Name of the label invoked.
        CookieVersion|int|-
        TotalServices|string|Total number of services bound to the vserver.
        ActiveServices|string|Total number of active services bound to the vserver.
        StateChangeTimeSec|string|Time when last state change happened. Seconds part.
        StateChangeTimeSeconds|string|Time when last state change happened. Seconds part.
        StateChangeTimeMsec|string|Time when last state change happened. MilliSeconds part.
        TicksSinceLastStateChange|string|Time in 10 millisecond ticks since the last state change.
        IsGlobalLoadBalancingVirtualServer|bool|-
        VirtualServerDynamicConnectionSpillOverThreshold|string|Spillover threshold for dynamic connection.
        BackupVserverStatus|string|-
        CacheType|string|-
        Hits|string|-
        PiPolicyHits|string|-
        PolicySubType|string|-
        VsvrBindsvcIp|string|-
        VsvrBindsvcPort|int|-
        NoDefaultBindings|string|-
        Priority|string|-
        Count|int|Count Parameter.

    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LvserverGetCommand>(INitroServiceClient, New LbvserverGetRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object LbvserverGetRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all servers.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of a server, and the value you want to see in the returned servers.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only servers with "Hello" as their Comment will be returned. Not Defining this will return all servers.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the servers matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of servers that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverGet, that object is <u>LbvserverGetResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Lbvservers: an array of LbvserverConfiguration-objects returned by the Get-Request, all of which contain the properties mentioned above.

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LbvserverRemoveCommand>(INitroServiceClient, new LbvserverRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object LbvserverRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverRemove, that object is <u>NitroResponse</u>.

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
        Name|string|Name for the virtual server. 
        ServiceType|string|Protocol used by the service (also called the service type). Possible values = HTTP, FTP, TCP, UDP, SSL, SSL_BRIDGE, SSL_TCP, DTLS, NNTP, DNS, DHCPRA, ANY, SIP_UDP, SIP_TCP, SIP_SSL, DNS_TCP, RTSP, PUSH, SSL_PUSH, RADIUS, RDP, MYSQL, MSSQL, DIAMETER, SSL_DIAMETER, TFTP, ORACLE, SMPP, SYSLOGTCP, SYSLOGUDP, FIX, SSL_FIX, PROXY, USER_TCP, USER_SSL_TCP, QUIC. Automatically assigned when choosing Data to use.
        IpV46|string|IPv4 or IPv6 address to assign to the virtual server.
        IpPattern|string|IP address pattern, in dotted decimal notation, for identifying packets to be accepted by the virtual server. The IP Mask parameter specifies which part of the destination IP address is matched against the pattern. Mutually exclusive with the IP Address parameter. For example, if the IP pattern assigned to the virtual server is 198.51.100.0 and the IP mask is 255.255.240.0 (a forward mask), the first 20 bits in the destination IP addresses are matched with the first 20 bits in the pattern. The virtual server accepts requests with IP addresses that range from 198.51.96.1 to 198.51.111.254. You can also use a pattern such as 0.0.2.2 and a mask such as 0.0.255.255 (a reverse mask). If a destination IP address matches more than one IP pattern, the pattern with the longest match is selected, and the associated virtual server processes the request. For example, if virtual servers vs1 and vs2 have the same IP pattern, 0.0.100.128, but different IP masks of 0.0.255.255 and 0.0.224.255, a destination IP address of 198.51.100.128 has the longest match with the IP pattern of vs1. If a destination IP address matches two or more virtual servers to the same extent, the request is processed by the virtual server whose port number matches the port number in the request.
        IpMask|string|IP mask, in dotted decimal notation, for the IP Pattern parameter. Can have leading or trailing non-zero octets (for example, 255.255.240.0 or 0.0.255.255). Accordingly, the mask specifies whether the first n bits or the last n bits of the destination IP address in a client request are to be matched with the corresponding bits in the IP pattern. The former is called a forward mask. The latter is called a reverse mask.
        Port|int|Port number for the virtual server.
        Range|double|Number of IP addresses that the appliance must generate and assign to the virtual server. The virtual server then functions as a network virtual server, accepting traffic on any of the generated IP addresses. The IP addresses are generated automatically, as follows: * For a range of n, the last octet of the address specified by the IP Address parameter increments n-1 times. * If the last octet exceeds 255, it rolls over to 0 and the third octet increments by 1.Note: The Range parameter assigns multiple IP addresses to one virtual server. To generate an array of virtual servers, each of which owns only one IP address, use brackets in the IP Address and Name parameters to specify the range. For example: add lb vserver my_vserver[1-3] HTTP 192.0.2.[1-3] 80. Default value: 1
        PersistenceType|string|Type of persistence for the virtual server. Available settings function as follows: * SOURCEIP - Connections from the same client IP address belong to the same persistence session. * COOKIEINSERT - Connections that have the same HTTP Cookie, inserted by a Set-Cookie directive from a server, belong to the same persistence session. * SSLSESSION - Connections that have the same SSL Session ID belong to the same persistence session. * CUSTOMSERVERID - Connections with the same server ID form part of the same session. For this persistence type, set the Server ID (CustomServerID) parameter for each service and configure the Rule parameter to identify the server ID in a request. * RULE - All connections that match a user defined rule belong to the same persistence session. * URLPASSIVE - Requests that have the same server ID in the URL query belong to the same persistence session. The server ID is the hexadecimal representation of the IP address and port of the service to which the request must be forwarded. This persistence type requires a rule to identify the server ID in the request. * DESTIP - Connections to the same destination IP address belong to the same persistence session. * SRCIPDESTIP - Connections that have the same source IP address and destination IP address belong to the same persistence session. * CALLID - Connections that have the same CALL-ID SIP header belong to the same persistence session. * RTSPSID - Connections that have the same RTSP Session ID belong to the same persistence session. * FIXSESSION - Connections that have the same SenderCompID and TargetCompID values belong to the same persistence session. * USERSESSION - Persistence session is created based on the persistence parameter value provided from an extension. Possible values = SOURCEIP, COOKIEINSERT, SSLSESSION, RULE, URLPASSIVE, CUSTOMSERVERID, DESTIP, SRCIPDESTIP, CALLID, RTSPSID, DIAMETER, FIXSESSION, USERSESSION, NONE
        Timeout|double|Time period for which a persistence session is in effect.
        PersistenceBackup|string|Backup persistence type for the virtual server. Becomes operational if the primary persistence mechanism fails. Possible values = SOURCEIP, NONE
        BackupPersistenceTimeout|double|Time period for which backup persistence is in effect. Default value: 2
        LbMethod|string|Load balancing method. The available settings function as follows:        * ROUNDROBIN - Distribute requests in rotation, regardless of the load. Weights can be assigned to services to enforce weighted round robin distribution. * LEASTCONNECTION (default) - Select the service with the fewest connections. * LEASTRESPONSETIME - Select the service with the lowest average response time. * LEASTBANDWIDTH - Select the service currently handling the least traffic. * LEASTPACKETS - Select the service currently serving the lowest number of packets per second. * CUSTOMLOAD - Base service selection on the SNMP metrics obtained by custom load monitors. * LRTM - Select the service with the lowest response time. Response times are learned through monitoring probes. This method also takes the number of active connections into account. Also available are a number of hashing methods, in which the appliance extracts a predetermined portion of the request, creates a hash of the portion, and then checks whether any previous requests had the same hash value. If it finds a match, it forwards the request to the service that served those previous requests. Following are the hashing methods: * URLHASH - Create a hash of the request URL (or part of the URL). * DOMAINHASH - Create a hash of the domain name in the request (or part of the domain name). The domain name is taken from either the URL or the Host header. If the domain name appears in both locations, the URL is preferred. If the request does not contain a domain name, the load balancing method defaults to LEASTCONNECTION. * DESTINATIONIPHASH - Create a hash of the destination IP address in the IP header. * SOURCEIPHASH - Create a hash of the source IP address in the IP header. * TOKEN - Extract a token from the request, create a hash of the token, and then select the service to which any previous requests with the same token hash value were sent. * SRCIPDESTIPHASH - Create a hash of the string obtained by concatenating the source IP address and destination IP address in the IP header. * SRCIPSRCPORTHASH - Create a hash of the source IP address and source port in the IP header. * CALLIDHASH - Create a hash of the SIP Call-ID header. * USER_TOKEN - Same as TOKEN LB method but token needs to be provided from an extension. Default value: LEASTCONNECTION. Possible values = ROUNDROBIN, LEASTCONNECTION, LEASTRESPONSETIME, URLHASH, DOMAINHASH, DESTINATIONIPHASH, SOURCEIPHASH, SRCIPDESTIPHASH, LEASTBANDWIDTH, LEASTPACKETS, TOKEN, SRCIPSRCPORTHASH, LRTM, CALLIDHASH, CUSTOMLOAD, LEASTREQUEST, AUDITLOGHASH, STATICPROXIMITY, USER_TOKEN
        HashLenght|double|Number of bytes to consider for the hash value used in the URLHASH and DOMAINHASH load balancing methods. Default value: 80
        NetMask|string|IPv4 subnet mask to apply to the destination IP address or source IP address when the load balancing method is DESTINATIONIPHASH or SOURCEIPHASH.
        V6NetMaskLen|double|Number of bits to consider in an IPv6 destination or source IP address, for creating the hash that is required by the DESTINATIONIPHASH and SOURCEIPHASH load balancing methods. Default value: 128
        BackupLbMethod|string|Backup load balancing method. Becomes operational if the primary load balancing method fails or cannot be used. Valid only if the primary method is based on static proximity. Default value: ROUNDROBIN. Possible values = ROUNDROBIN, LEASTCONNECTION, LEASTRESPONSETIME, SOURCEIPHASH, LEASTBANDWIDTH, LEASTPACKETS, CUSTOMLOAD
        CookieName|string|Use this parameter to specify the cookie name for COOKIE peristence type. It specifies the name of cookie with a maximum of 32 characters. If not specified, cookie name is internally generated.
        Rule|string|Expression, or name of a named expression, against which traffic is evaluated. Written in the classic or default syntax. Note: Maximum length of a string literal in the expression is 255 characters. A longer string can be split into smaller strings of up to 255 characters each, and the smaller strings concatenated with the + operator. For example, you can create a 500-character string as follows: '"<string of 255 characters>" + "<string of 245 characters>"' The following requirements apply only to the NetScaler CLI: * If the expression includes one or more spaces, enclose the entire expression in double quotation marks. * If the expression itself includes double quotation marks, escape the quotations by using the \ character. * Alternatively, you can use single quotation marks to enclose the rule, in which case you do not have to escape the double quotation marks. Default value: "none"
        ListenPolicy|string|Default syntax expression identifying traffic accepted by the virtual server. Can be either an expression (for example, CLIENT.IP.DST.IN_SUBNET(192.0.2.0/24) or the name of a named expression. In the above example, the virtual server accepts all requests whose destination IP address is in the 192.0.2.0/24 subnet. Default value: "NONE"
        ListenPriority|double|Integer specifying the priority of the listen policy. A higher number specifies a lower priority. If a request matches the listen policies of more than one virtual server the virtual server whose listen policy has the highest priority (the lowest priority number) accepts the request. Default value: 101
        ResRule|string|Default syntax expression specifying which part of a server's response to use for creating rule based persistence sessions (persistence type RULE). Can be either an expression or the name of a named expression. Example: HTTP.RES.HEADER("setcookie").VALUE(0).TYPECAST_NVLIST_T('=',';').VALUE("server1"). Default value: "none"
        PersistMask|string|Persistence mask for IP based persistence types, for IPv4 virtual servers.
        V6PersistMaskLen|double|Persistence mask for IP based persistence types, for IPv6 virtual servers. Default value: 128
        Pq|string|Use priority queuing on the virtual server. based persistence types, for IPv6 virtual servers. Default value: OFF Possible values = ON, OFF
        Sc|string|Use SureConnect on the virtual server. Default value: OFF. Possible values = ON, OFF
        RtspNat|string|Use network address translation (NAT) for RTSP data connections. Default value: OFF Possible values = ON, OFF
        M|string|Redirection mode for load balancing. Available settings function as follows: * IP - Before forwarding a request to a server, change the destination IP address to the server's IP address. * MAC - Before forwarding a request to a server, change the destination MAC address to the server's MAC address. The destination IP address is not changed. MAC-based redirection mode is used mostly in firewall load balancing deployments. * IPTUNNEL - Perform IP-in-IP encapsulation for client IP packets. In the outer IP headers, set the destination IP address to the IP address of the server and the source IP address to the subnet IP (SNIP). The client IP packets are not modified. Applicable to both IPv4 and IPv6 packets. * TOS - Encode the virtual server's TOS ID in the TOS field of the IP header. You can use either the IPTUNNEL or the TOS option to implement Direct Server Return (DSR). Default value: IP. Possible values = IP, MAC, IPTUNNEL, TOS
        TosId|double|TOS ID of the virtual server. Applicable only when the load balancing redirection mode is set to TOS.
        DataLenght|double|Length of the token to be extracted from the data segment of an incoming packet, for use in the token method of load balancing. The length of the token, specified in bytes, must not be greater than 24 KB. Applicable to virtual servers of type TCP.
        DataOffset|double|Offset to be considered when extracting a token from the TCP payload. Applicable to virtual servers, of type TCP, using the token method of load balancing. Must be within the first 24 KB of the TCP payload.
        Sessionless|string|Perform load balancing on a per-packet basis, without establishing sessions. Recommended for load balancing of intrusion detection system (IDS) servers and scenarios involving direct server return (DSR), where session information is unnecessary. Default value: DISABLED. Possible values = ENABLED, DISABLED
        TrofsPersistence|string|When value is ENABLED, Trofs persistence is honored. When value is DISABLED, Trofs persistence is not honored. Default value: ENABLED. Possible values = ENABLED, DISABLED
        State|string|State of the load balancing virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        ConnFailover|string|Mode in which the connection failover feature must operate for the virtual server. After a failover, established TCP connections and UDP packet flows are kept active and resumed on the secondary appliance. Clients remain connected to the same servers. Available settings function as follows: * STATEFUL - The primary appliance shares state information with the secondary appliance, in real time, resulting in some runtime processing overhead. * STATELESS - State information is not shared, and the new primary appliance tries to re-create the packet flow on the basis of the information contained in the packets it receives. * DISABLED - Connection failover does not occur. Default value: DISABLED. Possible values = DISABLED, STATEFUL, STATELESS
        RedirUrl|string|URL to which to redirect traffic if the virtual server becomes unavailable. WARNING! Make sure that the domain in the URL does not match the domain specified for a content switching policy. If it does, requests are continuously redirected to the unavailable virtual server.
        Cacheable|string|Route cacheable requests to a cache redirection virtual server. The load balancing virtual server can forward requests only to a transparent cache redirection virtual server that has an IP address and port combination of *:80, so such a cache redirection virtual server must be configured on the appliance. Default value: NO. Possible values = YES, NO
        CltTimeout|double|Idle time, in seconds, after which a client connection is terminated.
        SoMethod|string|Type of threshold that, when exceeded, triggers spillover. Available settings function as follows: * CONNECTION - Spillover occurs when the number of client connections exceeds the threshold. * DYNAMICCONNECTION - Spillover occurs when the number of client connections at the virtual server exceeds the sum of the maximum client (Max Clients) settings for bound services. Do not specify a spillover threshold for this setting, because the threshold is implied by the Max Clients settings of bound services. * BANDWIDTH - Spillover occurs when the bandwidth consumed by the virtual server's incoming and outgoing traffic exceeds the threshold. * HEALTH - Spillover occurs when the percentage of weights of the services that are UP drops below the threshold. For example, if services svc1, svc2, and svc3 are bound to a virtual server, with weights 1, 2, and 3, and the spillover threshold is 50%, spillover occurs if svc1 and svc3 or svc2 and svc3 transition to DOWN. * NONE - Spillover does not occur. Possible values = CONNECTION, DYNAMICCONNECTION, BANDWIDTH, HEALTH, NONE
        SoPersistence|string|If spillover occurs, maintain source IP address based persistence for both primary and backup virtual servers. Default value: DISABLED. Possible values = ENABLED, DISABLED
        SoPersistenceTimeout|double|Timeout for spillover persistence, in minutes. Default value: 2
        HealthThreshold|double|Threshold in percent of active services below which vserver state is made down. If this threshold is 0, vserver state will be up even if one bound service is up. Default value: 0
        SoThreshold|double|Threshold at which spillover occurs. Specify an integer for the CONNECTION spillover method, a bandwidth value in kilobits per second for the BANDWIDTH method (do not enter the units), or a percentage for the HEALTH method (do not enter the percentage symbol).
        SoBackupAction|string|Action to be performed if spillover is to take effect, but no backup chain to spillover is usable or exists. Possible values = DROP, ACCEPT, REDIRECT
        RedirectPortRewrite|string|Rewrite the port and change the protocol to ensure successful HTTP redirects from services. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DownStateFlush|string|Flush all active transactions associated with a virtual server whose state transitions from UP to DOWN. Do not enable this option for applications that must complete their transactions. Default value: ENABLED. Possible values = ENABLED, DISABLED
        BackupVserver|string|Name of the backup virtual server to which to forward requests if the primary virtual server goes DOWN or reaches its spillover threshold.
        DisablePrimaryOnDown|string|If the primary virtual server goes down, do not allow it to return to primary status until manually enabled. Default value: DISABLED. Possible values = ENABLED, DISABLED
        InsertVserverIpPort|string|Insert an HTTP header, whose value is the IP address and port number of the virtual server, before forwarding a request to the server. The format of the header is <vipHeader>: <virtual server IP address>_<port number >, where vipHeader is the name that you specify for the header. If the virtual server has an IPv6 address, the address in the header is enclosed in brackets ([ and ]) to separate it from the port number. If you have mapped an IPv4 address to a virtual server's IPv6 address, the value of this parameter determines which IP address is inserted in the header, as follows: * VIPADDR - Insert the IP address of the virtual server in the HTTP header regardless of whether the virtual server has an IPv4 address or an IPv6 address. A mapped IPv4 address, if configured, is ignored. * V6TOV4MAPPING - Insert the IPv4 address that is mapped to the virtual server's IPv6 address. If a mapped IPv4 address is not configured, insert the IPv6 address. * OFF - Disable header insertion. Possible values = OFF, VIPADDR, V6TOV4MAPPING
        VipHeader|string|Name for the inserted header. The default name is vip-header.
        AuthenticationHost|string|Fully qualified domain name (FQDN) of the authentication virtual server to which the user must be redirected for authentication. Make sure that the Authentication parameter is set to ENABLED.
        Authentication|string|Enable or disable user authentication. Default value: OFF. Possible values = ON, OFF
        Authn401|string|Enable or disable user authentication with HTTP 401 responses. Default value: OFF. Possible values = ON, OFF
        AuthnVsName|string|Name of an authentication virtual server with which to authenticate users.
        Push|string|Process traffic with the push virtual server that is bound to this load balancing virtual server. Default value: DISABLED. Possible values = ENABLED, DISABLED
        PushVserver|string|Name of the load balancing virtual server, of type PUSH or SSL_PUSH, to which the server pushes updates received on the load balancing virtual server that you are configuring.
        PushLabel|string|Expression for extracting a label from the server's response. Can be either an expression or the name of a named expression. Default value: "none"
        PushMultiClients|string|Allow multiple Web 2.0 connections from the same client to connect to the virtual server and expect updates. Default value: NO. Possible values = YES, NO
        TcpProfileName|string|Name of the TCP profile whose settings are to be applied to the virtual server.
        HttpProfileName|string|Name of the Http profile whose settings are to be applied to the virtual server.
        DbProfileName|string|Name of the DB profile whose settings are to be applied to the virtual server.
        Comment|string|Any comments that you might want to associate with the virtual server.
        L2Conn|string|Use Layer 2 parameters (channel number, MAC address, and VLAN ID) in addition to the 4-tuple (<source IP>:<source port>::<destination IP>:<destination port>) that is used to identify a connection. Allows multiple TCP and non-TCP connections with the same 4-tuple to co-exist on the NetScaler appliance. Possible values = ON, OFF
        OracleServerVersion|string|Oracle server version. Default value: 10G. Possible values = 10G, 11G
        MsSqlServerVersion|string|For a load balancing virtual server of type MSSQL, the Microsoft SQL Server version. Set this parameter if you expect some clients to run a version different from the version of the database. This setting provides compatibility between the client-side and server-side connections by ensuring that all communication conforms to the server's version. Default value: 2008R2. Possible values = 70, 2000, 2000SP1, 2005, 2008, 2008R2, 2012, 2014
        MySqlProtocolVersion|double|MySQL protocol version that the virtual server advertises to clients.
        MySqlServerVersion|string|MySQL server version string that the virtual server advertises to clients.
        MySqlCharacterSet|double|Character set that the virtual server advertises to clients.
        MySqlServerCapabilities|double|Server capabilities that the virtual server advertises to clients.
        AppFlowLog|string|Apply AppFlow logging to the virtual server. Default value: ENABLED. Possible values = ENABLED, DISABLED
        NetProfile|string|Name of the network profile to associate with the virtual server. If you set this parameter, the virtual server uses only the IP addresses in the network profile as source IP addresses when initiating connections with servers.
        IcmpVsrResponse|string|How the NetScaler appliance responds to ping requests received for an IP address that is common to one or more virtual servers. Available settings function as follows: * If set to PASSIVE on all the virtual servers that share the IP address, the appliance always responds to the ping requests. * If set to ACTIVE on all the virtual servers that share the IP address, the appliance responds to the ping requests if at least one of the virtual servers is UP. Otherwise, the appliance does not respond. * If set to ACTIVE on some virtual servers and PASSIVE on the others, the appliance responds if at least one virtual server with the ACTIVE setting is UP. Otherwise, the appliance does not respond. Note: This parameter is available at the virtual server level. A similar parameter, ICMP Response, is available at the IP address level, for IPv4 addresses of type VIP. To set that parameter, use the add ip command in the CLI or the Create IP dialog box in the GUI. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        RhiState|string|Route Health Injection (RHI) functionality of the NetSaler appliance for advertising the route of the VIP address associated with the virtual server. When Vserver RHI Level (RHI) parameter is set to VSVR_CNTRLD, the following are different RHI behaviors for the VIP address on the basis of RHIstate (RHI STATE) settings on the virtual servers associated with the VIP address: * If you set RHI STATE to PASSIVE on all virtual servers, the NetScaler ADC always advertises the route for the VIP address. * If you set RHI STATE to ACTIVE on all virtual servers, the NetScaler ADC advertises the route for the VIP address if at least one of the associated virtual servers is in UP state. * If you set RHI STATE to ACTIVE on some and PASSIVE on others, the NetScaler ADC advertises the route for the VIP address if at least one of the associated virtual servers, whose RHI STATE set to ACTIVE, is in UP state. Default value: PASSIVE. Possible values = PASSIVE, ACTIVE
        NewServiceRequest|double|Number of requests, or percentage of the load on existing services, by which to increase the load on a new service at each interval in slow-start mode. A non-zero value indicates that slow-start is applicable. A zero value indicates that the global RR startup parameter is applied. Changing the value to zero will cause services currently in slow start to take the full traffic as determined by the LB method. Subsequently, any new services added will use the global RR factor.
        NewServiceRequestUnit|string|Units in which to increment load at each interval in slow-start mode. Default value: PER_SECOND. Possible values = PER_SECOND, PERCENT
        NewServiceRequestIncrementInterval|double|Interval, in seconds, between successive increments in the load on a new service or a service whose state has just changed from DOWN to UP. A value of 0 (zero) specifies manual slow start. Default value: 0
        MinAutoScaleMembers|double|Minimum number of members expected to be present when vserver is used in Autoscale. Default value: 0
        MaxAutoScaleMembers|double|Maximum number of members expected to be present when vserver is used in Autoscale. Default value: 0
        PersistAvpno|double[ ]|Persist AVP number for Diameter Persistency. In case this AVP is not defined in Base RFC 3588 and it is nested inside a Grouped AVP, define a sequence of AVP numbers (max 3) in order of parent to child. So say persist AVP number X is nested inside AVP Y which is nested in Z, then define the list as Z Y X.
        SkipPersistency|string|This argument decides the behavior incase the service which is selected from an existing persistence session has reached threshold. Default value: None Possible values = Bypass, ReLb, None
        Td|double|Integer value that uniquely identifies the traffic domain in which you want to configure the entity. If you do not specify an ID, the entity becomes part of the default traffic domain, which has an ID of 0.
        AuthnProfile|string|Name of the authentication profile to be used when authentication is turned on.
        MacModerateInVlan|string|This option is used to retain vlan information of incoming packet when macmode is enabled. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Dbslb|string|Enable database specific load balancing for MySQL and MSSQL service types. Default value: DISABLED. Possible values = ENABLED, DISABLED
        Dns64|string|This argument is for enabling/disabling the dns64 on lbvserver. Possible values = ENABLED, DISABLED
        Bypassaaaa|string|If this option is enabled while resolving DNS64 query AAAA queries are not sent to back end dns server. Default value: NO. Possible values = YES, NO
        RecursionAvailable|string|When set to YES, this option causes the DNS replies from this vserver to have the RA bit turned on. Typically one would set this option to YES, when the vserver is load balancing a set of DNS servers thatsupport recursive queries. Default value: NO. Possible values = YES, NO
        ProcessLocal|string|By turning on this option packets destined to a vserver in a cluster will not under go any steering. Turn this option for single packet request response mode or when the upstream device is performing a proper RSS for connection based distribution. Default value: DISABLED. Possible values = ENABLED, DISABLED
        DnsProfileName|string|Name of the DNS profile to be associated with the VServer. DNS profile properties will be applied to the transactions processed by a VServer. This parameter is valid only for DNS and DNS-TCP VServers.
        LbProfileName|string|Name of the LB profile which is associated to the vserver.
        RedirectFromPort|int|Port number for the virtual server, from which we absorb the traffic for http redirect. Minimum value = 1
        HttpsRedirectUrl|string|URL to which to redirect traffic if the traffic is recieved from redirect port.
        RetainConnectionsOnCluster|string|This option enables you to retain existing connections on a node joining a Cluster system or when a node is being configured for passive timeout. By default, this option is disabled. Default value: NO. Possible values = YES, NO


   * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (LbvserverUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<LbvserverUpdateCommand> (INitroServiceClient, new LbvserverUpdateRequestData(){ });
            ```

            Where LbvserverUpdateRequestData is one of:
            - LbvserverDnsUpdateRequestData, LbvserverDnsTcpUpdateRequestData, LbvserverHttpUpdateRequestData, LbvserverSslBridgeUpdateRequestData, LbvserverSslUpdateRequestData, LbvserverSslTcpUpdateRequestData, LbvserverSslSyslogTcpUpdateRequestData, LbvserverSyslogUdpBridgeUpdateRequestData, LbvserverTcpUpdateRequestData, LbvserverUdpUpdateRequestData

   * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


#### LbvserverBinding

##### Lbvserver_Service_binding

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|Name of the Lbvserver.
        ServiceName|string|Name of the service to bind.
        Weight|double|Weight to assign to the specified service.
        ServicegroupName|string|name of the Servicegroup

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<LbvserverBindingAddServiceCommand> (INitroServiceClient, new LbvserverBindingAddServiceRequestData(){ });
            ```


    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for LbvserverBindingAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get - NYI

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LbvserverBindingRemoveserviceCommand>(INitroServiceClient, new LbvserverBindingRemoveServiceRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object LbvserverBindingRemoveServiceRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverBindingRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  
  

+ Update: NYI

##### Lbvserver_Servicegroup_binding

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|Name of the Lbvserver.
        ServiceName|string|Name of the service to bind.
        Weight|double|Weight to assign to the specified service.
        ServicegroupName|string|name of the Servicegroup

    * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<LbvserverBindingAddServicegroupCommand> (INitroServiceClient, new LbvserverBindingAddServicegroupRequestData(){ });
            ```


    
   * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for LbvserverBindingAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get - NYI

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<LbvserverBindingRemoveServicegroupCommand>(INitroServiceClient, new LbvserverBindingRemoveServicegroupRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object LbvserverBindingRemoveServicegroupRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverBindingRemove, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful  
  

+ Update: NYI