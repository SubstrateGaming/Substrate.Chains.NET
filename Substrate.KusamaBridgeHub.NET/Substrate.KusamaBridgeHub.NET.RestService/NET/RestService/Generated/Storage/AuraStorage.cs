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


namespace Substrate.KusamaBridgeHub.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAuraStorage interface definition.
    /// </summary>
    public interface IAuraStorage : IStorage
    {
        
        /// <summary>
        /// >> Authorities
        ///  The current authority set.
        /// </summary>
        Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 GetAuthorities();
        
        /// <summary>
        /// >> CurrentSlot
        ///  The current slot of this block.
        /// 
        ///  This will be set in `on_initialize`.
        /// </summary>
        Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot GetCurrentSlot();
    }
    
    /// <summary>
    /// AuraStorage class definition.
    /// </summary>
    public sealed class AuraStorage : IAuraStorage
    {
        
        /// <summary>
        /// _authoritiesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8> _authoritiesTypedStorage;
        
        /// <summary>
        /// _currentSlotTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot> _currentSlotTypedStorage;
        
        /// <summary>
        /// AuraStorage constructor.
        /// </summary>
        public AuraStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AuthoritiesTypedStorage = new TypedStorage<Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8>("Aura.Authorities", storageDataProvider, storageChangeDelegates);
            this.CurrentSlotTypedStorage = new TypedStorage<Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot>("Aura.CurrentSlot", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _authoritiesTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8> AuthoritiesTypedStorage
        {
            get
            {
                return _authoritiesTypedStorage;
            }
            set
            {
                _authoritiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentSlotTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot> CurrentSlotTypedStorage
        {
            get
            {
                return _currentSlotTypedStorage;
            }
            set
            {
                _currentSlotTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AuthoritiesTypedStorage.InitializeAsync("Aura", "Authorities");
            await CurrentSlotTypedStorage.InitializeAsync("Aura", "CurrentSlot");
        }
        
        /// <summary>
        /// Implements any storage change for Aura.Authorities
        /// </summary>
        [StorageChange("Aura", "Authorities")]
        public void OnUpdateAuthorities(string data)
        {
            AuthoritiesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Authorities
        ///  The current authority set.
        /// </summary>
        public Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 GetAuthorities()
        {
            return AuthoritiesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Aura.CurrentSlot
        /// </summary>
        [StorageChange("Aura", "CurrentSlot")]
        public void OnUpdateCurrentSlot(string data)
        {
            CurrentSlotTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentSlot
        ///  The current slot of this block.
        /// 
        ///  This will be set in `on_initialize`.
        /// </summary>
        public Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot GetCurrentSlot()
        {
            return CurrentSlotTypedStorage.Get();
        }
    }
}