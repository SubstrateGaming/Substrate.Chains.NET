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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_asset_manager.pallet
{
    
    
    public enum Event
    {
        
        ForeignAssetRegistered = 0,
        
        UnitsPerSecondChanged = 1,
        
        ForeignAssetTypeChanged = 2,
        
        ForeignAssetRemoved = 3,
        
        SupportedAssetRemoved = 4,
        
        LocalAssetRegistered = 5,
        
        ForeignAssetDestroyed = 6,
        
        LocalAssetDestroyed = 7,
    }
    
    /// <summary>
    /// >> 100 - Variant[pallet_asset_manager.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.asset_config.AssetRegistrarMetadata>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType>, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType>, Substrate.NetApi.Model.Types.Primitive.U128>
    {
    }
}