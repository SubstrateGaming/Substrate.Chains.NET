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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.sp_avn_common.event_types
{
    
    
    public enum CheckResult
    {
        
        Ok = 0,
        
        Invalid = 1,
        
        HttpErrorCheckingEvent = 2,
        
        InsufficientConfirmations = 3,
        
        Unknown = 4,
    }
    
    /// <summary>
    /// >> 107 - Variant[sp_avn_common.event_types.CheckResult]
    /// </summary>
    public sealed class EnumCheckResult : BaseEnum<CheckResult>
    {
    }
}
