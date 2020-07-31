using System;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Bot
{
    public class BotStats
    {
        [JsonPropertyName("botrequests")]public string BotRequests { get; set; }    
        [JsonPropertyName("botrequestsrate")]public double? BotRequestsRate { get; set; }    
        [JsonPropertyName("botreqbytes")]public string BotRequestBytes { get; set; }    
        [JsonPropertyName("botreqbytesrate")]public double? BotRequestBytesRate { get; set; }    
        [JsonPropertyName("botresponses")]public string BotResponses { get; set; }    
        [JsonPropertyName("botresponsesrate")]public double? BotResponsesRate { get; set; }    
        [JsonPropertyName("botresbytes")]public string BotResponseBytes { get; set; }    
        [JsonPropertyName("botresbytesrate")]public double? BotResponseBytesRate { get; set; }    
        [JsonPropertyName("botvioldevicefingerprint")]public string BotViolationsDeviceFingerprint { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintrate")]public double? BotViolationsDeviceFingerprintRate { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintlog")]public string BotViolationsDeviceFingerprintLog { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintlograte")]public double? BotViolationsDeviceFingerprintLogRate { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintdrop")]public string BotViolationsDeviceFingerprintDrop { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintdroprate")]public double? BotViolationsDeviceFingerprintDropRate { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintredirect")]public string BotViolationsDeviceFingerprintRedirect { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintredirectrate")]public double? BotViolationsDeviceFingerprintRedirectRate { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintcaptcha")]public string BotViolationsDeviceFingerprintCaptcha { get; set; }    
        [JsonPropertyName("botvioldevicefingerprintcaptcharate")]public double? BotViolationsDeviceFingerprintCaptchaRate { get; set; }    
        [JsonPropertyName("botviolipreputation")]public string BotViolationIpReputation { get; set; }    
        [JsonPropertyName("botviolipreputationrate")]public double? BotViolationIpReputationRate { get; set; }    
        [JsonPropertyName("botviolipreputationlog")]public string BotViolationIpReputationLog { get; set; }    
        [JsonPropertyName("botviolipreputationlograte")]public double? BotViolationIpReputationLogRate { get; set; }    
        [JsonPropertyName("botviolipreputationdrop")]public string BotViolationIpReputationDrop { get; set; }    
        [JsonPropertyName("botviolipreputationdroprate")]public double? BotViolationIpReputationDropRate { get; set; }    
        [JsonPropertyName("botviolipreputationredirect")]public string BotViolationIpReputationRedirect { get; set; }    
        [JsonPropertyName("botviolipreputationredirectrate")]public double? BotViolationIpReputationRedirectRate { get; set; }    
        [JsonPropertyName("botviolipreputationcaptcha")]public string BotViolationIpReputationCaptcha { get; set; }    
        [JsonPropertyName("botviolipreputationcaptcharate")]public double? BotViolationIpReputationCaptchaRate { get; set; }    
        [JsonPropertyName("botviolwhitelist")]public string BotViolationWhitelist { get; set; }    
        [JsonPropertyName("botviolwhitelistrate")]public double? BotViolationWhitelistRate { get; set; }    
        [JsonPropertyName("botviolwhitelistlog")]public string BotViolationWhitelistLog { get; set; }    
        [JsonPropertyName("botviolwhitelistlograte")]public double? BotViolationWhitelistLogRate { get; set; }    
        [JsonPropertyName("botviolblacklist")]public string BotViolationBlacklist { get; set; }    
        [JsonPropertyName("botviolblacklistrate")]public double? BotViolationBlacklistRate { get; set; }    
        [JsonPropertyName("botviolblacklistlog")]public string BotViolationBlacklistLog { get; set; }    
        [JsonPropertyName("botviolblacklistlograte")]public double? BotViolationBlacklistLogRate { get; set; }    
        [JsonPropertyName("botviolblacklistdrop")]public string BotViolationBlacklistDrop { get; set; }    
        [JsonPropertyName("botviolblacklistdroprate")]public double? BotViolationBlacklistDropRate { get; set; }    
        [JsonPropertyName("botviolblacklistredirect")]public string BotViolationBlacklistRedirect { get; set; }    
        [JsonPropertyName("botviolblacklistredirectrate")]public double? BotViolationBlacklistRedirectRate { get; set; }    
        [JsonPropertyName("botviolratelimit")]public string BotViolationRateLimit { get; set; }    
        [JsonPropertyName("botviolratelimitrate")]public double? BotViolationRateLimitRate { get; set; }    
        [JsonPropertyName("botviolratelimitlog")]public string BotViolationRateLimitLog { get; set; }    
        [JsonPropertyName("botviolratelimitlograte")]public double? BotViolationRateLimitLogRate { get; set; }    
        [JsonPropertyName("botviolratelimitdrop")]public string BotViolationRateLimitDrop { get; set; }    
        [JsonPropertyName("botviolratelimitdroprate")]public double? BotViolationRateLimitDropRate { get; set; }    
        [JsonPropertyName("botviolratelimitredirect")]public string BotViolationRateLimitRedirect { get; set; }    
        [JsonPropertyName("botviolratelimitredirectrate")]public double? BotViolationRateLimitRedirectRate { get; set; }    
        [JsonPropertyName("botviolstaticsignature")]public string BotViolationStaticSignature { get; set; }    
        [JsonPropertyName("botviolstaticsignaturerate")]public double? BotViolationStaticSignatureRate { get; set; }    
        [JsonPropertyName("botviolstaticsignaturelog")]public string BotViolationStaticSignatureLog { get; set; }    
        [JsonPropertyName("botviolstaticsignaturelograte")]public double? BotViolationStaticSignatureLogRate { get; set; }    
        [JsonPropertyName("botviolstaticsignaturedrop")]public string BotViolationStaticSignatureDrop { get; set; }    
        [JsonPropertyName("botviolstaticsignaturedroprate")]public double? BotViolationStaticSignatureDropRate { get; set; }    
        [JsonPropertyName("botviolstaticsignatureredirect")]public string BotViolationStaticSignatureRedirect { get; set; }    
        [JsonPropertyName("botviolstaticsignatureredirectrate")]public double? BotViolationStaticSignatureRedirectRate { get; set; }
    }
}