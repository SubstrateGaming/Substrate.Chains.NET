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


namespace Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> PoolCreated
        /// A successful call of the `CretaPool` extrinsic will create this event.
        /// </summary>
        PoolCreated = 0,
        
        /// <summary>
        /// >> LiquidityAdded
        /// A successful call of the `AddLiquidity` extrinsic will create this event.
        /// </summary>
        LiquidityAdded = 1,
        
        /// <summary>
        /// >> LiquidityRemoved
        /// A successful call of the `RemoveLiquidity` extrinsic will create this event.
        /// </summary>
        LiquidityRemoved = 2,
        
        /// <summary>
        /// >> SwapExecuted
        /// Assets have been converted from one to another. Both `SwapExactTokenForToken`
        /// and `SwapTokenForExactToken` will generate this event.
        /// </summary>
        SwapExecuted = 3,
        
        /// <summary>
        /// >> SwapCreditExecuted
        /// Assets have been converted from one to another.
        /// </summary>
        SwapCreditExecuted = 4,
    }
    
    /// <summary>
    /// >> 147 - Variant[pallet_asset_conversion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill>, BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128>>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128>>>>
    {
    }
}