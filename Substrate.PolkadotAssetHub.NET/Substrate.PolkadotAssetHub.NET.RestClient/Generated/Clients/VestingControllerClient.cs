//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotAssetHub.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_vesting;
   using Substrate.PolkadotAssetHub.NET.RestClient.Generated.Interfaces;
   
   public sealed class VestingControllerClient : BaseClient, IVestingControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public VestingControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT11> GetVesting(Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT11>(_httpClient, "vesting/vesting", Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.VestingStorage.VestingParams(key));
      }
      public async Task<bool> SubscribeVesting(Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.Vesting", Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Storage.VestingStorage.VestingParams(key));
      }
      public async Task<EnumReleases> GetStorageVersion()
      {
         return await SendRequestAsync<EnumReleases>(_httpClient, "vesting/storageversion");
      }
      public async Task<bool> SubscribeStorageVersion()
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.StorageVersion");
      }
   }
}
