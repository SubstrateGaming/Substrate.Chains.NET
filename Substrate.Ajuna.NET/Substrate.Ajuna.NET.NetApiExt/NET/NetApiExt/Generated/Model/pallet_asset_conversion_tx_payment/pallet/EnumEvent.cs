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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_asset_conversion_tx_payment.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> AssetTxFeePaid
        /// A transaction fee `actual_fee`, of which `tip` was added to the minimum inclusion fee,
        /// has been paid by `who` in an asset `asset_id`.
        /// </summary>
        AssetTxFeePaid = 0,
        
        /// <summary>
        /// >> AssetRefundFailed
        /// A swap of the refund in native currency back to asset failed.
        /// </summary>
        AssetRefundFailed = 1,
    }
    
    /// <summary>
    /// >> 208 - Variant[pallet_asset_conversion_tx_payment.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Ajuna.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.union_of.EnumNativeOrWithId>>(Event.AssetTxFeePaid);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.AssetRefundFailed);
        }
    }
}
