//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.HydraDX.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.HydraDX.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// AssetRegistryController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AssetRegistryController : ControllerBase
    {
        
        private IAssetRegistryStorage _assetRegistryStorage;
        
        /// <summary>
        /// AssetRegistryController constructor.
        /// </summary>
        public AssetRegistryController(IAssetRegistryStorage assetRegistryStorage)
        {
            _assetRegistryStorage = assetRegistryStorage;
        }
        
        /// <summary>
        /// >> Assets
        ///  Details of an asset.
        /// </summary>
        [HttpGet("Assets")]
        [ProducesResponseType(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.pallet_asset_registry.types.AssetDetails), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "AssetsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAssets(string key)
        {
            return this.Ok(_assetRegistryStorage.GetAssets(key));
        }
        
        /// <summary>
        /// >> NextAssetId
        ///  Next available asset id. This is sequential id assigned for each new registered asset.
        /// </summary>
        [HttpGet("NextAssetId")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "NextAssetIdParams")]
        public IActionResult GetNextAssetId()
        {
            return this.Ok(_assetRegistryStorage.GetNextAssetId());
        }
        
        /// <summary>
        /// >> AssetIds
        ///  Mapping between asset name and asset id.
        /// </summary>
        [HttpGet("AssetIds")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "AssetIdsParams", typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4))]
        public IActionResult GetAssetIds(string key)
        {
            return this.Ok(_assetRegistryStorage.GetAssetIds(key));
        }
        
        /// <summary>
        /// >> AssetLocations
        ///  Native location of an asset.
        /// </summary>
        [HttpGet("AssetLocations")]
        [ProducesResponseType(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.hydradx_runtime.xcm.AssetLocation), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "AssetLocationsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAssetLocations(string key)
        {
            return this.Ok(_assetRegistryStorage.GetAssetLocations(key));
        }
        
        /// <summary>
        /// >> BannedAssets
        ///  Non-native assets which transfer is banned.
        /// </summary>
        [HttpGet("BannedAssets")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "BannedAssetsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetBannedAssets(string key)
        {
            return this.Ok(_assetRegistryStorage.GetBannedAssets(key));
        }
        
        /// <summary>
        /// >> LocationAssets
        ///  Local asset for native location.
        /// </summary>
        [HttpGet("LocationAssets")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "LocationAssetsParams", typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Model.hydradx_runtime.xcm.AssetLocation))]
        public IActionResult GetLocationAssets(string key)
        {
            return this.Ok(_assetRegistryStorage.GetLocationAssets(key));
        }
        
        /// <summary>
        /// >> ExistentialDepositCounter
        ///  Number of accounts that paid existential deposits for insufficient assets.
        ///  This storage is used by `SufficiencyCheck`.
        /// </summary>
        [HttpGet("ExistentialDepositCounter")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.HydraDX.NET.NetApiExt.Generated.Storage.AssetRegistryStorage), "ExistentialDepositCounterParams")]
        public IActionResult GetExistentialDepositCounter()
        {
            return this.Ok(_assetRegistryStorage.GetExistentialDepositCounter());
        }
    }
}