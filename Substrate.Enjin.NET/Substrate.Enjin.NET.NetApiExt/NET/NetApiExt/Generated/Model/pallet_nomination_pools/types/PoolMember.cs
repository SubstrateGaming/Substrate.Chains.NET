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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_nomination_pools.types
{
    
    
    /// <summary>
    /// >> 759 - Composite[pallet_nomination_pools.types.PoolMember]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PoolMember : BaseType
    {
        
        /// <summary>
        /// >> unbonding_eras
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT7 UnbondingEras { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PoolMember";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UnbondingEras.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UnbondingEras = new Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT7();
            UnbondingEras.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
