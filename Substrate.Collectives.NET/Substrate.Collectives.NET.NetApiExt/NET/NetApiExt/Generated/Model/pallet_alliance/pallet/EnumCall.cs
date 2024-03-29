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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.pallet
{
    
    
    public enum Call
    {
        
        propose = 0,
        
        vote = 1,
        
        init_members = 3,
        
        disband = 4,
        
        set_rule = 5,
        
        announce = 6,
        
        remove_announcement = 7,
        
        join_alliance = 8,
        
        nominate_ally = 9,
        
        elevate_ally = 10,
        
        give_retirement_notice = 11,
        
        retire = 12,
        
        kick_member = 13,
        
        add_unscrupulous_items = 14,
        
        remove_unscrupulous_items = 15,
        
        close = 16,
        
        abdicate_fellow_status = 17,
    }
    
    /// <summary>
    /// >> 193 - Variant[pallet_alliance.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Collectives.NET.NetApiExt.Generated.Model.collectives_polkadot_runtime.EnumRuntimeCall, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseVoid, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>, Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.DisbandWitness, Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.Cid, Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.Cid, Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.types.Cid, BaseVoid, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseVoid, BaseVoid, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.EnumUnscrupulousItem>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_alliance.EnumUnscrupulousItem>, BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseVoid>
    {
    }
}
