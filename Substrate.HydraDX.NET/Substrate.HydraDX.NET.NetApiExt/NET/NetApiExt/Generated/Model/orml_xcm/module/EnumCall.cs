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


namespace Substrate.HydraDX.NET.NetApiExt.Generated.Model.orml_xcm.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> send_as_sovereign
        /// See [`Pallet::send_as_sovereign`].
        /// </summary>
        send_as_sovereign = 0,
    }
    
    /// <summary>
    /// >> 408 - Variant[orml_xcm.module.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.HydraDX.NET.NetApiExt.Generated.Model.staging_xcm.EnumVersionedMultiLocation, Substrate.HydraDX.NET.NetApiExt.Generated.Model.staging_xcm.EnumVersionedXcm>>
    {
    }
}