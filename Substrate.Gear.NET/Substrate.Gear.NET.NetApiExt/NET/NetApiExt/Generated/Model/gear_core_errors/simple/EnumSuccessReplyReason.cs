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


namespace Substrate.Gear.NET.NetApiExt.Generated.Model.gear_core_errors.simple
{
    
    
    /// <summary>
    /// >> SuccessReplyReason
    /// </summary>
    public enum SuccessReplyReason
    {
        
        /// <summary>
        /// >> Auto
        /// </summary>
        Auto = 0,
        
        /// <summary>
        /// >> Manual
        /// </summary>
        Manual = 1,
        
        /// <summary>
        /// >> Unsupported
        /// </summary>
        Unsupported = 255,
    }
    
    /// <summary>
    /// >> 311 - Variant[gear_core_errors.simple.SuccessReplyReason]
    /// </summary>
    public sealed class EnumSuccessReplyReason : BaseEnum<SuccessReplyReason>
    {
    }
}