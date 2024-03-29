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


namespace Substrate.Enjin.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IVoteManagerStorage interface definition.
    /// </summary>
    public interface IVoteManagerStorage : IStorage
    {
        
        /// <summary>
        /// >> VoteCurrencies
        ///  The currency used by `AccountId` to vote in Poll with
        ///  `PollIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency GetVoteCurrencies(string key);
        
        /// <summary>
        /// >> VotesToUnlock
        ///  The currency used by `AccountId` to vote in referendum with
        ///  `ReferendumIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock GetVotesToUnlock(string key);
    }
    
    /// <summary>
    /// VoteManagerStorage class definition.
    /// </summary>
    public sealed class VoteManagerStorage : IVoteManagerStorage
    {
        
        /// <summary>
        /// _voteCurrenciesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency> _voteCurrenciesTypedStorage;
        
        /// <summary>
        /// _votesToUnlockTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock> _votesToUnlockTypedStorage;
        
        /// <summary>
        /// VoteManagerStorage constructor.
        /// </summary>
        public VoteManagerStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.VoteCurrenciesTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency>("VoteManager.VoteCurrencies", storageDataProvider, storageChangeDelegates);
            this.VotesToUnlockTypedStorage = new TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock>("VoteManager.VotesToUnlock", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _voteCurrenciesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency> VoteCurrenciesTypedStorage
        {
            get
            {
                return _voteCurrenciesTypedStorage;
            }
            set
            {
                _voteCurrenciesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votesToUnlockTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock> VotesToUnlockTypedStorage
        {
            get
            {
                return _votesToUnlockTypedStorage;
            }
            set
            {
                _votesToUnlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await VoteCurrenciesTypedStorage.InitializeAsync("VoteManager", "VoteCurrencies");
            await VotesToUnlockTypedStorage.InitializeAsync("VoteManager", "VotesToUnlock");
        }
        
        /// <summary>
        /// Implements any storage change for VoteManager.VoteCurrencies
        /// </summary>
        [StorageChange("VoteManager", "VoteCurrencies")]
        public void OnUpdateVoteCurrencies(string key, string data)
        {
            VoteCurrenciesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VoteCurrencies
        ///  The currency used by `AccountId` to vote in Poll with
        ///  `PollIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency GetVoteCurrencies(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VoteCurrenciesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.EnumVoteCurrency result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for VoteManager.VotesToUnlock
        /// </summary>
        [StorageChange("VoteManager", "VotesToUnlock")]
        public void OnUpdateVotesToUnlock(string key, string data)
        {
            VotesToUnlockTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VotesToUnlock
        ///  The currency used by `AccountId` to vote in referendum with
        ///  `ReferendumIndex`
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock GetVotesToUnlock(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotesToUnlockTypedStorage.Dictionary.TryGetValue(key, out Substrate.Enjin.NET.NetApiExt.Generated.Model.pallet_vote_manager.types.BalanceToUnlock result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
