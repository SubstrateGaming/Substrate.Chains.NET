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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Model.frame_support.traits.misc
{
    
    
    /// <summary>
    /// >> 748 - Composite[frame_support.traits.misc.WrapperOpaque]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class WrapperOpaque : BaseType
    {
        
        /// <summary>
        /// >> value0
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Value0 { get; set; }
        /// <summary>
        /// >> T
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_im_online.BoundedOpaqueNetworkState T { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "WrapperOpaque";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value0.Encode());
            result.AddRange(T.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value0 = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Value0.Decode(byteArray, ref p);
            T = new Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_im_online.BoundedOpaqueNetworkState();
            T.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}