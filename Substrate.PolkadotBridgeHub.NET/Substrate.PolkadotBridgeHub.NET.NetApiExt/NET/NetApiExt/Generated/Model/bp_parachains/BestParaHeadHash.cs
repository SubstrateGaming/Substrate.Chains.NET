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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_parachains
{
    
    
    /// <summary>
    /// >> 418 - Composite[bp_parachains.BestParaHeadHash]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BestParaHeadHash : BaseType
    {
        
        /// <summary>
        /// >> at_relay_block_number
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AtRelayBlockNumber { get; set; }
        /// <summary>
        /// >> head_hash
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 HeadHash { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BestParaHeadHash";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AtRelayBlockNumber.Encode());
            result.AddRange(HeadHash.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AtRelayBlockNumber = new Substrate.NetApi.Model.Types.Primitive.U32();
            AtRelayBlockNumber.Decode(byteArray, ref p);
            HeadHash = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256();
            HeadHash.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}