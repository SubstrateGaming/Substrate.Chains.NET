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
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_asset_conversion.types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotAssetHub.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AssetConversionControllerMockupClient : MockupBaseClient, IAssetConversionControllerMockupClient
   {
      private HttpClient _httpClient;
      public AssetConversionControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetPools(PoolInfo value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.staging_xcm.v3.multilocation.MultiLocation> key)
      {
         return await SendMockupRequestAsync(_httpClient, "AssetConversion/Pools", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.AssetConversionStorage.PoolsParams(key));
      }
      public async Task<bool> SetNextPoolAssetId(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AssetConversion/NextPoolAssetId", value.Encode(), Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.AssetConversionStorage.NextPoolAssetIdParams());
      }
   }
}