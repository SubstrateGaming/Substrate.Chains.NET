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


namespace Substrate.Vara.NET.NetApiExt.Generated.Model.pallet_gear.schedule
{
    
    
    /// <summary>
    /// >> 604 - Composite[pallet_gear.schedule.MemoryWeights]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MemoryWeights : BaseType
    {
        
        /// <summary>
        /// >> lazy_pages_signal_read
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LazyPagesSignalRead { get; set; }
        /// <summary>
        /// >> lazy_pages_signal_write
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LazyPagesSignalWrite { get; set; }
        /// <summary>
        /// >> lazy_pages_signal_write_after_read
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LazyPagesSignalWriteAfterRead { get; set; }
        /// <summary>
        /// >> lazy_pages_host_func_read
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LazyPagesHostFuncRead { get; set; }
        /// <summary>
        /// >> lazy_pages_host_func_write
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LazyPagesHostFuncWrite { get; set; }
        /// <summary>
        /// >> lazy_pages_host_func_write_after_read
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LazyPagesHostFuncWriteAfterRead { get; set; }
        /// <summary>
        /// >> load_page_data
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight LoadPageData { get; set; }
        /// <summary>
        /// >> upload_page_data
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight UploadPageData { get; set; }
        /// <summary>
        /// >> static_page
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight StaticPage { get; set; }
        /// <summary>
        /// >> mem_grow
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight MemGrow { get; set; }
        /// <summary>
        /// >> parachain_read_heuristic
        /// </summary>
        public Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight ParachainReadHeuristic { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MemoryWeights";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(LazyPagesSignalRead.Encode());
            result.AddRange(LazyPagesSignalWrite.Encode());
            result.AddRange(LazyPagesSignalWriteAfterRead.Encode());
            result.AddRange(LazyPagesHostFuncRead.Encode());
            result.AddRange(LazyPagesHostFuncWrite.Encode());
            result.AddRange(LazyPagesHostFuncWriteAfterRead.Encode());
            result.AddRange(LoadPageData.Encode());
            result.AddRange(UploadPageData.Encode());
            result.AddRange(StaticPage.Encode());
            result.AddRange(MemGrow.Encode());
            result.AddRange(ParachainReadHeuristic.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            LazyPagesSignalRead = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LazyPagesSignalRead.Decode(byteArray, ref p);
            LazyPagesSignalWrite = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LazyPagesSignalWrite.Decode(byteArray, ref p);
            LazyPagesSignalWriteAfterRead = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LazyPagesSignalWriteAfterRead.Decode(byteArray, ref p);
            LazyPagesHostFuncRead = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LazyPagesHostFuncRead.Decode(byteArray, ref p);
            LazyPagesHostFuncWrite = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LazyPagesHostFuncWrite.Decode(byteArray, ref p);
            LazyPagesHostFuncWriteAfterRead = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LazyPagesHostFuncWriteAfterRead.Decode(byteArray, ref p);
            LoadPageData = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            LoadPageData.Decode(byteArray, ref p);
            UploadPageData = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            UploadPageData.Decode(byteArray, ref p);
            StaticPage = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            StaticPage.Decode(byteArray, ref p);
            MemGrow = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            MemGrow.Decode(byteArray, ref p);
            ParachainReadHeuristic = new Substrate.Vara.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            ParachainReadHeuristic.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}