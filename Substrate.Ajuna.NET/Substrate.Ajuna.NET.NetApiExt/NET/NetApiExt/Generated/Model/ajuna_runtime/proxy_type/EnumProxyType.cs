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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.ajuna_runtime.proxy_type
{
    
    
    public enum ProxyType
    {
        
        Any = 0,
        
        NonTransfer = 1,
        
        Governance = 2,
        
        Staking = 3,
        
        IdentityJudgement = 4,
        
        CancelProxy = 5,
    }
    
    /// <summary>
    /// >> 39 - Variant[ajuna_runtime.proxy_type.ProxyType]
    /// </summary>
    public sealed class EnumProxyType : BaseEnum<ProxyType>
    {
    }
}