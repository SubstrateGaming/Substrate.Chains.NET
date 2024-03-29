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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_asset_registry.module
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> RegisteredAsset
        /// </summary>
        RegisteredAsset = 0,
        
        /// <summary>
        /// >> UpdatedAsset
        /// </summary>
        UpdatedAsset = 1,
    }
    
    /// <summary>
    /// >> 200 - Variant[orml_asset_registry.module.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_traits.asset_registry.AssetMetadata>, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.orml_traits.asset_registry.AssetMetadata>>
    {
    }
}
