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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types
{
    
    
    /// <summary>
    /// >> 548 - Composite[zrml_global_disputes.types.OldOutcomeInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class OldOutcomeInfo : BaseType
    {
        
        /// <summary>
        /// >> outcome_sum
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 OutcomeSum { get; set; }
        /// <summary>
        /// >> owners
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT40 Owners { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "OldOutcomeInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(OutcomeSum.Encode());
            result.AddRange(Owners.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            OutcomeSum = new Substrate.NetApi.Model.Types.Primitive.U128();
            OutcomeSum.Decode(byteArray, ref p);
            Owners = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT40();
            Owners.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
