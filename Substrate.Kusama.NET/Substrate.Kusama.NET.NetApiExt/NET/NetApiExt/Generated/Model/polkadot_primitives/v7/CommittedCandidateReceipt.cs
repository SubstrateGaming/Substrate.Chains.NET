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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7
{
    
    
    /// <summary>
    /// >> 324 - Composite[polkadot_primitives.v7.CommittedCandidateReceipt]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CommittedCandidateReceipt : BaseType
    {
        
        /// <summary>
        /// >> descriptor
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateDescriptor Descriptor { get; set; }
        /// <summary>
        /// >> commitments
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateCommitments Commitments { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CommittedCandidateReceipt";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Descriptor.Encode());
            result.AddRange(Commitments.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Descriptor = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateDescriptor();
            Descriptor.Decode(byteArray, ref p);
            Commitments = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CandidateCommitments();
            Commitments.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}