//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.pallet_bridge_grandpa.storage_types
{
    
    
    /// <summary>
    /// >> 413 - Composite[pallet_bridge_grandpa.storage_types.StoredAuthoritySet]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class StoredAuthoritySet : BaseType
    {
        
        /// <summary>
        /// >> authorities
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT17 Authorities { get; set; }
        /// <summary>
        /// >> set_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 SetId { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "StoredAuthoritySet";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Authorities.Encode());
            result.AddRange(SetId.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Authorities = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT17();
            Authorities.Decode(byteArray, ref p);
            SetId = new Substrate.NetApi.Model.Types.Primitive.U64();
            SetId.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
