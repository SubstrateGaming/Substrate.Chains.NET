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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details
{
    
    
    public enum DidVerificationKey
    {
        
        Ed25519 = 0,
        
        Sr25519 = 1,
        
        Ecdsa = 2,
    }
    
    /// <summary>
    /// >> 299 - Variant[did.did_details.DidVerificationKey]
    /// </summary>
    public sealed class EnumDidVerificationKey : BaseEnumExt<DidVerificationKey, Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.ed25519.Public, Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public, Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.ecdsa.Public>
    {
    }
}