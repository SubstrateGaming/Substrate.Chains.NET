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


namespace Substrate.Coretime.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IPolkadotXcmStorage interface definition.
    /// </summary>
    public interface IPolkadotXcmStorage : IStorage
    {
        
        /// <summary>
        /// >> QueryCounter
        ///  The latest available query index.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetQueryCounter();
        
        /// <summary>
        /// >> Queries
        ///  The ongoing queries.
        /// </summary>
        Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus GetQueries(string key);
        
        /// <summary>
        /// >> AssetTraps
        ///  The existing asset traps.
        /// 
        ///  Key is the blake2 256 hash of (origin, versioned `Assets`) pair. Value is the number of
        ///  times this pair has been trapped (usually just 1 if it exists at all).
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetAssetTraps(string key);
        
        /// <summary>
        /// >> SafeXcmVersion
        ///  Default version to encode XCM when latest version of destination is unknown. If `None`,
        ///  then the destinations whose XCM version is unknown are considered unreachable.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetSafeXcmVersion();
        
        /// <summary>
        /// >> SupportedVersion
        ///  The Latest versions that we know various locations support.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetSupportedVersion(string key);
        
        /// <summary>
        /// >> VersionNotifiers
        ///  All locations that we have requested version notifications from.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetVersionNotifiers(string key);
        
        /// <summary>
        /// >> VersionNotifyTargets
        ///  The target locations that are subscribed to our version changes, as well as the most recent
        ///  of our versions we informed them of.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32> GetVersionNotifyTargets(string key);
        
        /// <summary>
        /// >> VersionDiscoveryQueue
        ///  Destinations whose latest XCM version we would like to know. Duplicates not allowed, and
        ///  the `u32` counter is the number of times that a send to the destination has been attempted,
        ///  which is used as a prioritization.
        /// </summary>
        Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 GetVersionDiscoveryQueue();
        
        /// <summary>
        /// >> CurrentMigration
        ///  The current migration's stage, if any.
        /// </summary>
        Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage GetCurrentMigration();
        
        /// <summary>
        /// >> RemoteLockedFungibles
        ///  Fungible assets which we know are locked on a remote chain.
        /// </summary>
        Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord GetRemoteLockedFungibles(string key);
        
        /// <summary>
        /// >> LockedFungibles
        ///  Fungible assets which we know are locked on this chain.
        /// </summary>
        Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16 GetLockedFungibles(string key);
        
        /// <summary>
        /// >> XcmExecutionSuspended
        ///  Global suspension state of the XCM executor.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetXcmExecutionSuspended();
        
        /// <summary>
        /// >> ShouldRecordXcm
        ///  Whether or not incoming XCMs (both executed locally and received) should be recorded.
        ///  Only one XCM program will be recorded at a time.
        ///  This is meant to be used in runtime APIs, and it's advised it stays false
        ///  for all other use cases, so as to not degrade regular performance.
        /// 
        ///  Only relevant if this pallet is being used as the [`xcm_executor::traits::RecordXcm`]
        ///  implementation in the XCM executor configuration.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetShouldRecordXcm();
        
        /// <summary>
        /// >> RecordedXcm
        ///  If [`ShouldRecordXcm`] is set to true, then the last XCM program executed locally
        ///  will be stored here.
        ///  Runtime APIs can fetch the XCM that was executed by accessing this value.
        /// 
        ///  Only relevant if this pallet is being used as the [`xcm_executor::traits::RecordXcm`]
        ///  implementation in the XCM executor configuration.
        /// </summary>
        Substrate.Coretime.NET.NetApiExt.Generated.Model.staging_xcm.v4.XcmT1 GetRecordedXcm();
    }
    
    /// <summary>
    /// PolkadotXcmStorage class definition.
    /// </summary>
    public sealed class PolkadotXcmStorage : IPolkadotXcmStorage
    {
        
        /// <summary>
        /// _queryCounterTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> _queryCounterTypedStorage;
        
        /// <summary>
        /// _queriesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus> _queriesTypedStorage;
        
        /// <summary>
        /// _assetTrapsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _assetTrapsTypedStorage;
        
        /// <summary>
        /// _safeXcmVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _safeXcmVersionTypedStorage;
        
        /// <summary>
        /// _supportedVersionTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _supportedVersionTypedStorage;
        
        /// <summary>
        /// _versionNotifiersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> _versionNotifiersTypedStorage;
        
        /// <summary>
        /// _versionNotifyTargetsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32>> _versionNotifyTargetsTypedStorage;
        
        /// <summary>
        /// _versionDiscoveryQueueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14> _versionDiscoveryQueueTypedStorage;
        
        /// <summary>
        /// _currentMigrationTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage> _currentMigrationTypedStorage;
        
        /// <summary>
        /// _remoteLockedFungiblesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord> _remoteLockedFungiblesTypedStorage;
        
        /// <summary>
        /// _lockedFungiblesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16> _lockedFungiblesTypedStorage;
        
        /// <summary>
        /// _xcmExecutionSuspendedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _xcmExecutionSuspendedTypedStorage;
        
        /// <summary>
        /// _shouldRecordXcmTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _shouldRecordXcmTypedStorage;
        
        /// <summary>
        /// _recordedXcmTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.staging_xcm.v4.XcmT1> _recordedXcmTypedStorage;
        
        /// <summary>
        /// PolkadotXcmStorage constructor.
        /// </summary>
        public PolkadotXcmStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.QueryCounterTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64>("PolkadotXcm.QueryCounter", storageDataProvider, storageChangeDelegates);
            this.QueriesTypedStorage = new TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus>("PolkadotXcm.Queries", storageDataProvider, storageChangeDelegates);
            this.AssetTrapsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("PolkadotXcm.AssetTraps", storageDataProvider, storageChangeDelegates);
            this.SafeXcmVersionTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("PolkadotXcm.SafeXcmVersion", storageDataProvider, storageChangeDelegates);
            this.SupportedVersionTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("PolkadotXcm.SupportedVersion", storageDataProvider, storageChangeDelegates);
            this.VersionNotifiersTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64>("PolkadotXcm.VersionNotifiers", storageDataProvider, storageChangeDelegates);
            this.VersionNotifyTargetsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32>>("PolkadotXcm.VersionNotifyTargets", storageDataProvider, storageChangeDelegates);
            this.VersionDiscoveryQueueTypedStorage = new TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14>("PolkadotXcm.VersionDiscoveryQueue", storageDataProvider, storageChangeDelegates);
            this.CurrentMigrationTypedStorage = new TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage>("PolkadotXcm.CurrentMigration", storageDataProvider, storageChangeDelegates);
            this.RemoteLockedFungiblesTypedStorage = new TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord>("PolkadotXcm.RemoteLockedFungibles", storageDataProvider, storageChangeDelegates);
            this.LockedFungiblesTypedStorage = new TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16>("PolkadotXcm.LockedFungibles", storageDataProvider, storageChangeDelegates);
            this.XcmExecutionSuspendedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("PolkadotXcm.XcmExecutionSuspended", storageDataProvider, storageChangeDelegates);
            this.ShouldRecordXcmTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("PolkadotXcm.ShouldRecordXcm", storageDataProvider, storageChangeDelegates);
            this.RecordedXcmTypedStorage = new TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.staging_xcm.v4.XcmT1>("PolkadotXcm.RecordedXcm", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _queryCounterTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> QueryCounterTypedStorage
        {
            get
            {
                return _queryCounterTypedStorage;
            }
            set
            {
                _queryCounterTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queriesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus> QueriesTypedStorage
        {
            get
            {
                return _queriesTypedStorage;
            }
            set
            {
                _queriesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _assetTrapsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> AssetTrapsTypedStorage
        {
            get
            {
                return _assetTrapsTypedStorage;
            }
            set
            {
                _assetTrapsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _safeXcmVersionTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> SafeXcmVersionTypedStorage
        {
            get
            {
                return _safeXcmVersionTypedStorage;
            }
            set
            {
                _safeXcmVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _supportedVersionTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> SupportedVersionTypedStorage
        {
            get
            {
                return _supportedVersionTypedStorage;
            }
            set
            {
                _supportedVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _versionNotifiersTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U64> VersionNotifiersTypedStorage
        {
            get
            {
                return _versionNotifiersTypedStorage;
            }
            set
            {
                _versionNotifiersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _versionNotifyTargetsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32>> VersionNotifyTargetsTypedStorage
        {
            get
            {
                return _versionNotifyTargetsTypedStorage;
            }
            set
            {
                _versionNotifyTargetsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _versionDiscoveryQueueTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14> VersionDiscoveryQueueTypedStorage
        {
            get
            {
                return _versionDiscoveryQueueTypedStorage;
            }
            set
            {
                _versionDiscoveryQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentMigrationTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage> CurrentMigrationTypedStorage
        {
            get
            {
                return _currentMigrationTypedStorage;
            }
            set
            {
                _currentMigrationTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _remoteLockedFungiblesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord> RemoteLockedFungiblesTypedStorage
        {
            get
            {
                return _remoteLockedFungiblesTypedStorage;
            }
            set
            {
                _remoteLockedFungiblesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lockedFungiblesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16> LockedFungiblesTypedStorage
        {
            get
            {
                return _lockedFungiblesTypedStorage;
            }
            set
            {
                _lockedFungiblesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _xcmExecutionSuspendedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> XcmExecutionSuspendedTypedStorage
        {
            get
            {
                return _xcmExecutionSuspendedTypedStorage;
            }
            set
            {
                _xcmExecutionSuspendedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _shouldRecordXcmTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> ShouldRecordXcmTypedStorage
        {
            get
            {
                return _shouldRecordXcmTypedStorage;
            }
            set
            {
                _shouldRecordXcmTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _recordedXcmTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Coretime.NET.NetApiExt.Generated.Model.staging_xcm.v4.XcmT1> RecordedXcmTypedStorage
        {
            get
            {
                return _recordedXcmTypedStorage;
            }
            set
            {
                _recordedXcmTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await QueryCounterTypedStorage.InitializeAsync("PolkadotXcm", "QueryCounter");
            await QueriesTypedStorage.InitializeAsync("PolkadotXcm", "Queries");
            await AssetTrapsTypedStorage.InitializeAsync("PolkadotXcm", "AssetTraps");
            await SafeXcmVersionTypedStorage.InitializeAsync("PolkadotXcm", "SafeXcmVersion");
            await SupportedVersionTypedStorage.InitializeAsync("PolkadotXcm", "SupportedVersion");
            await VersionNotifiersTypedStorage.InitializeAsync("PolkadotXcm", "VersionNotifiers");
            await VersionNotifyTargetsTypedStorage.InitializeAsync("PolkadotXcm", "VersionNotifyTargets");
            await VersionDiscoveryQueueTypedStorage.InitializeAsync("PolkadotXcm", "VersionDiscoveryQueue");
            await CurrentMigrationTypedStorage.InitializeAsync("PolkadotXcm", "CurrentMigration");
            await RemoteLockedFungiblesTypedStorage.InitializeAsync("PolkadotXcm", "RemoteLockedFungibles");
            await LockedFungiblesTypedStorage.InitializeAsync("PolkadotXcm", "LockedFungibles");
            await XcmExecutionSuspendedTypedStorage.InitializeAsync("PolkadotXcm", "XcmExecutionSuspended");
            await ShouldRecordXcmTypedStorage.InitializeAsync("PolkadotXcm", "ShouldRecordXcm");
            await RecordedXcmTypedStorage.InitializeAsync("PolkadotXcm", "RecordedXcm");
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.QueryCounter
        /// </summary>
        [StorageChange("PolkadotXcm", "QueryCounter")]
        public void OnUpdateQueryCounter(string data)
        {
            QueryCounterTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueryCounter
        ///  The latest available query index.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetQueryCounter()
        {
            return QueryCounterTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.Queries
        /// </summary>
        [StorageChange("PolkadotXcm", "Queries")]
        public void OnUpdateQueries(string key, string data)
        {
            QueriesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Queries
        ///  The ongoing queries.
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus GetQueries(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (QueriesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.AssetTraps
        /// </summary>
        [StorageChange("PolkadotXcm", "AssetTraps")]
        public void OnUpdateAssetTraps(string key, string data)
        {
            AssetTrapsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AssetTraps
        ///  The existing asset traps.
        /// 
        ///  Key is the blake2 256 hash of (origin, versioned `Assets`) pair. Value is the number of
        ///  times this pair has been trapped (usually just 1 if it exists at all).
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetAssetTraps(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetTrapsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.SafeXcmVersion
        /// </summary>
        [StorageChange("PolkadotXcm", "SafeXcmVersion")]
        public void OnUpdateSafeXcmVersion(string data)
        {
            SafeXcmVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> SafeXcmVersion
        ///  Default version to encode XCM when latest version of destination is unknown. If `None`,
        ///  then the destinations whose XCM version is unknown are considered unreachable.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetSafeXcmVersion()
        {
            return SafeXcmVersionTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.SupportedVersion
        /// </summary>
        [StorageChange("PolkadotXcm", "SupportedVersion")]
        public void OnUpdateSupportedVersion(string key, string data)
        {
            SupportedVersionTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SupportedVersion
        ///  The Latest versions that we know various locations support.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetSupportedVersion(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SupportedVersionTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.VersionNotifiers
        /// </summary>
        [StorageChange("PolkadotXcm", "VersionNotifiers")]
        public void OnUpdateVersionNotifiers(string key, string data)
        {
            VersionNotifiersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VersionNotifiers
        ///  All locations that we have requested version notifications from.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetVersionNotifiers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VersionNotifiersTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U64 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.VersionNotifyTargets
        /// </summary>
        [StorageChange("PolkadotXcm", "VersionNotifyTargets")]
        public void OnUpdateVersionNotifyTargets(string key, string data)
        {
            VersionNotifyTargetsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VersionNotifyTargets
        ///  The target locations that are subscribed to our version changes, as well as the most recent
        ///  of our versions we informed them of.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32> GetVersionNotifyTargets(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VersionNotifyTargetsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.VersionDiscoveryQueue
        /// </summary>
        [StorageChange("PolkadotXcm", "VersionDiscoveryQueue")]
        public void OnUpdateVersionDiscoveryQueue(string data)
        {
            VersionDiscoveryQueueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> VersionDiscoveryQueue
        ///  Destinations whose latest XCM version we would like to know. Duplicates not allowed, and
        ///  the `u32` counter is the number of times that a send to the destination has been attempted,
        ///  which is used as a prioritization.
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14 GetVersionDiscoveryQueue()
        {
            return VersionDiscoveryQueueTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.CurrentMigration
        /// </summary>
        [StorageChange("PolkadotXcm", "CurrentMigration")]
        public void OnUpdateCurrentMigration(string data)
        {
            CurrentMigrationTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentMigration
        ///  The current migration's stage, if any.
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage GetCurrentMigration()
        {
            return CurrentMigrationTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.RemoteLockedFungibles
        /// </summary>
        [StorageChange("PolkadotXcm", "RemoteLockedFungibles")]
        public void OnUpdateRemoteLockedFungibles(string key, string data)
        {
            RemoteLockedFungiblesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> RemoteLockedFungibles
        ///  Fungible assets which we know are locked on a remote chain.
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord GetRemoteLockedFungibles(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (RemoteLockedFungiblesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.RemoteLockedFungibleRecord result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.LockedFungibles
        /// </summary>
        [StorageChange("PolkadotXcm", "LockedFungibles")]
        public void OnUpdateLockedFungibles(string key, string data)
        {
            LockedFungiblesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> LockedFungibles
        ///  Fungible assets which we know are locked on this chain.
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16 GetLockedFungibles(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LockedFungiblesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.XcmExecutionSuspended
        /// </summary>
        [StorageChange("PolkadotXcm", "XcmExecutionSuspended")]
        public void OnUpdateXcmExecutionSuspended(string data)
        {
            XcmExecutionSuspendedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> XcmExecutionSuspended
        ///  Global suspension state of the XCM executor.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetXcmExecutionSuspended()
        {
            return XcmExecutionSuspendedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.ShouldRecordXcm
        /// </summary>
        [StorageChange("PolkadotXcm", "ShouldRecordXcm")]
        public void OnUpdateShouldRecordXcm(string data)
        {
            ShouldRecordXcmTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ShouldRecordXcm
        ///  Whether or not incoming XCMs (both executed locally and received) should be recorded.
        ///  Only one XCM program will be recorded at a time.
        ///  This is meant to be used in runtime APIs, and it's advised it stays false
        ///  for all other use cases, so as to not degrade regular performance.
        /// 
        ///  Only relevant if this pallet is being used as the [`xcm_executor::traits::RecordXcm`]
        ///  implementation in the XCM executor configuration.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetShouldRecordXcm()
        {
            return ShouldRecordXcmTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for PolkadotXcm.RecordedXcm
        /// </summary>
        [StorageChange("PolkadotXcm", "RecordedXcm")]
        public void OnUpdateRecordedXcm(string data)
        {
            RecordedXcmTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> RecordedXcm
        ///  If [`ShouldRecordXcm`] is set to true, then the last XCM program executed locally
        ///  will be stored here.
        ///  Runtime APIs can fetch the XCM that was executed by accessing this value.
        /// 
        ///  Only relevant if this pallet is being used as the [`xcm_executor::traits::RecordXcm`]
        ///  implementation in the XCM executor configuration.
        /// </summary>
        public Substrate.Coretime.NET.NetApiExt.Generated.Model.staging_xcm.v4.XcmT1 GetRecordedXcm()
        {
            return RecordedXcmTypedStorage.Get();
        }
    }
}