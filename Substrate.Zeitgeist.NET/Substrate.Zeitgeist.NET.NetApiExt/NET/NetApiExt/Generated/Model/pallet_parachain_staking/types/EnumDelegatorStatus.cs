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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_parachain_staking.types
{
    
    
    /// <summary>
    /// >> DelegatorStatus
    /// </summary>
    public enum DelegatorStatus
    {
        
        /// <summary>
        /// >> Active
        /// </summary>
        Active = 0,
        
        /// <summary>
        /// >> Leaving
        /// </summary>
        Leaving = 1,
    }
    
    /// <summary>
    /// >> 589 - Variant[pallet_parachain_staking.types.DelegatorStatus]
    /// </summary>
    public sealed class EnumDelegatorStatus : BaseEnumExt<DelegatorStatus, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}