//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotAssetHub.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_assets.types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotAssetHub.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class PoolAssetsControllerMockupClient : MockupBaseClient, IPoolAssetsControllerMockupClient
   {
      private HttpClient _httpClient;
      public PoolAssetsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAsset(AssetDetails value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "PoolAssets/Asset", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.PoolAssetsStorage.AssetParams(key));
      }
      public async Task<bool> SetAccount(AssetAccount value, Substrate.NetApi.Model.Types.Base.BaseTuple<U32, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "PoolAssets/Account", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.PoolAssetsStorage.AccountParams(key));
      }
      public async Task<bool> SetApprovals(Approval value, Substrate.NetApi.Model.Types.Base.BaseTuple<U32, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "PoolAssets/Approvals", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.PoolAssetsStorage.ApprovalsParams(key));
      }
      public async Task<bool> SetMetadata(AssetMetadataT3 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "PoolAssets/Metadata", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.PoolAssetsStorage.MetadataParams(key));
      }
      public async Task<bool> SetNextAssetId(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "PoolAssets/NextAssetId", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.PoolAssetsStorage.NextAssetIdParams());
      }
   }
}
