# CoreLayer.Citrix.Adc.Nitro

## Quick-start Guide  

The basic usage of NitroClient is to create and run commands, and get the response of the ADC to the command you ran.   
Creating the will look something like this:  

            var command = NitroCommandFactory.Create<YourCommand>(<YourClient>);  

You will notice 2 required parameters still to be specified. \<YourCommand> is where you would enter any of the pre-made commands (eg. ServerGetCommand, LbvserverAddCommand,...). \<YourClient> is an instance of the NitroServiceClient, which will hold the information specific to your connection. The client requires another 3 objects to be initialized: credentials in the form of NitroLoginRequestData, connectionsettings in the form of NitroServiceConnectionSettings, and NitroHttpClientCertificateValidation set to enabled or disabled. Creating these and the client would look something like this:


            var credentials = new NitroLoginRequestData("username", "password");

            var connectionSettings = new NitroServiceConnectionSettings(<YourUri>,
            3600, NitroServiceConnectionAuthenticationMethod.AutomaticHeaderInjection);

            var client = new NitroServiceClient(credentials, connectionSettings, NitroHttpClientCertificateValidation.<enabled/disabled_value>);  
As You can see, NitroLoginRequestData only requires your username and password, while NitroServiceConnectionSettings requires 3 parameters.  
- \<YourUri> : The Uri pointing to your citrix ADC.
- TimeOut: TimeOut in seconds.
- NitroServiceConnectionAuthenticationMethod: the authentication method, choice of: AutomaticHeaderInjection, AutomaticLogin and ManualLogin.   

The extra parameter NitroHttpClientCertificateValidation determines wether or not to validate the certificate. Setting this to Disabled is only advised when you are certain you trust what you are connecting to. 



Once your client is made, you can start making commands with it. The most straightforward command to make would be a GET(ALL) command, because it needs no extra information.  
eg.

            var command = NitroCommandFactory.Create<LbvserverGetCommand>(client);

When your command is made, executing it and getting the response is as simple as calling the GetResponse()-method on it, which will return a response-object containing all the information you asked for.  

            var response = command.GetResponse();

The response-item will now hold all information of the response. Common data that will be stored for a response on any kind of command includes:  
- ErrorCode: The errorcode if your command couldnt be run. (refer to the citrix documentation for a more in-depth list).
- StatusCode: SatusCode of the command.
- Message: Message accompanying the statuscode or errorcode.
- Severity: Severity of the error, if any.  

The Last part of the response will be different for every command. In out case, we made an LbvserverGetCommand. Which results in the data requested being stored in an LbvserverConfiguration[ ] named Lbvservers. As such, getting eg. the name of the first lbvserver in our response would look like this:  

            var name = response.Lbvservers[0].Name;



Ofcourse, some commands require more information. For example, you might want to add an Lbvserver, in which case you would have to add information on the specifications of the Lbvserver to add. The options of which data to change and add are stored in objects named in the line of "\<subject>AddRequestData". In some cases it is that simple (eg. SslProfileAddRequestData), but for some we decided to splitt them up further to prevent passing incorrect data. As such, adding an Lbvserver requires you to use a pre-made object (eg. LbvserverAddHttpRequestData, LbvserverAddTcpRequestData, ...) with properties applicable to the configuration specified on the object name. Lets use LbvserverAddHttpRequestData as an example.  

            var data = new LbvserverAddHttpRequestData("<lbvserverName>"){
                Port = 1234
            }

Making a new object of this type will require you to name it as a required parameter. Inside the {  }, all the properties you can access are the applicable parameters for a lbvserver with a Http serviceType(we used Port here as an example).  

When the data-object is made, you simply pass it to the command along with the client when making it.  
eg.

            var command = NitroCommandFactory.Create<LbvserverAddCommand>(client, data);

You can then run GetResponse( ) to run the command and get e reply from the ADC about your command.  
eg.

            var response = command.GetResponse();

            //Console.WriteLine(response.StatusCode);