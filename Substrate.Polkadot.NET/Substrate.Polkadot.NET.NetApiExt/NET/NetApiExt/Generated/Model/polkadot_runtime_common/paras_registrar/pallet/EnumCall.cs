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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_registrar.pallet
{
    
    
    public enum Call
    {
        
        register = 0,
        
        force_register = 1,
        
        deregister = 2,
        
        swap = 3,
        
        remove_lock = 4,
        
        reserve = 5,
        
        add_lock = 6,
        
        schedule_code_upgrade = 7,
        
        set_current_head = 8,
    }
    
    /// <summary>
    /// >> 414 - Variant[polkadot_runtime_common.paras_registrar.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode>, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData>>
    {
    }
}
