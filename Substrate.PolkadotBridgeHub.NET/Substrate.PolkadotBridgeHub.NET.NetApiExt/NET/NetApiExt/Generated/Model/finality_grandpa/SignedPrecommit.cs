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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.finality_grandpa
{
    
    
    /// <summary>
    /// >> 137 - Composite[finality_grandpa.SignedPrecommit]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SignedPrecommit : BaseType
    {
        
        /// <summary>
        /// >> precommit
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.finality_grandpa.Precommit Precommit { get; set; }
        /// <summary>
        /// >> signature
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature Signature { get; set; }
        /// <summary>
        /// >> id
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public Id { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SignedPrecommit";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Precommit.Encode());
            result.AddRange(Signature.Encode());
            result.AddRange(Id.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Precommit = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.finality_grandpa.Precommit();
            Precommit.Decode(byteArray, ref p);
            Signature = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Signature();
            Signature.Decode(byteArray, ref p);
            Id = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.app.Public();
            Id.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}