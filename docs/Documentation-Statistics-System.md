### System

#### System

+ Get
    * Properties  

        The following properties van be found in each SystemStats found in the array "SystemStatistics" inside of a SystemStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        VoltageNegative12VOutput|voltagev12n|double|Power supply -12V output. Acceptable range is -13.20 through -10.80 volts. 9800 and 9960 platforms display standard value of -12.0V.
        VoltageNegative5VOutput|voltagev5n|double|Power supply -5V output. Acceptable range is -5.50 through -4.50 volts. 9800 and 9960 platforms display standard value of -5.0V.
        CpuUsage|cpuusage|string|CPU utilization percentage.
        AverageCpuUsage|rescpuusage|string|Shows average CPU utilization percentage if more than 1 CPU is present.
        SecondaryCpuUsage|slavecpuusage|string|CPU 1 (currently the slave CPU) utilization, as percentage of capacity. Not applicable for a single-CPU system.
        PrimaryCpuUsage|mastercpuusage|string|CPU 0 (currently the master CPU) utilization, as percentage of capacity.
        AuxiliaryVoltagePin7|auxvolt7|double|Voltage of a device connected to health monitoring chip through pin 7.
        AuxiliaryVoltagePin6|auxvolt6|double|Voltage of a device connected to health monitoring chip through pin 6.
        AuxiliaryVoltagePin5|auxvolt5|double|Voltage of a device connected to health monitoring chip through pin 5.
        AuxiliaryVoltagePin4|auxvolt4|double|Voltage of a device connected to health monitoring chip through pin 4.
        AuxiliaryVoltagePin3|auxvolt3|double|Voltage of a device connected to health monitoring chip through pin 3.
        AuxiliaryVoltagePin2|auxvolt2|double|Voltage of a device connected to health monitoring chip through pin 2.
        AuxiliaryVoltagePin1|auxvolt1|double|Voltage of a device connected to health monitoring chip through pin 1.
        AuxiliaryVoltagePin0|auxvolt0|double|Voltage of a device connected to health monitoring chip through pin 0.
        VoltageSensor2Input|voltagevsen2|double|Voltage Sensor 2 Input. Currently only 13k Platforms will have valid value for this counter and for older platforms this will be 0.
        VoltageV5Standby|voltagev5sb|double|Power Supply 5V Standby Voltage. Currently only 13k Platforms will have valid value for this counter and for older platforms this will be 0.
        VoltageVtt|voltagevtt|double|Intel CPU Vtt power. Currently only 13k Platforms will have valid value for this counter and for older platforms this will be 0.
        VoltageVBatteryOutput|voltagevbat|double|Onboard battery power supply output. 9800 and 9950 platforms display standard value of 5.0V.
        VoltagePositive12VOutput|voltagev12p|double|Power supply +12V output. Acceptable range is 10.80 through 13.20 volts.
        VoltagePositive5VOutput|voltagev5p|double|Power supply +5V output. Acceptable range is 4.50 through 5.50 volts.
        VoltageV33Standby|voltagev33stby|double|Standby power supply +3.3V output. Acceptable range is 2.970 through 3.630 volts. 9800 and 9960 platforms display standard value of 3.3V. You can configure Standby 3.3V Supply Voltage by using the Set snmp alarm VOLTAGE-LOW command to set the lower limit and the Set snmp alarm VOLTAGE-HIGH command to set the upper limit.
        VoltageV33Main|voltagev33main|double|Main power supply +3.3V output. Acceptable range is 2.970 through 3.630 volts. This is a critical counter. You can configure Main 3.3V Supply Voltage, by using the Set snmp alarm VOLTAGE-LOW command to set the lower limit and the Set snmp alarm VOLTAGE-HIGH command to set the upper limit.
        VoltageVCpuCore1|voltagevcc1|double|CPU core 1 voltage. Acceptable range is 1.080 through 1.650 volts. If CPU 1 is not connected to the health monitoring chip, display shows voltage of CPU 0.
        VoltageVCpuCore0|voltagevcc0|double|CPU core 0 voltage. Acceptable range is 1.080 through 1.650 volts.
        NumberOfCpus|numcpus|string|The number of CPUs on the Citrix ADC.
        MemoryUsagePercent|memusagepcnt|double|Percentage of memory utilization on Citrix ADC.
        MemoryUseInMb|memuseinmb|string|Main memory currently in use, in megabytes.
        AdditionalManagementCpuUsagePercent|addimgmtcpuusagepcnt|double|Additonal Management CPU utilization percentage.
        ManagementCpu0UsagePercent|mgmtcpu0usagepcnt|double|Management CPU-0 utilization percentage.
        ManagementAverageCpuUsagePercent|mgmtcpuusagepcnt|double|Average Management CPU utilization percentage.
        PacketEngineAverageCpuUsagePercent|pktcpuusagepcnt|double|Average CPU utilization percentage for all packet engines excluding management PE.
        CpuUsagePercent|cpuusagepcnt|double|CPU utilization percentage.
        AverageCpuUsagePercent|rescpuusagepcnt|double|Average CPU utilization percentage. Not applicable for a single-CPU system.
        StartTimeLocal|starttimelocal|string|Time (in local timezone format) when the Citrix ADC was last started.
        StartTime|starttime|string|Time when the Citrix ADC was last started.
        Disk0PercentUsage|disk0perusage|double|Used space in /flash partition of the disk, as a percentage. This is a critical counter. You can configure /flash Used (%) by using the Set snmp alarm DISK-USAGE-HIGH command.
        Disk1PercentUsage|disk1perusage|double|	Used space in /var partition of the disk, as a percentage. This is a critical counter. You can configure /var Used (%) by using the Set snmp alarm DISK-USAGE-HIGH command.
        CpuFan0Speed|cpufan0speed|double|CPU Fan 0 speed. Acceptable range is 3000 through 6000 RPM. This is a critical counter. You can configure CPU Fan 0 Speed by using the Set snmp alarm FAN-SPEED-LOW command to set the lower limit.
        CpuFan1Speed|cpufan1speed|double|CPU Fan 1 speed. Acceptable range is 3000 through 6000 RPM. 7000 platform displays speed of CPU fan 0. This is a critical counter. You can configure CPU Fan 1 Speed by using the Set snmp alarm FAN-SPEED-LOW command to set the lower limit.
        SystemFanSpeed|systemfanspeed|double|	System fan speed. Acceptable range is 3000 through 6000 RPM. This is a critical counter. You can configure System Fan Speed by using the Set snmp alarm FAN-SPEED-LOW command to set the lower limit.
        Fan0Speed|fan0speed|double|System fan 1 speed. For new platforms associated pin is connected to CPU supporting fans. For platforms in which it is not connected, it will point to System Fan.
        FanSpeed|fanspeed|double|System fan 2 speed. For new platforms associated pin is connected to CPU supporting fans. For platforms in which it is not connected, it will point to System Fan
        Cpu0Temperature|cpu0temp|double|CPU 0 temperature. 9800 and 9960 platforms display internal chip temperature. This is a critical counter. You can configure CPU 0 Temperature by using the Set snmp alarm TEMPERATURE-HIGH command to set the upper limit.
        Cpu1Temperature|cpu1temp|double|CPU 1 temperature. 9800 and 9960 platforms display internal chip temperature. 7000, 9010 and 10010 platforms display CPU 0 temperature. This is a critical counter. You can configure CPU 1 Temperature by using the Set snmp alarm TEMPERATURE-HIGH command to set the upper limit.
        InternalTemperature|internaltemp|double|Internal temperature of health monitoring chip. This is a critical counter. You can configure Internal Temperature by using the Set snmp alarm TEMPERATURE-HIGH command to set the upper limit.
        PowerSupply1Status|powersupply1status|string|Power supply 1 failure status.
        PowerSupply2Status|powersupply2status|string|Power supply 2 failure status.
        PowerSupply3Status|powersupply3status|string|Power supply 3 failure status.
        PowerSupply4Status|powersupply4status|string|Power supply 4 failure status.
        Disk0Size|disk0size|double|Size of /flash partition of the hard disk.
        Disk0Used|disk0used|double|Used space in /flash partition of the hard disk.
        Disk0Available|disk0avail|double|Available space in /flash partition of the hard disk.
        Disk1Size|disk1size|double|Size of /var partition of the hard disk.
        Disk1Used|disk1used|double|Used space in /var partition of the hard disk.
        Disk1Available|disk1avail|double|Available space in /var partition of the hard disk.
        Fan2Speed|fan2speed|double|Speed of Fan 0 if associated pin is connected to health monitoring chip.
        Fan3Speed|fan3speed|double|Speed of Fan 1 if associated pin is connected to health monitoring chip.
        Fan4Speed|fan4speed|double|Speed of Fan 2 if associated pin is connected to health monitoring chip.
        Fan5Speed|fan5speed|double|Speed of Fan 3 if associated pin is connected to health monitoring chip.
        AuxiliaryTemperaturePin0|auxtemp0|double|Temperature of a device connected to health monitoring chip through pin 0.
        AuxiliaryTemperaturePin1|auxtemp1|double|Temperature of a device connected to health monitoring chip through pin 1.
        AuxiliaryTemperaturePin2|auxtemp2|double|	Temperature of a device connected to health monitoring chip through pin 2.
        AuxiliaryTemperaturePin3|auxtemp3|double|Temperature of a device connected to health monitoring chip through pin 3.
        TimeSinceStart|timesincestart|string|Seconds since the Citrix ADC started.
        MemorySizeMb|memsizemb|string|Total amount of system memory, in megabytes.



    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemStatCommand>(INitroServiceClient, New SystemStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object SystemStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemStat, that object is <u>SystemStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemStatistics: an array of SystemStats-objects returned by the Get-Request, all of which contain the properties mentioned above.



#### SystemBw

+ Get
    * Properties  

        The following properties van be found in SystemBwStats "SystemBwStatistics" inside of a SystemBwStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        HttpClientPoolInactive|httpcltpoolinactive|string|No of requests sent from BW client.
        HttpClientPoolOutactive|httpcltpooloutactive|string|No of responses Received.
        HttpServer200OkResponse|httpsvr200okresp|string|Number of 200 Ok response sent from the BW appliance.
        HttpServer200OkResponseRate|httpsvr200okresprate|double|Rate (/s) counter for httpsvr200okresp
        HttpServer404NotFound|httpsvr404notfound|string|Number of 404 Not Found responses sent
        HttpServer404NotFoundRate|httpsvr404notfoundrate|double|Rate (/s) counter for httpsvr404notfound
        HttpClientErrorStray|httpclterrstray|string|Number of stray packets received from server without HTTP request
        HttpClientErrorStrayRate|httpclterrstrayrate|double|Rate (/s) counter for httpclterrstray
        HttpClientTtfpLwmFailures|httpcltttfplwm|string|Number of Responses Falling on LWM for TTFP.
        HttpCltTtfpLwmFailuresRate|httpcltttfplwmrate|double|Rate (/s) counter for httpcltttfplwm
        HttpClientTtfpBand0Failures|httpcltttfp_0|string|Number of Responses Falling on Band-0 for TTFP.
        HttpClientTtfpBand0FailuresRate|httpcltttfp_0rate|double|Rate (/s) counter for httpcltttfp_0
        HttpClientTtfpBand1Failures|httpcltttfp_1|string|Number of Responses Falling on Band-1 for TTFP.
        HttpClientTtfpBand1FailuresRate|httpcltttfp_1rate|double|Rate (/s) counter for httpcltttfp_1
        HttpClientTtfpBand2Failures|httpcltttfp_2|string|Number of Responses Falling on Band-2 for TTFP.
        HttpClientTtfpBand2FailuresRate|httpcltttfp_2rate|double|Rate (/s) counter for httpcltttfp_2
        HttpClientTtfpBand3Failures|httpcltttfp_3|string|Number of Responses Falling on Band-3 for TTFP.
        HttpClientTtfpBand3FailuresRate|httpcltttfp_3rate|double|Rate (/s) counter for httpcltttfp_3
        HttpClientTtfpBand4Failures|httpcltttfp_4|string|Number of Responses Falling on Band-4 for TTFP.
        HttpClientTtfpBand4FailuresRate|httpcltttfp_4rate|double|Rate (/s) counter for httpcltttfp_4
        HttpClientTtfpBand5Failures|httpcltttfp_5|string|Number of Responses Falling on Band-5 for TTFP.
        HttpClientTtfpBand5FailuresRate|httpcltttfp_5rate|double|Rate (/s) counter for httpcltttfp_5
        HttpClientTtfpBand6Failures|httpcltttfp_6|string|Number of Responses Falling on Band-6 for TTFP.
        HttpClientTtfpBand6FailuresRate|httpcltttfp_6rate|double|Rate (/s) counter for httpcltttfp_6
        HttpClientTtfpBand7Failures|httpcltttfp_7|string|Number of Responses Falling on Band-7 for TTFP.
        HttpClientTtfpBand7FailuresRate|httpcltttfp_7rate|double|Rate (/s) counter for httpcltttfp_7
        HttpClientTtfpHwmFailures|httpcltttfphwm|string|Number of Responses Falling on HWM for TTFP.
        HttpClientTtfpHwmFailuresRate|httpcltttfphwmrate|double|Rate (/s) counter for httpcltttfphwm
        HttpClientTtfpMax|httpcltttfpmax|string|Peak RTT observed for Time to First response packet.
        HttpClientTtlpLwmFailures|httpcltttlplwm|string|Number of Responses Falling on LWM for TTLP.
        HttpClientTtlpLwmFailuresRate|httpcltttlplwmrate|double|Rate (/s) counter for httpcltttlplwm
        HttpCltTtlpBand0Failures|httpcltttlp_0|string|Number of Responses Falling on Band-0 for TTLP.
        HttpClientTtlpBand0Failuresrate|httpcltttlp_0rate|double|Rate (/s) counter for httpcltttlp_0
        HttpClientTtlpBand1Failures|httpcltttlp_1|string|Number of Responses Falling on Band-1 for TTLP.
        HttpClientTtlpBand1FailuresRate|httpcltttlp_1rate|double|Rate (/s) counter for httpcltttlp_1
        HttpClientTtlpBand2Failures|httpcltttlp_2|string|Number of Responses Falling on Band-2 for TTLP.
        HttpClientTtlpBand2FailuresRate|httpcltttlp_2rate|double|Rate (/s) counter for httpcltttlp_2
        HttpClientTtlpBand3Failures|httpcltttlp_3|string|Number of Responses Falling on Band-3 for TTLP.
        HttpClientTtlpBand3FailuresRate|httpcltttlp_3rate|double|Rate (/s) counter for httpcltttlp_3
        HttpClientTtlpBand4Failures|httpcltttlp_4|string|Number of Responses Falling on Band-4 for TTLP.
        HttpClientTtlpBand4FailuresRate|httpcltttlp_4rate|double|Rate (/s) counter for httpcltttlp_4
        HttpClientTtlpBand5Failures|httpcltttlp_5|string|Number of Responses Falling on Band-5 for TTLP.
        HttpClientTtlpBand5FailuresRate|httpcltttlp_5rate|double|Rate (/s) counter for httpcltttlp_5
        HttpClientTtlpBand6Failures|httpcltttlp_6|string|Number of Responses Falling on Band-6 for TTLP.
        HttpClientTtlpBand6FailuresRate|httpcltttlp_6rate|double|Rate (/s) counter for httpcltttlp_6
        HttpClientTtlpBand7Failures|httpcltttlp_7|string|Number of Responses Falling on Band-7 for TTLP.
        HttpClientTtlpBand7FailuresRate|httpcltttlp_7rate|double|Rate (/s) counter for httpcltttlp_7
        HttpClientTtlpHwmFailures|httpcltttlphwm|string|Number of Responses Falling on HWM for TTLP.
        HttpClientTtlpHwmRate|httpcltttlphwmrate|double|Rate (/s) counter for httpcltttlphwm
        HttpClientTtlpMax|httpcltttlpmax|string|Peak RTT observed for Time to Last response packet.




    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemBwCommand>(INitroServiceClient, New SystemBwStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object SystemBwRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemBwStat, that object is <u>SystemBwResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemBwStats: an array of SystemBwStats-objects returned by the Get-Request, all of which contain the properties mentioned above.


#### SystemCpu

+ Get
    * Properties  

        The following properties van be found in each SystemCpuStats found in the array "SystemCpuStatistics" inside of a SystemCpuStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        Id|id|string|ID of the CPU for which to display statistics.
        CpuUsagePercent|percpuuse|string|CPU utilization percentage.


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemCpuStatCommand>(INitroServiceClient, New SystemCpuStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object SystemCpuStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemCpuStat, that object is <u>SystemCpuStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemCpuStatistics: an array of SystemCpuStats-objects returned by the Get-Request, all of which contain the properties mentioned above.



#### SystemMemory

+ Get
    * Properties  

        The following properties van be found in each SystemMemoryStats found in the array "SystemMemoryStatistics" inside of a SystemCpuStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        CacheMemoryMaxMemoryLimitPercent|cacmemmaxmemlimitpcnt|double|Integrated Cache memory insue percent.
        CacheMemoryMaxMemoryLimit|cacmemmaxmemlimit|string|Integrated Cache memory insue, in megabytes.
        SharedMemoryAllocationFailed|shmemerrallocfailed|string|Total shared memory allocation failed.
        SharedMemoryAllocationPercent|shmemallocpcnt|double|Shared memory insue percent.
        SharedMemoryAllocatedInMb|shmemallocinmb|string|Shared memory insue, in megabytes.
        SharedMemoryTotalInMb|shmemtotinmb|string|Total shared memory allowed to allocate, in megabytes.
        MemoryTotalAllocatedFailed|memtotallocfailed|string|Total system memory allocation failed.
        MemoryTotalFree|memtotfree|string|Total Free PE Memory in the System.
        MemoryUsagePercent|memusagepcnt|double|	Percentage of memory utilization on Citrix ADC.
        MemoryTotalUseInMb|memtotuseinmb|string|Total Citrix ADC Memory in use, in megabytes.
        MemoryTotalAllocatedPercent|memtotallocpcnt|double|Currently allocated memory in percent.
        MemoryTotalAllocatedMb|memtotuseinmb|string|Currently allocated memory, in megabytes.
        MemoryTotalInMb|memtotinmb|string|Total memory available (grabbed) for use by packet engine (PE), in megabytes.
        MemoryTotalAvailable|memtotavail|string|Total system memory available for PE to grab from the system.
        CacheMemoryMaxSystemLimitMb|cacmemmaxsyslimitmb|string|Integrated Cache memory, in megabytes.


    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SystemMemoryStatCommand>(INitroServiceClient, New SystemMemoryStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object SystemMemoryStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SystemMemoryStat, that object is <u>SystemMemoryStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SystemMemoryStatistics: an array of SystemMemoryStats-objects returned by the Get-Request, all of which contain the properties mentioned above.
