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
    /// >> MarketStatus
    /// </summary>
    public enum MarketStatus
    {
        
        /// <summary>
        /// >> Proposed
        /// </summary>
        Proposed = 0,
        
        /// <summary>
        /// >> Active
        /// </summary>
        Active = 1,
        
        /// <summary>
        /// >> Closed
        /// </summary>
        Closed = 2,
        
        /// <summary>
        /// >> Reported
        /// </summary>
        Reported = 3,
        
        /// <summary>
        /// >> Disputed
        /// </summary>
        Disputed = 4,
        
        /// <summary>
        /// >> Resolved
        /// </summary>
        Resolved = 5,
    }
    
    /// <summary>
    /// >> 103 - Variant[zeitgeist_primitives.market.MarketStatus]
    /// </summary>
    public sealed class EnumMarketStatus : BaseEnum<MarketStatus>
    {
    }
}
