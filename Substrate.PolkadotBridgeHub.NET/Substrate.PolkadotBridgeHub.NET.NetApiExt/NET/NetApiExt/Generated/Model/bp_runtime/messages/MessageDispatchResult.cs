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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_runtime.messages
{
    
    
    /// <summary>
    /// >> 153 - Composite[bp_runtime.messages.MessageDispatchResult]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MessageDispatchResult : BaseType
    {
        
        /// <summary>
        /// >> unspent_weight
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight UnspentWeight { get; set; }
        /// <summary>
        /// >> dispatch_level_result
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bridge_runtime_common.messages_xcm_extension.EnumXcmBlobMessageDispatchResult DispatchLevelResult { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MessageDispatchResult";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UnspentWeight.Encode());
            result.AddRange(DispatchLevelResult.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UnspentWeight = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            UnspentWeight.Decode(byteArray, ref p);
            DispatchLevelResult = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bridge_runtime_common.messages_xcm_extension.EnumXcmBlobMessageDispatchResult();
            DispatchLevelResult.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}