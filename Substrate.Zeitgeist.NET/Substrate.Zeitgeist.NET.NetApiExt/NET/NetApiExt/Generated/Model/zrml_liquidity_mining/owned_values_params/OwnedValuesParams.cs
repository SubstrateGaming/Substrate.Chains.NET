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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_liquidity_mining.owned_values_params
{
    
    
    /// <summary>
    /// >> 504 - Composite[zrml_liquidity_mining.owned_values_params.OwnedValuesParams]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class OwnedValuesParams : BaseType
    {
        
        /// <summary>
        /// >> participated_blocks
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 ParticipatedBlocks { get; set; }
        /// <summary>
        /// >> perpetual_incentives
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 PerpetualIncentives { get; set; }
        /// <summary>
        /// >> total_incentives
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalIncentives { get; set; }
        /// <summary>
        /// >> total_shares
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalShares { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "OwnedValuesParams";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ParticipatedBlocks.Encode());
            result.AddRange(PerpetualIncentives.Encode());
            result.AddRange(TotalIncentives.Encode());
            result.AddRange(TotalShares.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ParticipatedBlocks = new Substrate.NetApi.Model.Types.Primitive.U64();
            ParticipatedBlocks.Decode(byteArray, ref p);
            PerpetualIncentives = new Substrate.NetApi.Model.Types.Primitive.U128();
            PerpetualIncentives.Decode(byteArray, ref p);
            TotalIncentives = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalIncentives.Decode(byteArray, ref p);
            TotalShares = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalShares.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
