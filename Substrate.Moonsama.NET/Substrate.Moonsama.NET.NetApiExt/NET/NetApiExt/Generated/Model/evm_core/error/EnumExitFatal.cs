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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.evm_core.error
{
    
    
    public enum ExitFatal
    {
        
        NotSupported = 0,
        
        UnhandledInterrupt = 1,
        
        CallErrorAsFatal = 2,
        
        Other = 3,
    }
    
    /// <summary>
    /// >> 117 - Variant[evm_core.error.ExitFatal]
    /// </summary>
    public sealed class EnumExitFatal : BaseEnumExt<ExitFatal, BaseVoid, BaseVoid, Substrate.Moonsama.NET.NetApiExt.Generated.Model.evm_core.error.EnumExitError, Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.CowT1>
    {
    }
}