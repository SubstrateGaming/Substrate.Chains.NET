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


namespace Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet
{
    
    
    public enum Call
    {
        
        service_overweight = 0,
        
        suspend_xcm_execution = 1,
        
        resume_xcm_execution = 2,
        
        update_suspend_threshold = 3,
        
        update_drop_threshold = 4,
        
        update_resume_threshold = 5,
        
        update_threshold_weight = 6,
        
        update_weight_restrict_decay = 7,
        
        update_xcmp_max_individual_weight = 8,
    }
    
    /// <summary>
    /// >> 224 - Variant[cumulus_pallet_xcmp_queue.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>
    {
    }
}
