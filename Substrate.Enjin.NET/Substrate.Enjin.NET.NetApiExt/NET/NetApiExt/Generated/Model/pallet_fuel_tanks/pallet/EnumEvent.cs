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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.pallet
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
        /// >> FuelTankCreated
        /// A new [`FuelTank`] was created.
        /// </summary>
        FuelTankCreated = 0,
        
        /// <summary>
        /// >> FuelTankMutated
        /// A [`FuelTank`] was mutated
        /// </summary>
        FuelTankMutated = 1,
        
        /// <summary>
        /// >> FuelTankDestroyed
        /// A [`FuelTank`] was destroyed
        /// </summary>
        FuelTankDestroyed = 2,
        
        /// <summary>
        /// >> CallDispatched
        /// A call was dispatched through a [`FuelTank`].
        /// </summary>
        CallDispatched = 3,
        
        /// <summary>
        /// >> AccountAdded
        /// An account was added to a [`FuelTank`]
        /// </summary>
        AccountAdded = 4,
        
        /// <summary>
        /// >> AccountRemoved
        /// An account was removed from a [`FuelTank`]
        /// </summary>
        AccountRemoved = 5,
        
        /// <summary>
        /// >> AccountRuleDataRemoved
        /// Account data of [`AccountId`](frame_system::Config::AccountId) was removed from
        /// [`RuleSetId`](Config::RuleSetId)
        /// </summary>
        AccountRuleDataRemoved = 6,
        
        /// <summary>
        /// >> RuleSetInserted
        /// A new rule set was added to [`FuelTank`]
        /// </summary>
        RuleSetInserted = 7,
        
        /// <summary>
        /// >> RuleSetRemoved
        /// A rule set was removed from [`FuelTank`]
        /// </summary>
        RuleSetRemoved = 8,
        
        /// <summary>
        /// >> FreezeStateMutated
        /// The freeze state change for fuel tank or its rule set was executed in `on_finalize`
        /// </summary>
        FreezeStateMutated = 9,
        
        /// <summary>
        /// >> DispatchFailed
        /// The dispatch of a call has failed
        /// </summary>
        DispatchFailed = 10,
        
        /// <summary>
        /// >> ConsumptionSet
        /// The consumption for an account was set for a rule set on a [`FuelTank`]
        /// </summary>
        ConsumptionSet = 11,
    }
    
    /// <summary>
    /// >> 251 - Variant[pallet_fuel_tanks.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.ep_core.frame.types.BoundedStringT3, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.impls.DefaultTankMutation>, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.rules.EnumDispatchRuleKind>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError>, BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.types.Consumption>>
    {
    }
}