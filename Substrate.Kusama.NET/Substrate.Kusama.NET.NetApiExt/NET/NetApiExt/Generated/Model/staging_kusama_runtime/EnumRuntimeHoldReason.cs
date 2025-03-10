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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_kusama_runtime
{
    
    
    /// <summary>
    /// >> RuntimeHoldReason
    /// </summary>
    public enum RuntimeHoldReason
    {
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 32,
        
        /// <summary>
        /// >> Nis
        /// </summary>
        Nis = 38,
    }
    
    /// <summary>
    /// >> 570 - Variant[staging_kusama_runtime.RuntimeHoldReason]
    /// </summary>
    public sealed class EnumRuntimeHoldReason : BaseEnumRust<RuntimeHoldReason>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRuntimeHoldReason()
        {
				AddTypeDecoder<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_preimage.pallet.EnumHoldReason>(RuntimeHoldReason.Preimage);
				AddTypeDecoder<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_nis.pallet.EnumHoldReason>(RuntimeHoldReason.Nis);
        }
    }
}
