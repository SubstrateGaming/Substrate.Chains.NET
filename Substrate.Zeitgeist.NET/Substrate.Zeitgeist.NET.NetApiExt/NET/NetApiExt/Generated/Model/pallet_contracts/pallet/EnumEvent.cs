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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.pallet_contracts.pallet
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
        /// >> Instantiated
        /// Contract deployed by address at the specified address.
        /// </summary>
        Instantiated = 0,
        
        /// <summary>
        /// >> Terminated
        /// Contract has been removed.
        /// 
        /// # Note
        /// 
        /// The only way for a contract to be removed and emitting this event is by calling
        /// `seal_terminate`.
        /// </summary>
        Terminated = 1,
        
        /// <summary>
        /// >> CodeStored
        /// Code with the specified hash has been stored.
        /// </summary>
        CodeStored = 2,
        
        /// <summary>
        /// >> ContractEmitted
        /// A custom event emitted by the contract.
        /// </summary>
        ContractEmitted = 3,
        
        /// <summary>
        /// >> CodeRemoved
        /// A code with the specified hash was removed.
        /// </summary>
        CodeRemoved = 4,
        
        /// <summary>
        /// >> ContractCodeUpdated
        /// A contract's code was updated.
        /// </summary>
        ContractCodeUpdated = 5,
        
        /// <summary>
        /// >> Called
        /// A contract was called either by a plain account or another contract.
        /// 
        /// # Note
        /// 
        /// Please keep in mind that like all events this is only emitted for successful
        /// calls. This is because on failure all storage changes including events are
        /// rolled back.
        /// </summary>
        Called = 6,
        
        /// <summary>
        /// >> DelegateCalled
        /// A contract delegate called a code hash.
        /// 
        /// # Note
        /// 
        /// Please keep in mind that like all events this is only emitted for successful
        /// calls. This is because on failure all storage changes including events are
        /// rolled back.
        /// </summary>
        DelegateCalled = 7,
    }
    
    /// <summary>
    /// >> 61 - Variant[pallet_contracts.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.primitive_types.H256>>
    {
    }
}