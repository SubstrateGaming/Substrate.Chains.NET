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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages
{
    
    
    /// <summary>
    /// >> 429 - Composite[bp_messages.MessageKey]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MessageKey : BaseType
    {
        
        /// <summary>
        /// >> lane_id
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.LaneId LaneId { get; set; }
        /// <summary>
        /// >> nonce
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 Nonce { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MessageKey";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(LaneId.Encode());
            result.AddRange(Nonce.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            LaneId = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.LaneId();
            LaneId.Decode(byteArray, ref p);
            Nonce = new Substrate.NetApi.Model.Types.Primitive.U64();
            Nonce.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}