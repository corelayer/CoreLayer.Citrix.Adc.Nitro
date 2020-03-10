using System;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;
using FluentValidation;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public class NitroRequestConfigurationValidator<T> 
        : AbstractValidator<T> 
        where T: INitroRequestConfiguration
    {

        public NitroRequestConfigurationValidator()
        {
            RuleForEach(x => x.Options.PropertyFilter)
                .IsEnumName(GetNitroRequestOptionsPropertiesTypeName(typeof(T)), false);
            RuleForEach(x => x.Options.ResourceFilter.Keys)
                .IsEnumName(GetNitroRequestOptionsPropertiesTypeName(typeof(T)), false);
        }

        public static Type GetNitroRequestOptionsPropertiesTypeName(Type inputType)
        {
            var targetType = inputType.Name.Replace("Configuration", "OptionsProperties");
            return Type.GetType(inputType.Namespace + "." + targetType);
        }
    }
}