//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Interfaces;
   
   public sealed class CollatorSelectionControllerClient : BaseClient, ICollatorSelectionControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public CollatorSelectionControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT7> GetInvulnerables()
      {
         return await SendRequestAsync<BoundedVecT7>(_httpClient, "collatorselection/invulnerables");
      }
      public async Task<bool> SubscribeInvulnerables()
      {
         return await _subscriptionClient.SubscribeAsync("CollatorSelection.Invulnerables");
      }
      public async Task<BoundedVecT8> GetCandidateList()
      {
         return await SendRequestAsync<BoundedVecT8>(_httpClient, "collatorselection/candidatelist");
      }
      public async Task<bool> SubscribeCandidateList()
      {
         return await _subscriptionClient.SubscribeAsync("CollatorSelection.CandidateList");
      }
      public async Task<U32> GetLastAuthoredBlock(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "collatorselection/lastauthoredblock", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.LastAuthoredBlockParams(key));
      }
      public async Task<bool> SubscribeLastAuthoredBlock(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("CollatorSelection.LastAuthoredBlock", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.CollatorSelectionStorage.LastAuthoredBlockParams(key));
      }
      public async Task<U32> GetDesiredCandidates()
      {
         return await SendRequestAsync<U32>(_httpClient, "collatorselection/desiredcandidates");
      }
      public async Task<bool> SubscribeDesiredCandidates()
      {
         return await _subscriptionClient.SubscribeAsync("CollatorSelection.DesiredCandidates");
      }
      public async Task<U128> GetCandidacyBond()
      {
         return await SendRequestAsync<U128>(_httpClient, "collatorselection/candidacybond");
      }
      public async Task<bool> SubscribeCandidacyBond()
      {
         return await _subscriptionClient.SubscribeAsync("CollatorSelection.CandidacyBond");
      }
   }
}
