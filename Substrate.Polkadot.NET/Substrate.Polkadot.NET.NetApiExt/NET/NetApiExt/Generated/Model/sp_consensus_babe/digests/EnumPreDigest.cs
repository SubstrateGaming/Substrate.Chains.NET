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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.digests
{
    
    
    /// <summary>
    /// >> PreDigest
    /// </summary>
    public enum PreDigest
    {
        
        /// <summary>
        /// >> Primary
        /// </summary>
        Primary = 1,
        
        /// <summary>
        /// >> SecondaryPlain
        /// </summary>
        SecondaryPlain = 2,
        
        /// <summary>
        /// >> SecondaryVRF
        /// </summary>
        SecondaryVRF = 3,
    }
    
    /// <summary>
    /// >> 558 - Variant[sp_consensus_babe.digests.PreDigest]
    /// </summary>
    public sealed class EnumPreDigest : BaseEnumExt<PreDigest, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.digests.PrimaryPreDigest, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.digests.SecondaryPlainPreDigest, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.digests.SecondaryVRFPreDigest>
    {
    }
}
