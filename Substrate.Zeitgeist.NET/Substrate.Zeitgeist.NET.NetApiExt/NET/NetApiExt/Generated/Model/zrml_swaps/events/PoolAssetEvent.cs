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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_swaps.events
{
    
    
    /// <summary>
    /// >> 97 - Composite[zrml_swaps.events.PoolAssetEvent]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PoolAssetEvent : BaseType
    {
        
        /// <summary>
        /// >> asset
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset Asset { get; set; }
        /// <summary>
        /// >> bound
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Bound { get; set; }
        /// <summary>
        /// >> cpep
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_swaps.events.CommonPoolEventParams Cpep { get; set; }
        /// <summary>
        /// >> transferred
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Transferred { get; set; }
        /// <summary>
        /// >> pool_amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 PoolAmount { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PoolAssetEvent";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Asset.Encode());
            result.AddRange(Bound.Encode());
            result.AddRange(Cpep.Encode());
            result.AddRange(Transferred.Encode());
            result.AddRange(PoolAmount.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Asset = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.asset.EnumAsset();
            Asset.Decode(byteArray, ref p);
            Bound = new Substrate.NetApi.Model.Types.Primitive.U128();
            Bound.Decode(byteArray, ref p);
            Cpep = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_swaps.events.CommonPoolEventParams();
            Cpep.Decode(byteArray, ref p);
            Transferred = new Substrate.NetApi.Model.Types.Primitive.U128();
            Transferred.Decode(byteArray, ref p);
            PoolAmount = new Substrate.NetApi.Model.Types.Primitive.U128();
            PoolAmount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
