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


namespace Substrate.Bajun.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IVestingStorage interface definition.
    /// </summary>
    public interface IVestingStorage : IStorage
    {
        
        /// <summary>
        /// >> VestingSchedules
        ///  Vesting schedules of an account.
        /// 
        ///  VestingSchedules: map AccountId => Vec<VestingSchedule>
        /// </summary>
        Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35 GetVestingSchedules(string key);
    }
    
    /// <summary>
    /// VestingStorage class definition.
    /// </summary>
    public sealed class VestingStorage : IVestingStorage
    {
        
        /// <summary>
        /// _vestingSchedulesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35> _vestingSchedulesTypedStorage;
        
        /// <summary>
        /// VestingStorage constructor.
        /// </summary>
        public VestingStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.VestingSchedulesTypedStorage = new TypedMapStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35>("Vesting.VestingSchedules", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _vestingSchedulesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35> VestingSchedulesTypedStorage
        {
            get
            {
                return _vestingSchedulesTypedStorage;
            }
            set
            {
                _vestingSchedulesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await VestingSchedulesTypedStorage.InitializeAsync("Vesting", "VestingSchedules");
        }
        
        /// <summary>
        /// Implements any storage change for Vesting.VestingSchedules
        /// </summary>
        [StorageChange("Vesting", "VestingSchedules")]
        public void OnUpdateVestingSchedules(string key, string data)
        {
            VestingSchedulesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VestingSchedules
        ///  Vesting schedules of an account.
        /// 
        ///  VestingSchedules: map AccountId => Vec<VestingSchedule>
        /// </summary>
        public Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35 GetVestingSchedules(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VestingSchedulesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35 result))
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
