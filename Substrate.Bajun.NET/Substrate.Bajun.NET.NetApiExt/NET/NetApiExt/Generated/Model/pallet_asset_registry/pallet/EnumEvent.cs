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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_asset_registry.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ReserveAssetRegistered
        /// </summary>
        ReserveAssetRegistered = 0,
        
        /// <summary>
        /// >> ReserveAssetUnregistered
        /// </summary>
        ReserveAssetUnregistered = 1,
    }
    
    /// <summary>
    /// >> 203 - Variant[pallet_asset_registry.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Bajun.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location>>(Event.ReserveAssetRegistered);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Bajun.NET.NetApiExt.Generated.Model.staging_xcm.v4.location.Location>>(Event.ReserveAssetUnregistered);
        }
    }
}
