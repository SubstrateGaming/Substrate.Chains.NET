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


namespace Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee
{
    
    
    /// <summary>
    /// >> 156 - Composite[pallet_ajuna_awesome_avatars.types.fee.MintFees]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintFees : BaseType
    {
        
        /// <summary>
        /// >> one
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 One { get; set; }
        /// <summary>
        /// >> three
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Three { get; set; }
        /// <summary>
        /// >> six
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Six { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MintFees";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(One.Encode());
            result.AddRange(Three.Encode());
            result.AddRange(Six.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            One = new Substrate.NetApi.Model.Types.Primitive.U128();
            One.Decode(byteArray, ref p);
            Three = new Substrate.NetApi.Model.Types.Primitive.U128();
            Three.Decode(byteArray, ref p);
            Six = new Substrate.NetApi.Model.Types.Primitive.U128();
            Six.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
