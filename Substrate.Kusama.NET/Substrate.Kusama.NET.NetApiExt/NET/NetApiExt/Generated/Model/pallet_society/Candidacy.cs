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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society
{
    
    
    /// <summary>
    /// >> 674 - Composite[pallet_society.Candidacy]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Candidacy : BaseType
    {
        
        /// <summary>
        /// >> round
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Round { get; set; }
        /// <summary>
        /// >> kind
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.EnumBidKind Kind { get; set; }
        /// <summary>
        /// >> bid
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Bid { get; set; }
        /// <summary>
        /// >> tally
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.Tally Tally { get; set; }
        /// <summary>
        /// >> skeptic_struck
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool SkepticStruck { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Candidacy";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Round.Encode());
            result.AddRange(Kind.Encode());
            result.AddRange(Bid.Encode());
            result.AddRange(Tally.Encode());
            result.AddRange(SkepticStruck.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Round = new Substrate.NetApi.Model.Types.Primitive.U32();
            Round.Decode(byteArray, ref p);
            Kind = new Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.EnumBidKind();
            Kind.Decode(byteArray, ref p);
            Bid = new Substrate.NetApi.Model.Types.Primitive.U128();
            Bid.Decode(byteArray, ref p);
            Tally = new Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society.Tally();
            Tally.Decode(byteArray, ref p);
            SkepticStruck = new Substrate.NetApi.Model.Types.Primitive.Bool();
            SkepticStruck.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}