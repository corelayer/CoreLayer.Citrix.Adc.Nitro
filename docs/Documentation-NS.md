### NS

#### NsHttpProfile

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|Name of the profile.
        DropInvalReqs|string|Drop invalid HTTP requests or responses. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkHttp09Inval|string|Mark HTTP/0.9 requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkConnReqInval|string|Mark CONNECT requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        CmpOnPush|string|Start data compression on receiving a TCP packet with PUSH flag set.Default value: DISABLED Possible values = ENABLED, DISABLED 
        ConMultiplex|string|Reuse server connections for requests from more than one client connections. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        MaxReusePool|double|Maximum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. If non-zero value is given, it has to be greater than or equal to the number of running Packet Engines. 
        DropExtraCrlf|string|Drop any extra 'CR' and 'LF' characters present after the header. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        IncomphdrDelay|double|Maximum time to wait, in milliseconds, between incomplete header packets. If the header packets take longer to arrive at Citrix ADC, the connection is silently dropped. Default value: 7000 
        WebSocket|string|HTTP connection to be upgraded to a web socket connection. Once upgraded, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED.Possible values = ENABLED, DISABLED 
        RtspTunnel|string|Allow RTSP tunnel in HTTP. Once application/x-rtsp-tunnelled is seen in Accept or Content-Type header, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReqTimeout|double|Time, in seconds, within which the HTTP request must complete. If the request does not complete within this time, the specified request timeout action is executed. Zero disables the timeout. 
        AdptTimeoout|string|Adapts the configured request timeout based on flow conditions. The timeout is increased or decreased internally and applied on the flow. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReqTimeoutAction|string|Action to take when the HTTP request does not complete within the specified request timeout duration. You can configure the following actions: * RESET - Send RST (reset) to client when timeout occurs. * DROP - Drop silently when timeout occurs. * Custom responder action - Name of the responder action to trigger when timeout occurs, used to send custom message. 
        DropExtraData|string|Drop any extra data when server sends more data than the specified content-length. Default value: DISABLED Possible values = ENABLED, DISABLED 
        WebLog|string|Enable or disable web logging. Default value: ENABLED Possible values = ENABLED, DISABLED 
        ClientIpHdrExpr|string|Name of the header that contains the real client IP address. 
        MaxReq|double|Maximum number of requests allowed on a single connection. Zero implies no limit on the number of requests. Default value: 0 
        PersistentEtag|string|Generate the persistent Citrix ADC specific ETag for the HTTP response with ETag header. Default value: DISABLED Possible values = ENABLED, DISABLED 
        Spdy|string|Enable SPDYv2 or SPDYv3 or both over SSL vserver. SSL will advertise SPDY support either during NPN Handshake or when client will advertises SPDY support during ALPN handshake. Both SPDY versions are enabled when this parameter is set to ENABLED. Default value: DISABLED Possible values = DISABLED, ENABLED, V2, V3 
        Http2|string|Choose whether to enable support for HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        Http2Direct|string|Choose whether to enable support for Direct HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AltSvc|string|Choose whether to enable support for Alternative Service. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReusePoolTimeout|double|Idle timeout (in seconds) for server connections in re-use pool. Connections in the re-use pool are flushed, if they remain idle for the configured timeout. Default value: 0 
        MaxHeaderLen|double|Number of bytes to be queued to look for complete header before returning error. If complete header is not obtained after queuing these many bytes, request will be marked as invalid and no L7 processing will be done for that TCP connection. 
        MinReusePool|double|Minimum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. 
        Http2MaxHeaderListSize|double|Maximum size of header list that the Citrix ADC is prepared to accept, in bytes. NOTE: The actual plain text header size that the Citrix ADC accepts is limited by maxHeaderLen. Please change maxHeaderLen parameter as well when modifying http2MaxHeaderListSize. 
        Http2MaxFrameSize|double|Maximum size of the frame payload that the Citrix ADC is willing to receive, in bytes. 
        Http2MaxConcurrentStreams|double|Maximum number of concurrent streams that is allowed per connection. 
        Http2InitialWindowSize|double|Initial window size for stream level flow control, in bytes.
        Http2HeaderTableSize|double|Maximum size of the header compression table used to decode header blocks, in bytes. 
        Http2MinSeverConn|double|Minimum number of HTTP2 connections established to backend server, on receiving HTTP requests from client before multiplexing the streams into the available HTTP/2 connections. 
        ApdexcltRespTimeThreshold|double|This option sets the satisfactory threshold (T) for server response time in milliseconds to be used for APDEX calculations. This means a transaction responding in less than this threshold is considered satisfactory. Transaction responding between T and 4*T is considered tolerable. Any transaction responding in more than 4*T time is considered frustrating. Citrix ADC maintains stats for such tolerable and frustrating transcations. Server Response time related apdex counters are only updated on backend services or a backend vserver which is not accepting client traffic. 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<NsHttpProfileAddCommand> (INitroServiceClient, new NsHttpProfileAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for NsHttpProfileAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get  -NsHttpProfileGetResponse NYI
    * Properties  

        The following properties van be found in each NsHttpProfileConfiguration found in the array "NsHttpProfiles" inside of a NsHttpProfileGetResponse.

        Property|DataType|Description
        ---|---|---

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsHttpProfileRemoveCommand>(INitroServiceClient, new NsHttpProfileRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object NsHttpProfileRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsHttpProfileRemove, that object is <u>NitroResponse</u>.

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
        Name|string|Name of the profile.
        DropInvalReqs|string|Drop invalid HTTP requests or responses. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkHttp09Inval|string|Mark HTTP/0.9 requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkConnReqInval|string|Mark CONNECT requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        CmpOnPush|string|Start data compression on receiving a TCP packet with PUSH flag set.Default value: DISABLED Possible values = ENABLED, DISABLED 
        ConMultiplex|string|Reuse server connections for requests from more than one client connections. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        MaxReusePool|double|Maximum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. If non-zero value is given, it has to be greater than or equal to the number of running Packet Engines. 
        DropExtraCrlf|string|Drop any extra 'CR' and 'LF' characters present after the header. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        IncomphdrDelay|double|Maximum time to wait, in milliseconds, between incomplete header packets. If the header packets take longer to arrive at Citrix ADC, the connection is silently dropped. Default value: 7000 
        WebSocket|string|HTTP connection to be upgraded to a web socket connection. Once upgraded, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED.Possible values = ENABLED, DISABLED 
        RtspTunnel|string|Allow RTSP tunnel in HTTP. Once application/x-rtsp-tunnelled is seen in Accept or Content-Type header, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReqTimeout|double|Time, in seconds, within which the HTTP request must complete. If the request does not complete within this time, the specified request timeout action is executed. Zero disables the timeout. 
        AdptTimeoout|string|Adapts the configured request timeout based on flow conditions. The timeout is increased or decreased internally and applied on the flow. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReqTimeoutAction|string|Action to take when the HTTP request does not complete within the specified request timeout duration. You can configure the following actions: * RESET - Send RST (reset) to client when timeout occurs. * DROP - Drop silently when timeout occurs. * Custom responder action - Name of the responder action to trigger when timeout occurs, used to send custom message. 
        DropExtraData|string|Drop any extra data when server sends more data than the specified content-length. Default value: DISABLED Possible values = ENABLED, DISABLED 
        WebLog|string|Enable or disable web logging. Default value: ENABLED Possible values = ENABLED, DISABLED 
        ClientIpHdrExpr|string|Name of the header that contains the real client IP address. 
        MaxReq|double|Maximum number of requests allowed on a single connection. Zero implies no limit on the number of requests. Default value: 0 
        PersistentEtag|string|Generate the persistent Citrix ADC specific ETag for the HTTP response with ETag header. Default value: DISABLED Possible values = ENABLED, DISABLED 
        Spdy|string|Enable SPDYv2 or SPDYv3 or both over SSL vserver. SSL will advertise SPDY support either during NPN Handshake or when client will advertises SPDY support during ALPN handshake. Both SPDY versions are enabled when this parameter is set to ENABLED. Default value: DISABLED Possible values = DISABLED, ENABLED, V2, V3 
        Http2|string|Choose whether to enable support for HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        Http2Direct|string|Choose whether to enable support for Direct HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AltSvc|string|Choose whether to enable support for Alternative Service. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReusePoolTimeout|double|Idle timeout (in seconds) for server connections in re-use pool. Connections in the re-use pool are flushed, if they remain idle for the configured timeout. Default value: 0 
        MaxHeaderLen|double|Number of bytes to be queued to look for complete header before returning error. If complete header is not obtained after queuing these many bytes, request will be marked as invalid and no L7 processing will be done for that TCP connection. 
        MinReusePool|double|Minimum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. 
        Http2MaxHeaderListSize|double|Maximum size of header list that the Citrix ADC is prepared to accept, in bytes. NOTE: The actual plain text header size that the Citrix ADC accepts is limited by maxHeaderLen. Please change maxHeaderLen parameter as well when modifying http2MaxHeaderListSize. 
        Http2MaxFrameSize|double|Maximum size of the frame payload that the Citrix ADC is willing to receive, in bytes. 
        Http2MaxConcurrentStreams|double|Maximum number of concurrent streams that is allowed per connection. 
        Http2InitialWindowSize|double|Initial window size for stream level flow control, in bytes.
        Http2HeaderTableSize|double|Maximum size of the header compression table used to decode header blocks, in bytes. 
        Http2MinSeverConn|double|Minimum number of HTTP2 connections established to backend server, on receiving HTTP requests from client before multiplexing the streams into the available HTTP/2 connections. 
        ApdexcltRespTimeThreshold|double|This option sets the satisfactory threshold (T) for server response time in milliseconds to be used for APDEX calculations. This means a transaction responding in less than this threshold is considered satisfactory. Transaction responding between T and 4*T is considered tolerable. Any transaction responding in more than 4*T time is considered frustrating. Citrix ADC maintains stats for such tolerable and frustrating transcations. Server Response time related apdex counters are only updated on backend services or a backend vserver which is not accepting client traffic. 

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (NsHttpProfileUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<NsHttpProfileUpdateCommand> (INitroServiceClient, new NsHttpProfileUpdateRequestData(){ });
            ```


    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsHttpProfileUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


#### NsTcpProfile


Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   | DataType |  Description 
        ---|---|---
        Name|string|Name of the profile.
        Ws|string|Enable or disable window scaling. Default value: DISABLED Possible values = ENABLED, DISABLED  
        Sack|string|Enable or disable Selective ACKnowledgement (SACK). Default value: DISABLED Possible values = ENABLED, DISABLED 
        WsVal|double|Factor used to calculate the new window size. This argument is needed only when window scaling is enabled. Default value: 4 
        Nagle|string|Enable or disable the Nagle algorithm on TCP connections. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AckOnPush|string|Send immediate positive acknowledgement (ACK) on receipt of TCP packets with PUSH flag. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Mss|double|Maximum number of octets to allow in a TCP data segment. 
        MaxBurst|double|Maximum number of TCP segments allowed in a burst. 
        InitialCwnd|double|Initial maximum upper limit on the number of TCP packets that can be outstanding on the TCP link to the server. 
        DelayEdAck|double|Timeout for TCP delayed ACK, in milliseconds. 
        OooQSize|double|Maximum size of out-of-order packets queue. A value of 0 means no limit. 
        MaxPktPermss|double|Maximum number of TCP packets allowed per maximum segment size (MSS). 
        PktPerretx|double|Maximum limit on the number of packets that should be retransmitted on receiving a partial ACK. 
        MinRto|double|Minimum retransmission timeout, in milliseconds, specified in 10-millisecond increments (value must yield a whole number if divided by 10). 
        SlowStartIncr|double|Multiplier that determines the rate at which slow start increases the size of the TCP transmission window after each acknowledgement of successful transmission. 
        Buffersize|double|TCP buffering size, in bytes. 
        SynCookie|string|Enable or disable the SYNCOOKIE mechanism for TCP handshake with clients. Disabling SYNCOOKIE prevents SYN attack protection on the Citrix ADC. 
        KaProbeUpdateLastActivity|string|Update last activity for the connection after receiving keep-alive (KA) probes. 
        Flavor|string|Set TCP congestion control algorithm. Default value: Default. Possible values = Default, Westwood, BIC, CUBIC, Nile 
        DynamicReceiveBuffering|string|Enable or disable dynamic receive buffering. When enabled, allows the receive buffer to be adjusted dynamically based on memory and network conditions. 
        Ka|string|Send periodic TCP keep-alive (KA) probes to check if peer is still up. 
        KaConnIdleTime|double|Duration, in seconds, for the connection to be idle, before sending a keep-alive (KA) probe. 
        KaMaxProbes|double|Number of keep-alive (KA) probes to be sent when not acknowledged, before assuming the peer to be down. 
        KaProbeInterval|double|Time interval, in seconds, before the next keep-alive (KA) probe, if the peer does not respond. 
        SendBuffSize|double|TCP Send Buffer Size. 
        MpTcp|string|Enable or disable Multipath TCP. 
        EstablishClientConn|string|Establishing Client Client connection on First data/ Final-ACK / Automatic. Default value: AUTOMATIC. Possible values = AUTOMATIC, CONN_ESTABLISHED, ON_FIRST_DATA 
        TcpSegOffload|string|Offload TCP segmentation to the NIC. If set to AUTOMATIC, TCP segmentation will be offloaded to the NIC, if the NIC supports it. 
        RstWindowAttenuate|string|Enable or disable RST window attenuation to protect against spoofing. When enabled, will reply with corrective ACK when a sequence number is invalid.
        RstMaxAck|string|Enable or disable acceptance of RST that is out of window yet echoes highest ACK sequence number. Useful only in proxy mode. 
        SpoofSynDrop|string|Enable or disable drop of invalid SYN packets to protect against spoofing. When disabled, established connections will be reset when a SYN packet is received. 
        Ecn|string|Enable or disable TCP Explicit Congestion Notification. 
        MpTcpDropDataOnPreestsf|string|Enable or disable silently dropping the data on Pre-Established subflow. When enabled, DSS data packets are dropped silently instead of dropping the connection when data is received on pre established subflow. 
        MpTcpFastOpen|string|Enable or disable Multipath TCP fastopen. When enabled, DSS data packets are accepted before receiving the third ack of SYN handshake. 
        MpTcpSessionTimeout|double|MPTCP session timeout in seconds. If this value is not set, idle MPTCP sessions are flushed after vserver's client idle timeout. 
        TimeStamp|string|Enable or Disable TCP Timestamp option (RFC 1323). 
        DSack|string|Enable or disable DSACK. 
        AckAggregation|string|Enable or disable ACK Aggregation. 
        Frto|string|Enable or disable FRTO (Forward RTO-Recovery). 
        MaxCwnd|double|TCP Maximum Congestion Window. 
        FAck|string|Enable or disable FACK (Forward ACK). 
        TcpMode|string|TCP Optimization modes TRANSPARENT / ENDPOINT. Default value: TRANSPARENT Possible values = TRANSPARENT, ENDPOINT 
        TcpFastOpen|string|Enable or disable TCP Fastopen. When enabled, NS can receive or send Data in SYN or SYN-ACK packets. 
        HyStart|string|Enable or disable CUBIC Hystart. 
        DupAckThresh|double|TCP dupack threshold. 
        BurstRateControl|string|TCP Burst Rate Control DISABLED/FIXED/DYNAMIC. FIXED requires a TCP rate to be set. Default value: DISABLED. Possible values = DISABLED, FIXED, DYNAMIC 
        TcpRate|double|TCP connection payload send rate in Kb/s. 
        RateQMax|double|Maximum connection queue size in bytes, when BurstRateControl is used. 
        DropHalfClosedConnOnTimeout|string|Silently drop tcp half closed connections on idle timeout. 
        DropEstConnOnTimeout|string|Silently drop tcp established connections on idle timeout. 
        ApplyAdaptiveTcp|string|Apply Adaptive TCP optimizations. 
        TcpFastOpenCookieSize|double|TCP FastOpen Cookie size. This accepts only even numbers. Odd number is trimmed down to nearest even number. 


   * Creation of the command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to add.

        - with Data
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page.

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<NsTcpProfileAddCommand> (INitroServiceClient, new NsTcpProfileAddRequestData(){ });
            ```

    
    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For commands for NsTcpProfileAdd, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse();  
        ```

        <u>Reponse</u> will now have its property <u>StatusCode</u> filled with information about the request. Status Code on Success: 201 Created, Status Code on Failure: 4xx (for general HTTP errors) or 5xx (for NetScaler-specific errors).
    
+ Get  -NsTcpProfileGetResponse NYI
    * Properties  

        The following properties van be found in each NsTcpProfileConfiguration found in the array "NsTcpProfiles" inside of a NsTcpProfileGetResponse.

        Property|DataType|Description
        ---|---|---

+ Remove: 
    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<NsTcpProfileRemoveCommand>(INitroServiceClient, new NsTcpProfileRemoveRequestOptions(){ });
        ```
        - Options:  
        For this command, the Options are gathered in an Object NsHttpProfileRemoveRequestOptions, which has following properties to be used as filters:
        <u>ResourceName</u>: The name of the object you wish to remove.  
    
    * Usage of the Command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsTcpProfileRemove, that object is <u>NitroResponse</u>.

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
        Name|string|Name of the profile.
        Ws|string|Enable or disable window scaling. Default value: DISABLED Possible values = ENABLED, DISABLED  
        Sack|string|Enable or disable Selective ACKnowledgement (SACK). Default value: DISABLED Possible values = ENABLED, DISABLED 
        WsVal|double|Factor used to calculate the new window size. This argument is needed only when window scaling is enabled. Default value: 4 
        Nagle|string|Enable or disable the Nagle algorithm on TCP connections. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AckOnPush|string|Send immediate positive acknowledgement (ACK) on receipt of TCP packets with PUSH flag. Default value: ENABLED Possible values = ENABLED, DISABLED 
        Mss|double|Maximum number of octets to allow in a TCP data segment. 
        MaxBurst|double|Maximum number of TCP segments allowed in a burst. 
        InitialCwnd|double|Initial maximum upper limit on the number of TCP packets that can be outstanding on the TCP link to the server. 
        DelayEdAck|double|Timeout for TCP delayed ACK, in milliseconds. 
        OooQSize|double|Maximum size of out-of-order packets queue. A value of 0 means no limit. 
        MaxPktPermss|double|Maximum number of TCP packets allowed per maximum segment size (MSS). 
        PktPerretx|double|Maximum limit on the number of packets that should be retransmitted on receiving a partial ACK. 
        MinRto|double|Minimum retransmission timeout, in milliseconds, specified in 10-millisecond increments (value must yield a whole number if divided by 10). 
        SlowStartIncr|double|Multiplier that determines the rate at which slow start increases the size of the TCP transmission window after each acknowledgement of successful transmission. 
        Buffersize|double|TCP buffering size, in bytes. 
        SynCookie|string|Enable or disable the SYNCOOKIE mechanism for TCP handshake with clients. Disabling SYNCOOKIE prevents SYN attack protection on the Citrix ADC. 
        KaProbeUpdateLastActivity|string|Update last activity for the connection after receiving keep-alive (KA) probes. 
        Flavor|string|Set TCP congestion control algorithm. Default value: Default. Possible values = Default, Westwood, BIC, CUBIC, Nile 
        DynamicReceiveBuffering|string|Enable or disable dynamic receive buffering. When enabled, allows the receive buffer to be adjusted dynamically based on memory and network conditions. 
        Ka|string|Send periodic TCP keep-alive (KA) probes to check if peer is still up. 
        KaConnIdleTime|double|Duration, in seconds, for the connection to be idle, before sending a keep-alive (KA) probe. 
        KaMaxProbes|double|Number of keep-alive (KA) probes to be sent when not acknowledged, before assuming the peer to be down. 
        KaProbeInterval|double|Time interval, in seconds, before the next keep-alive (KA) probe, if the peer does not respond. 
        SendBuffSize|double|TCP Send Buffer Size. 
        MpTcp|string|Enable or disable Multipath TCP. 
        EstablishClientConn|string|Establishing Client Client connection on First data/ Final-ACK / Automatic. Default value: AUTOMATIC. Possible values = AUTOMATIC, CONN_ESTABLISHED, ON_FIRST_DATA 
        TcpSegOffload|string|Offload TCP segmentation to the NIC. If set to AUTOMATIC, TCP segmentation will be offloaded to the NIC, if the NIC supports it. 
        RstWindowAttenuate|string|Enable or disable RST window attenuation to protect against spoofing. When enabled, will reply with corrective ACK when a sequence number is invalid.
        RstMaxAck|string|Enable or disable acceptance of RST that is out of window yet echoes highest ACK sequence number. Useful only in proxy mode. 
        SpoofSynDrop|string|Enable or disable drop of invalid SYN packets to protect against spoofing. When disabled, established connections will be reset when a SYN packet is received. 
        Ecn|string|Enable or disable TCP Explicit Congestion Notification. 
        MpTcpDropDataOnPreestsf|string|Enable or disable silently dropping the data on Pre-Established subflow. When enabled, DSS data packets are dropped silently instead of dropping the connection when data is received on pre established subflow. 
        MpTcpFastOpen|string|Enable or disable Multipath TCP fastopen. When enabled, DSS data packets are accepted before receiving the third ack of SYN handshake. 
        MpTcpSessionTimeout|double|MPTCP session timeout in seconds. If this value is not set, idle MPTCP sessions are flushed after vserver's client idle timeout. 
        TimeStamp|string|Enable or Disable TCP Timestamp option (RFC 1323). 
        DSack|string|Enable or disable DSACK. 
        AckAggregation|string|Enable or disable ACK Aggregation. 
        Frto|string|Enable or disable FRTO (Forward RTO-Recovery). 
        MaxCwnd|double|TCP Maximum Congestion Window. 
        FAck|string|Enable or disable FACK (Forward ACK). 
        TcpMode|string|TCP Optimization modes TRANSPARENT / ENDPOINT. Default value: TRANSPARENT Possible values = TRANSPARENT, ENDPOINT 
        TcpFastOpen|string|Enable or disable TCP Fastopen. When enabled, NS can receive or send Data in SYN or SYN-ACK packets. 
        HyStart|string|Enable or disable CUBIC Hystart. 
        DupAckThresh|double|TCP dupack threshold. 
        BurstRateControl|string|TCP Burst Rate Control DISABLED/FIXED/DYNAMIC. FIXED requires a TCP rate to be set. Default value: DISABLED. Possible values = DISABLED, FIXED, DYNAMIC 
        TcpRate|double|TCP connection payload send rate in Kb/s. 
        RateQMax|double|Maximum connection queue size in bytes, when BurstRateControl is used. 
        DropHalfClosedConnOnTimeout|string|Silently drop tcp half closed connections on idle timeout. 
        DropEstConnOnTimeout|string|Silently drop tcp established connections on idle timeout. 
        ApplyAdaptiveTcp|string|Apply Adaptive TCP optimizations. 
        TcpFastOpenCookieSize|double|TCP FastOpen Cookie size. This accepts only even numbers. Odd number is trimmed down to nearest even number. 

    * Creation of the Command

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Data to Update.

        - with Data (NsTcpProfileUpdateRequestData)  
        
            The possible parameters can be freely accessed on the Data-item, for a refference guide on these parameters and their usage, please refer to the guide at the top of this page

            Eg. 
            ```
            var command = NitroCommandFactory.Create\<NsTcpProfileUpdateCommand> (INitroServiceClient, new NsTcpProfileUpdateRequestData(){ });
            ```


    * Usage of the command: 

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For NsTcpProfileUpdate, that object is <u>NitroResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful 


