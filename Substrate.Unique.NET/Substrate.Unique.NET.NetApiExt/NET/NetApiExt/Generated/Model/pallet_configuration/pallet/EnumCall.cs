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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_configuration.pallet
{
    
    
    public enum Call
    {
        
        set_weight_to_fee_coefficient_override = 0,
        
        set_min_gas_price_override = 1,
        
        set_app_promotion_configuration_override = 3,
        
        set_collator_selection_desired_collators = 4,
        
        set_collator_selection_license_bond = 5,
        
        set_collator_selection_kick_threshold = 6,
    }
    
    /// <summary>
    /// >> 311 - Variant[pallet_configuration.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>, BaseVoid, Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_configuration.AppPromotionConfiguration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}