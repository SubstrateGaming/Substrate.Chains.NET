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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_validator_manager.pallet
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
        /// >> ValidatorsRegistered
        /// New validators were added to the set.
        /// </summary>
        ValidatorsRegistered = 0,
        
        /// <summary>
        /// >> ValidatorsDeregistered
        /// Validators were removed from the set.
        /// </summary>
        ValidatorsDeregistered = 1,
    }
    
    /// <summary>
    /// >> 176 - Variant[pallet_validator_manager.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>
    {
    }
}