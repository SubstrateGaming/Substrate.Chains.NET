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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types
{
    
    
    public enum ValidEvents
    {
        
        AddedValidator = 0,
        
        Lifted = 1,
        
        NftMint = 2,
        
        NftTransferTo = 3,
        
        NftCancelListing = 4,
        
        NftEndBatchListing = 5,
        
        AvtGrowthLifted = 6,
    }
    
    /// <summary>
    /// >> 354 - Variant[sp_avn_common.event_types.ValidEvents]
    /// </summary>
    public sealed class EnumValidEvents : BaseEnum<ValidEvents>
    {
    }
}