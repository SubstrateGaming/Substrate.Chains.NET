//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Polkadot.NET.RestClient.Generated.Interfaces;
   
   public sealed class TechnicalMembershipControllerClient : BaseClient, ITechnicalMembershipControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TechnicalMembershipControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT16> GetMembers()
      {
         return await SendRequestAsync<BoundedVecT16>(_httpClient, "technicalmembership/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("TechnicalMembership.Members");
      }
      public async Task<AccountId32> GetPrime()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "technicalmembership/prime");
      }
      public async Task<bool> SubscribePrime()
      {
         return await _subscriptionClient.SubscribeAsync("TechnicalMembership.Prime");
      }
   }
}
