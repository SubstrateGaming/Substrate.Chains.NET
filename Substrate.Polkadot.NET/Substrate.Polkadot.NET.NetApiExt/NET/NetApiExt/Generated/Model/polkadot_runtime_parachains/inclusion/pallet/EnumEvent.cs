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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> CandidateBacked
        /// A candidate was backed. `[candidate, head_data]`
        /// </summary>
        CandidateBacked = 0,
        
        /// <summary>
        /// >> CandidateIncluded
        /// A candidate was included. `[candidate, head_data]`
        /// </summary>
        CandidateIncluded = 1,
        
        /// <summary>
        /// >> CandidateTimedOut
        /// A candidate timed out. `[candidate, head_data]`
        /// </summary>
        CandidateTimedOut = 2,
        
        /// <summary>
        /// >> UpwardMessagesReceived
        /// Some upward messages have been received and will be processed.
        /// </summary>
        UpwardMessagesReceived = 3,
    }
    
    /// <summary>
    /// >> 474 - Variant[polkadot_runtime_parachains.inclusion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateReceipt, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CoreIndex, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.GroupIndex>>(Event.CandidateBacked);
				AddTypeDecoder<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateReceipt, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CoreIndex, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.GroupIndex>>(Event.CandidateIncluded);
				AddTypeDecoder<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateReceipt, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CoreIndex>>(Event.CandidateTimedOut);
				AddTypeDecoder<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.UpwardMessagesReceived);
        }
    }
}
