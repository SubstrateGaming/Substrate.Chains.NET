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


namespace Substrate.Gear.NET.NetApiExt.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> ConfigOp
    /// </summary>
    public enum ConfigOp
    {
        
        /// <summary>
        /// >> Noop
        /// </summary>
        Noop = 0,
        
        /// <summary>
        /// >> Set
        /// </summary>
        Set = 1,
        
        /// <summary>
        /// >> Remove
        /// </summary>
        Remove = 2,
    }
    
    /// <summary>
    /// >> 256 - Variant[pallet_nomination_pools.ConfigOp]
    /// </summary>
    public sealed class EnumConfigOp : BaseEnumExt<ConfigOp, BaseVoid, Substrate.Gear.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseVoid>
    {
    }
}