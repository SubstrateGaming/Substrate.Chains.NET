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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_election_provider_multi_phase
{
    
    
    /// <summary>
    /// >> 728 - Composite[pallet_election_provider_multi_phase.ReadySolution]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ReadySolution : BaseType
    {
        
        /// <summary>
        /// >> supports
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35 Supports { get; set; }
        /// <summary>
        /// >> score
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_npos_elections.ElectionScore Score { get; set; }
        /// <summary>
        /// >> compute
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_election_provider_multi_phase.EnumElectionCompute Compute { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ReadySolution";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Supports.Encode());
            result.AddRange(Score.Encode());
            result.AddRange(Compute.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Supports = new Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35();
            Supports.Decode(byteArray, ref p);
            Score = new Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_npos_elections.ElectionScore();
            Score.Decode(byteArray, ref p);
            Compute = new Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_election_provider_multi_phase.EnumElectionCompute();
            Compute.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
