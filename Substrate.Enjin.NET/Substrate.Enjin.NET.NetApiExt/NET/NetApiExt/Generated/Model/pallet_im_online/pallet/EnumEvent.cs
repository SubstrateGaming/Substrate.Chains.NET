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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_im_online.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> HeartbeatReceived
        /// A new heartbeat was received from `AuthorityId`.
        /// </summary>
        HeartbeatReceived = 0,
        
        /// <summary>
        /// >> AllGood
        /// At the end of the session, no offence was committed.
        /// </summary>
        AllGood = 1,
        
        /// <summary>
        /// >> SomeOffline
        /// At the end of the session, at least one validator was found to be offline.
        /// </summary>
        SomeOffline = 2,
    }
    
    /// <summary>
    /// >> 57 - Variant[pallet_im_online.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_im_online.sr25519.app_sr25519.Public, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_staking.Exposure>>>
    {
    }
}
