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


namespace Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_staking
{
    
    
    /// <summary>
    /// >> 623 - Composite[sp_staking.PagedExposureMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PagedExposureMetadata : BaseType
    {
        
        /// <summary>
        /// >> total
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> Total { get; set; }
        /// <summary>
        /// >> own
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> Own { get; set; }
        /// <summary>
        /// >> nominator_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 NominatorCount { get; set; }
        /// <summary>
        /// >> page_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PageCount { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PagedExposureMetadata";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(Own.Encode());
            result.AddRange(NominatorCount.Encode());
            result.AddRange(PageCount.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Total.Decode(byteArray, ref p);
            Own = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            Own.Decode(byteArray, ref p);
            NominatorCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            NominatorCount.Decode(byteArray, ref p);
            PageCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            PageCount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}