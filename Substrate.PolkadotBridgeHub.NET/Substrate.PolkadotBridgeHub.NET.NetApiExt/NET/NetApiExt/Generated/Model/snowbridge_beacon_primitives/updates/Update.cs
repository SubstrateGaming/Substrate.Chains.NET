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
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.updates
{
    
    
    /// <summary>
    /// >> 389 - Composite[snowbridge_beacon_primitives.updates.Update]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Update : BaseType
    {
        
        /// <summary>
        /// >> attested_header
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.BeaconHeader AttestedHeader { get; set; }
        /// <summary>
        /// >> sync_aggregate
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncAggregate SyncAggregate { get; set; }
        /// <summary>
        /// >> signature_slot
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 SignatureSlot { get; set; }
        /// <summary>
        /// >> next_sync_committee_update
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.updates.NextSyncCommitteeUpdate> NextSyncCommitteeUpdate { get; set; }
        /// <summary>
        /// >> finalized_header
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.BeaconHeader FinalizedHeader { get; set; }
        /// <summary>
        /// >> finality_branch
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> FinalityBranch { get; set; }
        /// <summary>
        /// >> block_roots_root
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 BlockRootsRoot { get; set; }
        /// <summary>
        /// >> block_roots_branch
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> BlockRootsBranch { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Update";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AttestedHeader.Encode());
            result.AddRange(SyncAggregate.Encode());
            result.AddRange(SignatureSlot.Encode());
            result.AddRange(NextSyncCommitteeUpdate.Encode());
            result.AddRange(FinalizedHeader.Encode());
            result.AddRange(FinalityBranch.Encode());
            result.AddRange(BlockRootsRoot.Encode());
            result.AddRange(BlockRootsBranch.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AttestedHeader = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.BeaconHeader();
            AttestedHeader.Decode(byteArray, ref p);
            SyncAggregate = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncAggregate();
            SyncAggregate.Decode(byteArray, ref p);
            SignatureSlot = new Substrate.NetApi.Model.Types.Primitive.U64();
            SignatureSlot.Decode(byteArray, ref p);
            NextSyncCommitteeUpdate = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.updates.NextSyncCommitteeUpdate>();
            NextSyncCommitteeUpdate.Decode(byteArray, ref p);
            FinalizedHeader = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.BeaconHeader();
            FinalizedHeader.Decode(byteArray, ref p);
            FinalityBranch = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>();
            FinalityBranch.Decode(byteArray, ref p);
            BlockRootsRoot = new Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256();
            BlockRootsRoot.Decode(byteArray, ref p);
            BlockRootsBranch = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>();
            BlockRootsBranch.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}