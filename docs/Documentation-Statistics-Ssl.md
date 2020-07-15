### Ssl

#### Ssl

+ Get
    * Properties  

        The following properties van be found in each SslStats found in the array "SslStatistics" inside of a SslStatResponse.

        Property|Citrix doc name|DataType|Description
        ---|---|---|---
        SslTotalHardwareBytesDecryptedBackEndSecondary|ssltothwdecbesecondary|string|Number of bytes decrypted on the back-end in hardware on secondary card.
        SslHardwareBytesDecryptedBackEndSecondaryRate|sslhwdecbesecondaryrate|double|Rate (/s) counter for ssltothwdecbesecondary
        SslTotalHardwareBytesDecryptedFrontEndSecondary|ssltothwdecfesecondary|string|Number of bytes decrypted on the front-end in hardware on secondary card.
        SslHardwareBytesDecryptedFrontEndSecondaryRate|sslhwdecfesecondaryrate|double|Rate (/s) counter for ssltothwdecfesecondary
        SslTotalHardwareBytesEncryptedBackEndSecondary|ssltothwencbesecondary|string|Number of bytes encrypted on the back-end in hardware on secondary card.
        SslHardwareBytesEncryptedBackEndSecondaryRate|sslhwencbesecondaryrate|double|Rate (/s) counter for ssltothwencbesecondary
        SslTotalHardwareBytesEncryptedFrontEndSecondary|ssltothwencfesecondary|string|Number of bytes encrypted on the front-end in hardware on secondary card.
        SslHardwareBytesEncryptedFrontEndSecondaryRate|sslhwencfesecondaryrate|double|Rate (/s) counter for ssltothwencfesecondary
        SslTotalBytesDecryptedHardwareSecondary|ssltotdechwsecondary|string|Number of bytes decrypted in hardware on secondary card.
        SslBytesDecryptedHardwareSecondaryRate|ssldechwsecondaryrate|double|Rate (/s) counter for ssltotdechwsecondary
        SslTotalBytesEncryptedHardwareSecondary|ssltotenchwsecondary|string|Number of bytes encrypted in hardware on secondary card.
        SslBytesEncryptedHardwareSecondaryRate|sslenchwsecondaryrate|double|Rate (/s) counter for ssltotenchwsecondary
        SslCryptoUtilizationSymmetricStat|sslcryptoutilizationsymmstat|string|Utilization of the hardware symmetric crypto resource. Only valid values are 0-100%. Only works on platforms with Intel crypto chips.
        SslCryptoUtilizationAsymmetricStat|sslcryptoutilizationasymstat|string|Utilization of the hardware asymmetric crypto resource. Only valid values are 0-100%. Only works on platforms with Intel crypto chips.
        SslCryptoUtilizationStat|sslcryptoutilizationstat2nd|double|Utilization of the hardware crypto resource. Only valid values are 0-100%. Only works on N3FIPS+N3 hybrid platform.
        SslCryptoUtilizationStatNitrox|sslcryptoutilizationstat|double|Utilization of the hardware crypto resource. Only valid values are 0-100%. Only works on platforms with Nitrox-3 chips.
        SslNumberOfCardsUpSecondary|sslnumcardsupsecondary|string|Number of Add on SSL cards that are UP.
        SslCardsSecondary|sslcardssecondary|string|Number of secondary SSL crypto cards present on the Citrix ADC.
        SslNumberOfCardsUp|sslnumcardsup|string|Number of SSL cards that are UP. If the number of cards UP is lower than a threshold, a failover is initiated.
        SslCardStatus|sslcardstatus|string|Status of the SSL card(s). The value should be interpreted in binary form, with each set bit indicates a card as UP.
        SslCards|sslcards|string|Number of SSL crypto cards present on the Citrix ADC.
        SslEngineStatus|sslenginestatus|string|State of the SSL Engine (1=UP/0=DOWN). This state is decided based on SSL Feature/License status and minimum number of cards UP.
        SslTotalSessions|ssltotsessions|string|Number of SSL sessions on the Citrix ADC.
        SslSessionsRate|sslsessionsrate|double|Rate (/s) counter for ssltotsessions
        SslTotalTransactions|ssltottransactions|string|Number of SSL transactions on the Citrix ADC
        SslTransactionsRate|ssltransactionsrate|double|Rate (/s) counter for ssltottransactions
        SslTotalSslV2Transactions|ssltotsslv2transactions|string|Number of SSLv2 transactions on the Citrix ADC.
        SslSslV2TransactionsRate|sslsslv2transactionsrate|double|Rate (/s) counter for ssltotsslv2transactions
        SslTotalSslV3Transactions|ssltotsslv3transactions|string|Total number of SSLv3 transactions on the Citrix ADC.
        SslSslV3TransactionsRate|sslsslv3transactionsrate|double|Rate (/s) counter for ssltotsslv3transactions
        SslTotalTlsV1Transactions|ssltottlsv1transactions|string|Number of TLSv1 transactions on the Citrix ADC.
        SslTlsV1TransactionsRate|ssltlsv1transactionsrate|double|Rate (/s) counter for ssltottlsv1transactions
        SslTotalTlsV11Transactions|ssltottlsv11transactions|string|Number of TLSv1.1 transactions on the Citrix ADC.
        SslTlsV11TransactionsRate|ssltlsv11transactionsrate|double|Rate (/s) counter for ssltottlsv11transactions
        SslTotalTlsV12Transactions|ssltottlsv12transactions|string|Number of TLSv1.2 transactions on the Citrix ADC.
        SslTlsV12TransactionsRate|ssltlsv12transactionsrate|double|Rate (/s) counter for ssltottlsv12transactions
        SslTotalTlsV13Transactions|ssltottlsv13transactions|string|Number of TLSv1.3 transactions on the Citrix ADC.
        SslTlsV13TransactionsRate|ssltlsv13transactionsrate|double|Rate (/s) counter for ssltottlsv13transactions
        SslTotalDtlsV1Transactions|ssltotdtlsv1transactions|string|Number of DTLSv1 transactions on the Citrix ADC.
        SslDtlsV1TransactionsRate|ssldtlsv1transactionsrate|double|Rate (/s) counter for ssltotdtlsv1transactions
        SslTotalDtlsV12Transactions|ssltotdtlsv12transactions|string|Number of DTLSv1.2 transactions on the Citrix ADC.
        SslDtlsV12TransactionsRate|ssldtlsv12transactionsrate|double|	Rate (/s) counter for ssltotdtlsv12transactions
        SslTotalSslV2Sessions|ssltotsslv2sessions|string|Number of SSLv2 sessions on the Citrix ADC.
        SslSslV2SessionsRate|sslsslv2sessionsrate|double|Rate (/s) counter for ssltotsslv2sessions
        SslTotalSslV3Sessions|ssltotsslv3sessions|string|Number of SSLv3 sessions on the Citrix ADC.
        SslSslV3SessionsRate|sslsslv3sessionsrate|double|Rate (/s) counter for ssltotsslv3sessions
        SslTotalTlsV1Sessions|ssltottlsv1sessions|string|Number of TLSv1 sessions on the Citrix ADC.
        SslTlsV1SessionsRate|ssltlsv1sessionsrate|double|Rate (/s) counter for ssltottlsv1sessions
        SslTotalTlsV11Sessions|ssltottlsv11sessions|string|Number of TLSv1.1 sessions on the Citrix ADC.
        SslTlsV11SessionsRate|ssltlsv11sessionsrate|double|Rate (/s) counter for ssltottlsv11sessions
        SslTotalTlsV12Sessions|ssltottlsv12sessions|string|Number of TLSv1.2 sessions on the Citrix ADC.
        SslTlsV12SessionsRate|ssltlsv12sessionsrate|double|Rate (/s) counter for ssltottlsv12sessions
        SslTotalTlsV13Sessions|ssltottlsv13sessions|string|Number of TLSv1.3 sessions on the Citrix ADC.
        SslTlsV13SessionsRate|ssltlsv13sessionsrate|double|Rate (/s) counter for ssltottlsv13sessions
        SslTotalDtlsV1Sessions|ssltotdtlsv1sessions|string|Number of DTLSv1 sessions on the Citrix ADC.
        SslDtlsV1SessionsRate|ssldtlsv1sessionsrate|double|Rate (/s) counter for ssltotdtlsv1sessions
        SslTotalDtlsV12Sessions|ssltotdtlsv12sessions|string|Number of DTLSv1.2 sessions on the Citrix ADC.
        SslDtlsV12SessionsRate|ssldtlsv12sessionsrate|double|	Rate (/s) counter for ssltotdtlsv12sessions
        SslTotalNewSessions|ssltotnewsessions|string|Number of new SSL sessions created on the Citrix ADC.
        SslNewSessionsRate|sslnewsessionsrate|double|Rate (/s) counter for ssltotnewsessions
        SslTotalSessionMisses|ssltotsessionmiss|string|Number of SSL session reuse misses on the Citrix ADC.
        SslSessionMissesRate|sslsessionmissrate|double|Rate (/s) counter for ssltotsessionmiss
        SslTotalSessionHits|ssltotsessionhits|string|Number of SSL session reuse hits on the Citrix ADC.
        SslSessionHitsRate|sslsessionhitsrate|double|Rate (/s) counter for ssltotsessionhits
        SslBackendTotalSessions|sslbetotsessions|string|Number of back-end SSL sessions on the Citrix ADC.
        SslBackendSessionsRate|sslbesessionsrate|double|Rate (/s) counter for sslbetotsessions
        SslBackendTotalSslV3Sessions|sslbetotsslv3sessions|string|Number of back-end SSLv3 sessions on the Citrix ADC.
        SslBackendSslV3SessionsRate|sslbesslv3sessionsrate|double|Rate (/s) counter for sslbetotsslv3sessions
        SslBackendTotalTlsV1Sessions|sslbetottlsv1sessions|string|Number of back-end TLSv1 sessions on the Citrix ADC.
        SslBackendTlsV1SessionsRate|sslbetlsv1sessionsrate|double|Rate (/s) counter for sslbetottlsv1sessions
        SslBackendTotalTlsV11Sessions|sslbetottlsv11sessions|string|Number of back-end TLSv1.1 sessions on the Citrix ADC.
        SslBackendTlsV11SessionsRate|sslbetlsv11sessionsrate|double|Rate (/s) counter for sslbetottlsv11sessions
        SslBackendTotalTlsV12Sessions|sslbetottlsv12sessions|string|Number of back-end TLSv1.2 sessions on the Citrix ADC.
        SslBackendTlsV12SessionsRate|sslbetlsv12sessionsrate|double|Rate (/s) counter for sslbetottlsv12sessions
        SslBackendTotalDtlsV1Sessions|sslbetotdtlsv1sessions|string|Number of back-end DTLSv1 sessions on the Citrix ADC.
        SslBackendDtlsV1SessionsRate|sslbedtlsv1sessionsrate|double|Rate (/s) counter for sslbetotdtlsv1sessions
        SslBackendTotalSessionMultiplexAttempts|sslbetotsessionmultiplexattempts|string|Number of back-end SSL session multiplex attempts on the Citrix ADC.
        SslBackendSessionMultiplexAttemptsRate|sslbesessionmultiplexattemptsrate|double|Rate (/s) counter for sslbetotsessionmultiplexattempts
        SslBackendTotalSessionMultiplexAttemptSuccess|sslbetotsessionmultiplexattemptsucces|string|Number of back-end SSL session multiplex successes on the Citrix ADC.
        SslBackendSessionMultiplexAttemptSuccessRate|sslbesessionmultiplexattemptsuccesrate|double|Rate (/s) counter for sslbetotsessionmultiplexattemptsuccess
        SslBackendTotalSessionMultiplexAttemptFails|sslbetotsessionmultiplexattemptfails|string|Number of back-end SSL session multiplex failures on the Citrix ADC.
        SslBackendSessionMultiplexAttemptFailsRate|sslbesessionmultiplexattemptfailsrate|double|Rate (/s) counter for sslbetotsessionmultiplexattemptfails
        SslTotalEncryptedBytes|ssltotenc|string|Number of bytes encrypted on the Citrix ADC.
        SslEncryptedBytesRate|sslencrate|double|Rate (/s) counter for ssltotenc
        SslTotalDecryptedBytes|ssltotdec|string|Number of bytes decrypted on the Citrix ADC.
        SslDecryptedBytesRate|ssldecrate|double|Rate (/s) counter for ssltotdec
        SslTotalSslServerInRecords|ssltotsslserverinrecords|string|Number server in record on the Citrix ADC.
        SslSslServerInRecordsRate|sslsslserverinrecordsrate|double|Rate (/s) counter for ssltotsslserverinrecords
        SslTotalRenegotiatedSessions|ssltotrenegsessions|string|Number of SSL session renegotiations on the Citrix ADC.
        SslRenegotiatedSessionsRate|sslrenegsessionsrate|double|Rate (/s) counter for ssltotrenegsessions
        SslTotalSslV3RenegotiatedSessions|ssltotsslv3renegsessions|string|Number of session renegotiations done on SSLv3.
        SslSslV3RenegotiatedSessionsRate|sslsslv3renegsessionsrate|double|Rate (/s) counter for ssltotsslv3renegsessions
        SslTotalTlsV1RenegotiatedSessions|ssltottlsv1renegsessions|string|Number of SSL session renegotiations done on TLSv1.
        SslTlsV1RenegotiatedSessionsRate|ssltlsv1renegsessionsrate|double|Rate (/s) counter for ssltottlsv1renegsessions
        SslTotalTlsV11RenegotiatedSessions|ssltottlsv11renegsessions|string|Number of SSL session renegotiations done on TLSv1.1.
        SslTlsV11RenegotiatedSessionsRate|ssltlsv11renegsessionsrate|double|Rate (/s) counter for ssltottlsv11renegsessions
        SslTotalTlsV12RenegotiatedSessions|ssltottlsv12renegsessions|string|Number of SSL session renegotiations done on TLSv1.2.
        SslTlsV12RenegotiatedSessionsRate|ssltlsv12renegsessionsrate|double|Rate (/s) counter for ssltottlsv12renegsessions
        SslTotalDtlsV1RenegotiatedSessions|ssltotdtlsv1renegsessions|string|Number of SSL session renegotiations done on DTLSv1.
        SslDtlsV1RenegotiatedSessionsRate|ssldtlsv1renegsessionsrate|double|Rate (/s) counter for ssltotdtlsv1renegsessions
        SslTotalDtlsV12RenegotiatedSessions|ssltotdtlsv12renegsessions|string|Number of SSL session renegotiations done on DTLSv1.2.
        SslDtlsV12RenegotiatedSessionsRate|ssldtlsv12renegsessionsrate|double|Rate (/s) counter for ssltotdtlsv12renegsessions
        SslTotalRsa512KeyExchanges|ssltotrsa512keyexchanges|string|Number of RSA 512-bit key exchanges on the Citrix ADC.
        SslRsa512KeyExchangesRate|sslrsa512keyexchangesrate|double|Rate (/s) counter for ssltotrsa512keyexchanges
        SslTotalRsa1024KeyExchanges|ssltotrsa1024keyexchanges|string|Number of RSA 1024-bit key exchanges on the Citrix ADC.
        SslRsa1024KeyExchangesRate|sslrsa1024keyexchangesrate|double|Rate (/s) counter for ssltotrsa1024keyexchanges
        SslTotalRsa2048KeyExchanges|ssltotrsa2048keyexchanges|string|Number of RSA 2048-bit key exchanges on the Citrix ADC.
        SslRsa2048KeyExchangesRate|sslrsa2048keyexchangesrate|double|Rate (/s) counter for ssltotrsa2048keyexchanges
        SslTotalRsa3072KeyExchanges|ssltotrsa3072keyexchanges|string|Number of RSA 3072-bit key exchanges on the Citrix ADC.
        SslRsa3072KeyExchangesRate|sslrsa3072keyexchangesrate|double|Rate (/s) counter for ssltotrsa3072keyexchanges
        SslTotalRsa4096KeyExchanges|ssltotrsa4096keyexchanges|string|Number of RSA 4096-bit key exchanges on the Citrix ADC.
        SslRsa4096KeyExchangesRate|sslrsa4096keyexchangesrate|double|Rate (/s) counter for ssltotrsa4096keyexchanges
        SslTotalDh512KeyExchanges|ssltotdh512keyexchanges|string|Number of Diffie-Helman 512-bit key exchanges on the Citrix ADC.
        SslDh512KeyExchangesRate|ssldh512keyexchangesrate|double|Rate (/s) counter for ssltotdh512keyexchanges
        SslTotalDh1024KeyExchanges|ssltotdh1024keyexchanges|string|Number of Diffie-Helman 1024-bit key exchanges on the Citrix ADC.
        SslDh1024KeyExchangesRate|ssldh1024keyexchangesrate|double|Rate (/s) counter for ssltotdh1024keyexchanges
        SslTotalDh2048KeyExchanges|ssltotdh2048keyexchanges|string|Number of Diffie-Helman 2048-bit key exchanges on the Citrix ADC.
        SslDh2048KeyExchangesRate|ssldh2048keyexchangesrate|double|Rate (/s) counter for ssltotdh2048keyexchanges
        SslTotalDh4096KeyExchanges|ssltotdh4096keyexchanges|string|Number of Diffie-Helman 4096-bit key exchanges on the Citrix ADC.
        SslDh4096KeyExchangesRate|ssldh4096keyexchangesrate|double|Rate (/s) counter for ssltotdh4096keyexchanges
        SslTotalEcdhe521KeyExchanges|ssltotecdhe521keyexchanges|string|Number of 521 Elliptical Curve Diffie-Helman on the Citrix ADC.
        SslEcdhe521KeyExchangesRate|sslecdhe512keyexchangesrate|double|Rate (/s) counter for ssltotecdhe521keyexchanges
        SslTotalEcdhe384KeyExchanges|ssltotecdhe384keyexchanges|string|Number of 384 Elliptical Curve Diffie-Helman on the Citrix ADC.
        SslEcdhe384KeyExchangesRate|sslecdhe384keyexchangesrate|double|Rate (/s) counter for ssltotecdhe384keyexchanges
        SslTotalEcdhe256KeyExchanges|ssltotecdhe256keyexchanges|string|Number of 256 Elliptical Curve Diffie-Helman on the Citrix ADC.
        SslEcdhe256KeyExchangesRate|sslecdhe256keyexchangesrate|double|Rate (/s) counter for ssltotecdhe256keyexchanges
        SslTotalEcdhe224KeyExchanges|ssltotecdhe224keyexchanges|string|Number of 224 Elliptical Curve Diffie-Helman on the Citrix ADC.
        SslEcdhe224KeyExchangesRate|sslecdhe224keyexchangesrate|double|Rate (/s) counter for ssltotecdhe224keyexchanges
        SslTotalEcdheTransactions|ssltotecdhetransactions|string|Total ECDHE Transactions on Citrix ADC.
        SslEcdheTransactionsRate|sslecdhetransactionsrate|double|Rate (/s) counter for ssltotecdhetransactions
        SslTotal40BitRc4Ciphers|ssltot40bitrc4ciphers|string|Number of RC4 40-bit cipher encryptions on the Citrix ADC.
        Ssl40BitRc4CiphersRate|ssl40bitrc4ciphersrate|double|Rate (/s) counter for ssltot40bitrc4ciphers
        SslTotal56BitRc4Ciphers|ssltot56bitrc4ciphers|string|Number of RC4 56-bit cipher encryptions on the Citrix ADC.
        Ssl56BitRc4CiphersRate|ssl56bitrc4ciphersrate|double|Rate (/s) counter for ssltot56bitrc4ciphers
        SslTotal64BitRc4Ciphers|ssltot64bitrc4ciphers|string|Number of RC4 64-bit cipher encryptions on the Citrix ADC.
        Ssl64BitRc4CiphersRate|ssl64bitrc4ciphersrate|double|Rate (/s) counter for ssltot64bitrc4ciphers
        SslTotal128BitRc4Ciphers|ssltot128bitrc4ciphers|string|Number of RC4 128-bit cipher encryptions on the Citrix ADC.
        Ssl128BitRc4CiphersRate|ssl128bitrc4ciphersrate|double|Rate (/s) counter for ssltot128bitrc4ciphers
        SslTotal40BitDesCiphers|ssltot40bitdesciphers|string|Number of DES 40-bit cipher encryptions on the Citrix ADC.
        Ssl40BitDesCiphersRate|ssl40bitdesciphersrate|double|Rate (/s) counter for ssltot40bitdesciphers
        SslTotal56BitDesCiphers|ssltot56bitdesciphers|string|Number of DES 56-bit cipher encryptions on the Citrix ADC.
        Ssl56BitDesCiphersRate|ssl56bitdesciphersrate|double|Rate (/s) counter for ssltot56bitdesciphers
        SslTotal168Bit3DesCiphers|ssltot168bit3desciphers|string|Number of DES 168-bit cipher encryptions on the Citrix ADC.
        Ssl168Bit3DesCiphersRate|ssl168bit3dexciphersrate|double|Rate (/s) counter for ssltot168bit3desciphers
        SslTotalCipherAes128|ssltotcipheraes128|string|Number of AES 128-bit cipher encryptions on the Citrix ADC.
        SslCipherAes128Rate|sslcipheraes128rate|double|Rate (/s) counter for ssltotcipheraes128
        SslTotalCipherAes256|ssltotcipheraes256|string|Number of AES 256-bit cipher encryptions on the Citrix ADC.
        SslCipherAes256Rate|sslcipheraes256rate|double|Rate (/s) counter for ssltotcipheraes256
        SslTotal40BitRc2Ciphers|ssltot40bitrc2ciphers|string|Number of RC2 40-bit cipher encryptions on the Citrix ADC.
        Ssl40BitRc2CiphersRate|ssl40bitrc2ciphersrate|double|Rate (/s) counter for ssltot40bitrc2ciphers
        SslTotal56BitRc2Ciphers|ssltot56bitrc2ciphers|string|Number of RC2 56-bit cipher encryptions on the Citrix ADC.
        Ssl56BitRc2CiphersRate|ssl56bitrc2ciphersrate|double|Rate (/s) counter for ssltot56bitrc2ciphers
        SslTotal128BitRc2Ciphers|ssltot128bitrc2ciphers|string|Number of RC2 128-bit cipher encryptions on the Citrix ADC.
        Ssl128BitRc2CiphersRate|ssl128bitrc2ciphersrate|double|Rate (/s) counter for ssltot128bitrc2ciphers
        SslTotal128BitAesGcmCiphers|ssltot128bitaesgcmciphers|string|Number of AEC-GCM 128-bit cipher encryptions on the Citrix ADC.
        Ssl128BitAesGcmCiphersRate|ssl128bitaesgcmciphersrate|double|Rate (/s) counter for ssltot128bitaesgcmciphers
        SslTotal256BitAesGcmCiphers|ssltot256bitaesgcmciphers|string|Number of AEC-GCM 256-bit cipher encryptions on the Citrix ADC.
        Ssl256BitAesGcmCiphersRate|ssl256bitaesgcmciphersrate|double|Rate (/s) counter for ssltot256bitaesgcmciphers
        SslTotalNullCiphers|ssltotnullciphers|string|Number of Null cipher encryptions on the Citrix ADC.
        SslNullCiphersRate|sslnullciphersrate|double|Rate (/s) counter for ssltotnullciphers
        SslTotalMd5Mac|ssltotmd5mac|string|Number of MD5 hashes on the Citrix ADC.
        SslMd5MacRate|sslmd5macrate|double|Rate (/s) counter for ssltotmd5mac
        SslTotalShaMac|ssltotshamac|string|Number of SHA hashes on the Citrix ADC.
        SslShaMacRate|sslshamacrate|double|Rate (/s) counter for ssltotshamac
        SslTotalSha256Mac|ssltotsha256mac|string|Number of SHA256 hashes on the Citrix ADC.
        SslSha256MacRate|sslsha256macrate|double|Rate (/s) counter for ssltotsha256mac
        SslTotalSha384Mac|ssltotsha384mac|string|Number of SHA384 hashes on the Citrix ADC.
        SslSha384MacRate|sslsha384macrate|double|Rate (/s) counter for ssltotsha384mac
        SslTotalSslV2Handshakes|sshtotsslv2handshakes|string|Number of handshakes on SSLv2 on the Citrix ADC.
        SslSslV2HandshakesRate|sslsslv2handshakesrate|double|Rate (/s) counter for ssltotsslv2handshakes
        SslTotalSslV3Handshakes|ssltotsslv3handshakes|string|Number of handshakes on SSLv3 on the Citrix ADC.
        SslSslV3HandshakesRate|sslsslv3handshakesrate|double|Rate (/s) counter for ssltotsslv3handshakes
        SslTotalTlsV1Handshakes|ssltottlsv1handshakes|string|Number of SSL handshakes on TLSv1 on the Citrix ADC.
        SslTlsV1HandshakesRate|ssltlsv1handshakesrate|double|Rate (/s) counter for ssltottlsv1handshakes
        SslTotalTlsV11Handshakes|ssltottlsv11handshakes|string|Number of SSL handshakes on TLSv1.1 on the Citrix ADC.
        SslTlsV11HandshakesRate|ssltlsv11handshakesrate|double|Rate (/s) counter for ssltottlsv11handshakes
        SslTotalTlsV12Handshakes|ssltottlsv12handshakes|string|Number of SSL handshakes on TLSv1.2 on the Citrix ADC.
        SslTlsV12HandshakesRate|ssltlsv12handshakesrate|double|Rate (/s) counter for ssltottlsv12handshakes
        SslTotalTlsV13Handshakes|ssltottlsv13handshakes|string|Number of SSL handshakes on TLSv1.3 on the Citrix ADC.
        SslTlsV13HandshakesRate|ssltlsv13handshakesrate|double|Rate (/s) counter for ssltottlsv13handshakes
        SslTotalDtlsV1Handshakes|ssltotdtlsv1handshakes|string|Number of SSL handshakes on DTLSv1 on the Citrix ADC.
        SslDtlsV1HandshakesRate|ssldtlsv1handshakesrate|double|Rate (/s) counter for ssltotdtlsv1handshakes
        SslTotalDtlsV12Handshakes|ssltotdtlsv12handshakes|string|Number of SSL handshakes on DTLSv1.2 on the Citrix ADC.
        SslDtlsV12HandshakesRate|ssldtlsv12handshakesrate|double|Rate (/s) counter for ssltotdtlsv12handshakes
        SslTotalSslV2ClientAuthentications|ssltotsslv2clientauthentications|string|Number of client authentications done on SSLv2.
        SslSslV2ClientAuthenticationsRate|sslsslv2clientauthenticationsrate|double|Rate (/s) counter for ssltotsslv2clientauthentications
        SslTotalSslV3ClientAuthentications|ssltotsslv3clientauthentications|string|Number of client authentications done on SSLv3.
        SslSslV3ClientAuthenticationsRate|sslsslv3clientauthenticationsrate|double|Rate (/s) counter for ssltotsslv3clientauthentications
        SslTotalTlsV1ClientAuthentications|ssltottlsv1clientauthentications|string|Number of client authentications done on TLSv1.
        SslTlsV1ClientAuthenticationsRate|ssltlsv1clientauthenticationsrate|double|Rate (/s) counter for ssltottlsv1clientauthentications
        SslTotalTlsV11ClientAuthentications|ssltottlsv11clientauthentications|string|Number of client authentications done on TLSv1.1.
        SslTlsV11ClientAuthenticationsRate|ssltlsv11clientauthenticationsrate|double|Rate (/s) counter for ssltottlsv11clientauthentications
        SslTotalTlsV12ClientAuthentications|ssltottlsv12clientauthentications|string|Number of client authentications done on TLSv1.2.
        SslTlsV12ClientAuthenticationsRate|ssltlsv12clientauthenticationsrate|double|Rate (/s) counter for ssltottlsv12clientauthentications
        SslTotalTlsV13ClientAuthentications|ssltottlsv13clientauthentications|string|Number of client authentications done on TLSv1.3.
        SslTlsV13ClientAuthenticationsRate|ssltlsv13clientauthenticationsrate|double|Rate (/s) counter for ssltottlsv13clientauthentications
        SslTotalDtlsV1ClientAuthentications|ssltotdtlsv1clientauthentications|string|Number of client authentications done on DTLSv1.
        SslDtlsV1ClientAuthenticationsRate|ssldtlsv1clientauthenticationsrate|double|Rate (/s) counter for ssltotdtlsv1clientauthentications
        SslTotalDtlsV12ClientAuthentications|ssltotdtlsv12clientauthentications|string|Number of client authentications done on DTLSv1.2.
        SslDtlsV12ClientAuthenticationsRate|ssldtlsv12clientauthenticationsrate|double|Rate (/s) counter for ssltotdtlsv12clientauthentications
        SslTotalRsaAuthorizations|ssltotrsaauthorizations|string|Number of RSA authentications on the Citrix ADC.
        SslRsaAuthorizationsRate|sslrsaauthorizationsrate|double|Rate (/s) counter for ssltotrsaauthorizations
        SslTotalDhAuthorizations|ssltotdhauthorizations|string|Number of Diffie-Helman authentications on the Citrix ADC.
        SslDhAuthorizationsRate|ssldhauthorizationsrate|double|Rate (/s) counter for ssltotdhauthorizations
        SslTotalDssAuthorizations|ssltotdssauthorizations|string|Total number of times DSS authorization is used on the Citrix ADC.
        SslDssAuthorizationsRate|ssldssauthorizationsrate|double|Rate (/s) counter for ssltotdssauthorizations
        SslTotalEcdsaAuthorizations|ssltotecdsaauthorizations|string|Total number of times ECDSA authorization is used on the Citrix ADC.
        SslEcdsaAuthorizationsRate|sslecdsaauthorizationsrate|double|Rate (/s) counter for ssltotecdsaauthorizations
        SslTotalNullAuthorizations|ssltotnullauthorizations|string|Number of Null authentications on the Citrix ADC.
        SslNullAuthorizationsRate|sslnullauthorizationsrate|double|Rate (/s) counter for ssltotnullauthorizations
        SslTotalBackendSessionRenegotiate|ssltotbkendsessionrenegotiate|string|Number of back-end SSL session renegotiations on the Citrix ADC.
        SslBackendSessionRenegotiateRate|sslbkendsessionrenegotiaterate|double|Rate (/s) counter for ssltotbkendsessionrenegotiate
        SslTotalBackendSslV3Renegotiate|ssltotbkendsslv3renego|string|Number of back-end SSLv3 session renegotiations on the Citrix ADC.
        SslBackendSslV3RenegotiateRate|sslbkendsslv3renegorate|double|Rate (/s) counter for ssltotbkendsslv3renego
        SslTotalBackendTlsvlRenegotiate|ssltotbkendtlsvlrenego|string|Number of back-end TLSv1 session renegotiations on the Citrix ADC.
        SslBackendTlsvlRenegotiateRate|sslbkendtlsvlrenegorate|double|Rate (/s) counter for ssltotbkendtlsvlrenego
        SslTotalBackendTlsV11Renegotiate|ssltotbkendtlsv11renego|string|Number of back-end TLSv1.1 session renegotiations on the Citrix ADC.
        SslBackendTlsV11RenegotiateRate|sslbkendtlsv11renegorate|double|Rate (/s) counter for ssltotbkendtlsv11renego
        SslTotalBackendTlsV12Renegotiate|ssltotbkendtlsv12renego|string|Number of back-end TLSv1.2 session renegotiations on the Citrix ADC.
        SslBackendTlsV12RenegotiateRate|sslbkendtlsv12renegorate|double|Rate (/s) counter for ssltotbkendtlsv12renego
        SslTotalBackendDtlsvlRenegotiate|ssltotbkenddtlsvlrenego|string|Number of back-end DTLSv1 session renegotiations on the Citrix ADC.
        SslBackendDtlsvlRenegotiateRate|sslbkenddtlsvlrenegorate|double|Rate (/s) counter for ssltotbkenddtlsvlrenego
        SslBackendTotalRsa512KeyExchanges|sslbetotrsa512keyexchanges|string|Number of back-end RSA 512-bit key exchanges on the Citrix ADC.
        SslBackendRsa512KeyExchangesRate|sslbersa512keyexchangesrate|double|Rate (/s) counter for sslbetotrsa512keyexchanges
        SslBackendTotalRsa1024KeyExchanges|sslbetotrsa1024keyexchanges|string|Number of back-end RSA 1024-bit key exchanges on the Citrix ADC.
        SslBackendRsa1024KeyExchangesRate|sslbersa1024keyexchangesrate|double|Rate (/s) counter for sslbetotrsa1024keyexchanges
        SslBackendTotalRsa2048KeyExchanges|sslbetotrsa2048keyexchanges|string|Number of back-end RSA 2048-bit key exchanges on the Citrix ADC.
        SslBackendRsa2048KeyExchangesRate|sslbersa2048keyexchangesrate|double|Rate (/s) counter for sslbetotrsa2048keyexchanges
        SslBackendTotalRsa3072KeyExchanges|sslbetotrsa3072keyexchanges|string|Number of back-end RSA 3072-bit key exchanges on the Citrix ADC.
        SslBackendRsa3072KeyExchangesRate|sslbersa3072keyexchangesrate|double|Rate (/s) counter for sslbetotrsa3072keyexchanges
        SslBackendTotalRsa4096KeyExchanges|sslbetotrsa4096keyexchanges|string|Number of back-end RSA 4096-bit key exchanges on the Citrix ADC.
        SslBackendRsa4096KeyExchangesRate|sslbersa4096keyexchangesrate|double|Rate (/s) counter for sslbetotrsa4096keyexchanges
        SslBackendTotalDh512KeyExchanges|sslbetotdh512keyexchanges|string|Number of back-end DH 512-bit key exchanges on the Citrix ADC.
        SslBackendDh512KeyExchangesRate|sslbedh512keyexchangesrate|double|Rate (/s) counter for sslbetotdh512keyexchanges
        SslBackendTotalDh1024KeyExchanges|sslbetotdh1024keyexchanges|string|Number of back-end DH 1024-bit key exchanges on the Citrix ADC.
        SslBackendDh1024KeyExchangesRate|sshbedh1024keyexchangesrate|double|Rate (/s) counter for sslbetotdh1024keyexchanges
        SslBackendTotalDh2048KeyExchanges|sslbetotdh2048keyexchanges|string|Number of back-end DH 2048-bit key exchanges on the Citrix ADC.
        SslBackendDh2048KeyExchangesRate|sslbedh2048keyexchangesrate|double|Rate (/s) counter for sslbetotdh2048keyexchanges
        SslBackendTotalDh4096KeyExchanges|sslbetotdh4096keyexchanges|string|Number of back-end DH 4096-bit key exchanges on the Citrix ADC.
        SslBackendDh4096KeyExchangesRate|sslbedh4096keyexchangesrate|double|Rate (/s) counter for sslbetotdh4096keyexchanges
        SslBackendTotalEcdhe521CurveKeyExchanges|sslbetotecdhecurve521|string|Number of back-end ECDHE 521 curve Key exchanges on the Citrix ADC.
        SslBackendEcdhe521CurveKeyExchangesRate|sslbeecdhecurve521rate|double|Rate (/s) counter for sslbetotecdhecurve521
        SslBackendTotalEcdhe384CurveKeyExchanges|sslbetotecdhecurve384|string|Number of back-end ECDHE 384 curve Key exchanges on the Citrix ADC.
        SslBackendEcdhe384CurveKeyExchangesRate|sslbeecdhecurve384rate|double|Rate (/s) counter for sslbetotecdhecurve384
        SslBackendTotalEcdhe256CurveKeyExchanges|sslbetotecdhecurve256|string|Number of back-end ECDHE 256 curve Key exchanges on the Citrix ADC.
        SslBackendEcdhe256CurveKeyExchangesRate|sslbeecdhecurve256rate|double|Rate (/s) counter for sslbetotecdhecurve256
        SslBackendTotalEcdhe224CurveKeyExchanges|sslbetotecdhecurve224|string|Number of back-end ECDHE 224 curve Key exchanges on the Citrix ADC.
        SslBackendEcdhe224CurveKeyExchangesRate|sslbeecdhecurve224rate|double|Rate (/s) counter for sslbetotecdhecurve224
        SslBackendTotal40BitRc4Ciphers|sslbetot40bitrc4ciphers|string|Number of back-end RC4 40-bit cipher encryptions on the Citrix ADC.
        SslBackend40BitRc4CiphersRate|sslbe40bitrc4ciphersrate|double|Rate (/s) counter for sslbetot40bitrc4ciphers
        SslBackendTotal56BitRc4Ciphers|sslbetot56bitrc4ciphers|string|Number of back-end RC4 56-bit cipher encryptions on the Citrix ADC.
        SslBackend56BitRc4CiphersRate|sslbe56bitrc4ciphersrate|double|Rate (/s) counter for sslbetot56bitrc4ciphers
        SslBackendTotal64BitRc4Ciphers|sslbetot64bitrc4ciphers|string|Number of back-end RC4 64-bit cipher encryptions on the Citrix ADC.
        SslBackend64BitRc4CiphersRate|sslbe64bitrc4ciphersrate|double|Rate (/s) counter for sslbetot64bitrc4ciphers
        SslBackendTotal128BitRc4Ciphers|sslbetot128bitrc4ciphers|string|Number of back-end RC4 128-bit cipher encryptions on the Citrix ADC.
        SslBackend128BitRc4CiphersRate|sslbe128bitrc4ciphersrate|double|Rate (/s) counter for sslbetot128bitrc4ciphers
        SslBackendTotal40BitDesCiphers|sslbetot40bitdesciphers|string|Number of back-end DES 40-bit cipher encryptions on the Citrix ADC.
        SslBackend40BitDesCiphersRate|sslbe40bitdesciphersrate|double|Rate (/s) counter for sslbetot40bitdesciphers
        SslBackendTotal56BitDesCiphers|sslbetot56bitdesciphers|string|Number of back-end DES 56-bit cipher encryptions on the Citrix ADC.
        SslBackend56BitDesCiphersRate|sslbe56bitdesciphersrate|double|Rate (/s) counter for sslbetot56bitdesciphers
        SslBackendTotal168Bit3DesCiphers|sslbetot168bit3desciphers|string|Number of back-end 3DES 168-bit cipher encryptions on the Citrix ADC.
        SslBackend168Bit3DesCiphersRate|sslbe168bit3desciphersrate|double|Rate (/s) counter for sslbetot168bit3desciphers
        SslTotalBackendCipherAes128|ssltotbkendcipheraes128|string|Back-end AES 128-bit cipher encryptions on the Citrix ADC.
        SslBackendCipherAes128Rate|sslbkendcipheraes128rate|double|Rate (/s) counter for ssltotbkendcipheraes128
        SslTotalBackendCipherAes256|ssltotbkendcipheraes256|string|Back-end AES 256-bit cipher encryptions on the Citrix ADC.
        SslBackendCipherAes256Rate|sslbkendcipheraes256rate|double|Rate (/s) counter for ssltotbkendcipheraes256
        SslBackendTotal40BitRc2Ciphers|sslbetot40bitrc2ciphers|string|Number of back-end RC2 40-bit cipher encryptions on the Citrix ADC.
        SslBackend40BitRc2CiphersRate|sslbe40bitrc2ciphersrate|double|Rate (/s) counter for sslbetot40bitrc2ciphers
        SslBackendTotal56BitRc2Ciphers|sslbetot56bitrc2ciphers|string|Number of back-end RC2 56-bit cipher encryptions on the Citrix ADC.
        SslBackend56BitRc2CiphersRate|sslbe56bitrc2ciphersrate|double|Rate (/s) counter for sslbetot56bitrc2ciphers
        SslBackendTotal128BitRc2Ciphers|sslbetot128bitrc2ciphers|string|Number of back-end RC2 128-bit cipher encryptions on the Citrix ADC.
        SslBackend128BitRc2CiphersRate|sslbe128bitrc2ciphersrate|double|Rate (/s) counter for sslbetot128bitrc2ciphers
        SslTotalBackendCipherAesGcm128|ssltotbkendcipheraesgcm128|string|Back-end AES-GCM 128-bit cipher encryptions on the Citrix ADC.
        SslBackendCipherAesGcm128Rate|sslbkendcipheraesgcm128rate|double|Rate (/s) counter for ssltotbkendcipheraesgcm128
        SslTotalBackendCipherAesGcm256|ssltotbkendcipheraesgcm256|string|Back-end AES-GCM 256-bit cipher encryptions on the Citrix ADC .
        SslBackendCipherAesGcm256Rate|sslbkendcipheraesgcm256rate|double|Rate (/s) counter for ssltotbkendcipheraesgcm256
        SslBackendTotalNullCiphers|sslbetotnullciphers|string|Number of back-end null cipher encryptions on the Citrix ADC.
        SslBackendNullCiphersRate|sslbenullciphersrate|double|Rate (/s) counter for sslbetotnullciphers
        SslBackendTotalMd5Mac|sslbetotmd5mac|string|Number of back-end MD5 hashes on the Citrix ADC.
        SslBackendMd5MacRate|sslbemd5macrate|double|Rate (/s) counter for sslbetotmd5mac
        SslBackendTotalShaMac|sslbetotshamac|string|Number of back-end SHA hashes on the Citrix ADC.
        SslBackendShaMacRate|sslbeshamacrate|double|Rate (/s) counter for sslbetotshamac
        SslBackendTotalSha256Mac|sslbetotsha256mac|string|Number of back-end SHA256 hashes on the Citrix ADC.
        SslBackendSha256MacRate|sslbesha256macrate|double|Rate (/s) counter for sslbetotsha256mac
        SslBackendTotalSha384Mac|sslbetotsha384mac|string|Number of back-end SHA384 hashes on the Citrix ADC.
        SslBackendSha384MacRate|sslbesha384macrate|double|Rate (/s) counter for sslbetotsha384mac
        SslBackendTotalSslV3Handshakes|sslbetotsslv3handshakes|string|Number of back-end SSLv3 handshakes on the Citrix ADC.
        SslBackendSslV3HandshakesRate|sslbesslv3handshakesrate|double|Rate (/s) counter for sslbetotsslv3handshakes
        SslBackendTotalTlsV1Handshakes|sslbetottlsv1handshakes|string|Number of back-end TLSv1 handshakes on the Citrix ADC.
        SslBackendTlsV1HandshakesRate|sslbetlsv1handshakesrate|double|Rate (/s) counter for sslbetottlsv1handshakes
        SslBackendTotalTlsV11Handshakes|sslbetottlsv11handshakes|string|Number of back-end TLSv1.1 handshakes on the Citrix ADC.
        SslBackendTlsV11HandshakesRate|sslbetlsv11handshakesrate|double|Rate (/s) counter for sslbetottlsv11handshakes
        SslBackendTotalTlsV12Handshakes|sslbetottlsv12handshakes|string|Number of back-end TLSv1.2 handshakes on the Citrix ADC.
        SslBackendTlsV12HandshakesRate|sslbetlsv12handshakesrate|double|Rate (/s) counter for sslbetottlsv12handshakes
        SslBackendTotalDtlsV1Handshakes|sslbetotdtlsv1handshakes|string|Number of back-end DTLSv1 handshakes on the Citrix ADC.
        SslBackendDtlsV1HandshakesRate|sslbedtlsv1handshakesrate|double|Rate (/s) counter for sslbetotdtlsv1handshakes
        SslBackendTotalSslV3ClientAuthentications|sslbetotsslv3clientauthentications|string|Number of back-end SSLv3 client authentications on the Citrix ADC.
        SslBackendSslV3ClientAuthenticationsRate|sslbesslv3clientauthenticationsrate|double|Rate (/s) counter for sslbetotsslv3clientauthentications
        SslBackendTotalTlsV1ClientAuthentications|sslbetottlsv1clientauthentications|string|Number of back-end TLSv1 client authentications on the Citrix ADC.
        SslBackendTlsV1ClientAuthenticationsRate|sslbetlsv1clientauthenticationsrate|double|Rate (/s) counter for sslbetottlsv1clientauthentications
        SslBackendTotalTlsV11ClientAuthentications|sslbetottlsv11clientauthentications|string|Number of back-end TLSv1.1 client authentications on the Citrix ADC.
        SslBackendTlsV11ClientAuthenticationsRate|sslbetlsv11clientauthenticationsrate|double|Rate (/s) counter for sslbetottlsv11clientauthentications
        SslBackendTotalTlsV12ClientAuthentications|sslbetottlsv12clientauthentications|string|Number of back-end TLSv1.2 client authentications on the Citrix ADC.
        SslBackendTlsV12ClientAuthenticationsRate|sslbetlsv12clientauthenticationsrate|double|Rate (/s) counter for sslbetottlsv12clientauthentications
        SslBackendTotalDtlsV1ClientAuthentications|sslbetotdtlsv1clientauthentications|string|Number of back-end DTLSv1 client authentications on the Citrix ADC.
        SslBackendDtlsV1ClientAuthenticationsRate|sslbedtlsv1clientauthenticationsrate|double|Rate (/s) counter for sslbetotdtlsv1clientauthentications
        SslBackendTotalRsaAuthorizations|sslbetotrsaauthorizations|string|Number of back-end RSA authentications on the Citrix ADC.
        SslBackendRsaAuthorizationsRate|sslbersaauthorizationsrate|double|Rate (/s) counter for sslbetotrsaauthorizations
        SslBackendTotalDhAuthorizations|sslbetotdhauthorizations|string|Number of back-end DH authentications on the Citrix ADC.
        SslBackendDhAuthorizationsRate|sslbedhauthorizationsrate|double|Rate (/s) counter for sslbetotdhauthorizations
        SslBackendTotalDssAuthorizations|sslbetotdssauthorizations|string|Number of back-end DSS authentications on the Citrix ADC.
        SslBackendDssAuthorizationsRate|sslbedssauthorizationsrate|double|Rate (/s) counter for sslbetotdssauthorizations
        SslBackendTotalEcdsaAuthorizations|sslbetotecdsaauthorizations|string|Number of back-end ECDSA authentications on the Citrix ADC.
        SslBackendEcdsaAuthorizationsRate|sslbeecdsaauthorizationsrate|double|Rate (/s) counter for sslbetotecdsaauthorizations
        SslBackendTotalNullAuthorizations|sslbetotnullauthorizations|string|Number of back-end null authentications on the Citrix ADC.
        SslBackendNullAuthorizationsRate|sslbenullauthorizationsrate|double|Rate (/s) counter for sslbetotnullauthorizations
        SslTotalOffloadRsaKeyExchanges|ssltotoffloadrsakeyexchanges|string|Number of RSA key exchanges offloaded to the cryptography card.
        SslOffloadRsaKeyExchangesRate|ssloffloadrsakeyexchangesrate|double|Rate (/s) counter for ssltotoffloadrsakeyexchanges
        SslTotalOffloadedRsaSigns|ssltotoffloadsignrsa|string|Number of RSA sign operations offloaded to the cryptography card.
        SslOffloadedRsaSignsRate|ssloffloadsignrsarate|double|Rate (/s) counter for ssltotoffloadsignrsa
        SslTotalOffloadDhKeyExchanges|ssltotoffloaddhkeyexchanges|string|Number of DH key exchanges offloaded to the cryptography card.
        SslOffloadDhKeyExchangesRate|ssloffloaddhkeyexchangesrate|double|Rate (/s) counter for ssltotoffloaddhkeyexchanges
        SslTotalOffloadBulkRc4|ssltotoffloadbulkrc4|string|Number of RC4 encryptions offloaded to the cryptography card.
        SslOffloadBulkRc4Rate|ssloffloadbulkrc4rate|double|Rate (/s) counter for ssltotoffloadbulkrc4
        SslTotalOffloadBulkDes|ssltotoffloadbulkdes|string|Number of DES encryptions offloaded to the cryptography card.
        SslOffloadBulkDesRate|ssloffloadbulkdesrate|double|Rate (/s) counter for ssltotoffloadbulkdes
        SslTotalOffloadBulkAes|ssltotoffloadbulkaes|string|Number of AES encryptions offloaded to the cryptography card.
        SslOffloadBulkAesRate|ssloffloadbulkaesrate|double|Rate (/s) counter for ssltotoffloadbulkaes
        SslTotalOffloadBulkAesGcm128|ssltotoffloadbulkaesgcm128|string|Number of AES-GCM 128-bit encryptions offloaded to the cryptography card.
        SslOffloadBulkAesGcm128Rate|ssloffloadbulkaesgcm128rate|double|Rate (/s) counter for ssltotoffloadbulkaesgcm128
        SslTotalOffloadBulkAesGcm256|ssltotoffloadbulkaesgcm256|string|Number of AES-GCM 256-bit encryptions offloaded to the cryptography card.
        SslOffloadBulkAesGcm256Rate|ssloffloadbulkaesgcm256rate|double|Rate (/s) counter for ssltotoffloadbulkaesgcm256
        SslTotalEncryptedBytesInHardware|ssltotenchw|string|Number of bytes encrypted in hardware.
        SslEncryptedBytesInHardwareRate|sslenchwrate|double|Rate (/s) counter for ssltotenchw
        SslTotalEncryptedBytesInSoftware|ssltotencsw|string|Number of bytes encrypted in software.
        SslEncryptedBytesInSoftwareRate|sslencswrate|double|Rate (/s) counter for ssltotencsw
        SslTotalEncryptedBytesFrontend|ssltotencfe|string|Number of bytes encrypted on the front-end.
        SslEncryptedBytesFrontendRate|sslencferate|double|Rate (/s) counter for ssltotencfe
        SslTotalHardwareEncryptedBytesFrontend|ssltothwencfe|string|Number of bytes encrypted in hardware on the front-end.
        SslHardwareEncryptedBytesFrontendRate|sslhwencferate|double|Rate (/s) counter for ssltothwencfe
        SslTotalSoftwareEncryptedBytesFrontend|ssltotswencfe|string|Number of bytes encrypted in software on the front-end.
        SslSoftwareEncryptedBytesFrontendRate|sslswencferate|double|Rate (/s) counter for ssltotswencfe
        SslTotalEncryptedBytesBackend|ssltotencbe|string|Number of bytes encrypted on the back-end.
        SslEncryptedBytesBackendRate|sslencberate|double|Rate (/s) counter for ssltotencbe
        SslTotalHardwareEncryptedBytesBackend|ssltothwencbe|string|Number of bytes encrypted in hardware on the back-end.
        SslHardwareEncryptedBytesBackendRate|sslhwencberate|double|Rate (/s) counter for ssltothwencbe
        SslTotalSoftwareEncryptedBytesBackend|ssltotswencbe|string|Number of bytes encrypted in software on the back-end.
        SslSoftwareEncryptedBytesBackendRate|sslswencberate|double|Rate (/s) counter for ssltotswencbe
        SslTotalDecryptedBytesInHardware|ssltotdechw|string|Number of bytes decrypted in hardware.
        SslDecryptedBytesInHardwareRate|ssldechwrate|double|Rate (/s) counter for ssltotdechw
        SslTotalDecryptedBytesInSoftware|ssltotdecsw|string|Number of bytes decrypted in software.
        SslDecryptedBytesInSoftwareRate|ssldecswrate|double|Rate (/s) counter for ssltotdecsw
        SslTotalDecryptedBytesFrontend|ssltotdecfe|string|Number of bytes decrypted on the front-end.
        SslDecryptedBytesFrontendRate|ssldecferate|double|Rate (/s) counter for ssltotdecfe
        SslTotalHardwareDecryptedBytesFrontend|ssltothwdecfe|string|Number of bytes decrypted in hardware on the front-end.
        SslHardwareDecryptedBytesFrontendRate|sslhwdecferate|double|Rate (/s) counter for ssltothwdecfe
        SslTotalSoftwareDecryptedBytesFrontend|ssltotswdecfe|string|Number of bytes decrypted in software on the front-end.
        SslSoftwareDecryptedBytesFrontendRate|sslswdecferate|double|Rate (/s) counter for ssltotswdecfe
        SslTotalDecryptedBytesBackend|ssltotdecbe|string|Number of bytes decrypted on the back-end.
        SslDecryptedBytesBackendRate|ssldecberate|double|Rate (/s) counter for ssltotdecbe
        SslTotalHardwareDecryptedBytesBackend|ssltothwdecbe|string|Number of bytes decrypted in hardware on the back-end.
        SslHardwareDecryptedBytesBackendRate|sslhwdecberate|double|Rate (/s) counter for ssltothwdecbe
        SslTotalSoftwareDecryptedBytesBackend|ssltotswdecbe|string|Number of bytes decrypted in software on the back-end
        SslSoftwareDecryptedBytesBackendRate|sslswdecberate|double|Rate (/s) counter for ssltotswdecbe
        SslCurrentSslInfoSpcbInUseCount|sslcursslinfospcbinusecount|string|Number of SPCB in use.
        SslCurrentSslInfoSpcbInUseCountRate|sslcursslinfospcdinusecountrate|double|Rate (/s) counter for sslcursslinfospcbinusecount
        SslCurrentSessions|sslcursessions|string|Number of active SSL sessions on the Citrix ADC.
        SslCurrentSessionsRate|sslcursessionsrate|double|Rate (/s) counter for sslcursessions
        SslCurrentQueueSize|sslcurqsize|string|Current queue size
        SslCurrentQueueSizeRate|sslcurqsizerate|double|Rate (/s) counter for sslcurqsize
        SslCurrentSslInfoNsCardInQueueCount|sslcursslinfonscardinqcount|string|Number of current SSL card InQ count.
        SslCurrentSslInfoNsCardInQueueCountRate|sslcursslinfonscardinqcountrate|double|Rate (/s) counter for sslcursslinfonscardinqcount
        SslCurrentSslInfoCardInBulkQueue|sslcursllinfocardinblkq|string|Number of current SSL card In BulkQ count.
        SslCurrentSslInfoCardInBulkQueueRate|sslcursslinfocardinblkqrate|double|Rate (/s) counter for sslcursslinfocardinblkq
        SslCurrentSslInfoCardInKeyQueue|sslcursslinfocardinkeyq|string|Number of current SSL card In KeyQ count.
        SslCurrentSslInfoCardInKeyQueueRate|sslcursslinfocardinkeyqrate|double|Rate (/s) counter for sslcursslinfocardinkeyq
        SslBackendMaxMultiplexedSessions|sslbemaxmultiplexedsessions|string|Number of back-end SSL sessions reused on the Citrix ADC.
        SslBackendMaxMultiplexedSessionsRate|sslbemaxmultiplexedsessionsrate|double|Rate (/s) counter for sslbemaxmultiplexedsessions
        SslTotal128BitIdeaCiphers|ssltot128bitideaciphers|string|Number of IDEA 128-bit cipher encryptions on the Citrix ADC.
        Ssl128BitIdeaCiphersRate|ssl128bitideaciphersrate|double|Rate (/s) counter for ssltot128bitideaciphers
        SslBackendTotal128BitIdeaCiphers|sslbetot128bitideaciphers|string|Number of back-end IDEA 128-bit cipher encryptions on the Citrix ADC.
        SslBackend128BitIdeaCiphersRate|sslbe128bitideaciphersrate|double|Rate (/s) counter for sslbetot128bitideaciphers






    * Creation of the Command:  

        To create a command, one tells NitroCommandFactory to create and passes the type of command to create, as wel as the parameters Client(INitroServiceClient) and the Options to filter by.  

        eg. 
        ```
        var command = NitroCommandFactory.Create\<SslStatCommand>(INitroServiceClient, New SslStatRequestOptions(){ });
        ```
        
        - Options:  
        For this command, the Options are gathered in an Object SslStatRequestOptions, which has following properties to be used as filters:  
        <u>ResourceName</u>: The name of the resource you want to Get, if none is specified, all resources matching the criteria will be returned.  Not Defining this will return all objects.  
        <u>ResourceFilter</u>: a Key-Value Pair with the name (key) of a property of an object, and the value you want to see in the returned objects.  
        eg. ResourceFilter = {{"Comment","Hello"}} will make it so only objects with "Hello" as their Comment will be returned. Not Defining this will return all objects.  
        <u>PropertyFilter</u>: A List of properties that should be returned when Getting the response of the Get Request.  
        eg. PropertyFilter = {"Name"} will make it so only the names of the objects matching the criteria are returned. Not Defining this will return all properties.  
        <u>Count</u>: A bool when if sets to true, will make it so the response to your query contains only the property Count that contains a double-value representing the amount of objects that match your search-criteria.

    * Usage of the Command:

        You can let the Command run and Get the reponse by storing it into a premade object using the commands GetResponse Method. For SslStat, that object is <u>SslStatResponse</u>.

        eg. 
        ```
        var response = command.GetResponse(); 
        ```

        Response will then hold all the information from the request in following properties:   
        - StatusCode: a combination of the statuscode and statuscodemessage. eg. "200 OK" if successful
        - ErrorCode: the errorcode of the request, 0 if successful.
        - ErrorMessage: the Message accompanying the ErrorCode, "Done" if successful.
        - Severity: the severity of the error, "NONE" if successful
        - SslStatistics: an array of SslStats-objects returned by the Get-Request, all of which contain the properties mentioned above.
