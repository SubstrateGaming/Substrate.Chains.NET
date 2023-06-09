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


namespace Substrate.Statemine.NET.NetApiExt.Generated.Model.pallet_multisig.pallet
{
    
    
    public enum Event
    {
        
        NewMultisig = 0,
        
        MultisigApproval = 1,
        
        MultisigExecuted = 2,
        
        MultisigCancelled = 3,
    }
    
    /// <summary>
    /// >> 104 - Variant[pallet_multisig.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Types.Base.Arr32U8>, BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Model.pallet_multisig.Timepoint, Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Types.Base.Arr32U8>, BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Model.pallet_multisig.Timepoint, Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.Statemine.NET.NetApiExt.Generated.Types.Base.EnumResult>, BaseTuple<Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Model.pallet_multisig.Timepoint, Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Statemine.NET.NetApiExt.Generated.Types.Base.Arr32U8>>
    {
    }
}
