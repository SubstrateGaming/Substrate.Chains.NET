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


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys
{
    
    
    /// <summary>
    /// >> 443 - Array
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Array)]
    public sealed class Arr512PublicKey : BaseType
    {
        
        /// <summary>
        /// >> Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey[]
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey[] Value { get; set; }
        
        /// <inheritdoc/>
        public override int TypeSize
        {
            get
            {
                return 512;
            }
        }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return string.Format("[{0}; {1}]", new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey().TypeName(), this.TypeSize);
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        /// <inheritdoc/>
        public void Create(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_milagro_bls.keys.PublicKey[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}