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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.public_credentials.pallet
{
    
    
    public enum Event
    {
        
        CredentialStored = 0,
        
        CredentialRemoved = 1,
        
        CredentialRevoked = 2,
        
        CredentialUnrevoked = 3,
    }
    
    /// <summary>
    /// >> 75 - Variant[public_credentials.pallet.Event]
    /// The events generated by this pallet.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets.AssetDid, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256>
    {
    }
}
