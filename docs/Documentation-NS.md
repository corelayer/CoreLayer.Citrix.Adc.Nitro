### NS

#### NsHttpProfile

Commands: add, get, remove, update

+ Add:  
    * Properties:

        Property   |Citrix doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|Name of the profile.
        DropInvalidRequestss|dropinvalreqs|string|Drop invalid HTTP requests or responses. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkHttp09RequestsInvalid|markhttp09inval|string|Mark HTTP/0.9 requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkConnectRequestInvalid|markconnreqinval|string|Mark CONNECT requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        CompressionOnPush|cmponpush|string|Start data compression on receiving a TCP packet with PUSH flag set.Default value: DISABLED Possible values = ENABLED, DISABLED 
        ConnectionMultiplex|connmultiplex|string|Reuse server connections for requests from more than one client connections. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        MaxReusePool|maxreusepool|double|Maximum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. If non-zero value is given, it has to be greater than or equal to the number of running Packet Engines. 
        DropExtraCrLfCharacters|dropextracrlf|string|Drop any extra 'CR' and 'LF' characters present after the header. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        IncompleteHeaderDelay|incomphdrdelay|double|Maximum time to wait, in milliseconds, between incomplete header packets. If the header packets take longer to arrive at Citrix ADC, the connection is silently dropped. Default value: 7000 
        WebSocket|websocket|string|HTTP connection to be upgraded to a web socket connection. Once upgraded, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED.Possible values = ENABLED, DISABLED 
        RtspTunnel|rtsptunnel|string|Allow RTSP tunnel in HTTP. Once application/x-rtsp-tunnelled is seen in Accept or Content-Type header, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED Possible values = ENABLED, DISABLED 
        RequestTimeout|reqtimeout|double|Time, in seconds, within which the HTTP request must complete. If the request does not complete within this time, the specified request timeout action is executed. Zero disables the timeout. 
        AdaptTimeout|adpttimeout|string|Adapts the configured request timeout based on flow conditions. The timeout is increased or decreased internally and applied on the flow. Default value: DISABLED Possible values = ENABLED, DISABLED 
        RequestTimeoutAction|reqtimeoutaction|string|Action to take when the HTTP request does not complete within the specified request timeout duration. You can configure the following actions: * RESET - Send RST (reset) to client when timeout occurs. * DROP - Drop silently when timeout occurs. * Custom responder action - Name of the responder action to trigger when timeout occurs, used to send custom message. 
        DropExtraData|dropextradata|string|Drop any extra data when server sends more data than the specified content-length. Default value: DISABLED Possible values = ENABLED, DISABLED 
        WebLog|weblog|string|Enable or disable web logging. Default value: ENABLED Possible values = ENABLED, DISABLED 
        ClientIpHeaderExpression|clientiphdrexpr|string|Name of the header that contains the real client IP address. 
        MaxRequests|maxreq|double|Maximum number of requests allowed on a single connection. Zero implies no limit on the number of requests. Default value: 0 
        PersistentEtag|persistentetag|string|Generate the persistent Citrix ADC specific ETag for the HTTP response with ETag header. Default value: DISABLED Possible values = ENABLED, DISABLED 
        EnableSpdy|spdy|string|Enable SPDYv2 or SPDYv3 or both over SSL vserver. SSL will advertise SPDY support either during NPN Handshake or when client will advertises SPDY support during ALPN handshake. Both SPDY versions are enabled when this parameter is set to ENABLED. Default value: DISABLED Possible values = DISABLED, ENABLED, V2, V3 
        Http2|http2|string|Choose whether to enable support for HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        Http2Direct|http2direct|string|Choose whether to enable support for Direct HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AlternativeServices|altsvc|string|Choose whether to enable support for Alternative Service. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReusePoolTimeout|reusepooltimeout|double|Idle timeout (in seconds) for server connections in re-use pool. Connections in the re-use pool are flushed, if they remain idle for the configured timeout. Default value: 0 
        MaxHeaderLength|maxheaderlen|double|Number of bytes to be queued to look for complete header before returning error. If complete header is not obtained after queuing these many bytes, request will be marked as invalid and no L7 processing will be done for that TCP connection. 
        MinReusePool|minreusepool|double|Minimum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. 
        Http2MaxHeaderListSize|http2maxheaderlistsize|double|Maximum size of header list that the Citrix ADC is prepared to accept, in bytes. NOTE: The actual plain text header size that the Citrix ADC accepts is limited by maxHeaderLen. Please change maxHeaderLen parameter as well when modifying http2MaxHeaderListSize. 
        Http2MaxFrameSize|http2maxframesize|double|Maximum size of the frame payload that the Citrix ADC is willing to receive, in bytes. 
        Http2MaxConcurrentStreams|http2maxconcurrentstreams|double|Maximum number of concurrent streams that is allowed per connection. 
        Http2InitialWindowSize|http2initialwindowsize|double|Initial window size for stream level flow control, in bytes.
        Http2HeaderTableSize|http2headersizetablesize|double|Maximum size of the header compression table used to decode header blocks, in bytes. 
        Http2MinSeverConnections|http2minseverconn|double|Minimum number of HTTP2 connections established to backend server, on receiving HTTP requests from client before multiplexing the streams into the available HTTP/2 connections. 
        ApdexClientResponseTimeThreshold|apdexcltresptimethreshold|double|This option sets the satisfactory threshold (T) for server response time in milliseconds to be used for APDEX calculations. This means a transaction responding in less than this threshold is considered satisfactory. Transaction responding between T and 4*T is considered tolerable. Any transaction responding in more than 4*T time is considered frustrating. Citrix ADC maintains stats for such tolerable and frustrating transcations. Server Response time related apdex counters are only updated on backend services or a backend vserver which is not accepting client traffic. 


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

        Property   |Citrix doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|Name of the profile.
        DropInvalidRequestss|dropinvalreqs|string|Drop invalid HTTP requests or responses. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkHttp09RequestsInvalid|markhttp09inval|string|Mark HTTP/0.9 requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        MarkConnectRequestInvalid|markconnreqinval|string|Mark CONNECT requests as invalid. Default value: DISABLED. Possible values = ENABLED, DISABLED 
        CompressionOnPush|cmponpush|string|Start data compression on receiving a TCP packet with PUSH flag set.Default value: DISABLED Possible values = ENABLED, DISABLED 
        ConnectionMultiplex|connmultiplex|string|Reuse server connections for requests from more than one client connections. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        MaxReusePool|maxreusepool|double|Maximum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. If non-zero value is given, it has to be greater than or equal to the number of running Packet Engines. 
        DropExtraCrLfCharacters|dropextracrlf|string|Drop any extra 'CR' and 'LF' characters present after the header. Default value: ENABLED. Possible values = ENABLED, DISABLED 
        IncompleteHeaderDelay|incomphdrdelay|double|Maximum time to wait, in milliseconds, between incomplete header packets. If the header packets take longer to arrive at Citrix ADC, the connection is silently dropped. Default value: 7000 
        WebSocket|websocket|string|HTTP connection to be upgraded to a web socket connection. Once upgraded, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED.Possible values = ENABLED, DISABLED 
        RtspTunnel|rtsptunnel|string|Allow RTSP tunnel in HTTP. Once application/x-rtsp-tunnelled is seen in Accept or Content-Type header, Citrix ADC does not process Layer 7 traffic on this connection. Default value: DISABLED Possible values = ENABLED, DISABLED 
        RequestTimeout|reqtimeout|double|Time, in seconds, within which the HTTP request must complete. If the request does not complete within this time, the specified request timeout action is executed. Zero disables the timeout. 
        AdaptTimeout|adpttimeout|string|Adapts the configured request timeout based on flow conditions. The timeout is increased or decreased internally and applied on the flow. Default value: DISABLED Possible values = ENABLED, DISABLED 
        RequestTimeoutAction|reqtimeoutaction|string|Action to take when the HTTP request does not complete within the specified request timeout duration. You can configure the following actions: * RESET - Send RST (reset) to client when timeout occurs. * DROP - Drop silently when timeout occurs. * Custom responder action - Name of the responder action to trigger when timeout occurs, used to send custom message. 
        DropExtraData|dropextradata|string|Drop any extra data when server sends more data than the specified content-length. Default value: DISABLED Possible values = ENABLED, DISABLED 
        WebLog|weblog|string|Enable or disable web logging. Default value: ENABLED Possible values = ENABLED, DISABLED 
        ClientIpHeaderExpression|clientiphdrexpr|string|Name of the header that contains the real client IP address. 
        MaxRequests|maxreq|double|Maximum number of requests allowed on a single connection. Zero implies no limit on the number of requests. Default value: 0 
        PersistentEtag|persistentetag|string|Generate the persistent Citrix ADC specific ETag for the HTTP response with ETag header. Default value: DISABLED Possible values = ENABLED, DISABLED 
        EnableSpdy|spdy|string|Enable SPDYv2 or SPDYv3 or both over SSL vserver. SSL will advertise SPDY support either during NPN Handshake or when client will advertises SPDY support during ALPN handshake. Both SPDY versions are enabled when this parameter is set to ENABLED. Default value: DISABLED Possible values = DISABLED, ENABLED, V2, V3 
        Http2|http2|string|Choose whether to enable support for HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        Http2Direct|http2direct|string|Choose whether to enable support for Direct HTTP/2. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AlternativeServices|altsvc|string|Choose whether to enable support for Alternative Service. Default value: DISABLED Possible values = ENABLED, DISABLED 
        ReusePoolTimeout|reusepooltimeout|double|Idle timeout (in seconds) for server connections in re-use pool. Connections in the re-use pool are flushed, if they remain idle for the configured timeout. Default value: 0 
        MaxHeaderLength|maxheaderlen|double|Number of bytes to be queued to look for complete header before returning error. If complete header is not obtained after queuing these many bytes, request will be marked as invalid and no L7 processing will be done for that TCP connection. 
        MinReusePool|minreusepool|double|Minimum limit on the number of connections, from the Citrix ADC to a particular server that are kept in the reuse pool. This setting is helpful for optimal memory utilization and for reducing the idle connections to the server just after the peak time. Zero implies no limit on reuse pool size. 
        Http2MaxHeaderListSize|http2maxheaderlistsize|double|Maximum size of header list that the Citrix ADC is prepared to accept, in bytes. NOTE: The actual plain text header size that the Citrix ADC accepts is limited by maxHeaderLen. Please change maxHeaderLen parameter as well when modifying http2MaxHeaderListSize. 
        Http2MaxFrameSize|http2maxframesize|double|Maximum size of the frame payload that the Citrix ADC is willing to receive, in bytes. 
        Http2MaxConcurrentStreams|http2maxconcurrentstreams|double|Maximum number of concurrent streams that is allowed per connection. 
        Http2InitialWindowSize|http2initialwindowsize|double|Initial window size for stream level flow control, in bytes.
        Http2HeaderTableSize|http2headersizetablesize|double|Maximum size of the header compression table used to decode header blocks, in bytes. 
        Http2MinSeverConnections|http2minseverconn|double|Minimum number of HTTP2 connections established to backend server, on receiving HTTP requests from client before multiplexing the streams into the available HTTP/2 connections. 
        ApdexClientResponseTimeThreshold|apdexcltresptimethreshold|double|This option sets the satisfactory threshold (T) for server response time in milliseconds to be used for APDEX calculations. This means a transaction responding in less than this threshold is considered satisfactory. Transaction responding between T and 4*T is considered tolerable. Any transaction responding in more than 4*T time is considered frustrating. Citrix ADC maintains stats for such tolerable and frustrating transcations. Server Response time related apdex counters are only updated on backend services or a backend vserver which is not accepting client traffic. 

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

        Property   |Citrix doc name| DataType |  Description 
        ---|---|---|---
        Name|name|string|Name of the profile.
        WindowScaling|ws|string|Enable or disable window scaling. Default value: DISABLED Possible values = ENABLED, DISABLED  
        SeletiveAcknowledgement|sack|string|Enable or disable Selective ACKnowledgement (SACK). Default value: DISABLED Possible values = ENABLED, DISABLED 
        WindowScalingValue|wsval|double|Factor used to calculate the new window size. This argument is needed only when window scaling is enabled. Default value: 4 
        Nagle|nagle|string|Enable or disable the Nagle algorithm on TCP connections. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AcknowledgementOnPush|ackonpush|string|Send immediate positive acknowledgement (ACK) on receipt of TCP packets with PUSH flag. Default value: ENABLED Possible values = ENABLED, DISABLED 
        MaximumSegmentSize|mss|double|Maximum number of octets to allow in a TCP data segment. 
        MaxBurst|maxburst|double|Maximum number of TCP segments allowed in a burst. 
        InitialCongestionWindow|initialcwnd|double|Initial maximum upper limit on the number of TCP packets that can be outstanding on the TCP link to the server. 
        DelayedAcknowledgement|delayedack|double|Timeout for TCP delayed ACK, in milliseconds. 
        OutOfOrderQueueSize|oooqsize|double|Maximum size of out-of-order packets queue. A value of 0 means no limit. 
        MaxPacketsPerMaximumSegmentSize|maxpktpermss|double|Maximum number of TCP packets allowed per maximum segment size (MSS). 
        PacketPerRetransmit|pktperretx|double|Maximum limit on the number of packets that should be retransmitted on receiving a partial ACK. 
        MinimumRetransmitionsTimeout|minrto|double|Minimum retransmission timeout, in milliseconds, specified in 10-millisecond increments (value must yield a whole number if divided by 10). 
        SlowStartIncrement|slowstartincr|double|Multiplier that determines the rate at which slow start increases the size of the TCP transmission window after each acknowledgement of successful transmission. 
        Buffersize|buffersize|double|TCP buffering size, in bytes. 
        SynCookie|syncookie|string|Enable or disable the SYNCOOKIE mechanism for TCP handshake with clients. Disabling SYNCOOKIE prevents SYN attack protection on the Citrix ADC. 
        KeepAliveProbeUpdateLastActivity|kaprobeupdatelastactivity|string|Update last activity for the connection after receiving keep-alive (KA) probes. 
        Flavor|flavor|string|Set TCP congestion control algorithm. Default value: Default. Possible values = Default, Westwood, BIC, CUBIC, Nile 
        DynamicReceiveBuffering|dynamicreceivebuffering|string|Enable or disable dynamic receive buffering. When enabled, allows the receive buffer to be adjusted dynamically based on memory and network conditions. 
        KeepAlive|ka|string|Send periodic TCP keep-alive (KA) probes to check if peer is still up. 
        KeepAliveConnectionIdleTime|kaconnidletime|double|Duration, in seconds, for the connection to be idle, before sending a keep-alive (KA) probe. 
        KeepAliveMaxProbes|kamaxprobes|double|Number of keep-alive (KA) probes to be sent when not acknowledged, before assuming the peer to be down. 
        KeepAliveProbeInterval|kaprobeinterval|double|Time interval, in seconds, before the next keep-alive (KA) probe, if the peer does not respond. 
        SendBufferSize|sendbuffsize|double|TCP Send Buffer Size. 
        MultiPathTcp|mptcp|string|Enable or disable Multipath TCP. 
        EstablishClientConnection|establishclientconn|string|Establishing Client Client connection on First data/ Final-ACK / Automatic. Default value: AUTOMATIC. Possible values = AUTOMATIC, CONN_ESTABLISHED, ON_FIRST_DATA 
        TcpSegmentOffload|tcpsegoffload|string|Offload TCP segmentation to the NIC. If set to AUTOMATIC, TCP segmentation will be offloaded to the NIC, if the NIC supports it. 
        RstWindowAttenuate|rstwindowattenuate|string|Enable or disable RST window attenuation to protect against spoofing. When enabled, will reply with corrective ACK when a sequence number is invalid.
        RstMaxAcknowledgement|rstmaxack|string|Enable or disable acceptance of RST that is out of window yet echoes highest ACK sequence number. Useful only in proxy mode. 
        SpoofSynDrop|spoofsyndrop|string|Enable or disable drop of invalid SYN packets to protect against spoofing. When disabled, established connections will be reset when a SYN packet is received. 
        ExplicitCongestionNotification|ecn|string|Enable or disable TCP Explicit Congestion Notification. 
        MultiPathTcpDropDataOnPreEstablishedSubFlow|mptcpdropdataonpreestsf|string|Enable or disable silently dropping the data on Pre-Established subflow. When enabled, DSS data packets are dropped silently instead of dropping the connection when data is received on pre established subflow. 
        MultiPathTcpFastOpen|mptcpfastopen|string|Enable or disable Multipath TCP fastopen. When enabled, DSS data packets are accepted before receiving the third ack of SYN handshake. 
        MultiPathTcpSessionTimeout|mptcpsessiontimeout|double|MPTCP session timeout in seconds. If this value is not set, idle MPTCP sessions are flushed after vserver's client idle timeout. 
        TimeStamp|timestamp|string|Enable or Disable TCP Timestamp option (RFC 1323). 
        DSack|dsack|string|Enable or disable DSACK. 
        AcknowledgementAggregation|ackaggregation|string|Enable or disable ACK Aggregation. 
        ForwardRtoRecovery|frto|string|Enable or disable FRTO (Forward RTO-Recovery). 
        MaxCongestionWindow|maxcwnd|double|TCP Maximum Congestion Window. 
        ForwardAcknowledgement|fack|string|Enable or disable FACK (Forward ACK). 
        TcpMode|tcpmode|string|TCP Optimization modes TRANSPARENT / ENDPOINT. Default value: TRANSPARENT Possible values = TRANSPARENT, ENDPOINT 
        TcpFastOpen|tcpfastopen|string|Enable or disable TCP Fastopen. When enabled, NS can receive or send Data in SYN or SYN-ACK packets. 
        HyStart|hystart|string|Enable or disable CUBIC Hystart. 
        DuplicateAcknowledgementThreshold|dupackthresh|double|TCP dupack threshold. 
        BurstRateControl|burstratecontrol|string|TCP Burst Rate Control DISABLED/FIXED/DYNAMIC. FIXED requires a TCP rate to be set. Default value: DISABLED. Possible values = DISABLED, FIXED, DYNAMIC 
        TcpRate|tcprate|double|TCP connection payload send rate in Kb/s. 
        RateQueueMax|rateqmax|double|Maximum connection queue size in bytes, when BurstRateControl is used. 
        DropHalfClosedConnectionOnTimeout|drophalfclosedconnontimeout|string|Silently drop tcp half closed connections on idle timeout. 
        DropEstablishedConnectionOnTimeout|dropestconnontimeout|string|Silently drop tcp established connections on idle timeout. 
        ApplyAdaptiveTcp|applyadaptivetcp|string|Apply Adaptive TCP optimizations. 
        TcpFastOpenCookieSize|tcpfastopencookiesize|double|TCP FastOpen Cookie size. This accepts only even numbers. Odd number is trimmed down to nearest even number. 


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

        Property|Citrix doc name|ValueType|Description
        ---|---|---|---
        Name|name|string|Name of the profile.
        WindowScaling|ws|string|Enable or disable window scaling. Default value: DISABLED Possible values = ENABLED, DISABLED  
        SelectiveAcknowledgement|sack|string|Enable or disable Selective ACKnowledgement (SACK). Default value: DISABLED Possible values = ENABLED, DISABLED 
        WindowScalingValue|wsval|double|Factor used to calculate the new window size. This argument is needed only when window scaling is enabled. Default value: 4 
        Nagle|nagle|string|Enable or disable the Nagle algorithm on TCP connections. Default value: DISABLED Possible values = ENABLED, DISABLED 
        AcknowledgementOnPush|ackonpush|string|Send immediate positive acknowledgement (ACK) on receipt of TCP packets with PUSH flag. Default value: ENABLED Possible values = ENABLED, DISABLED 
        MaximumSegmentSize|mss|double|Maximum number of octets to allow in a TCP data segment. 
        MaxBurst|maxburst|double|Maximum number of TCP segments allowed in a burst. 
        --------InitialCongestionWindow|initialcwnd|double|Initial maximum upper limit on the number of TCP packets that can be outstanding on the TCP link to the server. 
        DelayedAcknowledgement|delayedack|double|Timeout for TCP delayed ACK, in milliseconds. 
        OutOfOrderQueueSize|oooqsize|double|Maximum size of out-of-order packets queue. A value of 0 means no limit. 
        MaxPacketsPerMaximumSegmentSize|maxpktpermss|double|Maximum number of TCP packets allowed per maximum segment size (MSS). 
        PacketPerRetransmit|pktperretx|double|Maximum limit on the number of packets that should be retransmitted on receiving a partial ACK. 
        MinimumRetransmitionsTimeout|minrto|double|Minimum retransmission timeout, in milliseconds, specified in 10-millisecond increments (value must yield a whole number if divided by 10). 
        SlowStartIncrement|slowstartincr|double|Multiplier that determines the rate at which slow start increases the size of the TCP transmission window after each acknowledgement of successful transmission. 
        Buffersize|buffersize|double|TCP buffering size, in bytes. 
        SynCookie|syncookie|string|Enable or disable the SYNCOOKIE mechanism for TCP handshake with clients. Disabling SYNCOOKIE prevents SYN attack protection on the Citrix ADC. 
        KeepAliveProbeUpdateLastActivity|kaprobeupdatelastactivity|string|Update last activity for the connection after receiving keep-alive (KA) probes. 
        Flavor|flavor|string|Set TCP congestion control algorithm. Default value: Default. Possible values = Default, Westwood, BIC, CUBIC, Nile 
        DynamicReceiveBuffering|dynamicreceivebuffering|string|Enable or disable dynamic receive buffering. When enabled, allows the receive buffer to be adjusted dynamically based on memory and network conditions. 
        KeepAlive|ka|string|Send periodic TCP keep-alive (KA) probes to check if peer is still up. 
        KeepAliveConnectionIdleTime|kaconnidletime|double|Duration, in seconds, for the connection to be idle, before sending a keep-alive (KA) probe. 
        KeepAliveMaxProbes|kamaxprobes|double|Number of keep-alive (KA) probes to be sent when not acknowledged, before assuming the peer to be down. 
        KeepAliveProbeInterval|kaprobeinterval|double|Time interval, in seconds, before the next keep-alive (KA) probe, if the peer does not respond. 
        SendBufferSize|sendbuffsize|double|TCP Send Buffer Size. 
        MultiPathTcp|mptcp|string|Enable or disable Multipath TCP. 
        EstablishClientConnection|establishclientconn|string|Establishing Client Client connection on First data/ Final-ACK / Automatic. Default value: AUTOMATIC. Possible values = AUTOMATIC, CONN_ESTABLISHED, ON_FIRST_DATA 
        TcpSegmentOffload|tcpsegoffload|string|Offload TCP segmentation to the NIC. If set to AUTOMATIC, TCP segmentation will be offloaded to the NIC, if the NIC supports it. 
        RstWindowAttenuate|rstwindowattenuate|string|Enable or disable RST window attenuation to protect against spoofing. When enabled, will reply with corrective ACK when a sequence number is invalid.
        RstMaxAcknowledgement|rstmaxack|string|Enable or disable acceptance of RST that is out of window yet echoes highest ACK sequence number. Useful only in proxy mode. 
        SpoofSynDrop|spoofsyndrop|string|Enable or disable drop of invalid SYN packets to protect against spoofing. When disabled, established connections will be reset when a SYN packet is received. 
        ExplicitCongestionNotification|ecn|string|Enable or disable TCP Explicit Congestion Notification. 
        MultiPathTcpDropDataOnPreEstablishedSubFlow|mptcpdropdataonpreestsf|string|Enable or disable silently dropping the data on Pre-Established subflow. When enabled, DSS data packets are dropped silently instead of dropping the connection when data is received on pre established subflow. 
        MultiPathTcpFastOpen|mptcpfastopen|string|Enable or disable Multipath TCP fastopen. When enabled, DSS data packets are accepted before receiving the third ack of SYN handshake. 
        MultiPathTcpSessionTimeout|mptcpsessiontimeout|double|MPTCP session timeout in seconds. If this value is not set, idle MPTCP sessions are flushed after vserver's client idle timeout. 
        TimeStamp|timesta;p|string|Enable or Disable TCP Timestamp option (RFC 1323). 
        DSack|dsack|string|Enable or disable DSACK. 
        AcknowledgementAggregation|ackaggregation|string|Enable or disable ACK Aggregation. 
        ForwardRtoRecovery|frto|string|Enable or disable FRTO (Forward RTO-Recovery). 
        MaxCongestionWindow|maxcwnd|double|TCP Maximum Congestion Window. 
        ForwardAcknowledgement|fack|string|Enable or disable FACK (Forward ACK). 
        TcpMode|tcpmode|string|TCP Optimization modes TRANSPARENT / ENDPOINT. Default value: TRANSPARENT Possible values = TRANSPARENT, ENDPOINT 
        TcpFastOpen|tcpfastopen|string|Enable or disable TCP Fastopen. When enabled, NS can receive or send Data in SYN or SYN-ACK packets. 
        HyStart|hystart|string|Enable or disable CUBIC Hystart. 
        DuplicateAcknowledgementThreshold|dupackthresh|double|TCP dupack threshold. 
        BurstRateControl|burstratecontrol|string|TCP Burst Rate Control DISABLED/FIXED/DYNAMIC. FIXED requires a TCP rate to be set. Default value: DISABLED. Possible values = DISABLED, FIXED, DYNAMIC 
        TcpRate|tcprate|double|TCP connection payload send rate in Kb/s. 
        RateQueueMax|rateqmax|double|Maximum connection queue size in bytes, when BurstRateControl is used. 
        DropHalfClosedConnectionOnTimeout|drophalfclosedconnontimeout|string|Silently drop tcp half closed connections on idle timeout. 
        DropEstablishedConnectionOnTimeout|dropestconnontimeout|string|Silently drop tcp established connections on idle timeout. 
        ApplyAdaptiveTcp|applyadaptivetcp|string|Apply Adaptive TCP optimizations. 
        TcpFastOpenCookieSize|tcpfastopencookiesize|double|TCP FastOpen Cookie size. This accepts only even numbers. Odd number is trimmed down to nearest even number. 

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


