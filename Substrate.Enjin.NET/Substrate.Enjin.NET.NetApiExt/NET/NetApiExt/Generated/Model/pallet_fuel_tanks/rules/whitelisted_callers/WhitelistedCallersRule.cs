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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_fuel_tanks.rules.whitelisted_callers
{
    
    
    /// <summary>
    /// >> 264 - Composite[pallet_fuel_tanks.rules.whitelisted_callers.WhitelistedCallersRule]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class WhitelistedCallersRule : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT2 Value { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "WhitelistedCallersRule";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set.BoundedBTreeSetT2();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
