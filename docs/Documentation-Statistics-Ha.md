### Ha

#### HaNode

+ Get
    * Properties  

        The following properties van be found in each HaNodeStats found in the array HaNodeStats" inside of a HaNodeStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        HighAvailabilityCurrentStatus|hacurstatus|string|Whether a Citrix ADC is configured for high availability. Possible values are YES and NO. If the value is NO, the high availability statistics below are invalid.
        HighAvailabilityCurrentState|hacurstate|string|State of the HA node, based on its health, in a high availability setup. Possible values are: UP - Indicates that the node is accessible and can function as either a primary or secondary node. DISABLED - Indicates that the high availability status of the node has been manually disabled. Synchronization and propagation cannot take place between the peer nodes. INIT - Indicates that the node is in the process of becoming part of the high availability configuration. PARTIALFAIL - Indicates that one of the high availability monitored interfaces has failed because of a card or link failure. This state triggers a failover. COMPLETEFAIL - Indicates that all the interfaces of the node are unusable, because the interfaces on which high availability monitoring is enabled are not connected or are manually disabled. This state triggers a failover. DUMB - Indicates that the node is in listening mode. It does not participate in high availability transitions or transfer configuration from the peer node. This is a configured value, not a statistic. PARTIALFAILSSL - Indicates that the SSL card has failed. This state triggers a failover. ROUTEMONITORFAIL - Indicates that the route monitor has failed. This state triggers a failover.
        HighAvailabilityCurrentPrimaryState|hacurmasterstate|string|Indicates the high availability state of the node. Possible values are: STAYSECONDARY - Indicates that the selected node remains the secondary node in a high availability setup. In this case a forced failover does not change the state but, instead, returns an appropriate error message. This is a configured value and not a statistic. PRIMARY - Indicates that the selected node is the primary node in a high availability setup. SECONDARY - Indicates that the selected node is the secondary node in a high availability setup. CLAIMING - Indicates that the secondary node is in the process of taking over as the primary node. This is the intermediate state in the transition of the secondary node to primary status. FORCE CHANGE - Indicates that the secondary node is forcibly changing its status to primary due to a forced failover issued on the secondary node.
        LastTransitionTime|transtime|string|Time when the last master state transition occurred. You can use this statistic for debugging.
        HighAvailabilityTotalPacketReceive|hatotpktrx|string|Number of heartbeat packets received from the peer node. Heartbeats are sent at regular intervals (default is 200 milliseconds) to determine the state of the peer node.
        HighAvailabilityPacketReceiveRate|hapktrxrate|double|Rate (/s) counter for hatotpktrx
        HighAvailabilityTotalPacketTransmit|hatotpkttx|string|Number of heartbeat packets sent to the peer node. Heartbeats are sent at regular intervals (default is 200 milliseconds) to determine the state of the peer node.
        HighAvailabilityPacketTransmitRate|hapkttxrate|double|Rate (/s) counter for hatotpkttx
        HighAvailabilityErrorSyncFailure|haerrsyncfailure|string|Number of times the configuration of the primary and secondary nodes failed to synchronize since that last transition. A synchronization failure results in mismatched configuration. It can be caused by a mismatch in the Remote Procedural Call (RPC) password on the two nodes forming the high availability pair.
        HighAvailabilityErrorPropagationTimedOut|haerrproptimeout|string|Number of times propagation timed out.



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<HaNodeStatCommand>(INitroServiceClient, New HaNodeStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object LbvserverStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For LbvserverStat, that object is <u>LbvStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - HaNodeStats: an array of HaNodeStats-objects returned by the Get-Request, all of which contain the properties mentioned above.
