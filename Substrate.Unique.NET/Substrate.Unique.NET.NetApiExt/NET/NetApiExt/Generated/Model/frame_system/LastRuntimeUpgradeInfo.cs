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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.frame_system
{
    
    
    /// <summary>
    /// >> 143 - Composite[frame_system.LastRuntimeUpgradeInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class LastRuntimeUpgradeInfo : BaseType
    {
        
        /// <summary>
        /// >> spec_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _specVersion;
        
        /// <summary>
        /// >> spec_name
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Str _specName;
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> SpecVersion
        {
            get
            {
                return this._specVersion;
            }
            set
            {
                this._specVersion = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Str SpecName
        {
            get
            {
                return this._specName;
            }
            set
            {
                this._specName = value;
            }
        }
        
        public override string TypeName()
        {
            return "LastRuntimeUpgradeInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecVersion.Encode());
            result.AddRange(SpecName.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecVersion = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            SpecVersion.Decode(byteArray, ref p);
            SpecName = new Substrate.NetApi.Model.Types.Primitive.Str();
            SpecName.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}