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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_roles_management.types
{
    
    
    public enum Role
    {
        
        Creator = 1,
        
        Freezer = 2,
        
        Trader = 4,
        
        FeeReceiver = 8,
        
        Minter = 16,
        
        Operator = 32,
    }
    
    /// <summary>
    /// >> 133 - Variant[pallet_roles_management.types.Role]
    /// </summary>
    public sealed class EnumRole : BaseEnum<Role>
    {
    }
}