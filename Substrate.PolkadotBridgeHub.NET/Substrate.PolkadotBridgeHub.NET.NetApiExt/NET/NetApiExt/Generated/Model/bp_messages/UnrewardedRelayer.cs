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
    /// >> 427 - Composite[bp_messages.UnrewardedRelayer]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UnrewardedRelayer : BaseType
    {
        
        /// <summary>
        /// >> relayer
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Relayer { get; set; }
        /// <summary>
        /// >> messages
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.DeliveredMessages Messages { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UnrewardedRelayer";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Relayer.Encode());
            result.AddRange(Messages.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Relayer = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Relayer.Decode(byteArray, ref p);
            Messages = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages.DeliveredMessages();
            Messages.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}