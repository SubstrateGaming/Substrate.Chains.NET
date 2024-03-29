//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Moonsama.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ICrowdloanRewardsStorage interface definition.
    /// </summary>
    public interface ICrowdloanRewardsStorage : IStorage
    {
        
        /// <summary>
        /// >> AccountsPayable
        /// </summary>
        Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo GetAccountsPayable(string key);
        
        /// <summary>
        /// >> ClaimedRelayChainIds
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple GetClaimedRelayChainIds(string key);
        
        /// <summary>
        /// >> UnassociatedContributions
        /// </summary>
        Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo GetUnassociatedContributions(string key);
        
        /// <summary>
        /// >> Initialized
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetInitialized();
        
        /// <summary>
        /// >> InitRelayBlock
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetInitRelayBlock();
        
        /// <summary>
        /// >> EndRelayBlock
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetEndRelayBlock();
        
        /// <summary>
        /// >> InitializedRewardAmount
        ///  Total initialized amount so far. We store this to make pallet funds == contributors reward
        ///  check easier and more efficient
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetInitializedRewardAmount();
        
        /// <summary>
        /// >> TotalContributors
        ///  Total number of contributors to aid hinting benchmarking
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTotalContributors();
    }
    
    /// <summary>
    /// CrowdloanRewardsStorage class definition.
    /// </summary>
    public sealed class CrowdloanRewardsStorage : ICrowdloanRewardsStorage
    {
        
        /// <summary>
        /// _accountsPayableTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo> _accountsPayableTypedStorage;
        
        /// <summary>
        /// _claimedRelayChainIdsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> _claimedRelayChainIdsTypedStorage;
        
        /// <summary>
        /// _unassociatedContributionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo> _unassociatedContributionsTypedStorage;
        
        /// <summary>
        /// _initializedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _initializedTypedStorage;
        
        /// <summary>
        /// _initRelayBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _initRelayBlockTypedStorage;
        
        /// <summary>
        /// _endRelayBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _endRelayBlockTypedStorage;
        
        /// <summary>
        /// _initializedRewardAmountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _initializedRewardAmountTypedStorage;
        
        /// <summary>
        /// _totalContributorsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _totalContributorsTypedStorage;
        
        /// <summary>
        /// CrowdloanRewardsStorage constructor.
        /// </summary>
        public CrowdloanRewardsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AccountsPayableTypedStorage = new TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo>("CrowdloanRewards.AccountsPayable", storageDataProvider, storageChangeDelegates);
            this.ClaimedRelayChainIdsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple>("CrowdloanRewards.ClaimedRelayChainIds", storageDataProvider, storageChangeDelegates);
            this.UnassociatedContributionsTypedStorage = new TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo>("CrowdloanRewards.UnassociatedContributions", storageDataProvider, storageChangeDelegates);
            this.InitializedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("CrowdloanRewards.Initialized", storageDataProvider, storageChangeDelegates);
            this.InitRelayBlockTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("CrowdloanRewards.InitRelayBlock", storageDataProvider, storageChangeDelegates);
            this.EndRelayBlockTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("CrowdloanRewards.EndRelayBlock", storageDataProvider, storageChangeDelegates);
            this.InitializedRewardAmountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("CrowdloanRewards.InitializedRewardAmount", storageDataProvider, storageChangeDelegates);
            this.TotalContributorsTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("CrowdloanRewards.TotalContributors", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _accountsPayableTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo> AccountsPayableTypedStorage
        {
            get
            {
                return _accountsPayableTypedStorage;
            }
            set
            {
                _accountsPayableTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _claimedRelayChainIdsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> ClaimedRelayChainIdsTypedStorage
        {
            get
            {
                return _claimedRelayChainIdsTypedStorage;
            }
            set
            {
                _claimedRelayChainIdsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _unassociatedContributionsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo> UnassociatedContributionsTypedStorage
        {
            get
            {
                return _unassociatedContributionsTypedStorage;
            }
            set
            {
                _unassociatedContributionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _initializedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> InitializedTypedStorage
        {
            get
            {
                return _initializedTypedStorage;
            }
            set
            {
                _initializedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _initRelayBlockTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> InitRelayBlockTypedStorage
        {
            get
            {
                return _initRelayBlockTypedStorage;
            }
            set
            {
                _initRelayBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _endRelayBlockTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> EndRelayBlockTypedStorage
        {
            get
            {
                return _endRelayBlockTypedStorage;
            }
            set
            {
                _endRelayBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _initializedRewardAmountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> InitializedRewardAmountTypedStorage
        {
            get
            {
                return _initializedRewardAmountTypedStorage;
            }
            set
            {
                _initializedRewardAmountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _totalContributorsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> TotalContributorsTypedStorage
        {
            get
            {
                return _totalContributorsTypedStorage;
            }
            set
            {
                _totalContributorsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AccountsPayableTypedStorage.InitializeAsync("CrowdloanRewards", "AccountsPayable");
            await ClaimedRelayChainIdsTypedStorage.InitializeAsync("CrowdloanRewards", "ClaimedRelayChainIds");
            await UnassociatedContributionsTypedStorage.InitializeAsync("CrowdloanRewards", "UnassociatedContributions");
            await InitializedTypedStorage.InitializeAsync("CrowdloanRewards", "Initialized");
            await InitRelayBlockTypedStorage.InitializeAsync("CrowdloanRewards", "InitRelayBlock");
            await EndRelayBlockTypedStorage.InitializeAsync("CrowdloanRewards", "EndRelayBlock");
            await InitializedRewardAmountTypedStorage.InitializeAsync("CrowdloanRewards", "InitializedRewardAmount");
            await TotalContributorsTypedStorage.InitializeAsync("CrowdloanRewards", "TotalContributors");
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.AccountsPayable
        /// </summary>
        [StorageChange("CrowdloanRewards", "AccountsPayable")]
        public void OnUpdateAccountsPayable(string key, string data)
        {
            AccountsPayableTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AccountsPayable
        /// </summary>
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo GetAccountsPayable(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountsPayableTypedStorage.Dictionary.TryGetValue(key, out Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.ClaimedRelayChainIds
        /// </summary>
        [StorageChange("CrowdloanRewards", "ClaimedRelayChainIds")]
        public void OnUpdateClaimedRelayChainIds(string key, string data)
        {
            ClaimedRelayChainIdsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ClaimedRelayChainIds
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple GetClaimedRelayChainIds(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ClaimedRelayChainIdsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.UnassociatedContributions
        /// </summary>
        [StorageChange("CrowdloanRewards", "UnassociatedContributions")]
        public void OnUpdateUnassociatedContributions(string key, string data)
        {
            UnassociatedContributionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> UnassociatedContributions
        /// </summary>
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo GetUnassociatedContributions(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (UnassociatedContributionsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_crowdloan_rewards.pallet.RewardInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.Initialized
        /// </summary>
        [StorageChange("CrowdloanRewards", "Initialized")]
        public void OnUpdateInitialized(string data)
        {
            InitializedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Initialized
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetInitialized()
        {
            return InitializedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.InitRelayBlock
        /// </summary>
        [StorageChange("CrowdloanRewards", "InitRelayBlock")]
        public void OnUpdateInitRelayBlock(string data)
        {
            InitRelayBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InitRelayBlock
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetInitRelayBlock()
        {
            return InitRelayBlockTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.EndRelayBlock
        /// </summary>
        [StorageChange("CrowdloanRewards", "EndRelayBlock")]
        public void OnUpdateEndRelayBlock(string data)
        {
            EndRelayBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> EndRelayBlock
        ///  Vesting block height at the initialization of the pallet
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetEndRelayBlock()
        {
            return EndRelayBlockTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.InitializedRewardAmount
        /// </summary>
        [StorageChange("CrowdloanRewards", "InitializedRewardAmount")]
        public void OnUpdateInitializedRewardAmount(string data)
        {
            InitializedRewardAmountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InitializedRewardAmount
        ///  Total initialized amount so far. We store this to make pallet funds == contributors reward
        ///  check easier and more efficient
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetInitializedRewardAmount()
        {
            return InitializedRewardAmountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for CrowdloanRewards.TotalContributors
        /// </summary>
        [StorageChange("CrowdloanRewards", "TotalContributors")]
        public void OnUpdateTotalContributors(string data)
        {
            TotalContributorsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> TotalContributors
        ///  Total number of contributors to aid hinting benchmarking
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTotalContributors()
        {
            return TotalContributorsTypedStorage.Get();
        }
    }
}
