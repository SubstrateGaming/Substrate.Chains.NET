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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_amcl.bls381.big
{
    
    
    /// <summary>
    /// >> 447 - Composite[snowbridge_amcl.bls381.big.Big]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Big : BaseType
    {
        
        /// <summary>
        /// >> w
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Types.Base.Arr14I32 W { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Big";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(W.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            W = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Types.Base.Arr14I32();
            W.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}