### Network

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