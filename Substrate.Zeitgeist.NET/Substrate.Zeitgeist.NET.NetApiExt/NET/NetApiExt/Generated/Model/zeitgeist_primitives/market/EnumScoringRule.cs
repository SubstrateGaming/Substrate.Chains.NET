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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.market
{
    
    
    /// <summary>
    /// >> ScoringRule
    /// </summary>
    public enum ScoringRule
    {
        
        /// <summary>
        /// >> Lmsr
        /// </summary>
        Lmsr = 0,
        
        /// <summary>
        /// >> Orderbook
        /// </summary>
        Orderbook = 1,
        
        /// <summary>
        /// >> Parimutuel
        /// </summary>
        Parimutuel = 2,
    }
    
    /// <summary>
    /// >> 111 - Variant[zeitgeist_primitives.market.ScoringRule]
    /// </summary>
    public sealed class EnumScoringRule : BaseEnum<ScoringRule>
    {
    }
}