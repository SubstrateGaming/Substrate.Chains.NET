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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_authorship
{
    
    
    public enum UncleEntryItem
    {
        
        InclusionHeight = 0,
        
        Uncle = 1,
    }
    
    /// <summary>
    /// >> 194 - Variant[pallet_authorship.UncleEntryItem]
    /// </summary>
    public sealed class EnumUncleEntryItem : BaseEnumExt<UncleEntryItem, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>
    {
    }
}
