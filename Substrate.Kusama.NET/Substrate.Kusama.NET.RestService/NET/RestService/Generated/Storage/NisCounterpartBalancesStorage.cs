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


namespace Substrate.Kusama.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// INisCounterpartBalancesStorage interface definition.
    /// </summary>
    public interface INisCounterpartBalancesStorage : IStorage
    {
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetTotalIssuance();
        
        /// <summary>
        /// >> InactiveIssuance
        ///  The total units of outstanding deactivated balance in the system.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetInactiveIssuance();
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData GetAccount(string key);
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// 
        ///  Use of locks is deprecated in favour of freezes. See `https://github.com/paritytech/substrate/pull/12951/`
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6 GetLocks(string key);
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// 
        ///  Use of reserves is deprecated in favour of holds. See `https://github.com/paritytech/substrate/pull/12951/`
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39 GetReserves(string key);
        
        /// <summary>
        /// >> Holds
        ///  Holds on account balances.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 GetHolds(string key);
        
        /// <summary>
        /// >> Freezes
        ///  Freeze locks on account balances.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 GetFreezes(string key);
    }
    
    /// <summary>
    /// NisCounterpartBalancesStorage class definition.
    /// </summary>
    public sealed class NisCounterpartBalancesStorage : INisCounterpartBalancesStorage
    {
        
        /// <summary>
        /// _totalIssuanceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _totalIssuanceTypedStorage;
        
        /// <summary>
        /// _inactiveIssuanceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _inactiveIssuanceTypedStorage;
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData> _accountTypedStorage;
        
        /// <summary>
        /// _locksTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6> _locksTypedStorage;
        
        /// <summary>
        /// _reservesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39> _reservesTypedStorage;
        
        /// <summary>
        /// _holdsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14> _holdsTypedStorage;
        
        /// <summary>
        /// _freezesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40> _freezesTypedStorage;
        
        /// <summary>
        /// NisCounterpartBalancesStorage constructor.
        /// </summary>
        public NisCounterpartBalancesStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TotalIssuanceTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("NisCounterpartBalances.TotalIssuance", storageDataProvider, storageChangeDelegates);
            this.InactiveIssuanceTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("NisCounterpartBalances.InactiveIssuance", storageDataProvider, storageChangeDelegates);
            this.AccountTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData>("NisCounterpartBalances.Account", storageDataProvider, storageChangeDelegates);
            this.LocksTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6>("NisCounterpartBalances.Locks", storageDataProvider, storageChangeDelegates);
            this.ReservesTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39>("NisCounterpartBalances.Reserves", storageDataProvider, storageChangeDelegates);
            this.HoldsTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14>("NisCounterpartBalances.Holds", storageDataProvider, storageChangeDelegates);
            this.FreezesTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40>("NisCounterpartBalances.Freezes", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _totalIssuanceTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> TotalIssuanceTypedStorage
        {
            get
            {
                return _totalIssuanceTypedStorage;
            }
            set
            {
                _totalIssuanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _inactiveIssuanceTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> InactiveIssuanceTypedStorage
        {
            get
            {
                return _inactiveIssuanceTypedStorage;
            }
            set
            {
                _inactiveIssuanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData> AccountTypedStorage
        {
            get
            {
                return _accountTypedStorage;
            }
            set
            {
                _accountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _locksTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6> LocksTypedStorage
        {
            get
            {
                return _locksTypedStorage;
            }
            set
            {
                _locksTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _reservesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39> ReservesTypedStorage
        {
            get
            {
                return _reservesTypedStorage;
            }
            set
            {
                _reservesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _holdsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14> HoldsTypedStorage
        {
            get
            {
                return _holdsTypedStorage;
            }
            set
            {
                _holdsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _freezesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40> FreezesTypedStorage
        {
            get
            {
                return _freezesTypedStorage;
            }
            set
            {
                _freezesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TotalIssuanceTypedStorage.InitializeAsync("NisCounterpartBalances", "TotalIssuance");
            await InactiveIssuanceTypedStorage.InitializeAsync("NisCounterpartBalances", "InactiveIssuance");
            await AccountTypedStorage.InitializeAsync("NisCounterpartBalances", "Account");
            await LocksTypedStorage.InitializeAsync("NisCounterpartBalances", "Locks");
            await ReservesTypedStorage.InitializeAsync("NisCounterpartBalances", "Reserves");
            await HoldsTypedStorage.InitializeAsync("NisCounterpartBalances", "Holds");
            await FreezesTypedStorage.InitializeAsync("NisCounterpartBalances", "Freezes");
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.TotalIssuance
        /// </summary>
        [StorageChange("NisCounterpartBalances", "TotalIssuance")]
        public void OnUpdateTotalIssuance(string data)
        {
            TotalIssuanceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetTotalIssuance()
        {
            return TotalIssuanceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.InactiveIssuance
        /// </summary>
        [StorageChange("NisCounterpartBalances", "InactiveIssuance")]
        public void OnUpdateInactiveIssuance(string data)
        {
            InactiveIssuanceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InactiveIssuance
        ///  The total units of outstanding deactivated balance in the system.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetInactiveIssuance()
        {
            return InactiveIssuanceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.Account
        /// </summary>
        [StorageChange("NisCounterpartBalances", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.Locks
        /// </summary>
        [StorageChange("NisCounterpartBalances", "Locks")]
        public void OnUpdateLocks(string key, string data)
        {
            LocksTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// 
        ///  Use of locks is deprecated in favour of freezes. See `https://github.com/paritytech/substrate/pull/12951/`
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6 GetLocks(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LocksTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT6 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.Reserves
        /// </summary>
        [StorageChange("NisCounterpartBalances", "Reserves")]
        public void OnUpdateReserves(string key, string data)
        {
            ReservesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// 
        ///  Use of reserves is deprecated in favour of holds. See `https://github.com/paritytech/substrate/pull/12951/`
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39 GetReserves(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReservesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.Holds
        /// </summary>
        [StorageChange("NisCounterpartBalances", "Holds")]
        public void OnUpdateHolds(string key, string data)
        {
            HoldsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Holds
        ///  Holds on account balances.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 GetHolds(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (HoldsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for NisCounterpartBalances.Freezes
        /// </summary>
        [StorageChange("NisCounterpartBalances", "Freezes")]
        public void OnUpdateFreezes(string key, string data)
        {
            FreezesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Freezes
        ///  Freeze locks on account balances.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 GetFreezes(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FreezesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 result))
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
