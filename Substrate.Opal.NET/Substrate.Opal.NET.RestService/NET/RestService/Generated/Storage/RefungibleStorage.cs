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


namespace Substrate.Opal.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IRefungibleStorage interface definition.
    /// </summary>
    public interface IRefungibleStorage : IStorage
    {
        
        /// <summary>
        /// >> TokensMinted
        ///  Total amount of minted tokens in a collection.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTokensMinted(string key);
        
        /// <summary>
        /// >> TokensBurnt
        ///  Amount of tokens burnt in a collection.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTokensBurnt(string key);
        
        /// <summary>
        /// >> TokenProperties
        ///  Amount of pieces a refungible token is split into.
        /// </summary>
        Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2 GetTokenProperties(string key);
        
        /// <summary>
        /// >> TotalSupply
        ///  Total amount of pieces for token
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetTotalSupply(string key);
        
        /// <summary>
        /// >> Owned
        ///  Used to enumerate tokens owned by account.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetOwned(string key);
        
        /// <summary>
        /// >> AccountBalance
        ///  Amount of tokens (not pieces) partially owned by an account within a collection.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetAccountBalance(string key);
        
        /// <summary>
        /// >> Balance
        ///  Amount of token pieces owned by account.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetBalance(string key);
        
        /// <summary>
        /// >> Allowance
        ///  Allowance set by a token owner for another user to perform one of certain transactions on a number of pieces of a token.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetAllowance(string key);
        
        /// <summary>
        /// >> CollectionAllowance
        ///  Spender set by a wallet owner that could perform certain transactions on all tokens in the wallet.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetCollectionAllowance(string key);
    }
    
    /// <summary>
    /// RefungibleStorage class definition.
    /// </summary>
    public sealed class RefungibleStorage : IRefungibleStorage
    {
        
        /// <summary>
        /// _tokensMintedTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _tokensMintedTypedStorage;
        
        /// <summary>
        /// _tokensBurntTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _tokensBurntTypedStorage;
        
        /// <summary>
        /// _tokenPropertiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2> _tokenPropertiesTypedStorage;
        
        /// <summary>
        /// _totalSupplyTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> _totalSupplyTypedStorage;
        
        /// <summary>
        /// _ownedTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _ownedTypedStorage;
        
        /// <summary>
        /// _accountBalanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _accountBalanceTypedStorage;
        
        /// <summary>
        /// _balanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> _balanceTypedStorage;
        
        /// <summary>
        /// _allowanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> _allowanceTypedStorage;
        
        /// <summary>
        /// _collectionAllowanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _collectionAllowanceTypedStorage;
        
        /// <summary>
        /// RefungibleStorage constructor.
        /// </summary>
        public RefungibleStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TokensMintedTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Refungible.TokensMinted", storageDataProvider, storageChangeDelegates);
            this.TokensBurntTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Refungible.TokensBurnt", storageDataProvider, storageChangeDelegates);
            this.TokenPropertiesTypedStorage = new TypedMapStorage<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2>("Refungible.TokenProperties", storageDataProvider, storageChangeDelegates);
            this.TotalSupplyTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Refungible.TotalSupply", storageDataProvider, storageChangeDelegates);
            this.OwnedTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Refungible.Owned", storageDataProvider, storageChangeDelegates);
            this.AccountBalanceTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Refungible.AccountBalance", storageDataProvider, storageChangeDelegates);
            this.BalanceTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Refungible.Balance", storageDataProvider, storageChangeDelegates);
            this.AllowanceTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Refungible.Allowance", storageDataProvider, storageChangeDelegates);
            this.CollectionAllowanceTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Refungible.CollectionAllowance", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _tokensMintedTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> TokensMintedTypedStorage
        {
            get
            {
                return _tokensMintedTypedStorage;
            }
            set
            {
                _tokensMintedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokensBurntTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> TokensBurntTypedStorage
        {
            get
            {
                return _tokensBurntTypedStorage;
            }
            set
            {
                _tokensBurntTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokenPropertiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2> TokenPropertiesTypedStorage
        {
            get
            {
                return _tokenPropertiesTypedStorage;
            }
            set
            {
                _tokenPropertiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _totalSupplyTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> TotalSupplyTypedStorage
        {
            get
            {
                return _totalSupplyTypedStorage;
            }
            set
            {
                _totalSupplyTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _ownedTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> OwnedTypedStorage
        {
            get
            {
                return _ownedTypedStorage;
            }
            set
            {
                _ownedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountBalanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> AccountBalanceTypedStorage
        {
            get
            {
                return _accountBalanceTypedStorage;
            }
            set
            {
                _accountBalanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _balanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> BalanceTypedStorage
        {
            get
            {
                return _balanceTypedStorage;
            }
            set
            {
                _balanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _allowanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> AllowanceTypedStorage
        {
            get
            {
                return _allowanceTypedStorage;
            }
            set
            {
                _allowanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionAllowanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> CollectionAllowanceTypedStorage
        {
            get
            {
                return _collectionAllowanceTypedStorage;
            }
            set
            {
                _collectionAllowanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TokensMintedTypedStorage.InitializeAsync("Refungible", "TokensMinted");
            await TokensBurntTypedStorage.InitializeAsync("Refungible", "TokensBurnt");
            await TokenPropertiesTypedStorage.InitializeAsync("Refungible", "TokenProperties");
            await TotalSupplyTypedStorage.InitializeAsync("Refungible", "TotalSupply");
            await OwnedTypedStorage.InitializeAsync("Refungible", "Owned");
            await AccountBalanceTypedStorage.InitializeAsync("Refungible", "AccountBalance");
            await BalanceTypedStorage.InitializeAsync("Refungible", "Balance");
            await AllowanceTypedStorage.InitializeAsync("Refungible", "Allowance");
            await CollectionAllowanceTypedStorage.InitializeAsync("Refungible", "CollectionAllowance");
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.TokensMinted
        /// </summary>
        [StorageChange("Refungible", "TokensMinted")]
        public void OnUpdateTokensMinted(string key, string data)
        {
            TokensMintedTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokensMinted
        ///  Total amount of minted tokens in a collection.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTokensMinted(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokensMintedTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.TokensBurnt
        /// </summary>
        [StorageChange("Refungible", "TokensBurnt")]
        public void OnUpdateTokensBurnt(string key, string data)
        {
            TokensBurntTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokensBurnt
        ///  Amount of tokens burnt in a collection.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTokensBurnt(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokensBurntTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.TokenProperties
        /// </summary>
        [StorageChange("Refungible", "TokenProperties")]
        public void OnUpdateTokenProperties(string key, string data)
        {
            TokenPropertiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenProperties
        ///  Amount of pieces a refungible token is split into.
        /// </summary>
        public Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2 GetTokenProperties(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenPropertiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.TotalSupply
        /// </summary>
        [StorageChange("Refungible", "TotalSupply")]
        public void OnUpdateTotalSupply(string key, string data)
        {
            TotalSupplyTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TotalSupply
        ///  Total amount of pieces for token
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetTotalSupply(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TotalSupplyTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.Owned
        /// </summary>
        [StorageChange("Refungible", "Owned")]
        public void OnUpdateOwned(string key, string data)
        {
            OwnedTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Owned
        ///  Used to enumerate tokens owned by account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetOwned(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnedTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.AccountBalance
        /// </summary>
        [StorageChange("Refungible", "AccountBalance")]
        public void OnUpdateAccountBalance(string key, string data)
        {
            AccountBalanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AccountBalance
        ///  Amount of tokens (not pieces) partially owned by an account within a collection.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetAccountBalance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountBalanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.Balance
        /// </summary>
        [StorageChange("Refungible", "Balance")]
        public void OnUpdateBalance(string key, string data)
        {
            BalanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Balance
        ///  Amount of token pieces owned by account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetBalance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BalanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.Allowance
        /// </summary>
        [StorageChange("Refungible", "Allowance")]
        public void OnUpdateAllowance(string key, string data)
        {
            AllowanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Allowance
        ///  Allowance set by a token owner for another user to perform one of certain transactions on a number of pieces of a token.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetAllowance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AllowanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Refungible.CollectionAllowance
        /// </summary>
        [StorageChange("Refungible", "CollectionAllowance")]
        public void OnUpdateCollectionAllowance(string key, string data)
        {
            CollectionAllowanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionAllowance
        ///  Spender set by a wallet owner that could perform certain transactions on all tokens in the wallet.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetCollectionAllowance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionAllowanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
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
