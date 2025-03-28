//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   
   public sealed class VestingControllerClient : BaseClient, IVestingControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public VestingControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT33> GetVestingSchedules(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT33>(_httpClient, "vesting/vestingschedules", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.VestingStorage.VestingSchedulesParams(key));
      }
      public async Task<bool> SubscribeVestingSchedules(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.VestingSchedules", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.VestingStorage.VestingSchedulesParams(key));
      }
   }
}
