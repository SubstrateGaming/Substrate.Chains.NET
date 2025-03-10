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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types
{
    
    
    /// <summary>
    /// >> 442 - Composite[snowbridge_beacon_primitives.types.SyncCommitteePrepared]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SyncCommitteePrepared : BaseType
    {
        
        /// <summary>
        /// >> root
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 Root { get; set; }
        /// <summary>
        /// >> pubkeys
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.Arr512PublicKey Pubkeys { get; set; }
        /// <summary>
        /// >> aggregate_pubkey
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey AggregatePubkey { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SyncCommitteePrepared";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Root.Encode());
            result.AddRange(Pubkeys.Encode());
            result.AddRange(AggregatePubkey.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Root = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256();
            Root.Decode(byteArray, ref p);
            Pubkeys = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.Arr512PublicKey();
            Pubkeys.Decode(byteArray, ref p);
            AggregatePubkey = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey();
            AggregatePubkey.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
