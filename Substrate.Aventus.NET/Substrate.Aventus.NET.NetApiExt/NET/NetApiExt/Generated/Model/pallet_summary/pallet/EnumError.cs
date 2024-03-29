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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_summary.pallet
{
    
    
    public enum Error
    {
        
        Overflow = 0,
        
        ErrorCalculatingChosenValidator = 1,
        
        ErrorConvertingBlockNumber = 2,
        
        ErrorGettingSummaryDataFromService = 3,
        
        InvalidSummaryRange = 4,
        
        ErrorSubmittingTransaction = 5,
        
        InvalidKey = 6,
        
        ErrorSigning = 7,
        
        InvalidHexString = 8,
        
        InvalidUTF8Bytes = 9,
        
        InvalidRootHashLength = 10,
        
        SummaryPendingOrApproved = 11,
        
        RootHasAlreadyBeenRegisteredForVoting = 12,
        
        InvalidRoot = 13,
        
        DuplicateVote = 14,
        
        ErrorEndingVotingPeriod = 15,
        
        ErrorSubmitCandidateTxnToTier1 = 16,
        
        VotingSessionIsNotValid = 17,
        
        ErrorRecoveringPublicKeyFromSignature = 18,
        
        ECDSASignatureNotValid = 19,
        
        RootDataNotFound = 20,
        
        InvalidChallenge = 21,
        
        WrongValidator = 22,
        
        GracePeriodElapsed = 23,
        
        TooEarlyToAdvance = 24,
        
        InvalidIngressCounter = 25,
        
        SchedulePeriodIsTooShort = 26,
        
        VotingPeriodIsTooShort = 27,
        
        VotingPeriodIsTooLong = 28,
        
        VotingPeriodIsLessThanFinalityReportLatency = 29,
        
        VotingPeriodIsEqualOrLongerThanSchedulePeriod = 30,
        
        CurrentSlotValidatorNotFound = 31,
    }
    
    /// <summary>
    /// >> 415 - Variant[pallet_summary.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
