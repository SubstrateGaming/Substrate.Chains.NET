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


namespace Substrate.Astar.NET.NetApiExt.Generated.Model.astar_runtime
{
    
    
    public enum ProxyType
    {
        
        Any = 0,
        
        NonTransfer = 1,
        
        Balances = 2,
        
        Assets = 3,
        
        IdentityJudgement = 4,
        
        CancelProxy = 5,
        
        DappsStaking = 6,
        
        StakerRewardClaim = 7,
    }
    
    /// <summary>
    /// >> 36 - Variant[astar_runtime.ProxyType]
    /// </summary>
    public sealed class EnumProxyType : BaseEnum<ProxyType>
    {
    }
}