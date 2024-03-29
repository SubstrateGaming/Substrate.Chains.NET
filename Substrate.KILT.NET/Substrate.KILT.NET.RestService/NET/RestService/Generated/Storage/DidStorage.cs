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
    /// IDidStorage interface definition.
    /// </summary>
    public interface IDidStorage : IStorage
    {
        
        /// <summary>
        /// >> Did
        ///  DIDs stored on chain.
        /// 
        ///  It maps from a DID identifier to the DID details.
        /// </summary>
        Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.DidDetails GetDid(string key);
        
        /// <summary>
        /// >> ServiceEndpoints
        ///  Service endpoints associated with DIDs.
        /// 
        ///  It maps from (DID identifier, service ID) to the service details.
        /// </summary>
        Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint GetServiceEndpoints(string key);
        
        /// <summary>
        /// >> DidEndpointsCount
        ///  Counter of service endpoints for each DID.
        /// 
        ///  It maps from (DID identifier) to a 32-bit counter.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetDidEndpointsCount(string key);
        
        /// <summary>
        /// >> DidBlacklist
        ///  The set of DIDs that have been deleted and cannot therefore be created
        ///  again for security reasons.
        /// 
        ///  It maps from a DID identifier to a unit tuple, for the sake of tracking
        ///  DID identifiers.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple GetDidBlacklist(string key);
    }
    
    /// <summary>
    /// DidStorage class definition.
    /// </summary>
    public sealed class DidStorage : IDidStorage
    {
        
        /// <summary>
        /// _didTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.DidDetails> _didTypedStorage;
        
        /// <summary>
        /// _serviceEndpointsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint> _serviceEndpointsTypedStorage;
        
        /// <summary>
        /// _didEndpointsCountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _didEndpointsCountTypedStorage;
        
        /// <summary>
        /// _didBlacklistTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> _didBlacklistTypedStorage;
        
        /// <summary>
        /// DidStorage constructor.
        /// </summary>
        public DidStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.DidTypedStorage = new TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.DidDetails>("Did.Did", storageDataProvider, storageChangeDelegates);
            this.ServiceEndpointsTypedStorage = new TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint>("Did.ServiceEndpoints", storageDataProvider, storageChangeDelegates);
            this.DidEndpointsCountTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Did.DidEndpointsCount", storageDataProvider, storageChangeDelegates);
            this.DidBlacklistTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple>("Did.DidBlacklist", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _didTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.DidDetails> DidTypedStorage
        {
            get
            {
                return _didTypedStorage;
            }
            set
            {
                _didTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _serviceEndpointsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint> ServiceEndpointsTypedStorage
        {
            get
            {
                return _serviceEndpointsTypedStorage;
            }
            set
            {
                _serviceEndpointsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _didEndpointsCountTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> DidEndpointsCountTypedStorage
        {
            get
            {
                return _didEndpointsCountTypedStorage;
            }
            set
            {
                _didEndpointsCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _didBlacklistTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> DidBlacklistTypedStorage
        {
            get
            {
                return _didBlacklistTypedStorage;
            }
            set
            {
                _didBlacklistTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await DidTypedStorage.InitializeAsync("Did", "Did");
            await ServiceEndpointsTypedStorage.InitializeAsync("Did", "ServiceEndpoints");
            await DidEndpointsCountTypedStorage.InitializeAsync("Did", "DidEndpointsCount");
            await DidBlacklistTypedStorage.InitializeAsync("Did", "DidBlacklist");
        }
        
        /// <summary>
        /// Implements any storage change for Did.Did
        /// </summary>
        [StorageChange("Did", "Did")]
        public void OnUpdateDid(string key, string data)
        {
            DidTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Did
        ///  DIDs stored on chain.
        /// 
        ///  It maps from a DID identifier to the DID details.
        /// </summary>
        public Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.DidDetails GetDid(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DidTypedStorage.Dictionary.TryGetValue(key, out Substrate.KILT.NET.NetApiExt.Generated.Model.did.did_details.DidDetails result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Did.ServiceEndpoints
        /// </summary>
        [StorageChange("Did", "ServiceEndpoints")]
        public void OnUpdateServiceEndpoints(string key, string data)
        {
            ServiceEndpointsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ServiceEndpoints
        ///  Service endpoints associated with DIDs.
        /// 
        ///  It maps from (DID identifier, service ID) to the service details.
        /// </summary>
        public Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint GetServiceEndpoints(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ServiceEndpointsTypedStorage.Dictionary.TryGetValue(key, out Substrate.KILT.NET.NetApiExt.Generated.Model.did.service_endpoints.DidEndpoint result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Did.DidEndpointsCount
        /// </summary>
        [StorageChange("Did", "DidEndpointsCount")]
        public void OnUpdateDidEndpointsCount(string key, string data)
        {
            DidEndpointsCountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DidEndpointsCount
        ///  Counter of service endpoints for each DID.
        /// 
        ///  It maps from (DID identifier) to a 32-bit counter.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetDidEndpointsCount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DidEndpointsCountTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Did.DidBlacklist
        /// </summary>
        [StorageChange("Did", "DidBlacklist")]
        public void OnUpdateDidBlacklist(string key, string data)
        {
            DidBlacklistTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DidBlacklist
        ///  The set of DIDs that have been deleted and cannot therefore be created
        ///  again for security reasons.
        /// 
        ///  It maps from a DID identifier to a unit tuple, for the sake of tracking
        ///  DID identifiers.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple GetDidBlacklist(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DidBlacklistTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple result))
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
