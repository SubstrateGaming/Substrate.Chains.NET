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


namespace Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_uniques.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> create
        /// See [`Pallet::create`].
        /// </summary>
        create = 0,
        
        /// <summary>
        /// >> force_create
        /// See [`Pallet::force_create`].
        /// </summary>
        force_create = 1,
        
        /// <summary>
        /// >> destroy
        /// See [`Pallet::destroy`].
        /// </summary>
        destroy = 2,
        
        /// <summary>
        /// >> mint
        /// See [`Pallet::mint`].
        /// </summary>
        mint = 3,
        
        /// <summary>
        /// >> burn
        /// See [`Pallet::burn`].
        /// </summary>
        burn = 4,
        
        /// <summary>
        /// >> transfer
        /// See [`Pallet::transfer`].
        /// </summary>
        transfer = 5,
        
        /// <summary>
        /// >> redeposit
        /// See [`Pallet::redeposit`].
        /// </summary>
        redeposit = 6,
        
        /// <summary>
        /// >> freeze
        /// See [`Pallet::freeze`].
        /// </summary>
        freeze = 7,
        
        /// <summary>
        /// >> thaw
        /// See [`Pallet::thaw`].
        /// </summary>
        thaw = 8,
        
        /// <summary>
        /// >> freeze_collection
        /// See [`Pallet::freeze_collection`].
        /// </summary>
        freeze_collection = 9,
        
        /// <summary>
        /// >> thaw_collection
        /// See [`Pallet::thaw_collection`].
        /// </summary>
        thaw_collection = 10,
        
        /// <summary>
        /// >> transfer_ownership
        /// See [`Pallet::transfer_ownership`].
        /// </summary>
        transfer_ownership = 11,
        
        /// <summary>
        /// >> set_team
        /// See [`Pallet::set_team`].
        /// </summary>
        set_team = 12,
        
        /// <summary>
        /// >> approve_transfer
        /// See [`Pallet::approve_transfer`].
        /// </summary>
        approve_transfer = 13,
        
        /// <summary>
        /// >> cancel_approval
        /// See [`Pallet::cancel_approval`].
        /// </summary>
        cancel_approval = 14,
        
        /// <summary>
        /// >> force_item_status
        /// See [`Pallet::force_item_status`].
        /// </summary>
        force_item_status = 15,
        
        /// <summary>
        /// >> set_attribute
        /// See [`Pallet::set_attribute`].
        /// </summary>
        set_attribute = 16,
        
        /// <summary>
        /// >> clear_attribute
        /// See [`Pallet::clear_attribute`].
        /// </summary>
        clear_attribute = 17,
        
        /// <summary>
        /// >> set_metadata
        /// See [`Pallet::set_metadata`].
        /// </summary>
        set_metadata = 18,
        
        /// <summary>
        /// >> clear_metadata
        /// See [`Pallet::clear_metadata`].
        /// </summary>
        clear_metadata = 19,
        
        /// <summary>
        /// >> set_collection_metadata
        /// See [`Pallet::set_collection_metadata`].
        /// </summary>
        set_collection_metadata = 20,
        
        /// <summary>
        /// >> clear_collection_metadata
        /// See [`Pallet::clear_collection_metadata`].
        /// </summary>
        clear_collection_metadata = 21,
        
        /// <summary>
        /// >> set_accept_ownership
        /// See [`Pallet::set_accept_ownership`].
        /// </summary>
        set_accept_ownership = 22,
        
        /// <summary>
        /// >> set_collection_max_supply
        /// See [`Pallet::set_collection_max_supply`].
        /// </summary>
        set_collection_max_supply = 23,
        
        /// <summary>
        /// >> set_price
        /// See [`Pallet::set_price`].
        /// </summary>
        set_price = 24,
        
        /// <summary>
        /// >> buy_item
        /// See [`Pallet::buy_item`].
        /// </summary>
        buy_item = 25,
    }
    
    /// <summary>
    /// >> 349 - Variant[pallet_uniques.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Call.create);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.force_create);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_uniques.types.DestroyWitness>>(Call.destroy);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Call.mint);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>(Call.burn);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Call.transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.redeposit);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.freeze);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.thaw);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.freeze_collection);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.thaw_collection);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Call.transfer_ownership);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Call.set_team);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Call.approve_transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>(Call.cancel_approval);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.force_item_status);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3, Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>(Call.set_attribute);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3>>(Call.clear_attribute);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.set_metadata);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.clear_metadata);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.set_collection_metadata);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.clear_collection_metadata);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>(Call.set_accept_ownership);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.set_collection_max_supply);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.HydraDX.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>(Call.set_price);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.buy_item);
        }
    }
}
