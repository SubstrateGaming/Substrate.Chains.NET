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


namespace Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker
{
    
    
    /// <summary>
    /// >> 388 - Composite[pallet_avn_finality_tracker.SubmissionData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SubmissionData : BaseType
    {
        
        /// <summary>
        /// >> finalised_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _finalisedBlock;
        
        /// <summary>
        /// >> submitted_at_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _submittedAtBlock;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 FinalisedBlock
        {
            get
            {
                return this._finalisedBlock;
            }
            set
            {
                this._finalisedBlock = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SubmittedAtBlock
        {
            get
            {
                return this._submittedAtBlock;
            }
            set
            {
                this._submittedAtBlock = value;
            }
        }
        
        public override string TypeName()
        {
            return "SubmissionData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(FinalisedBlock.Encode());
            result.AddRange(SubmittedAtBlock.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            FinalisedBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            FinalisedBlock.Decode(byteArray, ref p);
            SubmittedAtBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            SubmittedAtBlock.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}