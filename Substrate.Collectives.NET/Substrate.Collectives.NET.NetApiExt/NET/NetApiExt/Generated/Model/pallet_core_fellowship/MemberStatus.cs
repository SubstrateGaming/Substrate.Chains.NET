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


namespace Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_core_fellowship
{
    
    
    /// <summary>
    /// >> 447 - Composite[pallet_core_fellowship.MemberStatus]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MemberStatus : BaseType
    {
        
        /// <summary>
        /// >> is_active
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool IsActive { get; set; }
        /// <summary>
        /// >> last_promotion
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LastPromotion { get; set; }
        /// <summary>
        /// >> last_proof
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LastProof { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MemberStatus";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(IsActive.Encode());
            result.AddRange(LastPromotion.Encode());
            result.AddRange(LastProof.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            IsActive = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsActive.Decode(byteArray, ref p);
            LastPromotion = new Substrate.NetApi.Model.Types.Primitive.U32();
            LastPromotion.Decode(byteArray, ref p);
            LastProof = new Substrate.NetApi.Model.Types.Primitive.U32();
            LastProof.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}