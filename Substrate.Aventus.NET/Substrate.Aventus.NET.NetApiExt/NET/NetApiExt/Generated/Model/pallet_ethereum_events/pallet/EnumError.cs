//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_events.pallet
{
    
    
    public enum Error
    {
        
        DuplicateEvent = 0,
        
        MissingEventToCheck = 1,
        
        UnrecognizedEventSignature = 2,
        
        EventParsingFailed = 3,
        
        ErrorSigning = 4,
        
        ErrorSubmittingTransaction = 5,
        
        InvalidKey = 6,
        
        PendingChallengeEventNotFound = 7,
        
        InvalidEventToChallenge = 8,
        
        Overflow = 9,
        
        DuplicateChallenge = 10,
        
        ErrorSavingValidationToLocalDB = 11,
        
        MalformedHash = 12,
        
        InvalidEventToProcess = 13,
        
        ChallengingOwnEvent = 14,
        
        InvalidContractAddress = 15,
        
        InvalidContractType = 16,
        
        InvalidEventChallengePeriod = 17,
        
        SenderIsNotSigner = 18,
        
        UnauthorizedTransaction = 19,
        
        UnauthorizedSignedAddEthereumLogTransaction = 20,
    }
    
    /// <summary>
    /// >> 396 - Variant[pallet_ethereum_events.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}