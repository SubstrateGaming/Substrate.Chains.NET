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


namespace Substrate.PolkadotAssetHub.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IToKusamaXcmRouterStorage interface definition.
    /// </summary>
    public interface IToKusamaXcmRouterStorage : IStorage
    {
        
        /// <summary>
        /// >> Bridge
        ///  Bridge that we are using.
        /// 
        ///  **bridges-v1** assumptions: all outbound messages through this router are using single lane
        ///  and to single remote consensus. If there is some other remote consensus that uses the same
        ///  bridge hub, the separate pallet instance shall be used, In `v2` we'll have all required
        ///  primitives (lane-id aka bridge-id, derived from XCM locations) to support multiple  bridges
        ///  by the same pallet instance.
        /// </summary>
        Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bp_xcm_bridge_hub_router.BridgeState GetBridge();
    }
    
    /// <summary>
    /// ToKusamaXcmRouterStorage class definition.
    /// </summary>
    public sealed class ToKusamaXcmRouterStorage : IToKusamaXcmRouterStorage
    {
        
        /// <summary>
        /// _bridgeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bp_xcm_bridge_hub_router.BridgeState> _bridgeTypedStorage;
        
        /// <summary>
        /// ToKusamaXcmRouterStorage constructor.
        /// </summary>
        public ToKusamaXcmRouterStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.BridgeTypedStorage = new TypedStorage<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bp_xcm_bridge_hub_router.BridgeState>("ToKusamaXcmRouter.Bridge", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _bridgeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bp_xcm_bridge_hub_router.BridgeState> BridgeTypedStorage
        {
            get
            {
                return _bridgeTypedStorage;
            }
            set
            {
                _bridgeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await BridgeTypedStorage.InitializeAsync("ToKusamaXcmRouter", "Bridge");
        }
        
        /// <summary>
        /// Implements any storage change for ToKusamaXcmRouter.Bridge
        /// </summary>
        [StorageChange("ToKusamaXcmRouter", "Bridge")]
        public void OnUpdateBridge(string data)
        {
            BridgeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Bridge
        ///  Bridge that we are using.
        /// 
        ///  **bridges-v1** assumptions: all outbound messages through this router are using single lane
        ///  and to single remote consensus. If there is some other remote consensus that uses the same
        ///  bridge hub, the separate pallet instance shall be used, In `v2` we'll have all required
        ///  primitives (lane-id aka bridge-id, derived from XCM locations) to support multiple  bridges
        ///  by the same pallet instance.
        /// </summary>
        public Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bp_xcm_bridge_hub_router.BridgeState GetBridge()
        {
            return BridgeTypedStorage.Get();
        }
    }
}