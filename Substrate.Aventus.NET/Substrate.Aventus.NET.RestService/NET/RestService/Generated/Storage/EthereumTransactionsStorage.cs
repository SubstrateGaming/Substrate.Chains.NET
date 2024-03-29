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
    /// IEthereumTransactionsStorage interface definition.
    /// </summary>
    public interface IEthereumTransactionsStorage : IStorage
    {
        
        /// <summary>
        /// >> Repository
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.ethereum_transaction.EthTransactionCandidate GetRepository(string key);
        
        /// <summary>
        /// >> DispatchedAvnTxIds
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.DispatchedData> GetDispatchedAvnTxIds(string key);
        
        /// <summary>
        /// >> ReservedTransactions
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetReservedTransactions(string key);
        
        /// <summary>
        /// >> PublishRootContract
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 GetPublishRootContract();
        
        /// <summary>
        /// >> Nonce
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetNonce();
    }
    
    /// <summary>
    /// EthereumTransactionsStorage class definition.
    /// </summary>
    public sealed class EthereumTransactionsStorage : IEthereumTransactionsStorage
    {
        
        /// <summary>
        /// _repositoryTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.ethereum_transaction.EthTransactionCandidate> _repositoryTypedStorage;
        
        /// <summary>
        /// _dispatchedAvnTxIdsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.DispatchedData>> _dispatchedAvnTxIdsTypedStorage;
        
        /// <summary>
        /// _reservedTransactionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> _reservedTransactionsTypedStorage;
        
        /// <summary>
        /// _publishRootContractTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160> _publishRootContractTypedStorage;
        
        /// <summary>
        /// _nonceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> _nonceTypedStorage;
        
        /// <summary>
        /// EthereumTransactionsStorage constructor.
        /// </summary>
        public EthereumTransactionsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.RepositoryTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.ethereum_transaction.EthTransactionCandidate>("EthereumTransactions.Repository", storageDataProvider, storageChangeDelegates);
            this.DispatchedAvnTxIdsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.DispatchedData>>("EthereumTransactions.DispatchedAvnTxIds", storageDataProvider, storageChangeDelegates);
            this.ReservedTransactionsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64>("EthereumTransactions.ReservedTransactions", storageDataProvider, storageChangeDelegates);
            this.PublishRootContractTypedStorage = new TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160>("EthereumTransactions.PublishRootContract", storageDataProvider, storageChangeDelegates);
            this.NonceTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64>("EthereumTransactions.Nonce", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _repositoryTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.ethereum_transaction.EthTransactionCandidate> RepositoryTypedStorage
        {
            get
            {
                return _repositoryTypedStorage;
            }
            set
            {
                _repositoryTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _dispatchedAvnTxIdsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.DispatchedData>> DispatchedAvnTxIdsTypedStorage
        {
            get
            {
                return _dispatchedAvnTxIdsTypedStorage;
            }
            set
            {
                _dispatchedAvnTxIdsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _reservedTransactionsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> ReservedTransactionsTypedStorage
        {
            get
            {
                return _reservedTransactionsTypedStorage;
            }
            set
            {
                _reservedTransactionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _publishRootContractTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160> PublishRootContractTypedStorage
        {
            get
            {
                return _publishRootContractTypedStorage;
            }
            set
            {
                _publishRootContractTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nonceTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> NonceTypedStorage
        {
            get
            {
                return _nonceTypedStorage;
            }
            set
            {
                _nonceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await RepositoryTypedStorage.InitializeAsync("EthereumTransactions", "Repository");
            await DispatchedAvnTxIdsTypedStorage.InitializeAsync("EthereumTransactions", "DispatchedAvnTxIds");
            await ReservedTransactionsTypedStorage.InitializeAsync("EthereumTransactions", "ReservedTransactions");
            await PublishRootContractTypedStorage.InitializeAsync("EthereumTransactions", "PublishRootContract");
            await NonceTypedStorage.InitializeAsync("EthereumTransactions", "Nonce");
        }
        
        /// <summary>
        /// Implements any storage change for EthereumTransactions.Repository
        /// </summary>
        [StorageChange("EthereumTransactions", "Repository")]
        public void OnUpdateRepository(string key, string data)
        {
            RepositoryTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Repository
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.ethereum_transaction.EthTransactionCandidate GetRepository(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (RepositoryTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.ethereum_transaction.EthTransactionCandidate result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for EthereumTransactions.DispatchedAvnTxIds
        /// </summary>
        [StorageChange("EthereumTransactions", "DispatchedAvnTxIds")]
        public void OnUpdateDispatchedAvnTxIds(string key, string data)
        {
            DispatchedAvnTxIdsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DispatchedAvnTxIds
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.DispatchedData> GetDispatchedAvnTxIds(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DispatchedAvnTxIdsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_ethereum_transactions.DispatchedData> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for EthereumTransactions.ReservedTransactions
        /// </summary>
        [StorageChange("EthereumTransactions", "ReservedTransactions")]
        public void OnUpdateReservedTransactions(string key, string data)
        {
            ReservedTransactionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReservedTransactions
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetReservedTransactions(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReservedTransactionsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U64 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for EthereumTransactions.PublishRootContract
        /// </summary>
        [StorageChange("EthereumTransactions", "PublishRootContract")]
        public void OnUpdatePublishRootContract(string data)
        {
            PublishRootContractTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PublishRootContract
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.primitive_types.H160 GetPublishRootContract()
        {
            return PublishRootContractTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumTransactions.Nonce
        /// </summary>
        [StorageChange("EthereumTransactions", "Nonce")]
        public void OnUpdateNonce(string data)
        {
            NonceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Nonce
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetNonce()
        {
            return NonceTypedStorage.Get();
        }
    }
}
