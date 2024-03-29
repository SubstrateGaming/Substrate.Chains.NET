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
    /// IAvnFinalityTrackerStorage interface definition.
    /// </summary>
    public interface IAvnFinalityTrackerStorage : IStorage
    {
        
        /// <summary>
        /// >> LatestFinalisedBlock
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetLatestFinalisedBlock();
        
        /// <summary>
        /// >> LastFinalisedBlockUpdate
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetLastFinalisedBlockUpdate();
        
        /// <summary>
        /// >> LastFinalisedBlockSubmission
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetLastFinalisedBlockSubmission();
        
        /// <summary>
        /// >> SubmittedBlockNumbers
        /// </summary>
        Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker.SubmissionData GetSubmittedBlockNumbers(string key);
    }
    
    /// <summary>
    /// AvnFinalityTrackerStorage class definition.
    /// </summary>
    public sealed class AvnFinalityTrackerStorage : IAvnFinalityTrackerStorage
    {
        
        /// <summary>
        /// _latestFinalisedBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _latestFinalisedBlockTypedStorage;
        
        /// <summary>
        /// _lastFinalisedBlockUpdateTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _lastFinalisedBlockUpdateTypedStorage;
        
        /// <summary>
        /// _lastFinalisedBlockSubmissionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _lastFinalisedBlockSubmissionTypedStorage;
        
        /// <summary>
        /// _submittedBlockNumbersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker.SubmissionData> _submittedBlockNumbersTypedStorage;
        
        /// <summary>
        /// AvnFinalityTrackerStorage constructor.
        /// </summary>
        public AvnFinalityTrackerStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.LatestFinalisedBlockTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("AvnFinalityTracker.LatestFinalisedBlock", storageDataProvider, storageChangeDelegates);
            this.LastFinalisedBlockUpdateTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("AvnFinalityTracker.LastFinalisedBlockUpdate", storageDataProvider, storageChangeDelegates);
            this.LastFinalisedBlockSubmissionTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("AvnFinalityTracker.LastFinalisedBlockSubmission", storageDataProvider, storageChangeDelegates);
            this.SubmittedBlockNumbersTypedStorage = new TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker.SubmissionData>("AvnFinalityTracker.SubmittedBlockNumbers", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _latestFinalisedBlockTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> LatestFinalisedBlockTypedStorage
        {
            get
            {
                return _latestFinalisedBlockTypedStorage;
            }
            set
            {
                _latestFinalisedBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastFinalisedBlockUpdateTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> LastFinalisedBlockUpdateTypedStorage
        {
            get
            {
                return _lastFinalisedBlockUpdateTypedStorage;
            }
            set
            {
                _lastFinalisedBlockUpdateTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastFinalisedBlockSubmissionTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> LastFinalisedBlockSubmissionTypedStorage
        {
            get
            {
                return _lastFinalisedBlockSubmissionTypedStorage;
            }
            set
            {
                _lastFinalisedBlockSubmissionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _submittedBlockNumbersTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker.SubmissionData> SubmittedBlockNumbersTypedStorage
        {
            get
            {
                return _submittedBlockNumbersTypedStorage;
            }
            set
            {
                _submittedBlockNumbersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await LatestFinalisedBlockTypedStorage.InitializeAsync("AvnFinalityTracker", "LatestFinalisedBlock");
            await LastFinalisedBlockUpdateTypedStorage.InitializeAsync("AvnFinalityTracker", "LastFinalisedBlockUpdate");
            await LastFinalisedBlockSubmissionTypedStorage.InitializeAsync("AvnFinalityTracker", "LastFinalisedBlockSubmission");
            await SubmittedBlockNumbersTypedStorage.InitializeAsync("AvnFinalityTracker", "SubmittedBlockNumbers");
        }
        
        /// <summary>
        /// Implements any storage change for AvnFinalityTracker.LatestFinalisedBlock
        /// </summary>
        [StorageChange("AvnFinalityTracker", "LatestFinalisedBlock")]
        public void OnUpdateLatestFinalisedBlock(string data)
        {
            LatestFinalisedBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LatestFinalisedBlock
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetLatestFinalisedBlock()
        {
            return LatestFinalisedBlockTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AvnFinalityTracker.LastFinalisedBlockUpdate
        /// </summary>
        [StorageChange("AvnFinalityTracker", "LastFinalisedBlockUpdate")]
        public void OnUpdateLastFinalisedBlockUpdate(string data)
        {
            LastFinalisedBlockUpdateTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LastFinalisedBlockUpdate
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetLastFinalisedBlockUpdate()
        {
            return LastFinalisedBlockUpdateTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AvnFinalityTracker.LastFinalisedBlockSubmission
        /// </summary>
        [StorageChange("AvnFinalityTracker", "LastFinalisedBlockSubmission")]
        public void OnUpdateLastFinalisedBlockSubmission(string data)
        {
            LastFinalisedBlockSubmissionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LastFinalisedBlockSubmission
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetLastFinalisedBlockSubmission()
        {
            return LastFinalisedBlockSubmissionTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AvnFinalityTracker.SubmittedBlockNumbers
        /// </summary>
        [StorageChange("AvnFinalityTracker", "SubmittedBlockNumbers")]
        public void OnUpdateSubmittedBlockNumbers(string key, string data)
        {
            SubmittedBlockNumbersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SubmittedBlockNumbers
        /// </summary>
        public Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker.SubmissionData GetSubmittedBlockNumbers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SubmittedBlockNumbersTypedStorage.Dictionary.TryGetValue(key, out Substrate.Aventus.NET.NetApiExt.Generated.Model.pallet_avn_finality_tracker.SubmissionData result))
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
