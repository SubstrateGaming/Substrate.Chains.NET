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
    /// IAuthorityDiscoveryStorage interface definition.
    /// </summary>
    public interface IAuthorityDiscoveryStorage : IStorage
    {
        
        /// <summary>
        /// >> Keys
        ///  Keys of the current authority set.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 GetKeys();
        
        /// <summary>
        /// >> NextKeys
        ///  Keys of the next authority set.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 GetNextKeys();
    }
    
    /// <summary>
    /// AuthorityDiscoveryStorage class definition.
    /// </summary>
    public sealed class AuthorityDiscoveryStorage : IAuthorityDiscoveryStorage
    {
        
        /// <summary>
        /// _keysTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5> _keysTypedStorage;
        
        /// <summary>
        /// _nextKeysTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5> _nextKeysTypedStorage;
        
        /// <summary>
        /// AuthorityDiscoveryStorage constructor.
        /// </summary>
        public AuthorityDiscoveryStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.KeysTypedStorage = new TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5>("AuthorityDiscovery.Keys", storageDataProvider, storageChangeDelegates);
            this.NextKeysTypedStorage = new TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5>("AuthorityDiscovery.NextKeys", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _keysTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5> KeysTypedStorage
        {
            get
            {
                return _keysTypedStorage;
            }
            set
            {
                _keysTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextKeysTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5> NextKeysTypedStorage
        {
            get
            {
                return _nextKeysTypedStorage;
            }
            set
            {
                _nextKeysTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await KeysTypedStorage.InitializeAsync("AuthorityDiscovery", "Keys");
            await NextKeysTypedStorage.InitializeAsync("AuthorityDiscovery", "NextKeys");
        }
        
        /// <summary>
        /// Implements any storage change for AuthorityDiscovery.Keys
        /// </summary>
        [StorageChange("AuthorityDiscovery", "Keys")]
        public void OnUpdateKeys(string data)
        {
            KeysTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Keys
        ///  Keys of the current authority set.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 GetKeys()
        {
            return KeysTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AuthorityDiscovery.NextKeys
        /// </summary>
        [StorageChange("AuthorityDiscovery", "NextKeys")]
        public void OnUpdateNextKeys(string data)
        {
            NextKeysTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextKeys
        ///  Keys of the next authority set.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT5 GetNextKeys()
        {
            return NextKeysTypedStorage.Get();
        }
    }
}
