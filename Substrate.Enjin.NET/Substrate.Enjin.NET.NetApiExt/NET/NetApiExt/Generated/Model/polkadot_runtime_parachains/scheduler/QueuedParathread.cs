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
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler
{
    
    
    /// <summary>
    /// >> 803 - Composite[polkadot_runtime_parachains.scheduler.QueuedParathread]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class QueuedParathread : BaseType
    {
        
        /// <summary>
        /// >> claim
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.ParathreadEntry Claim { get; set; }
        /// <summary>
        /// >> core_offset
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CoreOffset { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "QueuedParathread";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Claim.Encode());
            result.AddRange(CoreOffset.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Claim = new Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.ParathreadEntry();
            Claim.Decode(byteArray, ref p);
            CoreOffset = new Substrate.NetApi.Model.Types.Primitive.U32();
            CoreOffset.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}