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


namespace Substrate.Aventus.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ITokenManagerStorage interface definition.
    /// </summary>
    public interface ITokenManagerStorage : IStorage
    {
        
        /// <summary>
        /// >> Balances
        ///  The number of units of tokens held by any given account.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetBalances(string key);
        
        /// <summary>
        /// >> Nonces
        ///  An account nonce that represents the number of transfers from this account
        ///  It is shared for all tokens held by the account
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetNonces(string key);
        
        /// <summary>
        /// >> LowerAccountId
        ///  An account without a known private key, that can send transfers (eg Lowering transfers) but
        ///  from which no one can send funds. Tokens sent to this account are effectively destroyed.
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256 GetLowerAccountId();
        
        /// <summary>
        /// >> AVTTokenContract
        ///  The ethereum address of the AVT contract. Default value is the Rinkeby address
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 GetAVTTokenContract();
    }
    
    /// <summary>
    /// TokenManagerStorage class definition.
    /// </summary>
    public sealed class TokenManagerStorage : ITokenManagerStorage
    {
        
        /// <summary>
        /// _balancesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> _balancesTypedStorage;
        
        /// <summary>
        /// _noncesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> _noncesTypedStorage;
        
        /// <summary>
        /// _lowerAccountIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256> _lowerAccountIdTypedStorage;
        
        /// <summary>
        /// _aVTTokenContractTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160> _aVTTokenContractTypedStorage;
        
        /// <summary>
        /// TokenManagerStorage constructor.
        /// </summary>
        public TokenManagerStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.BalancesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128>("TokenManager.Balances", storageDataProvider, storageChangeDelegates);
            this.NoncesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64>("TokenManager.Nonces", storageDataProvider, storageChangeDelegates);
            this.LowerAccountIdTypedStorage = new TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256>("TokenManager.LowerAccountId", storageDataProvider, storageChangeDelegates);
            this.AVTTokenContractTypedStorage = new TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160>("TokenManager.AVTTokenContract", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _balancesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U128> BalancesTypedStorage
        {
            get
            {
                return _balancesTypedStorage;
            }
            set
            {
                _balancesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _noncesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> NoncesTypedStorage
        {
            get
            {
                return _noncesTypedStorage;
            }
            set
            {
                _noncesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lowerAccountIdTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256> LowerAccountIdTypedStorage
        {
            get
            {
                return _lowerAccountIdTypedStorage;
            }
            set
            {
                _lowerAccountIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _aVTTokenContractTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160> AVTTokenContractTypedStorage
        {
            get
            {
                return _aVTTokenContractTypedStorage;
            }
            set
            {
                _aVTTokenContractTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await BalancesTypedStorage.InitializeAsync("TokenManager", "Balances");
            await NoncesTypedStorage.InitializeAsync("TokenManager", "Nonces");
            await LowerAccountIdTypedStorage.InitializeAsync("TokenManager", "LowerAccountId");
            await AVTTokenContractTypedStorage.InitializeAsync("TokenManager", "AVTTokenContract");
        }
        
        /// <summary>
        /// Implements any storage change for TokenManager.Balances
        /// </summary>
        [StorageChange("TokenManager", "Balances")]
        public void OnUpdateBalances(string key, string data)
        {
            BalancesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Balances
        ///  The number of units of tokens held by any given account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetBalances(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BalancesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TokenManager.Nonces
        /// </summary>
        [StorageChange("TokenManager", "Nonces")]
        public void OnUpdateNonces(string key, string data)
        {
            NoncesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Nonces
        ///  An account nonce that represents the number of transfers from this account
        ///  It is shared for all tokens held by the account
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetNonces(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NoncesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U64 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TokenManager.LowerAccountId
        /// </summary>
        [StorageChange("TokenManager", "LowerAccountId")]
        public void OnUpdateLowerAccountId(string data)
        {
            LowerAccountIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LowerAccountId
        ///  An account without a known private key, that can send transfers (eg Lowering transfers) but
        ///  from which no one can send funds. Tokens sent to this account are effectively destroyed.
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H256 GetLowerAccountId()
        {
            return LowerAccountIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TokenManager.AVTTokenContract
        /// </summary>
        [StorageChange("TokenManager", "AVTTokenContract")]
        public void OnUpdateAVTTokenContract(string data)
        {
            AVTTokenContractTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> AVTTokenContract
        ///  The ethereum address of the AVT contract. Default value is the Rinkeby address
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 GetAVTTokenContract()
        {
            return AVTTokenContractTypedStorage.Get();
        }
    }
}