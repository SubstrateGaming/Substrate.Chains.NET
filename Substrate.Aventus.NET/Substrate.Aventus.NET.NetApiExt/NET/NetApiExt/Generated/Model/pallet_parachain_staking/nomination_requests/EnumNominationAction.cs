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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_parachain_staking.nomination_requests
{
    
    
    public enum NominationAction
    {
        
        Revoke = 0,
        
        Decrease = 1,
    }
    
    /// <summary>
    /// >> 37 - Variant[pallet_parachain_staking.nomination_requests.NominationAction]
    /// </summary>
    public sealed class EnumNominationAction : BaseEnumExt<NominationAction, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>
    {
    }
}