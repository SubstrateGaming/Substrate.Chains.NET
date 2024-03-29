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
    
    
    public enum Call
    {
        
        register_foreign_asset = 0,
        
        set_asset_units_per_second = 1,
        
        change_existing_asset_type = 2,
        
        remove_supported_asset = 3,
        
        remove_existing_asset_type = 4,
        
        register_local_asset = 5,
        
        destroy_foreign_asset = 6,
        
        destroy_local_asset = 7,
    }
    
    /// <summary>
    /// >> 313 - Variant[pallet_asset_manager.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.asset_config.AssetRegistrarMetadata, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.moonsama_runtime.xcm_config.EnumAssetType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.U128>
    {
    }
}
