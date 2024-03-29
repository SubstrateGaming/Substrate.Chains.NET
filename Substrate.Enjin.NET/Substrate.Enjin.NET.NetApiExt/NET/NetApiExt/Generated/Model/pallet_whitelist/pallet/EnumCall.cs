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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_whitelist.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> whitelist_call
        /// </summary>
        whitelist_call = 0,
        
        /// <summary>
        /// >> remove_whitelisted_call
        /// </summary>
        remove_whitelisted_call = 1,
        
        /// <summary>
        /// >> dispatch_whitelisted_call
        /// </summary>
        dispatch_whitelisted_call = 2,
        
        /// <summary>
        /// >> dispatch_whitelisted_call_with_preimage
        /// </summary>
        dispatch_whitelisted_call_with_preimage = 3,
    }
    
    /// <summary>
    /// >> 596 - Variant[pallet_whitelist.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, Substrate.Enjin.NET.NetApiExt.Generated.Model.enjin_runtime.EnumRuntimeCall>
    {
    }
}
