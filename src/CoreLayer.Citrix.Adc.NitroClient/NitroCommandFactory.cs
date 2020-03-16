using System;
using System.Linq;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public static class NitroCommandFactory
    {
         private static string GetConfigurationApiNamespace(string commandNamespace)
        {
            return commandNamespace.Replace("Commands", "Api");
        }

        private static string GetConfigurationTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "RequestConfiguration");
        }

        private static string GetConfigurationDataRootTypeName(string commandNamespace)
        {
            return commandNamespace.Replace("Command", "RequestDataRoot");
        }
        
        private static INitroRequestConfiguration GetTargetConfigurationInstance(Type type)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetConfigurationTypeName = GetConfigurationTypeName(type.Name);

            var targetConfigurationType = Type.GetType(requestNameSpace + "." + targetConfigurationTypeName);
            var targetConfigurationInstance = (INitroRequestConfiguration) Activator.CreateInstance(targetConfigurationType);

            return targetConfigurationInstance;
        }

        private static INitroRequestConfiguration GetTargetConfigurationInstance(Type type,
            INitroRequestDataRoot dataRoot)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetConfigurationTypeName = GetConfigurationTypeName(type.Name);

            var targetConfigurationType = Type.GetType(requestNameSpace + "." + targetConfigurationTypeName);
            var targetConfigurationInstance = (INitroRequestConfiguration) Activator.CreateInstance(targetConfigurationType, dataRoot);

            return targetConfigurationInstance;
        }

        private static INitroRequestDataRoot GetTargetConfigurationDataRootInstance(Type type, INitroRequestData data)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetRequestDataRootTypeName = GetConfigurationDataRootTypeName(type.Name);
            var targetRequestDataRootType =
                Type.GetType(requestNameSpace + "." + targetRequestDataRootTypeName);
            
            // TODO Exception handling
            var targetDataRootInstance = (INitroRequestDataRoot) Activator.CreateInstance(targetRequestDataRootType, new object[]{ data});

            return targetDataRootInstance;
        }

        private static INitroRequestDataRoot GetTargetConfigurationDataRootInstance(Type type, dynamic[] data)
        {
            var requestNameSpace = GetConfigurationApiNamespace(type.Namespace);
            var targetRequestDataRootTypeName = GetConfigurationDataRootTypeName(type.Name);
            var targetRequestDataRootType =
                Type.GetType(requestNameSpace + "." + targetRequestDataRootTypeName);
            
            // TODO Exception handling
            var targetDataRootInstance = (INitroRequestDataRoot) Activator.CreateInstance(targetRequestDataRootType, new object[]{ data});

            return targetDataRootInstance;
        }

        private static dynamic GetTargetCommandInstance(Type type, INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration)
        {
            return Activator.CreateInstance(type, new object[]{httpClient, requestConfiguration});
        }
        
        public static T Create<T>(INitroHttpClient httpClient)
        {
            return GetTargetCommandInstance(
                typeof(T), 
                httpClient, 
                GetTargetConfigurationInstance(typeof(T)));
        }

        public static T Create<T>(INitroHttpClient httpClient, INitroRequestOptions options)
        {
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T));
            targetConfigurationInstance.Options = options;

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
        }

        public static T Create<T>(INitroHttpClient httpClient, INitroRequestData data)
        {
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
        }

        public static T Create<T>(INitroHttpClient httpClient, INitroRequestData[] dataList)
        {
            dynamic[] data = dataList.Cast<dynamic>().ToArray();
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
            
        }

        public static T Create<T>(INitroHttpClient httpClient, INitroRequestData data, INitroRequestOptions options)
        {
            var targetDataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);
            var targetConfigurationInstance = GetTargetConfigurationInstance(typeof(T), targetDataRoot);
            targetConfigurationInstance.Options = options;
            
            //targetConfigurationInstance.DataRoot = GetTargetConfigurationDataRootInstance(typeof(T), data);

            return GetTargetCommandInstance(
                typeof(T),
                httpClient,
                targetConfigurationInstance);
        }
    }
}