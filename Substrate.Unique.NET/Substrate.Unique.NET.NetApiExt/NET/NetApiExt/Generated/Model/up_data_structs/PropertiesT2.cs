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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 437 - Composite[up_data_structs.PropertiesT2]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PropertiesT2 : BaseType
    {
        
        /// <summary>
        /// >> map
        /// </summary>
        private Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT1 _map;
        
        /// <summary>
        /// >> consumed_space
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _consumedSpace;
        
        /// <summary>
        /// >> _reserved
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _reserved;
        
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT1 Map
        {
            get
            {
                return this._map;
            }
            set
            {
                this._map = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ConsumedSpace
        {
            get
            {
                return this._consumedSpace;
            }
            set
            {
                this._consumedSpace = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Reserved
        {
            get
            {
                return this._reserved;
            }
            set
            {
                this._reserved = value;
            }
        }
        
        public override string TypeName()
        {
            return "PropertiesT2";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Map.Encode());
            result.AddRange(ConsumedSpace.Encode());
            result.AddRange(Reserved.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Map = new Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT1();
            Map.Decode(byteArray, ref p);
            ConsumedSpace = new Substrate.NetApi.Model.Types.Primitive.U32();
            ConsumedSpace.Decode(byteArray, ref p);
            Reserved = new Substrate.NetApi.Model.Types.Primitive.U32();
            Reserved.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}