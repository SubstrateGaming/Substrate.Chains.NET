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


namespace Substrate.Hydration.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ITransactionPauseStorage interface definition.
    /// </summary>
    public interface ITransactionPauseStorage : IStorage
    {
        
        /// <summary>
        /// >> PausedTransactions
        ///  The paused transaction map
        /// 
        ///  map (PalletNameBytes, FunctionNameBytes) => Option<()>
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple GetPausedTransactions(string key);
    }
    
    /// <summary>
    /// TransactionPauseStorage class definition.
    /// </summary>
    public sealed class TransactionPauseStorage : ITransactionPauseStorage
    {
        
        /// <summary>
        /// _pausedTransactionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> _pausedTransactionsTypedStorage;
        
        /// <summary>
        /// TransactionPauseStorage constructor.
        /// </summary>
        public TransactionPauseStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.PausedTransactionsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple>("TransactionPause.PausedTransactions", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _pausedTransactionsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> PausedTransactionsTypedStorage
        {
            get
            {
                return _pausedTransactionsTypedStorage;
            }
            set
            {
                _pausedTransactionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await PausedTransactionsTypedStorage.InitializeAsync("TransactionPause", "PausedTransactions");
        }
        
        /// <summary>
        /// Implements any storage change for TransactionPause.PausedTransactions
        /// </summary>
        [StorageChange("TransactionPause", "PausedTransactions")]
        public void OnUpdatePausedTransactions(string key, string data)
        {
            PausedTransactionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> PausedTransactions
        ///  The paused transaction map
        /// 
        ///  map (PalletNameBytes, FunctionNameBytes) => Option<()>
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple GetPausedTransactions(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PausedTransactionsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple result))
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
