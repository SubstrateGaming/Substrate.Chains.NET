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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_whitelist.pallet
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
        /// >> CallWhitelisted
        /// </summary>
        CallWhitelisted = 0,
        
        /// <summary>
        /// >> WhitelistedCallRemoved
        /// </summary>
        WhitelistedCallRemoved = 1,
        
        /// <summary>
        /// >> WhitelistedCallDispatched
        /// </summary>
        WhitelistedCallDispatched = 2,
    }
    
    /// <summary>
    /// >> 642 - Variant[pallet_whitelist.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Enjin.NET.NetApiExt.Generated.Types.Base.EnumResult>>
    {
    }
}