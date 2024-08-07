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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_registrar.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> register
        /// See [`Pallet::register`].
        /// </summary>
        register = 0,
        
        /// <summary>
        /// >> force_register
        /// See [`Pallet::force_register`].
        /// </summary>
        force_register = 1,
        
        /// <summary>
        /// >> deregister
        /// See [`Pallet::deregister`].
        /// </summary>
        deregister = 2,
        
        /// <summary>
        /// >> swap
        /// See [`Pallet::swap`].
        /// </summary>
        swap = 3,
        
        /// <summary>
        /// >> remove_lock
        /// See [`Pallet::remove_lock`].
        /// </summary>
        remove_lock = 4,
        
        /// <summary>
        /// >> reserve
        /// See [`Pallet::reserve`].
        /// </summary>
        reserve = 5,
        
        /// <summary>
        /// >> add_lock
        /// See [`Pallet::add_lock`].
        /// </summary>
        add_lock = 6,
        
        /// <summary>
        /// >> schedule_code_upgrade
        /// See [`Pallet::schedule_code_upgrade`].
        /// </summary>
        schedule_code_upgrade = 7,
        
        /// <summary>
        /// >> set_current_head
        /// See [`Pallet::set_current_head`].
        /// </summary>
        set_current_head = 8,
    }
    
    /// <summary>
    /// >> 361 - Variant[polkadot_runtime_common.paras_registrar.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode>, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode>, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id>, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseVoid, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode>, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData>>
    {
    }
}
