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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_salary.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Inducted
        /// A member is inducted into the payroll.
        /// </summary>
        Inducted = 0,
        
        /// <summary>
        /// >> Registered
        /// A member registered for a payout.
        /// </summary>
        Registered = 1,
        
        /// <summary>
        /// >> Paid
        /// A payment happened.
        /// </summary>
        Paid = 2,
        
        /// <summary>
        /// >> CycleStarted
        /// The next cycle begins.
        /// </summary>
        CycleStarted = 3,
        
        /// <summary>
        /// >> Swapped
        /// A member swapped their account.
        /// </summary>
        Swapped = 4,
    }
    
    /// <summary>
    /// >> 271 - Variant[pallet_salary.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(Event.Inducted);
				AddTypeDecoder<BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Registered);
				AddTypeDecoder<BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U64>>(Event.Paid);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.CycleStarted);
				AddTypeDecoder<BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.Swapped);
        }
    }
}