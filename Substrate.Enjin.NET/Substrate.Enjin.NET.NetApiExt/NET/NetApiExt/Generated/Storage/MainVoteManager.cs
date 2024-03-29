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


namespace Substrate.Enjin.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> VoteManagerStorage
    /// </summary>
    public sealed class VoteManagerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> VoteManagerStorage Constructor
        /// </summary>
        public VoteManagerStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("VoteManager", "VoteCurrencies"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("VoteManager", "VotesToUnlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock)));
        }
        
        /// <summary>
        /// >> VoteCurrenciesParams
        ///  The currency used by `AccountId` to vote in Poll with
        ///  `PollIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public static string VoteCurrenciesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("VoteManager", "VoteCurrencies", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VoteCurrenciesDefault
        /// Default value as hex string
        /// </summary>
        public static string VoteCurrenciesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VoteCurrencies
        ///  The currency used by `AccountId` to vote in Poll with
        ///  `PollIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public async Task<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency> VoteCurrencies(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = VoteManagerStorage.VoteCurrenciesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> VotesToUnlockParams
        ///  The currency used by `AccountId` to vote in referendum with
        ///  `ReferendumIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public static string VotesToUnlockParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("VoteManager", "VotesToUnlock", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VotesToUnlockDefault
        /// Default value as hex string
        /// </summary>
        public static string VotesToUnlockDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VotesToUnlock
        ///  The currency used by `AccountId` to vote in referendum with
        ///  `ReferendumIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public async Task<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock> VotesToUnlock(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = VoteManagerStorage.VotesToUnlockParams(key);
            var result = await _client.GetStorageAsync<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> VoteManagerCalls
    /// </summary>
    public sealed class VoteManagerCalls
    {
        
        /// <summary>
        /// >> vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vote(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> poll_index, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_conviction_voting.vote.EnumAccountVote vote, Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency currency)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll_index.Encode());
            byteArray.AddRange(vote.Encode());
            byteArray.AddRange(currency.Encode());
            return new Method(109, "VoteManager", 0, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveVote(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U16> @class, Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(109, "VoteManager", 1, "remove_vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_other_vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveOtherVote(Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target, Substrate.NetApi.Model.Types.Primitive.U16 @class, Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(109, "VoteManager", 2, "remove_other_vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unlock
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unlock(Substrate.NetApi.Model.Types.Primitive.U16 @class, Substrate.Enjin.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target, Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@class.Encode());
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(109, "VoteManager", 3, "unlock", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> VoteManagerConstants
    /// </summary>
    public sealed class VoteManagerConstants
    {
    }
    
    /// <summary>
    /// >> VoteManagerErrors
    /// </summary>
    public enum VoteManagerErrors
    {
        
        /// <summary>
        /// >> AlreadyDelegating
        /// The account is already delegating their vote.
        /// </summary>
        AlreadyDelegating,
        
        /// <summary>
        /// >> InsufficientFunds
        /// The account has insufficient funds to cast the vote.
        /// </summary>
        InsufficientFunds,
        
        /// <summary>
        /// >> NotOngoing
        /// The maximum number of votes for this referendum has been reached.
        /// </summary>
        NotOngoing,
        
        /// <summary>
        /// >> NotVoter
        /// The account is not a registered voter for the referendum.
        /// </summary>
        NotVoter,
        
        /// <summary>
        /// >> NoPermission
        /// The account does not have permission to perform the operation.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> UnlockVoteNotFound
        /// The vote unlock information was not found.
        /// </summary>
        UnlockVoteNotFound,
        
        /// <summary>
        /// >> UnlockPeriodNotPassed
        /// The unlock period for the vote has not yet passed.
        /// </summary>
        UnlockPeriodNotPassed,
        
        /// <summary>
        /// >> MaxVotesReached
        /// Max votes exceeded
        /// </summary>
        MaxVotesReached,
        
        /// <summary>
        /// >> ClassNeeded
        /// Class info missing
        /// </summary>
        ClassNeeded,
        
        /// <summary>
        /// >> NoPermissionYet
        /// The account does not have permission, usually related to unlock periods
        /// </summary>
        NoPermissionYet,
    }
}
