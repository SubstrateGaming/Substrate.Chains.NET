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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v4
{
    
    
    /// <summary>
    /// >> 463 - Composite[polkadot_primitives.v4.CandidateReceipt]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CandidateReceipt : BaseType
    {
        
        /// <summary>
        /// >> descriptor
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.CandidateDescriptor _descriptor;
        
        /// <summary>
        /// >> commitments_hash
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 _commitmentsHash;
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.CandidateDescriptor Descriptor
        {
            get
            {
                return this._descriptor;
            }
            set
            {
                this._descriptor = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256 CommitmentsHash
        {
            get
            {
                return this._commitmentsHash;
            }
            set
            {
                this._commitmentsHash = value;
            }
        }
        
        public override string TypeName()
        {
            return "CandidateReceipt";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Descriptor.Encode());
            result.AddRange(CommitmentsHash.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Descriptor = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v4.CandidateDescriptor();
            Descriptor.Decode(byteArray, ref p);
            CommitmentsHash = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256();
            CommitmentsHash.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}