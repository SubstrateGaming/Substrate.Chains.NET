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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_migrations.pallet
{
    
    
    public enum Event
    {
        
        RuntimeUpgradeStarted = 0,
        
        RuntimeUpgradeCompleted = 1,
        
        MigrationStarted = 2,
        
        MigrationCompleted = 3,
        
        FailedToSuspendIdleXcmExecution = 4,
        
        FailedToResumeIdleXcmExecution = 5,
    }
    
    /// <summary>
    /// >> 58 - Variant[pallet_migrations.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseVoid, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError>
    {
    }
}
