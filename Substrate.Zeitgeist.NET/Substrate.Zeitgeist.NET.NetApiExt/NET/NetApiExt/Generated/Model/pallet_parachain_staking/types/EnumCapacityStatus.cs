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
    /// >> CapacityStatus
    /// </summary>
    public enum CapacityStatus
    {
        
        /// <summary>
        /// >> Full
        /// </summary>
        Full = 0,
        
        /// <summary>
        /// >> Empty
        /// </summary>
        Empty = 1,
        
        /// <summary>
        /// >> Partial
        /// </summary>
        Partial = 2,
    }
    
    /// <summary>
    /// >> 591 - Variant[pallet_parachain_staking.types.CapacityStatus]
    /// </summary>
    public sealed class EnumCapacityStatus : BaseEnum<CapacityStatus>
    {
    }
}