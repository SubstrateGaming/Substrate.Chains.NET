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
    /// >> 801 - Composite[polkadot_runtime_parachains.scheduler.ParathreadClaimQueue]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ParathreadClaimQueue : BaseType
    {
        
        /// <summary>
        /// >> queue
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler.QueuedParathread> Queue { get; set; }
        /// <summary>
        /// >> next_core_offset
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 NextCoreOffset { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ParathreadClaimQueue";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Queue.Encode());
            result.AddRange(NextCoreOffset.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Queue = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Enjin.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler.QueuedParathread>();
            Queue.Decode(byteArray, ref p);
            NextCoreOffset = new Substrate.NetApi.Model.Types.Primitive.U32();
            NextCoreOffset.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
