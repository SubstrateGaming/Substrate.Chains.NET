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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v5
{
    
    
    /// <summary>
    /// >> 368 - Composite[polkadot_primitives.v5.PvfCheckStatement]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PvfCheckStatement : BaseType
    {
        
        /// <summary>
        /// >> accept
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool Accept { get; set; }
        /// <summary>
        /// >> subject
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCodeHash Subject { get; set; }
        /// <summary>
        /// >> session_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SessionIndex { get; set; }
        /// <summary>
        /// >> validator_index
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.ValidatorIndex ValidatorIndex { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PvfCheckStatement";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Accept.Encode());
            result.AddRange(Subject.Encode());
            result.AddRange(SessionIndex.Encode());
            result.AddRange(ValidatorIndex.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Accept = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Accept.Decode(byteArray, ref p);
            Subject = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCodeHash();
            Subject.Decode(byteArray, ref p);
            SessionIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            SessionIndex.Decode(byteArray, ref p);
            ValidatorIndex = new Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.ValidatorIndex();
            ValidatorIndex.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}