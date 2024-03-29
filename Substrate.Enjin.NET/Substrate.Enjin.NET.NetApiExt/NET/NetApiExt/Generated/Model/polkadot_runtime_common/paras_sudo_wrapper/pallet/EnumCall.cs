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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_sudo_wrapper.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> sudo_schedule_para_initialize
        /// Schedule a para to be initialized at the start of the next session.
        /// </summary>
        sudo_schedule_para_initialize = 0,
        
        /// <summary>
        /// >> sudo_schedule_para_cleanup
        /// Schedule a para to be cleaned up at the start of the next session.
        /// </summary>
        sudo_schedule_para_cleanup = 1,
        
        /// <summary>
        /// >> sudo_schedule_parathread_upgrade
        /// Upgrade a parathread to a parachain
        /// </summary>
        sudo_schedule_parathread_upgrade = 2,
        
        /// <summary>
        /// >> sudo_schedule_parachain_downgrade
        /// Downgrade a parachain to a parathread
        /// </summary>
        sudo_schedule_parachain_downgrade = 3,
        
        /// <summary>
        /// >> sudo_queue_downward_xcm
        /// Send a downward XCM to the given para.
        /// 
        /// The given parachain should exist and the payload should not exceed the preconfigured size
        /// `config.max_downward_message_size`.
        /// </summary>
        sudo_queue_downward_xcm = 4,
        
        /// <summary>
        /// >> sudo_establish_hrmp_channel
        /// Forcefully establish a channel from the sender to the recipient.
        /// 
        /// This is equivalent to sending an `Hrmp::hrmp_init_open_channel` extrinsic followed by
        /// `Hrmp::hrmp_accept_open_channel`.
        /// </summary>
        sudo_establish_hrmp_channel = 5,
    }
    
    /// <summary>
    /// >> 506 - Variant[polkadot_runtime_common.paras_sudo_wrapper.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ParaGenesisArgs>, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Enjin.NET.NetApiExt.Generated.Model.xcm.EnumVersionedXcm>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
