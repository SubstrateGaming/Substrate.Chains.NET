//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Collectives.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> AmbassadorCollectiveStorage
    /// </summary>
    public sealed class AmbassadorCollectiveStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AmbassadorCollectiveStorage Constructor
        /// </summary>
        public AmbassadorCollectiveStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCollective", "MemberCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCollective", "Members"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCollective", "IdToIndex"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCollective", "IndexToId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCollective", "Voting"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AmbassadorCollective", "VotingCleanup"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31)));
        }
        
        /// <summary>
        /// >> MemberCountParams
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        public static string MemberCountParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("AmbassadorCollective", "MemberCount", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MemberCountDefault
        /// Default value as hex string
        /// </summary>
        public static string MemberCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> MemberCount
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> MemberCount(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCollectiveStorage.MemberCountParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current members of the collective.
        /// </summary>
        public static string MembersParams(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("AmbassadorCollective", "Members", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MembersDefault
        /// Default value as hex string
        /// </summary>
        public static string MembersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective.
        /// </summary>
        public async Task<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord> Members(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCollectiveStorage.MembersParams(key);
            var result = await _client.GetStorageAsync<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> IdToIndexParams
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        public static string IdToIndexParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("AmbassadorCollective", "IdToIndex", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> IdToIndexDefault
        /// Default value as hex string
        /// </summary>
        public static string IdToIndexDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> IdToIndex
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> IdToIndex(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCollectiveStorage.IdToIndexParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> IndexToIdParams
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        public static string IndexToIdParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("AmbassadorCollective", "IndexToId", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> IndexToIdDefault
        /// Default value as hex string
        /// </summary>
        public static string IndexToIdDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> IndexToId
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        public async Task<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> IndexToId(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCollectiveStorage.IndexToIdParams(key);
            var result = await _client.GetStorageAsync<Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> VotingParams
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public static string VotingParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("AmbassadorCollective", "Voting", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VotingDefault
        /// Default value as hex string
        /// </summary>
        public static string VotingDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public async Task<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord> Voting(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCollectiveStorage.VotingParams(key);
            var result = await _client.GetStorageAsync<Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> VotingCleanupParams
        /// </summary>
        public static string VotingCleanupParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("AmbassadorCollective", "VotingCleanup", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> VotingCleanupDefault
        /// Default value as hex string
        /// </summary>
        public static string VotingCleanupDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VotingCleanup
        /// </summary>
        public async Task<Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31> VotingCleanup(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = AmbassadorCollectiveStorage.VotingCleanupParams(key);
            var result = await _client.GetStorageAsync<Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AmbassadorCollectiveCalls
    /// </summary>
    public sealed class AmbassadorCollectiveCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AddMember(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(70, "AmbassadorCollective", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> promote_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method PromoteMember(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(70, "AmbassadorCollective", 1, "promote_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> demote_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method DemoteMember(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(70, "AmbassadorCollective", 2, "demote_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveMember(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Substrate.NetApi.Model.Types.Primitive.U16 min_rank)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(min_rank.Encode());
            return new Method(70, "AmbassadorCollective", 3, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vote
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Vote(Substrate.NetApi.Model.Types.Primitive.U32 poll, Substrate.NetApi.Model.Types.Primitive.Bool aye)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll.Encode());
            byteArray.AddRange(aye.Encode());
            return new Method(70, "AmbassadorCollective", 4, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cleanup_poll
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CleanupPoll(Substrate.NetApi.Model.Types.Primitive.U32 poll_index, Substrate.NetApi.Model.Types.Primitive.U32 max)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll_index.Encode());
            byteArray.AddRange(max.Encode());
            return new Method(70, "AmbassadorCollective", 5, "cleanup_poll", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> exchange_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ExchangeMember(Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress new_who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(new_who.Encode());
            return new Method(70, "AmbassadorCollective", 6, "exchange_member", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> AmbassadorCollectiveConstants
    /// </summary>
    public sealed class AmbassadorCollectiveConstants
    {
    }
    
    /// <summary>
    /// >> AmbassadorCollectiveErrors
    /// </summary>
    public enum AmbassadorCollectiveErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Account is already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Account is not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> NotPolling
        /// The given poll index is unknown or has closed.
        /// </summary>
        NotPolling,
        
        /// <summary>
        /// >> Ongoing
        /// The given poll is still ongoing.
        /// </summary>
        Ongoing,
        
        /// <summary>
        /// >> NoneRemaining
        /// There are no further records to be removed.
        /// </summary>
        NoneRemaining,
        
        /// <summary>
        /// >> Corruption
        /// Unexpected error in state.
        /// </summary>
        Corruption,
        
        /// <summary>
        /// >> RankTooLow
        /// The member's rank is too low to vote.
        /// </summary>
        RankTooLow,
        
        /// <summary>
        /// >> InvalidWitness
        /// The information provided is incorrect.
        /// </summary>
        InvalidWitness,
        
        /// <summary>
        /// >> NoPermission
        /// The origin is not sufficiently privileged to do the operation.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> SameMember
        /// The new member to exchange is the same as the old member
        /// </summary>
        SameMember,
    }
}