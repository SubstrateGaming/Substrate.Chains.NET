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


namespace Substrate.GameDAO.NET.NetApiExt.Generated.Model.cumulus_pallet_xcm.pallet
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
        /// >> InvalidFormat
        /// Downward message is invalid XCM.
        /// \[ id \]
        /// </summary>
        InvalidFormat = 0,
        
        /// <summary>
        /// >> UnsupportedVersion
        /// Downward message is unsupported version of XCM.
        /// \[ id \]
        /// </summary>
        UnsupportedVersion = 1,
        
        /// <summary>
        /// >> ExecutedDownward
        /// Downward message executed with the given outcome.
        /// \[ id, outcome \]
        /// </summary>
        ExecutedDownward = 2,
    }
    
    /// <summary>
    /// >> 137 - Variant[cumulus_pallet_xcm.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.GameDAO.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.GameDAO.NET.NetApiExt.Generated.Types.Base.Arr32U8, BaseTuple<Substrate.GameDAO.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.GameDAO.NET.NetApiExt.Generated.Model.xcm.v3.traits.EnumOutcome>>
    {
    }
}