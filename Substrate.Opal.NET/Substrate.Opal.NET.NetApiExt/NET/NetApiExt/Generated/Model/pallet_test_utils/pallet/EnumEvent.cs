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


namespace Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_test_utils.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ValueIsSet
        /// </summary>
        ValueIsSet = 0,
        
        /// <summary>
        /// >> ShouldRollback
        /// </summary>
        ShouldRollback = 1,
        
        /// <summary>
        /// >> BatchCompleted
        /// </summary>
        BatchCompleted = 2,
    }
    
    /// <summary>
    /// >> 387 - Variant[pallet_test_utils.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnum<Event>
    {
    }
}