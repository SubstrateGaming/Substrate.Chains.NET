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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_nomination_pools
{
    
    
    public enum ClaimPermission
    {
        
        Permissioned = 0,
        
        PermissionlessCompound = 1,
        
        PermissionlessWithdraw = 2,
        
        PermissionlessAll = 3,
    }
    
    /// <summary>
    /// >> 303 - Variant[pallet_nomination_pools.ClaimPermission]
    /// </summary>
    public sealed class EnumClaimPermission : BaseEnum<ClaimPermission>
    {
    }
}