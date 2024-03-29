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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_simple_disputes.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InvalidMarketStatus
        /// 1. Any resolution must either have a `Disputed` or `Reported` market status
        /// 2. If status is `Disputed`, then at least one dispute must exist
        /// </summary>
        InvalidMarketStatus = 0,
        
        /// <summary>
        /// >> MarketDoesNotHaveSimpleDisputesMechanism
        /// On dispute or resolution, someone tried to pass a non-simple-disputes market type
        /// </summary>
        MarketDoesNotHaveSimpleDisputesMechanism = 1,
        
        /// <summary>
        /// >> StorageOverflow
        /// </summary>
        StorageOverflow = 2,
        
        /// <summary>
        /// >> OutcomeMismatch
        /// </summary>
        OutcomeMismatch = 3,
        
        /// <summary>
        /// >> CannotDisputeSameOutcome
        /// </summary>
        CannotDisputeSameOutcome = 4,
        
        /// <summary>
        /// >> MarketIsNotReported
        /// </summary>
        MarketIsNotReported = 5,
        
        /// <summary>
        /// >> MaxDisputesReached
        /// The maximum number of disputes has been reached.
        /// </summary>
        MaxDisputesReached = 6,
    }
    
    /// <summary>
    /// >> 529 - Variant[zrml_simple_disputes.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
