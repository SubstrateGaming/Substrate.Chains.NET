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


namespace Substrate.Moonbeam.NET.NetApiExt.Generated.Model.pallet_moonbeam_orbiters.pallet
{
    
    
    public enum Event
    {
        
        OrbiterJoinCollatorPool = 0,
        
        OrbiterLeaveCollatorPool = 1,
        
        OrbiterRewarded = 2,
        
        OrbiterRotation = 3,
        
        OrbiterRegistered = 4,
        
        OrbiterUnregistered = 5,
    }
    
    /// <summary>
    /// >> 48 - Variant[pallet_moonbeam_orbiters.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>>, BaseTuple<Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Moonbeam.NET.NetApiExt.Generated.Model.account.AccountId20>
    {
    }
}