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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.runtime_common.assets
{
    
    
    /// <summary>
    /// >> 76 - Composite[runtime_common.assets.AssetDid]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetDid : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.kilt_asset_dids.v1.AssetDid _value;
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.kilt_asset_dids.v1.AssetDid Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "AssetDid";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.KILT.NET.NetApiExt.Generated.Model.kilt_asset_dids.v1.AssetDid();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}