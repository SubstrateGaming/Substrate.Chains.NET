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


namespace Substrate.KILT.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IIndicesStorage interface definition.
    /// </summary>
    public interface IIndicesStorage : IStorage
    {
        
        /// <summary>
        /// >> Accounts
        ///  The lookup from index to account.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool> GetAccounts(string key);
    }
    
    /// <summary>
    /// IndicesStorage class definition.
    /// </summary>
    public sealed class IndicesStorage : IIndicesStorage
    {
        
        /// <summary>
        /// _accountsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>> _accountsTypedStorage;
        
        /// <summary>
        /// IndicesStorage constructor.
        /// </summary>
        public IndicesStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AccountsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>("Indices.Accounts", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _accountsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>> AccountsTypedStorage
        {
            get
            {
                return _accountsTypedStorage;
            }
            set
            {
                _accountsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AccountsTypedStorage.InitializeAsync("Indices", "Accounts");
        }
        
        /// <summary>
        /// Implements any storage change for Indices.Accounts
        /// </summary>
        [StorageChange("Indices", "Accounts")]
        public void OnUpdateAccounts(string key, string data)
        {
            AccountsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Accounts
        ///  The lookup from index to account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool> GetAccounts(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KILT.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool> result))
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
