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


namespace Substrate.HydraDX.NET.NetApiExt.Generated.Model.xcm.v2.multiasset
{
    
    
    /// <summary>
    /// >> MultiAssetFilter
    /// </summary>
    public enum MultiAssetFilter
    {
        
        /// <summary>
        /// >> Definite
        /// </summary>
        Definite = 0,
        
        /// <summary>
        /// >> Wild
        /// </summary>
        Wild = 1,
    }
    
    /// <summary>
    /// >> 432 - Variant[xcm.v2.multiasset.MultiAssetFilter]
    /// </summary>
    public sealed class EnumMultiAssetFilter : BaseEnumRust<MultiAssetFilter>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumMultiAssetFilter()
        {
				AddTypeDecoder<Substrate.HydraDX.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.MultiAssets>(MultiAssetFilter.Definite);
				AddTypeDecoder<Substrate.HydraDX.NET.NetApiExt.Generated.Model.xcm.v2.multiasset.EnumWildMultiAsset>(MultiAssetFilter.Wild);
        }
    }
}