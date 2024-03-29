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


namespace Substrate.Zeitgeist.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> GlobalDisputesStorage
    /// </summary>
    public sealed class GlobalDisputesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> GlobalDisputesStorage Constructor
        /// </summary>
        public GlobalDisputesStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GlobalDisputes", "Locks"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GlobalDisputes", "Outcomes"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.outcome_report.EnumOutcomeReport>), typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.OutcomeInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GlobalDisputes", "GlobalDisputesInfo"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U128), typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.GlobalDisputeInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GlobalDisputes", "Winners"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U128), typeof(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.OldWinnerInfo)));
        }
        
        /// <summary>
        /// >> LocksParams
        ///  All highest lock information (vote id, outcome index and locked balance)
        ///  for a particular voter.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        public static string LocksParams(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("GlobalDisputes", "Locks", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LocksDefault
        /// Default value as hex string
        /// </summary>
        public static string LocksDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Locks
        ///  All highest lock information (vote id, outcome index and locked balance)
        ///  for a particular voter.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39> Locks(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = GlobalDisputesStorage.LocksParams(key);
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT39>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> OutcomesParams
        ///  Maps the market id to the outcome and providing information about the outcome.
        /// </summary>
        public static string OutcomesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.outcome_report.EnumOutcomeReport> key)
        {
            return RequestGenerator.GetStorage("GlobalDisputes", "Outcomes", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> OutcomesDefault
        /// Default value as hex string
        /// </summary>
        public static string OutcomesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Outcomes
        ///  Maps the market id to the outcome and providing information about the outcome.
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.OutcomeInfo> Outcomes(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.outcome_report.EnumOutcomeReport> key, string blockhash, CancellationToken token)
        {
            string parameters = GlobalDisputesStorage.OutcomesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.OutcomeInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> GlobalDisputesInfoParams
        ///  Maps the market id to all information
        ///  about the global dispute.
        /// </summary>
        public static string GlobalDisputesInfoParams(Substrate.NetApi.Model.Types.Primitive.U128 key)
        {
            return RequestGenerator.GetStorage("GlobalDisputes", "GlobalDisputesInfo", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> GlobalDisputesInfoDefault
        /// Default value as hex string
        /// </summary>
        public static string GlobalDisputesInfoDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> GlobalDisputesInfo
        ///  Maps the market id to all information
        ///  about the global dispute.
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.GlobalDisputeInfo> GlobalDisputesInfo(Substrate.NetApi.Model.Types.Primitive.U128 key, string blockhash, CancellationToken token)
        {
            string parameters = GlobalDisputesStorage.GlobalDisputesInfoParams(key);
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.GlobalDisputeInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> WinnersParams
        /// </summary>
        public static string WinnersParams(Substrate.NetApi.Model.Types.Primitive.U128 key)
        {
            return RequestGenerator.GetStorage("GlobalDisputes", "Winners", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> WinnersDefault
        /// Default value as hex string
        /// </summary>
        public static string WinnersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Winners
        /// </summary>
        public async Task<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.OldWinnerInfo> Winners(Substrate.NetApi.Model.Types.Primitive.U128 key, string blockhash, CancellationToken token)
        {
            string parameters = GlobalDisputesStorage.WinnersParams(key);
            var result = await _client.GetStorageAsync<Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zrml_global_disputes.types.OldWinnerInfo>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> GlobalDisputesCalls
    /// </summary>
    public sealed class GlobalDisputesCalls
    {
        
        /// <summary>
        /// >> add_vote_outcome
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddVoteOutcome(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> market_id, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.outcome_report.EnumOutcomeReport outcome)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(market_id.Encode());
            byteArray.AddRange(outcome.Encode());
            return new Method(59, "GlobalDisputes", 0, "add_vote_outcome", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> refund_vote_fees
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RefundVoteFees(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> market_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(market_id.Encode());
            return new Method(59, "GlobalDisputes", 5, "refund_vote_fees", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> purge_outcomes
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PurgeOutcomes(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> market_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(market_id.Encode());
            return new Method(59, "GlobalDisputes", 1, "purge_outcomes", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reward_outcome_owner
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RewardOutcomeOwner(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> market_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(market_id.Encode());
            return new Method(59, "GlobalDisputes", 2, "reward_outcome_owner", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vote_on_outcome
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method VoteOnOutcome(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> market_id, Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.zeitgeist_primitives.outcome_report.EnumOutcomeReport outcome, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(market_id.Encode());
            byteArray.AddRange(outcome.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(59, "GlobalDisputes", 3, "vote_on_outcome", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unlock_vote_balance
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UnlockVoteBalance(Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress voter)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(voter.Encode());
            return new Method(59, "GlobalDisputes", 4, "unlock_vote_balance", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> GlobalDisputesConstants
    /// </summary>
    public sealed class GlobalDisputesConstants
    {
        
        /// <summary>
        /// >> AddOutcomePeriod
        ///  The time period in which the addition of new outcomes are allowed.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 AddOutcomePeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0x201C000000000000");
            return result;
        }
        
        /// <summary>
        /// >> GlobalDisputeLockId
        ///  The vote lock identifier.
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Types.Base.Arr8U8 GlobalDisputeLockId()
        {
            var result = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Types.Base.Arr8U8();
            result.Create("0x7A67652F67646C6B");
            return result;
        }
        
        /// <summary>
        /// >> GlobalDisputesPalletId
        ///  The pallet identifier.
        /// </summary>
        public Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.frame_support.PalletId GlobalDisputesPalletId()
        {
            var result = new Substrate.Zeitgeist.NET.NetApiExt.Generated.Model.frame_support.PalletId();
            result.Create("0x7A67652F676C6470");
            return result;
        }
        
        /// <summary>
        /// >> MaxGlobalDisputeVotes
        ///  The maximum numbers of distinct markets
        ///  on which one account can simultaneously vote on outcomes.
        ///  When the user unlocks, the user has again `MaxGlobalDisputeVotes` number of votes.
        ///  This constant is useful to limit the number of for-loop iterations (weight constraints).
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxGlobalDisputeVotes()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x32000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxOwners
        ///  The maximum number of owners
        ///  for a voting outcome for private API calls of `push_vote_outcome`.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxOwners()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x0A000000");
            return result;
        }
        
        /// <summary>
        /// >> MinOutcomeVoteAmount
        ///  The minimum required amount to vote on an outcome.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinOutcomeVoteAmount()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00E87648170000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> RemoveKeysLimit
        ///  The maximum number of keys to remove from a storage map.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 RemoveKeysLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xFA000000");
            return result;
        }
        
        /// <summary>
        /// >> GdVotingPeriod
        ///  The time period in which votes are allowed.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GdVotingPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0xE0C4000000000000");
            return result;
        }
        
        /// <summary>
        /// >> VotingOutcomeFee
        ///  The fee required to add a voting outcome.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 VotingOutcomeFee()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00204AA9D10100000000000000000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> GlobalDisputesErrors
    /// </summary>
    public enum GlobalDisputesErrors
    {
        
        /// <summary>
        /// >> AmountTooLow
        /// Sender tried to vote with an amount below a defined minimum.
        /// </summary>
        AmountTooLow,
        
        /// <summary>
        /// >> InvalidGlobalDisputeStatus
        /// The global dispute status is invalid for this operation.
        /// </summary>
        InvalidGlobalDisputeStatus,
        
        /// <summary>
        /// >> InsufficientAmount
        /// Sender does not have enough funds for the vote on an outcome.
        /// </summary>
        InsufficientAmount,
        
        /// <summary>
        /// >> MaxOwnersReached
        /// The maximum amount of owners is reached.
        /// </summary>
        MaxOwnersReached,
        
        /// <summary>
        /// >> MaxVotesReached
        /// The maximum number of votes for this account is reached.
        /// </summary>
        MaxVotesReached,
        
        /// <summary>
        /// >> NoFundsToReward
        /// The amount in the reward pot is zero.
        /// </summary>
        NoFundsToReward,
        
        /// <summary>
        /// >> GlobalDisputeNotFound
        /// No global dispute present at the moment.
        /// </summary>
        GlobalDisputeNotFound,
        
        /// <summary>
        /// >> OutcomeAlreadyExists
        /// The voting outcome has been already added.
        /// </summary>
        OutcomeAlreadyExists,
        
        /// <summary>
        /// >> OutcomeDoesNotExist
        /// The outcome specified is not present in the voting outcomes.
        /// </summary>
        OutcomeDoesNotExist,
        
        /// <summary>
        /// >> OutcomeMismatch
        /// Submitted outcome does not match market type.
        /// </summary>
        OutcomeMismatch,
        
        /// <summary>
        /// >> OutcomesNotFullyCleaned
        /// The outcomes are not fully cleaned yet.
        /// </summary>
        OutcomesNotFullyCleaned,
        
        /// <summary>
        /// >> SharedPossessionRequired
        /// Only a shared possession is allowed.
        /// </summary>
        SharedPossessionRequired,
        
        /// <summary>
        /// >> UnfinishedGlobalDispute
        /// The global dispute period is not over yet. The winner is not yet determined.
        /// </summary>
        UnfinishedGlobalDispute,
        
        /// <summary>
        /// >> AddOutcomePeriodIsOver
        /// The period in which outcomes can be added is over.
        /// </summary>
        AddOutcomePeriodIsOver,
        
        /// <summary>
        /// >> NotInGdVotingPeriod
        /// It is not inside the period in which votes are allowed.
        /// </summary>
        NotInGdVotingPeriod,
        
        /// <summary>
        /// >> GlobalDisputeNotDestroyed
        /// The operation requires a global dispute in a destroyed state.
        /// </summary>
        GlobalDisputeNotDestroyed,
        
        /// <summary>
        /// >> GlobalDisputeAlreadyExists
        /// The global dispute was already started.
        /// </summary>
        GlobalDisputeAlreadyExists,
    }
}
