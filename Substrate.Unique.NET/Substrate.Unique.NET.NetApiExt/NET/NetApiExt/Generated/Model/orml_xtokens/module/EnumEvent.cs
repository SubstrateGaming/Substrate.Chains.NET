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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.orml_xtokens.module
{
    
    
    public enum Event
    {
        
        TransferredMultiAssets = 0,
    }
    
    /// <summary>
    /// >> 46 - Variant[orml_xtokens.module.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.xcm.v3.multiasset.MultiAssets, Substrate.Unique.NET.NetApiExt.Generated.Model.xcm.v3.multiasset.MultiAsset, Substrate.Unique.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation>>
    {
    }
}