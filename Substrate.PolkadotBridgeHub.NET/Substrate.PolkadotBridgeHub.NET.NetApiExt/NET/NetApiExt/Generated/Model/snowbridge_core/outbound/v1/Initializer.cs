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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.outbound.v1
{
    
    
    /// <summary>
    /// >> 397 - Composite[snowbridge_core.outbound.v1.Initializer]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Initializer : BaseType
    {
        
        /// <summary>
        /// >> params
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Params { get; set; }
        /// <summary>
        /// >> maximum_required_gas
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 MaximumRequiredGas { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Initializer";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Params.Encode());
            result.AddRange(MaximumRequiredGas.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Params = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Params.Decode(byteArray, ref p);
            MaximumRequiredGas = new Substrate.NetApi.Model.Types.Primitive.U64();
            MaximumRequiredGas.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
