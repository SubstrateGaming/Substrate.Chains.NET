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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_im_online
{
    
    
    /// <summary>
    /// >> 749 - Composite[pallet_im_online.BoundedOpaqueNetworkState]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedOpaqueNetworkState : BaseType
    {
        
        /// <summary>
        /// >> peer_id
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6 PeerId { get; set; }
        /// <summary>
        /// >> external_addresses
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT7 ExternalAddresses { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BoundedOpaqueNetworkState";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PeerId.Encode());
            result.AddRange(ExternalAddresses.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PeerId = new Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6();
            PeerId.Decode(byteArray, ref p);
            ExternalAddresses = new Substrate.Enjin.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT7();
            ExternalAddresses.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}