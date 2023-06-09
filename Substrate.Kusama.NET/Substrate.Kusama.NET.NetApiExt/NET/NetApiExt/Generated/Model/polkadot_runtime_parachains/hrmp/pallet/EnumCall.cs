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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.pallet
{
    
    
    public enum Call
    {
        
        hrmp_init_open_channel = 0,
        
        hrmp_accept_open_channel = 1,
        
        hrmp_close_channel = 2,
        
        force_clean_hrmp = 3,
        
        force_process_hrmp_open = 4,
        
        force_process_hrmp_close = 5,
        
        hrmp_cancel_open_request = 6,
        
        force_open_hrmp_channel = 7,
    }
    
    /// <summary>
    /// >> 365 - Variant[polkadot_runtime_parachains.hrmp.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
