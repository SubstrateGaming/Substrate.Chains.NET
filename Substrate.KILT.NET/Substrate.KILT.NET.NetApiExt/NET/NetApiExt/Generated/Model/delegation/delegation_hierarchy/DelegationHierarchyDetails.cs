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


namespace Substrate.KILT.NET.NetApiExt.Generated.Model.delegation.delegation_hierarchy
{
    
    
    /// <summary>
    /// >> 425 - Composite[delegation.delegation_hierarchy.DelegationHierarchyDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DelegationHierarchyDetails : BaseType
    {
        
        /// <summary>
        /// >> ctype_hash
        /// </summary>
        private Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256 _ctypeHash;
        
        public Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256 CtypeHash
        {
            get
            {
                return this._ctypeHash;
            }
            set
            {
                this._ctypeHash = value;
            }
        }
        
        public override string TypeName()
        {
            return "DelegationHierarchyDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(CtypeHash.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            CtypeHash = new Substrate.KILT.NET.NetApiExt.Generated.Model.primitive_types.H256();
            CtypeHash.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}