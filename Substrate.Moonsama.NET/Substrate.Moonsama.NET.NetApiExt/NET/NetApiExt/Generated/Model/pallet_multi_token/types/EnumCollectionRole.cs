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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_multi_token.types
{
    
    
    public enum CollectionRole
    {
        
        Issuer = 1,
        
        Freezer = 2,
        
        Admin = 4,
        
        Governance = 8,
        
        Creator = 16,
        
        Manager = 32,
        
        CompositeCreator = 64,
        
        Trader = 128,
    }
    
    /// <summary>
    /// >> 153 - Variant[pallet_multi_token.types.CollectionRole]
    /// </summary>
    public sealed class EnumCollectionRole : BaseEnum<CollectionRole>
    {
    }
}
