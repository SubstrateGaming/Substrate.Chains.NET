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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.parachain_staking.pallet
{
    
    
    public enum Error
    {
        
        DelegatorNotFound = 0,
        
        CandidateNotFound = 1,
        
        DelegatorExists = 2,
        
        CandidateExists = 3,
        
        ValStakeZero = 4,
        
        ValStakeBelowMin = 5,
        
        ValStakeAboveMax = 6,
        
        DelegationBelowMin = 7,
        
        AlreadyLeaving = 8,
        
        NotLeaving = 9,
        
        CannotLeaveYet = 10,
        
        CannotJoinBeforeUnlocking = 11,
        
        AlreadyDelegating = 12,
        
        NotYetDelegating = 13,
        
        DelegationsPerRoundExceeded = 14,
        
        TooManyDelegators = 15,
        
        TooFewCollatorCandidates = 16,
        
        CannotStakeIfLeaving = 17,
        
        CannotDelegateIfLeaving = 18,
        
        MaxCollatorsPerDelegatorExceeded = 19,
        
        AlreadyDelegatedCollator = 20,
        
        DelegationNotFound = 21,
        
        Underflow = 22,
        
        CannotSetAboveMax = 23,
        
        CannotSetBelowMin = 24,
        
        InvalidSchedule = 25,
        
        NoMoreUnstaking = 26,
        
        TooEarly = 27,
        
        StakeNotFound = 28,
        
        UnstakingIsEmpty = 29,
        
        RewardsNotFound = 30,
    }
    
    /// <summary>
    /// >> 233 - Variant[parachain_staking.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
