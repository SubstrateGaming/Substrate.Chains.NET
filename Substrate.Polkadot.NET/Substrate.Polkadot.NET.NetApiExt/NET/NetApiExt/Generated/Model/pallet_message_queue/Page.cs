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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_message_queue
{
    
    
    /// <summary>
    /// >> 825 - Composite[pallet_message_queue.Page]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Page : BaseType
    {
        
        /// <summary>
        /// >> remaining
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _remaining;
        
        /// <summary>
        /// >> remaining_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _remainingSize;
        
        /// <summary>
        /// >> first_index
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _firstIndex;
        
        /// <summary>
        /// >> first
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _first;
        
        /// <summary>
        /// >> last
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _last;
        
        /// <summary>
        /// >> heap
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 _heap;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Remaining
        {
            get
            {
                return this._remaining;
            }
            set
            {
                this._remaining = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 RemainingSize
        {
            get
            {
                return this._remainingSize;
            }
            set
            {
                this._remainingSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 FirstIndex
        {
            get
            {
                return this._firstIndex;
            }
            set
            {
                this._firstIndex = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 First
        {
            get
            {
                return this._first;
            }
            set
            {
                this._first = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Last
        {
            get
            {
                return this._last;
            }
            set
            {
                this._last = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 Heap
        {
            get
            {
                return this._heap;
            }
            set
            {
                this._heap = value;
            }
        }
        
        public override string TypeName()
        {
            return "Page";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Remaining.Encode());
            result.AddRange(RemainingSize.Encode());
            result.AddRange(FirstIndex.Encode());
            result.AddRange(First.Encode());
            result.AddRange(Last.Encode());
            result.AddRange(Heap.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Remaining = new Substrate.NetApi.Model.Types.Primitive.U32();
            Remaining.Decode(byteArray, ref p);
            RemainingSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            RemainingSize.Decode(byteArray, ref p);
            FirstIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            FirstIndex.Decode(byteArray, ref p);
            First = new Substrate.NetApi.Model.Types.Primitive.U32();
            First.Decode(byteArray, ref p);
            Last = new Substrate.NetApi.Model.Types.Primitive.U32();
            Last.Decode(byteArray, ref p);
            Heap = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43();
            Heap.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}