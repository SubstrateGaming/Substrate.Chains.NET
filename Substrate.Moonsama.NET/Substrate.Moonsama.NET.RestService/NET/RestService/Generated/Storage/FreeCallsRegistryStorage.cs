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
    /// IFreeCallsRegistryStorage interface definition.
    /// </summary>
    public interface IFreeCallsRegistryStorage : IStorage
    {
        
        /// <summary>
        /// >> FreeCallsRegistry
        ///  A map of EVM call signatures to empty values that indicates whether a given signature is registered as a free call.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple GetFreeCallsRegistry(string key);
        
        /// <summary>
        /// >> RequestExpiryDate
        ///  A map of senders to empty that indicates that indicates whether a sender can request free calls for some EVM account.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetRequestExpiryDate(string key);
        
        /// <summary>
        /// >> FreeCallsAvailable
        ///  A map of senders to EvmCallCounter structs that indicates how many free calls the sender has available and when they expire.
        /// </summary>
        Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter GetFreeCallsAvailable(string key);
    }
    
    /// <summary>
    /// FreeCallsRegistryStorage class definition.
    /// </summary>
    public sealed class FreeCallsRegistryStorage : IFreeCallsRegistryStorage
    {
        
        /// <summary>
        /// _freeCallsRegistryTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> _freeCallsRegistryTypedStorage;
        
        /// <summary>
        /// _requestExpiryDateTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _requestExpiryDateTypedStorage;
        
        /// <summary>
        /// _freeCallsAvailableTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter> _freeCallsAvailableTypedStorage;
        
        /// <summary>
        /// FreeCallsRegistryStorage constructor.
        /// </summary>
        public FreeCallsRegistryStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.FreeCallsRegistryTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple>("FreeCallsRegistry.FreeCallsRegistry", storageDataProvider, storageChangeDelegates);
            this.RequestExpiryDateTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FreeCallsRegistry.RequestExpiryDate", storageDataProvider, storageChangeDelegates);
            this.FreeCallsAvailableTypedStorage = new TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter>("FreeCallsRegistry.FreeCallsAvailable", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _freeCallsRegistryTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> FreeCallsRegistryTypedStorage
        {
            get
            {
                return _freeCallsRegistryTypedStorage;
            }
            set
            {
                _freeCallsRegistryTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _requestExpiryDateTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> RequestExpiryDateTypedStorage
        {
            get
            {
                return _requestExpiryDateTypedStorage;
            }
            set
            {
                _requestExpiryDateTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _freeCallsAvailableTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter> FreeCallsAvailableTypedStorage
        {
            get
            {
                return _freeCallsAvailableTypedStorage;
            }
            set
            {
                _freeCallsAvailableTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await FreeCallsRegistryTypedStorage.InitializeAsync("FreeCallsRegistry", "FreeCallsRegistry");
            await RequestExpiryDateTypedStorage.InitializeAsync("FreeCallsRegistry", "RequestExpiryDate");
            await FreeCallsAvailableTypedStorage.InitializeAsync("FreeCallsRegistry", "FreeCallsAvailable");
        }
        
        /// <summary>
        /// Implements any storage change for FreeCallsRegistry.FreeCallsRegistry
        /// </summary>
        [StorageChange("FreeCallsRegistry", "FreeCallsRegistry")]
        public void OnUpdateFreeCallsRegistry(string key, string data)
        {
            FreeCallsRegistryTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FreeCallsRegistry
        ///  A map of EVM call signatures to empty values that indicates whether a given signature is registered as a free call.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple GetFreeCallsRegistry(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FreeCallsRegistryTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FreeCallsRegistry.RequestExpiryDate
        /// </summary>
        [StorageChange("FreeCallsRegistry", "RequestExpiryDate")]
        public void OnUpdateRequestExpiryDate(string key, string data)
        {
            RequestExpiryDateTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> RequestExpiryDate
        ///  A map of senders to empty that indicates that indicates whether a sender can request free calls for some EVM account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetRequestExpiryDate(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (RequestExpiryDateTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FreeCallsRegistry.FreeCallsAvailable
        /// </summary>
        [StorageChange("FreeCallsRegistry", "FreeCallsAvailable")]
        public void OnUpdateFreeCallsAvailable(string key, string data)
        {
            FreeCallsAvailableTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FreeCallsAvailable
        ///  A map of senders to EvmCallCounter structs that indicates how many free calls the sender has available and when they expire.
        /// </summary>
        public Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter GetFreeCallsAvailable(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FreeCallsAvailableTypedStorage.Dictionary.TryGetValue(key, out Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types.EvmCallCounter result))
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