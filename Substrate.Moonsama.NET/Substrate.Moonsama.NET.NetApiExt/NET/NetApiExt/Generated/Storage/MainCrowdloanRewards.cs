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


namespace Substrate.Moonsama.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class CrowdloanRewardsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public CrowdloanRewardsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "AccountsPayable"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20), typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "ClaimedRelayChainIds"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "UnassociatedContributions"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8), typeof(Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "Initialized"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "InitRelayBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "EndRelayBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "InitializedRewardAmount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CrowdloanRewards", "TotalContributors"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> AccountsPayableParams
        /// </summary>
        public static string AccountsPayableParams(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "AccountsPayable", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AccountsPayableDefault
        /// Default value as hex string
        /// </summary>
        public static string AccountsPayableDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AccountsPayable
        /// </summary>
        public async Task<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo> AccountsPayable(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key, CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.AccountsPayableParams(key);
            var result = await _client.GetStorageAsync<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ClaimedRelayChainIdsParams
        /// </summary>
        public static string ClaimedRelayChainIdsParams(Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "ClaimedRelayChainIds", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ClaimedRelayChainIdsDefault
        /// Default value as hex string
        /// </summary>
        public static string ClaimedRelayChainIdsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ClaimedRelayChainIds
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple> ClaimedRelayChainIds(Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8 key, CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.ClaimedRelayChainIdsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> UnassociatedContributionsParams
        /// </summary>
        public static string UnassociatedContributionsParams(Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "UnassociatedContributions", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> UnassociatedContributionsDefault
        /// Default value as hex string
        /// </summary>
        public static string UnassociatedContributionsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> UnassociatedContributions
        /// </summary>
        public async Task<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo> UnassociatedContributions(Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8 key, CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.UnassociatedContributionsParams(key);
            var result = await _client.GetStorageAsync<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> InitializedParams
        /// </summary>
        public static string InitializedParams()
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "Initialized", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InitializedDefault
        /// Default value as hex string
        /// </summary>
        public static string InitializedDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Initialized
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> Initialized(CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.InitializedParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> InitRelayBlockParams
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        public static string InitRelayBlockParams()
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "InitRelayBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InitRelayBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string InitRelayBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> InitRelayBlock
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> InitRelayBlock(CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.InitRelayBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> EndRelayBlockParams
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        public static string EndRelayBlockParams()
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "EndRelayBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EndRelayBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string EndRelayBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> EndRelayBlock
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> EndRelayBlock(CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.EndRelayBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> InitializedRewardAmountParams
        ///  Total initialized amount so far. We store this to make pallet funds == contributors reward
        ///  check easier and more efficient
        /// </summary>
        public static string InitializedRewardAmountParams()
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "InitializedRewardAmount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InitializedRewardAmountDefault
        /// Default value as hex string
        /// </summary>
        public static string InitializedRewardAmountDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> InitializedRewardAmount
        ///  Total initialized amount so far. We store this to make pallet funds == contributors reward
        ///  check easier and more efficient
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> InitializedRewardAmount(CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.InitializedRewardAmountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> TotalContributorsParams
        ///  Total number of contributors to aid hinting benchmarking
        /// </summary>
        public static string TotalContributorsParams()
        {
            return RequestGenerator.GetStorage("CrowdloanRewards", "TotalContributors", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TotalContributorsDefault
        /// Default value as hex string
        /// </summary>
        public static string TotalContributorsDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> TotalContributors
        ///  Total number of contributors to aid hinting benchmarking
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> TotalContributors(CancellationToken token)
        {
            string parameters = CrowdloanRewardsStorage.TotalContributorsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
    }
    
    public sealed class CrowdloanRewardsCalls
    {
        
        /// <summary>
        /// >> associate_native_identity
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AssociateNativeIdentity(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 reward_account, Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8 relay_account, Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_runtime.EnumMultiSignature proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reward_account.Encode());
            byteArray.AddRange(relay_account.Encode());
            byteArray.AddRange(proof.Encode());
            return new Method(70, "CrowdloanRewards", 0, "associate_native_identity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_association_with_relay_keys
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ChangeAssociationWithRelayKeys(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 reward_account, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 previous_account, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_runtime.EnumMultiSignature>> proofs)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reward_account.Encode());
            byteArray.AddRange(previous_account.Encode());
            byteArray.AddRange(proofs.Encode());
            return new Method(70, "CrowdloanRewards", 1, "change_association_with_relay_keys", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Claim()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(70, "CrowdloanRewards", 2, "claim", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> update_reward_address
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UpdateRewardAddress(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 new_reward_account)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(new_reward_account.Encode());
            return new Method(70, "CrowdloanRewards", 3, "update_reward_address", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> complete_initialization
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CompleteInitialization(Substrate.NetApi.Model.Types.Primitive.U32 lease_ending_block)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(lease_ending_block.Encode());
            return new Method(70, "CrowdloanRewards", 4, "complete_initialization", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> initialize_reward_vec
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InitializeRewardVec(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Moonsama.NET.NetApiExt.Generated.Types.Base.Arr32U8, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20>, Substrate.NetApi.Model.Types.Primitive.U128>> rewards)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(rewards.Encode());
            return new Method(70, "CrowdloanRewards", 5, "initialize_reward_vec", byteArray.ToArray());
        }
    }
    
    public sealed class CrowdloanRewardsConstants
    {
        
        /// <summary>
        /// >> InitializationPayment
        ///  Percentage to be payed at initialization
        /// </summary>
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill InitializationPayment()
        {
            var result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            result.Create("0x00C2EB0B");
            return result;
        }
        
        /// <summary>
        /// >> MaxInitContributors
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxInitContributors()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x58020000");
            return result;
        }
        
        /// <summary>
        /// >> RewardAddressRelayVoteThreshold
        ///  A fraction representing the percentage of proofs
        ///  that need to be presented to change a reward address through the relay keys
        /// </summary>
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill RewardAddressRelayVoteThreshold()
        {
            var result = new Substrate.Moonsama.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            result.Create("0x00CA9A3B");
            return result;
        }
        
        /// <summary>
        /// >> SignatureNetworkIdentifier
        ///  Network Identifier to be appended into the signatures for reward address change/association
        ///  Prevents replay attacks from one network to the other
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> SignatureNetworkIdentifier()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            result.Create("0x206D6F6F6E73616D61");
            return result;
        }
        
        /// <summary>
        /// >> UnsignedPriority
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 UnsignedPriority()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0xFFFFFFFFFFFFFFFF");
            return result;
        }
    }
    
    public enum CrowdloanRewardsErrors
    {
        
        /// <summary>
        /// >> AlreadyAssociated
        /// User trying to associate a native identity with a relay chain identity for posterior
        /// reward claiming provided an already associated relay chain identity
        /// </summary>
        AlreadyAssociated,
        
        /// <summary>
        /// >> BatchBeyondFundPot
        /// Trying to introduce a batch that goes beyond the limits of the funds
        /// </summary>
        BatchBeyondFundPot,
        
        /// <summary>
        /// >> FirstClaimAlreadyDone
        /// First claim already done
        /// </summary>
        FirstClaimAlreadyDone,
        
        /// <summary>
        /// >> RewardNotHighEnough
        /// The contribution is not high enough to be eligible for rewards
        /// </summary>
        RewardNotHighEnough,
        
        /// <summary>
        /// >> InvalidClaimSignature
        /// User trying to associate a native identity with a relay chain identity for posterior
        /// reward claiming provided a wrong signature
        /// </summary>
        InvalidClaimSignature,
        
        /// <summary>
        /// >> InvalidFreeClaimSignature
        /// User trying to claim the first free reward provided the wrong signature
        /// </summary>
        InvalidFreeClaimSignature,
        
        /// <summary>
        /// >> NoAssociatedClaim
        /// User trying to claim an award did not have an claim associated with it. This may mean
        /// they did not contribute to the crowdloan, or they have not yet associated a native id
        /// with their contribution
        /// </summary>
        NoAssociatedClaim,
        
        /// <summary>
        /// >> RewardsAlreadyClaimed
        /// User trying to claim rewards has already claimed all rewards associated with its
        /// identity and contribution
        /// </summary>
        RewardsAlreadyClaimed,
        
        /// <summary>
        /// >> RewardVecAlreadyInitialized
        /// Reward vec has already been initialized
        /// </summary>
        RewardVecAlreadyInitialized,
        
        /// <summary>
        /// >> RewardVecNotFullyInitializedYet
        /// Reward vec has not yet been fully initialized
        /// </summary>
        RewardVecNotFullyInitializedYet,
        
        /// <summary>
        /// >> RewardsDoNotMatchFund
        /// Rewards should match funds of the pallet
        /// </summary>
        RewardsDoNotMatchFund,
        
        /// <summary>
        /// >> TooManyContributors
        /// Initialize_reward_vec received too many contributors
        /// </summary>
        TooManyContributors,
        
        /// <summary>
        /// >> VestingPeriodNonValid
        /// Provided vesting period is not valid
        /// </summary>
        VestingPeriodNonValid,
        
        /// <summary>
        /// >> NonContributedAddressProvided
        /// User provided a signature from a non-contributor relay account
        /// </summary>
        NonContributedAddressProvided,
        
        /// <summary>
        /// >> InsufficientNumberOfValidProofs
        /// User submitted an unsifficient number of proofs to change the reward address
        /// </summary>
        InsufficientNumberOfValidProofs,
    }
}
