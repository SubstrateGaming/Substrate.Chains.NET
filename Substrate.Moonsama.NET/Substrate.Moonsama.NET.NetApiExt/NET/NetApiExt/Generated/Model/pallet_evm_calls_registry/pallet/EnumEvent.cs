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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.pallet
{
    
    
    public enum Event
    {
        
        RegisteredFreeCallSignature = 0,
        
        UnregisteredFreeCallSignature = 1,
        
        FreeCallsRequestedSuccessfully = 2,
    }
    
    /// <summary>
    /// >> 118 - Variant[pallet_evm_calls_registry.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr4U8, Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EnumFreeCallType>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr4U8, Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EnumFreeCallType>, BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}