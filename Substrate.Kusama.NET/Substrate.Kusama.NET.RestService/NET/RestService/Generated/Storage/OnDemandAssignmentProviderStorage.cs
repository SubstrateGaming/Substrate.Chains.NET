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
    /// IOnDemandAssignmentProviderStorage interface definition.
    /// </summary>
    public interface IOnDemandAssignmentProviderStorage : IStorage
    {
        
        /// <summary>
        /// >> ParaIdAffinity
        ///  Maps a `ParaId` to `CoreIndex` and keeps track of how many assignments the scheduler has in
        ///  it's lookahead. Keeping track of this affinity prevents parallel execution of the same
        ///  `ParaId` on two or more `CoreIndex`es.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.CoreAffinityCount GetParaIdAffinity(string key);
        
        /// <summary>
        /// >> QueueStatus
        ///  Overall status of queue (both free + affinity entries)
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.QueueStatusType GetQueueStatus();
        
        /// <summary>
        /// >> FreeEntries
        ///  Priority queue for all orders which don't yet (or not any more) have any core affinity.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2 GetFreeEntries();
        
        /// <summary>
        /// >> AffinityEntries
        ///  Queue entries that are currently bound to a particular core due to core affinity.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2 GetAffinityEntries(string key);
        
        /// <summary>
        /// >> Revenue
        ///  Keeps track of accumulated revenue from on demand order sales.
        /// </summary>
        Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44 GetRevenue();
    }
    
    /// <summary>
    /// OnDemandAssignmentProviderStorage class definition.
    /// </summary>
    public sealed class OnDemandAssignmentProviderStorage : IOnDemandAssignmentProviderStorage
    {
        
        /// <summary>
        /// _paraIdAffinityTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.CoreAffinityCount> _paraIdAffinityTypedStorage;
        
        /// <summary>
        /// _queueStatusTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.QueueStatusType> _queueStatusTypedStorage;
        
        /// <summary>
        /// _freeEntriesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2> _freeEntriesTypedStorage;
        
        /// <summary>
        /// _affinityEntriesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2> _affinityEntriesTypedStorage;
        
        /// <summary>
        /// _revenueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44> _revenueTypedStorage;
        
        /// <summary>
        /// OnDemandAssignmentProviderStorage constructor.
        /// </summary>
        public OnDemandAssignmentProviderStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ParaIdAffinityTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.CoreAffinityCount>("OnDemandAssignmentProvider.ParaIdAffinity", storageDataProvider, storageChangeDelegates);
            this.QueueStatusTypedStorage = new TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.QueueStatusType>("OnDemandAssignmentProvider.QueueStatus", storageDataProvider, storageChangeDelegates);
            this.FreeEntriesTypedStorage = new TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2>("OnDemandAssignmentProvider.FreeEntries", storageDataProvider, storageChangeDelegates);
            this.AffinityEntriesTypedStorage = new TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2>("OnDemandAssignmentProvider.AffinityEntries", storageDataProvider, storageChangeDelegates);
            this.RevenueTypedStorage = new TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44>("OnDemandAssignmentProvider.Revenue", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _paraIdAffinityTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.CoreAffinityCount> ParaIdAffinityTypedStorage
        {
            get
            {
                return _paraIdAffinityTypedStorage;
            }
            set
            {
                _paraIdAffinityTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queueStatusTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.QueueStatusType> QueueStatusTypedStorage
        {
            get
            {
                return _queueStatusTypedStorage;
            }
            set
            {
                _queueStatusTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _freeEntriesTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2> FreeEntriesTypedStorage
        {
            get
            {
                return _freeEntriesTypedStorage;
            }
            set
            {
                _freeEntriesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _affinityEntriesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2> AffinityEntriesTypedStorage
        {
            get
            {
                return _affinityEntriesTypedStorage;
            }
            set
            {
                _affinityEntriesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _revenueTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44> RevenueTypedStorage
        {
            get
            {
                return _revenueTypedStorage;
            }
            set
            {
                _revenueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ParaIdAffinityTypedStorage.InitializeAsync("OnDemandAssignmentProvider", "ParaIdAffinity");
            await QueueStatusTypedStorage.InitializeAsync("OnDemandAssignmentProvider", "QueueStatus");
            await FreeEntriesTypedStorage.InitializeAsync("OnDemandAssignmentProvider", "FreeEntries");
            await AffinityEntriesTypedStorage.InitializeAsync("OnDemandAssignmentProvider", "AffinityEntries");
            await RevenueTypedStorage.InitializeAsync("OnDemandAssignmentProvider", "Revenue");
        }
        
        /// <summary>
        /// Implements any storage change for OnDemandAssignmentProvider.ParaIdAffinity
        /// </summary>
        [StorageChange("OnDemandAssignmentProvider", "ParaIdAffinity")]
        public void OnUpdateParaIdAffinity(string key, string data)
        {
            ParaIdAffinityTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ParaIdAffinity
        ///  Maps a `ParaId` to `CoreIndex` and keeps track of how many assignments the scheduler has in
        ///  it's lookahead. Keeping track of this affinity prevents parallel execution of the same
        ///  `ParaId` on two or more `CoreIndex`es.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.CoreAffinityCount GetParaIdAffinity(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ParaIdAffinityTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.CoreAffinityCount result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for OnDemandAssignmentProvider.QueueStatus
        /// </summary>
        [StorageChange("OnDemandAssignmentProvider", "QueueStatus")]
        public void OnUpdateQueueStatus(string data)
        {
            QueueStatusTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueueStatus
        ///  Overall status of queue (both free + affinity entries)
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types.QueueStatusType GetQueueStatus()
        {
            return QueueStatusTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for OnDemandAssignmentProvider.FreeEntries
        /// </summary>
        [StorageChange("OnDemandAssignmentProvider", "FreeEntries")]
        public void OnUpdateFreeEntries(string data)
        {
            FreeEntriesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> FreeEntries
        ///  Priority queue for all orders which don't yet (or not any more) have any core affinity.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2 GetFreeEntries()
        {
            return FreeEntriesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for OnDemandAssignmentProvider.AffinityEntries
        /// </summary>
        [StorageChange("OnDemandAssignmentProvider", "AffinityEntries")]
        public void OnUpdateAffinityEntries(string key, string data)
        {
            AffinityEntriesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AffinityEntries
        ///  Queue entries that are currently bound to a particular core due to core affinity.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2 GetAffinityEntries(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AffinityEntriesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.BinaryHeapT2 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for OnDemandAssignmentProvider.Revenue
        /// </summary>
        [StorageChange("OnDemandAssignmentProvider", "Revenue")]
        public void OnUpdateRevenue(string data)
        {
            RevenueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Revenue
        ///  Keeps track of accumulated revenue from on demand order sales.
        /// </summary>
        public Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44 GetRevenue()
        {
            return RevenueTypedStorage.Get();
        }
    }
}
