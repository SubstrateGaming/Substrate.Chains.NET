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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.ctype.pallet
{
    
    
    public enum Event
    {
        
        CTypeCreated = 0,
        
        CTypeUpdated = 1,
    }
    
    /// <summary>
    /// >> 61 - Variant[ctype.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256>
    {
    }
}
