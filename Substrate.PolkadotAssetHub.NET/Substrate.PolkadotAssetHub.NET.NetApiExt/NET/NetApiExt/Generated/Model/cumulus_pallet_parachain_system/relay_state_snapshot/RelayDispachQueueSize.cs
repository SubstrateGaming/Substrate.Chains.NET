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


namespace Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.relay_state_snapshot
{
    
    
    /// <summary>
    /// >> 153 - Composite[cumulus_pallet_parachain_system.relay_state_snapshot.RelayDispachQueueSize]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RelayDispachQueueSize : BaseType
    {
        
        /// <summary>
        /// >> remaining_count
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _remainingCount;
        
        /// <summary>
        /// >> remaining_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _remainingSize;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 RemainingCount
        {
            get
            {
                return this._remainingCount;
            }
            set
            {
                this._remainingCount = value;
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
        
        public override string TypeName()
        {
            return "RelayDispachQueueSize";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(RemainingCount.Encode());
            result.AddRange(RemainingSize.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            RemainingCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            RemainingCount.Decode(byteArray, ref p);
            RemainingSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            RemainingSize.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}