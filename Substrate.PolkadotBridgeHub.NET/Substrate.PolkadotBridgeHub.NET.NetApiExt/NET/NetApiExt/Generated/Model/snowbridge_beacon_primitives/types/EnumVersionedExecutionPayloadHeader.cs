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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types
{
    
    
    /// <summary>
    /// >> VersionedExecutionPayloadHeader
    /// </summary>
    public enum VersionedExecutionPayloadHeader
    {
        
        /// <summary>
        /// >> Capella
        /// </summary>
        Capella = 0,
        
        /// <summary>
        /// >> Deneb
        /// </summary>
        Deneb = 1,
    }
    
    /// <summary>
    /// >> 379 - Variant[snowbridge_beacon_primitives.types.VersionedExecutionPayloadHeader]
    /// </summary>
    public sealed class EnumVersionedExecutionPayloadHeader : BaseEnumRust<VersionedExecutionPayloadHeader>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVersionedExecutionPayloadHeader()
        {
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.ExecutionPayloadHeader>(VersionedExecutionPayloadHeader.Capella);
				AddTypeDecoder<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.deneb.ExecutionPayloadHeader>(VersionedExecutionPayloadHeader.Deneb);
        }
    }
}
