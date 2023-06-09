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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    public enum Error
    {
        
        TooManyCandidates = 0,
        
        TooFewCandidates = 1,
        
        Unknown = 2,
        
        Permission = 3,
        
        AlreadyCandidate = 4,
        
        NotCandidate = 5,
        
        AlreadyInvulnerable = 6,
        
        NoAssociatedValidatorId = 7,
        
        ValidatorNotRegistered = 8,
    }
    
    /// <summary>
    /// >> 170 - Variant[pallet_collator_selection.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/v3/runtime/events-and-errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
