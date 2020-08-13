### Network

#### Bridge

+ Get
    * Properties  

        The following properties can be found in the BridgeStats-objects inside of a BridgeStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        TcpTotalBridgeMacMoved|tcptotbdgmacmoved|string|The number of times bridging registered MAC moved
        TcpBridgeMacMovedRate|tcpbdgmacmovedrate|double|Rate (/s) counter for tcptotbdgmacmoved
        TcpTotalBridgingTableCollisions|tcptotbdgcollisions|string|The number of bridging table collisions
        TcpBridgingTableCollisionsRate|tcpbdgcollisionsrate|double|Rate (/s) counter for tcptotbdgcollisions
        TcpErrorBridgeMuted|tcperrbdgmuted|string|The number of bridging related interface mutes
        TcpErrorBridgeMutedRate|tcperrbdgmutedrate|double|	Rate (/s) counter for tcperrbdgmuted
        TotalBridgedPackets|totbdgpkts|string|The total number of bridged packets
        BridgedPacketsRate|bdgpktsrate|double|Rate (/s) counter for totbdgpkts
        TotalBridgedMbits|totbdgmbits|string|The total number of bridged Mbits
        BridgedMbitsRate|bdgmbitsrate|double|Rate (/s) counter for totbdgmbits




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<BridgeStatCommand>(INitroServiceClient, New BridgeStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object BridgeStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")): 
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For BridgeStat, that object is <u>BridgeStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - BridgeStatistics: a BridgeStats-object returned by the Get-Request, containing the properties mentioned above.




#### Inat

+ Get
    * Properties  

        The following properties can be found in the InatStats-objects-array inside of a InatStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|The INAT.
        Nat46TotalTcp46Translations|nat46tottcp46|string|Total TCP packets translated (V4->v6).
        Nat46Tcp46TranslationsRate|nat46tcp46rate|double|Rate (/s) counter for nat46tottcp46
        Nat46TotalUdp46Translations|nat46totudp46|string|Total UDP packets translated (V4->v6).
        Nat46Udp46TranslationsRate|nat46udp46rate|double|Rate (/s) counter for nat46totudp46
        Nat46TotalIcmp46Translations|nat46toticmp46|string|Total ICMP packets translated (V4->v6).
        Nat46Icmp46TranslationsRate|nat46icmp46rate|double|Rate (/s) counter for nat46toticmp46
        Nat46TotalDrop46|nat46totdrop46|string|Total IPV4 packets dropped.
        Nat46Drop46Rate|nat46drop46rate|double|Rate (/s) counter for nat46totdrop46
        Nat46TotalTcp64Translations|nat46tottcp64|string|Total TCP packets translated (V6->v4).
        Nat46Tcp64TranslationsRate|nat46tcp64rate|double|Rate (/s) counter for nat46tottcp64
        Nat46TotalUdp64Translations|nat46totudp64|string|Total UDP packets translated (V6->v4).
        Nat46Udp64TranslationsRate|nat46udp64rate|double|Rate (/s) counter for nat46totudp64
        Nat46TotalIcmp64Translations|nat46toticmp64|string|Total ICMP packets translated (V6->v4).
        Nat46Icmp64TranslationsRate|nat46icmp64rate|double|Rate (/s) counter for nat46toticmp64
        Nat46TotalDrop64|nat46totdrop64|string|Total IPV6 packets dropped.
        Nat46Drop64Rate|nat46drop64rate|double|Rate (/s) counter for nat46totdrop64
        InatNat46Tcp46Translations|inatnat46tcp46|string|TCP packets translated (V4->v6).
        InatNat46Tcp46TranslationsRate|inatnat46tcp46rate|double|Rate (/s) counter for inatnat46tcp46
        InatNat46Udp46Translations|inatnat46udp46|string|UDP packets translated (V4->v6).
        InatNat46Udp46TranslationsRate|inatnat46udp46rate|double|Rate (/s) counter for inatnat46udp46
        InatNat46Icmp46Translations|inatnat46icmp46|string|ICMP packets translated (V4->v6)
        InatNat46Icmp46TranslationsRate|inatnat46icmp46rate|double|Rate (/s) counter for inatnat46icmp46
        InatNat46Drop46|inatnat46drop46|string|IPV4 packets dropped.
        InatNat46Drop46Rate|inatnat46drop46rate|double|Rate (/s) counter for inatnat46drop46
        InatNat46Tcp64Translations|inatnat46tcp64|string|TCP packets translated (V6->v4).
        InatNat46Tcp64TranslationsRate|inatnat46tcp64rate|double|Rate (/s) counter for inatnat46tcp64
        InatNat46Udp64Translations|inatnat46udp64|string|UDP packets translated (V6->v4).
        InatNat46Udp64TranslationsRate|inatnat46udp64rate|double|Rate (/s) counter for inatnat46udp64
        InatNat46Icmp64Translations|inatnat46icmp64|string|ICMP packets translated (V6->v4).
        InatNat46Icmp64TranslationsRate|inatnat46icmp64rate|double|Rate (/s) counter for inatnat46icmp64
        InatNat46Drop64|inatnat46drop64|string|IPV6 packets dropped.
        InatNat46Drop64Rate|inatnat46drop64rate|double|Rate (/s) counter for inatnat46drop64



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<InatStatCommand>(INitroServiceClient, New InatStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object InatStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For InatStat, that object is <u>InatStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - InatStatistics: a InatStats-object-array returned by the Get-Request, containing the properties mentioned above.


#### InatSession

+ Get
    * Properties  

        The following properties can be found in the InatSessionStats-objects-array inside of a InatSessionStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|INAT name.
        GlobalInatReceiveBytes|globalinatreceivebytes|string|Total INAT Received Bytes
        GlobalInatCurrentSessions|globalinatcursessions|string|Total INAT current sessions
        InatTotalSentBytes|inattotsentbytes|string|INAT total Sent Bytes
        GlobalInatPacketSent|globalinatpktsent|string|Total INAT Packets Sent
        InatReceiveBytesRate|inatreceivebytesrate|double|Rate (/s) counter for inattotreceivebytes
        GlobalInatSentBytesRate|globalinatsentbytesrate|double|Rate (/s) counter for globalinattotsentbytes
        GlobalInatCurrentSessionsRate|globalinatcursessionsrate|double|Rate (/s) counter for globalinatcursessions
        InatHitsRate|inathitsrate|double|Rate (/s) counter for inattothits
        InatTotalReceiveBytes|inattotreceivebytes|string|INAT total Received Bytes
        InatCurrentSessionsRate|inatcursessionsrate|double|Rate (/s) counter for inatcursessions
        GlobalInatReceiveBytesRate|globalinatreceivebytesrate|double|Rate (/s) counter for globalinatreceivebytes
        GlobalInatPacketSentRate|globalinatpktsentrate|double|Rate (/s) counter for globalinatpktsent
        InatCurrentSessions|inatcursessions|string|INAT current sessions
        InatSentBytesRate|inatsentbytesrate|double|Rate (/s) counter for inattotsentbytes
        GlobalInatTotalSentBytes|globalinattotsentbytes|string|Total INAT Sent Bytes
        GlobalInatHits|globalinathits|string|Total INAT Session hits
        GlobalInatHitsRate|globalinathitsrate|double|Rate (/s) counter for globalinathits
        InatPacketSentRate|inatpktsentrate|double|Rate (/s) counter for inattotpktsent
        GlobalInatPacketReceived|globalinatpktreceived|string|Total INAT Packets Received
        GlobalInatPacketReceivedRate|globalinatpktreceivedrate|double|Rate (/s) counter for globalinatpktreceived
        InatTotalPacketReceived|inattotpktreceived|string|INAT total Packets Received
        InatTotalHits|inattothits|string|INAT total sessions
        InatTotalPacketSent|inattotpktsent|string|INAT total Packets Sent
        InatPacketReceivedRate|inatpktreceivedrate|double|Rate (/s) counter for inattotpktreceived

        


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<InatSessionStatCommand>(INitroServiceClient, New InatSessionStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object InatSessionStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For InatSessionStat, that object is <u>InatSessionStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - InatSessionStatistics: a InatSessionStats-object-array returned by the Get-Request, containing the properties mentioned above.




#### Interface

+ Get
    * Properties  

        The following properties van be found in each InterfaceStats found in the array "InterfaceStats" inside of a InterfaceStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Id|id|string|Interface number, in C/U format, where C can take one of the following values:* 0 - Indicates a management interface.* 1 - Indicates a 1 Gbps port.* 10 - Indicates a 10 Gbps port.* LA - Indicates a link aggregation port.* LO - Indicates a loop back port.U is a unique integer for representing an interface in a particular port group.
        CurInterfaceState|curintfstate|string|Current state of the specified interface. The interface state set to UP only if the link state is UP and administrative state is ENABLED .
        CurrentLinkUptime|curlinkuptime|string|Duration for which the link is UP. This statistic is reset when the state changes to DOWN.
        CurrentLinkDowntime|curlinkdowntime|string|Duration for which the link is DOWN. This statistic is reset when the state changes to UP.
        TotalReceiveBytes|totrxbytes|string|Number of bytes received by an interface since the Citrix ADC was started or the interface statistics were cleared.
        ReceiveBytesRate|rxbytesrate|double|Rate (/s) counter for totrxbytes
        TotalTransmitBytes|tottxbytes|string|Number of bytes transmitted by an interface since the Citrix ADC was started or the interface statistics were cleared.
        TransmitBytesRate|txbytesrate|double|Rate (/s) counter for tottxbytes
        TotalReceivePackets|totrxpkts|string|Number of packets received by an interface since the Citrix ADC was started or the interface statistics were cleared.
        ReceivePacketsRate|rxpktsrate|double|Rate (/s) counter for totrxpkts
        TotalTransmitPackets|tottxpkts|string|Number of packets transmitted by an interface since the Citrix ADC was started or the interface statistics were cleared.
        TransmitPacketsRate|txpktsrate|double|Rate (/s) counter for tottxpkts
        JumboPacketsReceived|jumbopktsreceived|string|Number of Jumbo Packets received on this interface.
        JumboPacketsReceivedRate|jumbopktsreceivedrate|double|Rate (/s) counter for jumbopktsreceived
        JumboPacketsTransmitted|jumbopktstransmitted|string|Number of Jumbo packets transmitted on this interface by upper layer, with TSO enabled actual trasmission size could be non Jumbo.
        JumboPacketsTransmittedRate|jumbopktstransmittedrate|double|Rate (/s) counter for jumbopktstransmitted
        TrunkPacketsReceived|trunkpktsreceived|string|	Number of Tagged Packets received on this Trunk interface through Allowed VLan List.
        TrunkPacketsReceivedRate|trunkpktsreceivedrate|double|Rate (/s) counter for trunkpktsreceived
        TrunkPacketsTransmitted|trunkpktstransmitted|string|Number of Tagged Packets transmitted on this Trunk interface through Allowed VLan List.
        TrunkPacketsTransmittedRate|trunkpktstransmittedrate|double|Rate (/s) counter for trunkpktstransmitted
        NicTotalMulticastPackets|nictotmulticastpkts|string|Number of multicast packets received by the specified interface since the Citrix ADC was started or the interface statistics were cleared.
        NicMulticastPacketsRate|nicmulticastpktsrate|double|Rate (/s) counter for nictotmulticastpkts
        TotalNetscalerPackets|totntscalerpkts|string|Number of packets, destined to the Citrix ADC, received by an interface since the Citrix ADC was started or the interface statistics were cleared. The packets destined to Citrix ADC are those that have the same MAC address as that of an interface or a VMAC address owned by the Citrix ADC.
        NetscalerPacketsRate|netscalerpktsrate|double|Rate (/s) counter for totnetscalerpkts
        ReceivedLacpdu|rxlacpdu|string|Number of Link Aggregation Control Protocol Data Units(LACPDUs) received by the specified interface since the Citrix ADC was started or the interface statistics were cleared.
        ReceiveLacpduRate|rxlacpdurate|double|Rate (/s) counter for rxlacpdu
        TransmitLacpdu|txlacpdu|string|Number of Link Aggregation Control Protocol Data Units(LACPDUs) transmitted by the specified interface since the Citrix ADC was started or the interface statistics were cleared.
        TransmitLacpduRate|txlacpdurate|double|	Rate (/s) counter for txlacpdu
        ErrorPacketReceive|errpktrx|string|Number of inbound packets dropped by the hardware on a specified interface once the Citrix ADC starts or the interface statistics are cleared. This happens due to following reasons: 1) The hardware receives packets at a rate higher rate than that at which the software is processing packets. In this case, the hardware FIFO overruns and starts dropping the packets . 2) The specified interface fails to receive inbound packets from the appliance because of insufficient memory. 3) The specified interface receives packets with CRC errors (Alignment or Frame Check Sequence). 4) The specified interface receives overly long packets. 5) The specified interface receives packets with alignment errors. 6) The software does less buffering because it is running out of available memory. When hardware detects that there is no space into which to push newly arrived packets, it starts dropping them. 7) The specified interface receives packets with Frame Check Sequence (FCS) errors. 8) The specified interface receives packets smaller than 64 bytes. 9) The specified interface discards error-free inbound packets because of insufficient resources. For example: NIC buffers. 10) Packets are missed because of collision detection, link lost, physical decoding error, or MAC abort.
        ErrorPacketReceiveRate|errpktrxrate|double|Rate (/s) counter for errpktrx
        ErrorPacketTransmit|errpkttx|string|Number of outbound packets dropped by the hardware on a specified interface since the Citrix ADC was started or the interface statistics were cleared. This could happen due to length (undersize or oversize) errors and lack of resources. This statistic is available only for: (1) Loop back interface (LO) of all platforms. (2) All data ports on the Citrix ADC 12000 platform. (3) Management ports on the MPX 15000 and 17000 platforms.
        ErrorPacketTransmitRate|errpkttxrat|double|Rate (/s) counter for errpkttx
        ErrorIfInDiscards|errifindiscards|string|Number of error-free inbound packets discarded by the specified interface due to a lack of resources, for example, insufficient receive buffers.
        ErrorIfInDiscardsRate|errifindiscardsrate|double|Rate (/s) counter for errifindiscard.
        NicErrorIfOutDiscards|nicerrifoutdiscards|string|Number of error-free outbound packets discarded by the specified interface due to a lack of resources. This statistic is not available on: (1) 10G ports of Citrix ADC MPX 12500/12500/15500-10G platforms. (2) 10G data ports on Citrix ADC MPX 17500/19500/21500 platforms.
        NicErrorIfOutDiscardsRate|nicerrifoutdiscardsrate|double|Rate (/s) counter for nicerrifoutdiscards
        ErrorDroppedReceivePackets|errdroppedrxpkts|string|Number of inbound packets dropped by the specified interface. Commonly dropped packets are multicast frames, spanning tree BPDUs, packets destined to a MAC not owned by the Citrix ADC when L2 mode is disabled, or packets tagged for a VLAN that is not bound to the interface. This statistic will increment in most healthy networks at a steady rate regardless of traffic load. If a sharp spike in dropped packets occurs, it generally indicates an issue with connected L2 switches, such as a forwarding database overflow resulting in packets being broadcast on all ports.
        ErrorDroppedReceivePacketsRate|errdroppedrxpktsrate|double|Rate (/s) counter for errdroppedrxpkts
        ErrorDroppedTransmitPackets|errdroppedtxpkts|string|Number of packets dropped in transmission by the specified interface due to one of the following reasons. (1) VLAN mismatch. (2) Oversized packets. (3) Interface congestion. (4) Loopback packets sent on non loop back interface.
        ErrorDroppedTransmitPacketsRate|errdroppedtxpktsrate|double|Rate (/s) counter for errdroppedtxpkts
        ErrorLinkHangs|errlinkhangs|string|Number of times the specified interface detected hangs in the transmit and receive paths since the Citrix ADC was started or the interface statistics were cleared.
        NicStatusStalls|nicstsstalls|string|Number of times the status updates for a specified interface were stalled since the Citrix ADC was started or the interface statistics were cleared. A status stall is detected when the status of the interface is not updated by the NIC hardware within 0.8 seconds of the last update.
        NicTransmitStalls|nixtxstalls|string|Number of times the interface stalled, when transmitting packets, since the Citrix ADC was started or the interface statistics were cleared. Transmit (Tx) stalls are detected when a packet posted for transmission is not transmitted in 4 seconds.
        NicReceiveStalls|nicrxstalls|string|Number of times the interface stalled, when receiving packets, since the Citrix ADC was started or the interface statistics were cleared. Receive (Rx) stalls are detected when the following conditions are met: (1)The link is up for more than 10 minutes. (2)Packets are transmitted, but no packets is received for 16 seconds.
        NicErrorDisables|nicerrdisables|string|Number of times the specified interface is disabled by the Citrix ADC, due to continuous Receive (Rx) or Transmit (Tx) stalls, since the Citrix ADC was started or the interface statistics were cleared. The Citrix ADC disables an interface when one of the following conditions is met: (1) Three consecutive transmit stalls occurs with at most gap of 10 seconds between any two stalls. (2) Three consecutive receive stalls occurs with at most gap of 120 seconds between any two stalls.
        LinkReinitialized|linkreinits|string|Number of times the link has been re-initialized. A re-initialization occurs due to link state change, configuration parameter change, or administrative reset operation.
        TotalMacMoved|totmacmoved|string|Number of MAC moves between ports. If a high rate of MAC moves is observed, it is likely that there is a bridge loop between two interfaces.
        MacMovedRate|macmovedrate|double|Rate (/s) counter for totmacmoved
        ErrorNicMuted|errnicmuted|string|Number of times the specified interface stopped transmitting and receiving packets due to MAC moves between ports.
        ReceivedCrcErrors|rxcrcerrors|string|Number of packets received with the wrong checksum by the specified interface since the Citrix ADC was started or the interface statistics were cleared. This indicates the number of Jabber frames received instead of CRC errors on the 10G data ports of Citrix ADC 12000-10G platform and the data ports of Citrix ADC MPX 15000 and 17000 platforms.
        ReceivedCrcErrorsRate|rxcrcerrorsrate|double|Rate (/s) counter for rxcrcerrors
        InterfaceAlias|interfacealias|string|Alias Name for the Interface
        CurrentLinkState|curlinkstate|string|The current state of the link associated with the interface. For logical interfaces (LA), the state of the link is dependent on the state of the slave interfaces. For the link to be UP at least one of the slave interfaces needs to be UP.





    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<InterfaceStatCommand>(INitroServiceClient, New InterfaceStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object InterfaceStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For InterfaceStat, that object is <u>InterfaceStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - InterfaceStats: an array of interfaceStats-objects returned by the Get-Request, all of which contain the properties mentioned above.



#### MapBmr

+ Get
    * Properties  

        The following properties can be found in the MapBmrStats-objects-array inside of a MapBmrStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Name|name|string|Basic Mapping Rule name.
        BmrV6ReceivePacketsRate|bmrv6rxpktsrate|double|Rate (/s) counter for bmrtotv6rxpkts
        BmrV4ReceivePacketsUdpRate|bmrv4rxpktsudprate|double|Rate (/s) counter for bmrtotv4rxpktsudp
        BmrTotalV6TransmitPackets|bmrtotv6txpkts|string|Total number of MAP-T BMR V6 Transmitted packets.
        BmrV6ReceivePacketsUdpRate|bmrv6rxpktsudprate|double|Rate (/s) counter for bmrtotv6rxpktsudp
        BmrTotalV6TransmitPacketsIcmp|bmrtotv6txpktsicmp|string|Total number of MAP-T BMR V6 ICMP Transmitted packets.
        BmrTotalV4ReceivePacketsUdp|bmrtotv4rxpktsudp|string|Total number of MAP-T BMR V4 UDP Transmitted packets.
        BmrV6TransmitPacketsUdpRate|bmrv6txpktsudprate|double|Rate (/s) counter for bmrtotv6txpktsudp
        BmrV4TransmitPacketsIcmpRate|bmrv4txpktsicmprate|double|Rate (/s) counter for bmrtotv4txpktsicmp
        BmrTotalV6ReceivePackets|bmrtotv6rxpkts|string|Total number of MAP-T BMR V6 Recieved packets.
        BmrV4TransmitPacketsRate|bmrv4txpktsrate|double|Rate (/s) counter for bmrtotv4txpkts
        BmrTotalV4ReceivePackets|bmrtotv4rxpkts|string|Total number of MAP-T BMR V4 Recieved packets.
        BmrV4TransmitPacketsTcpRate|bmrv4txpktstcprate|double|Rate (/s) counter for bmrtotv4txpktstcp
        BmrV4ReceivePacketsIcmpRate|bmrv4rxpktsicmprate|double|Rate (/s) counter for bmrtotv4rxpktsicmp
        BmrV4ReceivePacketsTcpRate|bmrv4rxpktstcprate|double|Rate (/s) counter for bmrtotv4rxpktstcp
        BmrV6TransmitPacketsIcmpRate|bmrv6txpktsicmprate|double|Rate (/s) counter for bmrtotv6txpktsicmp
        BmrV6TransmitPacketsTcpRate|bmrv6txpktstcprate|double|Rate (/s) counter for bmrtotv6txpktstcp
        BmrTotalV6ReceivePacketsIcmp|bmrtotv6rxpktsicmp|string|Total number of MAP-T BMR V6 ICMP Recieved packets.
        BmrTotalV6TransmitPacketsUdp|bmrtotv6txpktsudp|string|Total number of MAP-T BMR V6 UDP Transmitted packets.
        BmrV6ReceivePacketsTcpRate|bmrv6rxpktstcprate|double|Rate (/s) counter for bmrtotv6rxpktstcp
        BmrTotalV4TransmitPacketsIcmp|bmrtotv4txpktsicmp|string|Total number of MAP-T BMR V4 ICMP Transmitted packets.
        BmrTotalV4TransmitPacketsTcp|bmrtotv4txpktstcp|string|Total number of MAP-T BMR V4 TCP Transmitted packets.
        BmrTotalV4ReceivePacketsIcmp|bmrtotv4rxpktsicmp|string|Total number of MAP-T BMR V4 ICMP Recieved packets.
        BmrV6TransmitPacketsRate|bmrv6txpktsrate|double|Rate (/s) counter for bmrtotv6txpkts
        BmrTotalV4TransmitPacketsUdp|bmrtotv4txpktsudp|string|Total number of MAP-T BMR V4 UDP Transmitted packets.
        BmrTotalV4ReceivePacketsTcp|bmrtotv4rxpktstcp|string|Total number of MAP-T BMR V4 TCP Recieved packets.
        BmrTotalV4TransmitPackets|bmrtotv4txpkts|string|Total number of MAP-T BMR V4 Transmitted packets.
        BmrV4TransmitPacketsUdpRate|bmrv4txpktsudprate|double|Rate (/s) counter for bmrtotv4txpktsudp
        BmrTotalV6ReceivePacketsUdp|bmrtotv6rxpktsudp|string|Total number of MAP-T BMR V6 UDP Recieved packets.
        BmrTotalV6TransmitPacketsTcp|bmrtotv6txpktstcp|string|Total number of MAP-T BMR V6 TCP Transmitted packets.
        BmrTotalV6ReceivePacketsTcp|bmrtotv6rxpktstcp|string|Total number of MAP-T BMR V6 TCP Recieved packets.
        BmrV4ReceivePacketsRate|bmrv4rxpktsrate|double|Rate (/s) counter for bmrtotv4rxpkts
        BmrV6ReceivePacketsIcmpRate|bmrv6rxpktsicmprate|double|Rate (/s) counter for bmrtotv6rxpktsicmp

        


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<MapBmrStatCommand>(INitroServiceClient, New MapBmrStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object MapBmrStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For MapBmrStat, that object is <u>MapBmrStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - MapBmrStatistics: a MapBmrStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### MapDomain - NYI

+ Get
    * Properties  

        The following properties can be found in the MapDomainStats-objects-array inside of a MapDomainStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---

        

        


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<MapDomainStatCommand>(INitroServiceClient, New MapDomainStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object MapDomainStatRequestOptions, which has following properties to be used as filters:  
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

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For MapDomainStat, that object is <u>MapDomainStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - MapDomainStatistics: a MapDomainStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### Nat64

+ Get
    * Properties  

        The following properties can be found in the Nat64Stats-objects-array inside of a Nat64StatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Nat64IcmpSessionsRate|nat64icmpsessionsrate|double|Rate (/s) counter for nat64toticmpsessions
        Nat64TotalIcmpSessions|nat64toticmpsessions|string|Total number of ICMP sessions created by NAT64.
        Nat64SessionsRate|nat64sessionsrate|double|Rate (/s) counter for nat64totsessions
        Nat64TotalSessions|nat64totsessions|string|Total number of sessions created by NAT64.
        Nat64UdpSessionsRate|nat64udpsessionsrate|double|Rate (/s) counter for nat64totudpsessions
        Nat64TotalUdpSessions|nat64totudpsessions|string|Total number of UDP sessions created by NAT64.
        Nat64TcpSessionsRate|nat64tcpsessionsrate|double|Rate (/s) counter for nat64tottcpsessions
        Nat64TotalTcpSessions|nat64tottcpsessions|string|Total number of TCP sessions created by NAT64.
        

        


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<Nat64StatCommand>(INitroServiceClient, New Nat64StatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object Nat64StatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For Nat64Stat, that object is <u>Nat64StatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - Nat64Statistics: a Nat64Stats-object-array returned by the Get-Request, containing the properties mentioned above.



#### RNat

+ Get
    * Properties  

        The following properties can be found in the RNatStats-objects-array inside of a RNatStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        RNatCurrentSessions|rnatcursessions|string|Currently active RNAT sessions.
        RNatTotalTransmitPackets|rnattottxpkts|string|Packets sent during RNAT sessions.
        RNatTransmitPacketsRate|rnattxpktsrate|double|Rate (/s) counter for rnattottxpkts
        RNatTotalReceivePackets|rnattotrxpkts|string|Packets received during RNAT sessions.
        RNatReceivePacketsRate|rnatrxpktsrate|double|Rate (/s) counter for rnattotrxpkts
        RNatTotalReceiveBytes|rnattotrxbytes|string|Bytes received during RNAT sessions.
        RNatReceiveBytesRate|rnatrxbytesrate|double|Rate (/s) counter for rnattotrxbytes
        RNatTotalTransmitBytes|rnattottxbytes|string|Bytes sent during RNAT sessions.
        RNatTransmitBytesRate|rnattxbytesrate|double|Rate (/s) counter for rnattottxbytes
        RNatTotalConnectionRequests|rnattottxsyn|string|Requests for connections sent during RNAT sessions.
        RNatConnectionRequestsRate|rnattxsynrate|double|Rate (/s) counter for rnattottxsyn




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<RNatStatCommand>(INitroServiceClient, New RNatStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object RNatStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For RNatStat, that object is <u>RNatStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - RNatStatistics: a RNatStats-object-array returned by the Get-Request, containing the properties mentioned above.


#### RNat6

+ Get
    * Properties  

        The following properties can be found in the RNat6Stats-objects-array inside of a RNat6StatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        RNat6CurrentSessions|rnat6cursessions|string|Currently active RNAT6 sessions.
        RNat6TotalTransmitPackets|rnat6tottxpkts|string|Packets sent during RNAT6 sessions.
        RNat6TransmitPacketsRate|rnat6txpktsrate|double|Rate (/s) counter for rnat6tottxpkts
        RNat6TotalReceivePackets|rnat6totrxpkts|string|Packets received during RNAT6 sessions.
        RNat6ReceivePacketsRate|rnat6rxpktsrate|double|Rate (/s) counter for rnat6totrxpkts
        RNat6TotalReceiveBytes|rnat6totrxbytes|string|Bytes received during RNAT6 sessions.
        RNat6ReceiveBytesRate|rnat6rxbytesrate|double|Rate (/s) counter for rnat6totrxbytes
        RNat6TotalTransmitBytes|rnat6tottxbytes|string|Bytes sent during RNAT6 sessions.
        RNat6TransmitBytesRate|rnat6txbytesrate|double|Rate (/s) counter for rnat6tottxbytes
        RNat6TotalConnectionRequests|rnat6tottxsyn|string|Requests for connections sent during RNAT6 sessions.
        RNat6ConnectionRequestsRate|rnat6txsynrate|double|Rate (/s) counter for rnat6tottxsyn




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<RNat6StatCommand>(INitroServiceClient, New RNat6StatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object RNat6StatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For RNat6Stat, that object is <u>RNat6StatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - RNat6Statistics: a RNat6Stats-object-array returned by the Get-Request, containing the properties mentioned above.


#### RNatIp

+ Get
    * Properties  

        The following properties can be found in the RNatIpStats-objects-array inside of a RNatIpStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        RNatIp|Rnatip|string|Specifies the NAT IP address of the configured RNAT entry for which you want to see the statistics
        IpRNatCurrentSessions|iprnatcursessions|string|Currently active RNAT sessions started from this IP address.
        IpTrafficDomain|iptd|string|Traffic domain for ipaddr.
        IpRNatTransmitPacketsRate|iprnattxpktsrate|double|Rate (/s) counter for iprnattottxpkts
        IpRNatTotalTransmitPackets|iprnattottxpkts|string|Packets sent from this IP address during RNAT sessions.
        IpRNatReceivePacketsRate|iprnatrxpktsrate|double|Rate (/s) counter for iprnattotrxpkts
        IpRNatTotalReceivePackets|iprnattotrxpkts|string|Packets received on this IP address during RNAT sessions.
        IpRNatTotalTransmitBytes|iprnattottxbytes|string|Bytes sent from this IP address during RNAT sessions.
        IpRNatTransmitBytesRate|iprnattxbytesrate|double|Rate (/s) counter for iprnattottxbytes
        IpRNatTotalReceiveBytes|iprnattotrxbytes|string|Bytes received on this IP address during RNAT sessions.
        IpRNatReceiveBytesRate|iprnatrxbytesrate|double|Rate (/s) counter for iprnattotrxbytes
        IpRNatTotalConnectionRequests|iprnattottxsyn|string|Requests for connections sent from this IP address during RNAT sessions.
        IpRNatConnectionRequestsRate|iprnattxsynrate|double|Rate (/s) counter for iprnattottxsyn



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<RNatIpStatCommand>(INitroServiceClient, New RNatIpStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object RNatIpStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:Rnatip, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For RNatIpStat, that object is <u>RNatIpStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - RNatIpStatistics: a RNatIpStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### TunnelIp

+ Get
    * Properties  

        The following properties can be found in the TunnelIpStats-objects-array inside of a TunnelIpStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        TunnelIp|tunnelip|string|remote IP address of the configured tunnel.
        TunnelTotalReceivePackets|tnltotrxpkts|string|Total number of packets received on the tunnel.
        TunnelReceivePacketsRate|tnlrxpktsrate|double|Rate (/s) counter for tnltotrxpkts
        TunnelTotalTransmitPackets|tnltottxpkts|string|Total number of packets transmitted on the tunnel.
        TunnelTransmitPacketsRate|tnltxpktsrate|double|Rate (/s) counter for tnltottxpkts
        TunnelTotalTransmitBytes|tnltottxbytes|string|Total number of bytes received on the tunnel.
        TunnelTransmitBytesRate|tnltxbytesrate|double|Rate (/s) counter for tnltotrxbytes
        TunnelTotalReceiveBytes|tnltotrxbytes|string|Total number of bytes transmitted on the tunnel.
        TunnelReceiveBytesRate|tnlrxbytesrate|double|Rate (/s) counter for tnltottxbytes



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<TunnelIpStatCommand>(INitroServiceClient, New TunnelIpStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object RNatIpStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:tunnelip, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For TunnelIpStat, that object is <u>TunnelIpStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - TunnelIpStatistics: a TunnelIpStats-object-array returned by the Get-Request, containing the properties mentioned above.



#### TunnelIp6

+ Get
    * Properties  

        The following properties can be found in the TunnelIp6Stats-objects-array inside of a TunnelIp6StatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        TunnelIp6|tunnelip|string|remote IP address of the configured tunnel.
        TunnelTotalReceivePackets|tnltotrxpkts|string|Total number of packets received on the tunnel.
        TunnelReceivePacketsRate|tnlrxpktsrate|double|Rate (/s) counter for tnltotrxpkts
        TunnelTotalTransmitPackets|tnltottxpkts|string|Total number of packets transmitted on the tunnel.
        TunnelTransmitPacketsRate|tnltxpktsrate|double|Rate (/s) counter for tnltottxpkts
        TunnelTotalTransmitBytes|tnltottxbytes|string|Total number of bytes received on the tunnel.
        TunnelTransmitBytesRate|tnltxbytesrate|double|Rate (/s) counter for tnltotrxbytes
        TunnelTotalReceiveBytes|tnltotrxbytes|string|Total number of bytes transmitted on the tunnel.
        TunnelReceiveBytesRate|tnlrxbytesrate|double|Rate (/s) counter for tnltottxbytes



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<TunnelIp6StatCommand>(INitroServiceClient, New TunnelIp6StatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object TunnelIp6StatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:tunnelip6, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For TunnelIp6Stat, that object is <u>TunnelIp6StatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - TunnelIp6Statistics: a TunnelIp6Stats-object-array returned by the Get-Request, containing the properties mentioned above.






#### Vlan

+ Get
    * Properties  

        The following properties van be found in each VlanStats found in the array "VlanStatistics" inside of a VlanStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Id|id|string|An integer specifying the VLAN identification number (VID). Possible values: 1 through 4094.
        VlanTotalReceivePackets|vlantotrxpkts|string|Packets received on the VLAN.
        VlanReceivePacketsRate|vlanrxpktsrate|double|Rate (/s) counter for vlantotrxpkts
        VlanTotalReceiveBytes|vlantotrxbytes|string|Bytes of data received on the VLAN.
        VlanReceiveBytesRate|vlanrxbytesrate|double|Rate (/s) counter for vlantotrxbytes
        VlanTotalTransmitPackets|vlantottxpkts|string|Packets transmitted on the VLAN.
        VlanTransmitPacketsRate|vlantxpktsrate|double|Rate (/s) counter for vlantottxpkts
        VlanTotalTransmitBytes|vlantottxbytes|string|Bytes of data transmitted on the VLAN.
        VlanTransmitBytesRate|vlantxbytesrate|double|Rate (/s) counter for vlantottxbytes
        VlanTotalDroppedPackets|vlantotaldroppedpkts|string|Inbound packets dropped by the VLAN upon reception.
        VlanTotalBroadcastPackets|vlantotbroadcastpkts|double|Broadcast packets sent and received on the VLAN.



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<VlanStatCommand>(INitroServiceClient, New VlanStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object InterfaceStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For VlanStat, that object is <u>VlanStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - VlanStatistics: an array of VlanStats-objects returned by the Get-Request, all of which contain the properties mentioned above.



#### Vxlan

+ Get
    * Properties  

        The following properties can be found in the VxlanStats-objects-array inside of a VxlanStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Id|id|string|An integer specifying the VXLAN identification number (VNID).
        VxlanReceiveBytesRate|vxlanrxbytesrate|double|Rate (/s) counter for vxlantotrxbytes
        VxlanTotalTransmitPackets|vxlantottxpkts|string|Packets transmitted on the VXLAN.
        VxlanReceivePacketsRate|vxlanrxpktsrate|double|Rate (/s) counter for vxlantotrxpkts
        VxlanTotalReceiveBytes|vxlantotrxbytes|string|Bytes of data received on the VXLAN.
        VxlanTransmitBytesRate|vxlantxbytesrate|double|Rate (/s) counter for vxlantottxbytes
        VxlanTransmitPacketsRate|vxlantxpktsrate|double|Rate (/s) counter for vxlantottxpkts
        VxlanTotalTransmitBytes|vxlantottxbytes|string|Bytes of data transmitted on the VXLAN.
        VxlanTotalReceivePackets|vxlantotrxpkts|string|Packets received on the VXLAN.



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<VxlanStatCommand>(INitroServiceClient, New VxlanStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object VxlanStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  <b>(not applicable to this request)</b>
        <u>ResourceFilter</u>: No effect on this resource  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria. <b>(not applicable to this request)</b>  
        <u>Arguments</u>: a dictionary<string, string> that holds specific possible arguments, these are(even if a bool or double is required, they will be passed as string (so true => "true")):  
            - key:id, value: string
            - key:detail, value: bool  
            - key:fullvalues, value: bool  
            - key:ntimes, value: double  
            - key:logfile, value: string  
            - key:clearstats, value: string  
        

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For VxlanStat, that object is <u>VxlanStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - VxlanStatistics: a VxlanStats-object-array returned by the Get-Request, containing the properties mentioned above.


