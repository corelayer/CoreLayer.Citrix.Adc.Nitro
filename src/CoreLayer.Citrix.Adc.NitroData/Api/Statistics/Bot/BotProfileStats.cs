using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot
{
    public class BotProfileStats
    {
        public string Name { get; set; }
        [JsonPropertyName("botvioldevicefingerprintlogprofile")]public string BotViolationDeviceFingerprintLogProfile { get; set; }
        [JsonPropertyName("botvioldevicefingerprintlogprofilerate")]public double? BotViolationDeviceFingerPrintLogProfileRate { get; set; }
        [JsonPropertyName("botvioldevicefingerprintredirectprofile")]public string BotViolationDeviceFingerPrintRedirectProfile { get; set; }
        [JsonPropertyName("botvioldevicefingerprintredirectprofilerate")]public double? BotViolationDeviceFingerPrintRedirectProfileRate { get; set; }
        [JsonPropertyName("botviolipreputationlogprofile")]public string BotViolationIpReputationLogProfile { get; set; }
        [JsonPropertyName("botviolipreputationlogprofilerate")]public double? BotViolationIpReputationLogProfileRate { get; set; }
        [JsonPropertyName("botviolipreputationredirectprofile")]public string BotViolationIpReputationRedirectProfile { get; set; }
        [JsonPropertyName("botviolipreputationredirectprofilerate")]public double? BotViolationIpReputationRedirectProfileRate { get; set; }
        [JsonPropertyName("botviolstaticsignaturedropprofile")]public string BotViolationStaticSignatureDropProfile { get; set; }
        [JsonPropertyName("botviolstaticsignaturedropprofilerate")]public double? BotViolationStaticSignatureDropProfileRate { get; set; }
        [JsonPropertyName("botviolblacklistlogprofile")]public string BotViolationBlacklistLogProfile { get; set; }
        [JsonPropertyName("botviolblacklistlogprofilerate")]public double? BotViolationBlacklistLogProfileRate { get; set; }
        [JsonPropertyName("botviolratelimitlogprofile")]public string BotViolationRateLimitLogProfile { get; set; }
        [JsonPropertyName("botviolratelimitlogprofilerate")]public double? BotViolationRateLimitLogProfileRate { get; set; }
        [JsonPropertyName("botviolstaticsignatureprofile")]public string BotViolationStaticSignatureProfile { get; set; }
        [JsonPropertyName("botviolstaticsignatureprofilerate")]public double? BotViolationStaticSignatureProfileRate { get; set; }
        [JsonPropertyName("botviolblacklistredirectprofile")]public string BotViolationBlacklistRedirectProfile { get; set; }
        [JsonPropertyName("botviolblacklistredirectprofilerate")]public double? BotViolationBlacklistRedirectProfileRate { get; set; }
        [JsonPropertyName("botviolratelimitprofile")]public string BotViolationRateLimitProfile { get; set; }
        [JsonPropertyName("botviolratelimitprofilerate")]public double? BotViolationRateLimitProfileRate { get; set; }
        [JsonPropertyName("botviolblacklistdropprofile")]public string BotViolationBlacklistDropProfile { get; set; }
        [JsonPropertyName("botviolblacklistdropprofilerate")]public double? BotViolationBlacklistDropProfileRate { get; set; }
        [JsonPropertyName("botviolipreputationprofile")]public string BotViolationIpReputationProfile { get; set; }
        [JsonPropertyName("botviolipreputationprofilerate")]public double? BotViolationIpReputationProfileRate { get; set; }
        [JsonPropertyName("botviolstaticsignaturelogprofile")]public string BotViolationStaticSignatureLogProfile { get; set; }
        [JsonPropertyName("botviolstaticsignaturelogprofilerate")]public double? BotViolationStaticSignatureLogProfileRate { get; set; }
        [JsonPropertyName("botvioldevicefingerprintdropprofile")]public string BotViolationDeviceFingerprintDropProfile { get; set; }
        [JsonPropertyName("botvioldevicefingerprintdropprofilerate")]public double? BotViolationDeviceFingerprintDropProfileRate { get; set; }
        [JsonPropertyName("botviolblacklistprofile")]public string BotViolationBlacklistProfile { get; set; }
        [JsonPropertyName("botviolblacklistprofilerate")]public double? BotViolationBlacklistProfileRate { get; set; }
        [JsonPropertyName("botviolipreputationdropprofile")]public string BotViolationIpReputationDropProfile { get; set; }
        [JsonPropertyName("botviolipreputationdropprofilerate")]public double? BotViolationIpReputationDropProfileRate { get; set; }
        [JsonPropertyName("botresponsesperprofile")]public string BotResponsesPerProfile { get; set; }
        [JsonPropertyName("botresponsesperprofilerate")]public double? BotResponsesPerProfileRate { get; set; }
        [JsonPropertyName("botviolstaticsignatureredirectprofile")]public string BotViolationStaticSignatureRedirectProfile { get; set; }
        [JsonPropertyName("botviolstaticsignatureredirectprofilerate")]public double? BotViolationStaticSignatureRedirectProfileRate { get; set; }
        [JsonPropertyName("botvioldevicefingerprintprofile")]public string BotViolationDeviceFingerprintProfile { get; set; }
        [JsonPropertyName("botvioldevicefingerprintprofilerate")]public double? BotViolationDeviceFingerprintProfileRate { get; set; }
        [JsonPropertyName("botresbytesperprofile")]public string BotResponseBytesPerProfile { get; set; }
        [JsonPropertyName("botresbytesperprofilerate")]public double? BotResponseBytesPerProfileRate { get; set; }
        [JsonPropertyName("botviolratelimitdropprofile")]public string BotViolationRateLimitDropProfile { get; set; }
        [JsonPropertyName("botviolratelimitdropprofilerate")]public double? BotViolationRateLimitDropProfileRate { get; set; }
        [JsonPropertyName("botrequestsperprofile")]public string BotRequestsPerProfile { get; set; }
        [JsonPropertyName("botrequestsperprofilerate")]public double? BotRequestsPerProfileRate { get; set; }
        [JsonPropertyName("botviolwhitelistprofile")]public string BotViolationWhitelistProfile { get; set; }
        [JsonPropertyName("botviolwhitelistprofilerate")]public double? BotViolationWhitelistProfileRate { get; set; }
        [JsonPropertyName("botviolratelimitredirectprofile")]public string BotViolationRateLimitRedirectProfile { get; set; }
        [JsonPropertyName("botviolratelimitredirectprofilerate")]public double? BotViolationRateLimitRedirectProfileRate { get; set; }
        [JsonPropertyName("botreqbytesperprofile")]public string BotRequestBytesPerProfile { get; set; }
        [JsonPropertyName("botreqbytesperprofilerate")]public double? BotRequestBytesPerProfileRate { get; set; }
        [JsonPropertyName("botviolwhitelistlogprofile")]public string BotViolationWhitelistLogProfile { get; set; }
        [JsonPropertyName("botviolwhitelistlogprofilerate")]public double? BotViolationWhitelistLogProfileRate { get; set; }
    
    }
}