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


namespace Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.xcm
{
    
    
    /// <summary>
    /// >> VersionedAssets
    /// </summary>
    public enum VersionedAssets
    {
        
        /// <summary>
        /// >> V2
        /// </summary>
        V2 = 1,
        
        /// <summary>
        /// >> V3
        /// </summary>
        V3 = 3,
        
        /// <summary>
        /// >> V4
        /// </summary>
        V4 = 4,
    }
    
    /// <summary>
    /// >> 96 - Variant[xcm.VersionedAssets]
    /// </summary>
    public sealed class EnumVersionedAssets : BaseEnumExt<VersionedAssets, BaseVoid, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets, BaseVoid, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.xcm.v3.multiasset.MultiAssets, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v4.asset.Assets>
    {
    }
}