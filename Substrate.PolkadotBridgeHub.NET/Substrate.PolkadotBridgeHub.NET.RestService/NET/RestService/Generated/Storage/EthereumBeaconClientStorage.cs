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


namespace Substrate.PolkadotBridgeHub.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IEthereumBeaconClientStorage interface definition.
    /// </summary>
    public interface IEthereumBeaconClientStorage : IStorage
    {
        
        /// <summary>
        /// >> InitialCheckpointRoot
        ///  Latest imported checkpoint root
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetInitialCheckpointRoot();
        
        /// <summary>
        /// >> LatestFinalizedBlockRoot
        ///  Latest imported finalized block root
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetLatestFinalizedBlockRoot();
        
        /// <summary>
        /// >> FinalizedBeaconState
        ///  Beacon state by finalized block root
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.CompactBeaconState GetFinalizedBeaconState(string key);
        
        /// <summary>
        /// >> FinalizedBeaconStateIndex
        ///  Finalized Headers: Current position in ring buffer
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetFinalizedBeaconStateIndex();
        
        /// <summary>
        /// >> FinalizedBeaconStateMapping
        ///  Finalized Headers: Mapping of ring buffer index to a pruning candidate
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetFinalizedBeaconStateMapping(string key);
        
        /// <summary>
        /// >> ValidatorsRoot
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetValidatorsRoot();
        
        /// <summary>
        /// >> CurrentSyncCommittee
        ///  Sync committee for current period
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared GetCurrentSyncCommittee();
        
        /// <summary>
        /// >> NextSyncCommittee
        ///  Sync committee for next period
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared GetNextSyncCommittee();
        
        /// <summary>
        /// >> OperatingMode
        ///  The current operating mode of the pallet.
        /// </summary>
        Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode.EnumBasicOperatingMode GetOperatingMode();
    }
    
    /// <summary>
    /// EthereumBeaconClientStorage class definition.
    /// </summary>
    public sealed class EthereumBeaconClientStorage : IEthereumBeaconClientStorage
    {
        
        /// <summary>
        /// _initialCheckpointRootTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> _initialCheckpointRootTypedStorage;
        
        /// <summary>
        /// _latestFinalizedBlockRootTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> _latestFinalizedBlockRootTypedStorage;
        
        /// <summary>
        /// _finalizedBeaconStateTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.CompactBeaconState> _finalizedBeaconStateTypedStorage;
        
        /// <summary>
        /// _finalizedBeaconStateIndexTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _finalizedBeaconStateIndexTypedStorage;
        
        /// <summary>
        /// _finalizedBeaconStateMappingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> _finalizedBeaconStateMappingTypedStorage;
        
        /// <summary>
        /// _validatorsRootTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> _validatorsRootTypedStorage;
        
        /// <summary>
        /// _currentSyncCommitteeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared> _currentSyncCommitteeTypedStorage;
        
        /// <summary>
        /// _nextSyncCommitteeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared> _nextSyncCommitteeTypedStorage;
        
        /// <summary>
        /// _operatingModeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode.EnumBasicOperatingMode> _operatingModeTypedStorage;
        
        /// <summary>
        /// EthereumBeaconClientStorage constructor.
        /// </summary>
        public EthereumBeaconClientStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.InitialCheckpointRootTypedStorage = new TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>("EthereumBeaconClient.InitialCheckpointRoot", storageDataProvider, storageChangeDelegates);
            this.LatestFinalizedBlockRootTypedStorage = new TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>("EthereumBeaconClient.LatestFinalizedBlockRoot", storageDataProvider, storageChangeDelegates);
            this.FinalizedBeaconStateTypedStorage = new TypedMapStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.CompactBeaconState>("EthereumBeaconClient.FinalizedBeaconState", storageDataProvider, storageChangeDelegates);
            this.FinalizedBeaconStateIndexTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("EthereumBeaconClient.FinalizedBeaconStateIndex", storageDataProvider, storageChangeDelegates);
            this.FinalizedBeaconStateMappingTypedStorage = new TypedMapStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>("EthereumBeaconClient.FinalizedBeaconStateMapping", storageDataProvider, storageChangeDelegates);
            this.ValidatorsRootTypedStorage = new TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256>("EthereumBeaconClient.ValidatorsRoot", storageDataProvider, storageChangeDelegates);
            this.CurrentSyncCommitteeTypedStorage = new TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared>("EthereumBeaconClient.CurrentSyncCommittee", storageDataProvider, storageChangeDelegates);
            this.NextSyncCommitteeTypedStorage = new TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared>("EthereumBeaconClient.NextSyncCommittee", storageDataProvider, storageChangeDelegates);
            this.OperatingModeTypedStorage = new TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode.EnumBasicOperatingMode>("EthereumBeaconClient.OperatingMode", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _initialCheckpointRootTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> InitialCheckpointRootTypedStorage
        {
            get
            {
                return _initialCheckpointRootTypedStorage;
            }
            set
            {
                _initialCheckpointRootTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _latestFinalizedBlockRootTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> LatestFinalizedBlockRootTypedStorage
        {
            get
            {
                return _latestFinalizedBlockRootTypedStorage;
            }
            set
            {
                _latestFinalizedBlockRootTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _finalizedBeaconStateTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.CompactBeaconState> FinalizedBeaconStateTypedStorage
        {
            get
            {
                return _finalizedBeaconStateTypedStorage;
            }
            set
            {
                _finalizedBeaconStateTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _finalizedBeaconStateIndexTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> FinalizedBeaconStateIndexTypedStorage
        {
            get
            {
                return _finalizedBeaconStateIndexTypedStorage;
            }
            set
            {
                _finalizedBeaconStateIndexTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _finalizedBeaconStateMappingTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> FinalizedBeaconStateMappingTypedStorage
        {
            get
            {
                return _finalizedBeaconStateMappingTypedStorage;
            }
            set
            {
                _finalizedBeaconStateMappingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _validatorsRootTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256> ValidatorsRootTypedStorage
        {
            get
            {
                return _validatorsRootTypedStorage;
            }
            set
            {
                _validatorsRootTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentSyncCommitteeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared> CurrentSyncCommitteeTypedStorage
        {
            get
            {
                return _currentSyncCommitteeTypedStorage;
            }
            set
            {
                _currentSyncCommitteeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextSyncCommitteeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared> NextSyncCommitteeTypedStorage
        {
            get
            {
                return _nextSyncCommitteeTypedStorage;
            }
            set
            {
                _nextSyncCommitteeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _operatingModeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode.EnumBasicOperatingMode> OperatingModeTypedStorage
        {
            get
            {
                return _operatingModeTypedStorage;
            }
            set
            {
                _operatingModeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await InitialCheckpointRootTypedStorage.InitializeAsync("EthereumBeaconClient", "InitialCheckpointRoot");
            await LatestFinalizedBlockRootTypedStorage.InitializeAsync("EthereumBeaconClient", "LatestFinalizedBlockRoot");
            await FinalizedBeaconStateTypedStorage.InitializeAsync("EthereumBeaconClient", "FinalizedBeaconState");
            await FinalizedBeaconStateIndexTypedStorage.InitializeAsync("EthereumBeaconClient", "FinalizedBeaconStateIndex");
            await FinalizedBeaconStateMappingTypedStorage.InitializeAsync("EthereumBeaconClient", "FinalizedBeaconStateMapping");
            await ValidatorsRootTypedStorage.InitializeAsync("EthereumBeaconClient", "ValidatorsRoot");
            await CurrentSyncCommitteeTypedStorage.InitializeAsync("EthereumBeaconClient", "CurrentSyncCommittee");
            await NextSyncCommitteeTypedStorage.InitializeAsync("EthereumBeaconClient", "NextSyncCommittee");
            await OperatingModeTypedStorage.InitializeAsync("EthereumBeaconClient", "OperatingMode");
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.InitialCheckpointRoot
        /// </summary>
        [StorageChange("EthereumBeaconClient", "InitialCheckpointRoot")]
        public void OnUpdateInitialCheckpointRoot(string data)
        {
            InitialCheckpointRootTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InitialCheckpointRoot
        ///  Latest imported checkpoint root
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetInitialCheckpointRoot()
        {
            return InitialCheckpointRootTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.LatestFinalizedBlockRoot
        /// </summary>
        [StorageChange("EthereumBeaconClient", "LatestFinalizedBlockRoot")]
        public void OnUpdateLatestFinalizedBlockRoot(string data)
        {
            LatestFinalizedBlockRootTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LatestFinalizedBlockRoot
        ///  Latest imported finalized block root
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetLatestFinalizedBlockRoot()
        {
            return LatestFinalizedBlockRootTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.FinalizedBeaconState
        /// </summary>
        [StorageChange("EthereumBeaconClient", "FinalizedBeaconState")]
        public void OnUpdateFinalizedBeaconState(string key, string data)
        {
            FinalizedBeaconStateTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FinalizedBeaconState
        ///  Beacon state by finalized block root
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.CompactBeaconState GetFinalizedBeaconState(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FinalizedBeaconStateTypedStorage.Dictionary.TryGetValue(key, out Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.CompactBeaconState result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.FinalizedBeaconStateIndex
        /// </summary>
        [StorageChange("EthereumBeaconClient", "FinalizedBeaconStateIndex")]
        public void OnUpdateFinalizedBeaconStateIndex(string data)
        {
            FinalizedBeaconStateIndexTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> FinalizedBeaconStateIndex
        ///  Finalized Headers: Current position in ring buffer
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetFinalizedBeaconStateIndex()
        {
            return FinalizedBeaconStateIndexTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.FinalizedBeaconStateMapping
        /// </summary>
        [StorageChange("EthereumBeaconClient", "FinalizedBeaconStateMapping")]
        public void OnUpdateFinalizedBeaconStateMapping(string key, string data)
        {
            FinalizedBeaconStateMappingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FinalizedBeaconStateMapping
        ///  Finalized Headers: Mapping of ring buffer index to a pruning candidate
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetFinalizedBeaconStateMapping(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FinalizedBeaconStateMappingTypedStorage.Dictionary.TryGetValue(key, out Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.ValidatorsRoot
        /// </summary>
        [StorageChange("EthereumBeaconClient", "ValidatorsRoot")]
        public void OnUpdateValidatorsRoot(string data)
        {
            ValidatorsRootTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ValidatorsRoot
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 GetValidatorsRoot()
        {
            return ValidatorsRootTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.CurrentSyncCommittee
        /// </summary>
        [StorageChange("EthereumBeaconClient", "CurrentSyncCommittee")]
        public void OnUpdateCurrentSyncCommittee(string data)
        {
            CurrentSyncCommitteeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentSyncCommittee
        ///  Sync committee for current period
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared GetCurrentSyncCommittee()
        {
            return CurrentSyncCommitteeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.NextSyncCommittee
        /// </summary>
        [StorageChange("EthereumBeaconClient", "NextSyncCommittee")]
        public void OnUpdateNextSyncCommittee(string data)
        {
            NextSyncCommitteeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextSyncCommittee
        ///  Sync committee for next period
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_beacon_primitives.types.SyncCommitteePrepared GetNextSyncCommittee()
        {
            return NextSyncCommitteeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for EthereumBeaconClient.OperatingMode
        /// </summary>
        [StorageChange("EthereumBeaconClient", "OperatingMode")]
        public void OnUpdateOperatingMode(string data)
        {
            OperatingModeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> OperatingMode
        ///  The current operating mode of the pallet.
        /// </summary>
        public Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode.EnumBasicOperatingMode GetOperatingMode()
        {
            return OperatingModeTypedStorage.Get();
        }
    }
}
