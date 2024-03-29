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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_common.assigned_slots.pallet
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
        /// >> PermanentSlotAssigned
        /// A para was assigned a permanent parachain slot
        /// </summary>
        PermanentSlotAssigned = 0,
        
        /// <summary>
        /// >> TemporarySlotAssigned
        /// A para was assigned a temporary parachain slot
        /// </summary>
        TemporarySlotAssigned = 1,
    }
    
    /// <summary>
    /// >> 175 - Variant[polkadot_runtime_common.assigned_slots.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>
    {
    }
}
