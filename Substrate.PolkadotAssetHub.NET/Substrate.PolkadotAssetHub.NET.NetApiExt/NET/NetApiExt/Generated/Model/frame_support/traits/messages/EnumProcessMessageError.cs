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


namespace Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.frame_support.traits.messages
{
    
    
    /// <summary>
    /// >> ProcessMessageError
    /// </summary>
    public enum ProcessMessageError
    {
        
        /// <summary>
        /// >> BadFormat
        /// </summary>
        BadFormat = 0,
        
        /// <summary>
        /// >> Corrupt
        /// </summary>
        Corrupt = 1,
        
        /// <summary>
        /// >> Unsupported
        /// </summary>
        Unsupported = 2,
        
        /// <summary>
        /// >> Overweight
        /// </summary>
        Overweight = 3,
        
        /// <summary>
        /// >> Yield
        /// </summary>
        Yield = 4,
    }
    
    /// <summary>
    /// >> 121 - Variant[frame_support.traits.messages.ProcessMessageError]
    /// </summary>
    public sealed class EnumProcessMessageError : BaseEnumExt<ProcessMessageError, BaseVoid, BaseVoid, BaseVoid, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, BaseVoid>
    {
    }
}