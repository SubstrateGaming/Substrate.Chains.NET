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
    
    
    public enum DidSignature
    {
        
        Ed25519 = 0,
        
        Sr25519 = 1,
        
        Ecdsa = 2,
    }
    
    /// <summary>
    /// >> 277 - Variant[did.did_details.DidSignature]
    /// </summary>
    public sealed class EnumDidSignature : BaseEnumExt<DidSignature, Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.ed25519.Signature, Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.sr25519.Signature, Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.ecdsa.Signature>
    {
    }
}