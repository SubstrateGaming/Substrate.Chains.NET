//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Collectives.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_treasury;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Collectives.NET.RestClient.Generated.Interfaces;
   
   public sealed class FellowshipTreasuryControllerClient : BaseClient, IFellowshipTreasuryControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public FellowshipTreasuryControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetProposalCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "fellowshiptreasury/proposalcount");
      }
      public async Task<bool> SubscribeProposalCount()
      {
         return await _subscriptionClient.SubscribeAsync("FellowshipTreasury.ProposalCount");
      }
      public async Task<Proposal> GetProposals(U32 key)
      {
         return await SendRequestAsync<Proposal>(_httpClient, "fellowshiptreasury/proposals", Substrate.Collectives.NET.NetApiExt.Generated.Storage.FellowshipTreasuryStorage.ProposalsParams(key));
      }
      public async Task<bool> SubscribeProposals(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("FellowshipTreasury.Proposals", Substrate.Collectives.NET.NetApiExt.Generated.Storage.FellowshipTreasuryStorage.ProposalsParams(key));
      }
      public async Task<U128> GetDeactivated()
      {
         return await SendRequestAsync<U128>(_httpClient, "fellowshiptreasury/deactivated");
      }
      public async Task<bool> SubscribeDeactivated()
      {
         return await _subscriptionClient.SubscribeAsync("FellowshipTreasury.Deactivated");
      }
      public async Task<BoundedVecT35> GetApprovals()
      {
         return await SendRequestAsync<BoundedVecT35>(_httpClient, "fellowshiptreasury/approvals");
      }
      public async Task<bool> SubscribeApprovals()
      {
         return await _subscriptionClient.SubscribeAsync("FellowshipTreasury.Approvals");
      }
      public async Task<U32> GetSpendCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "fellowshiptreasury/spendcount");
      }
      public async Task<bool> SubscribeSpendCount()
      {
         return await _subscriptionClient.SubscribeAsync("FellowshipTreasury.SpendCount");
      }
      public async Task<SpendStatus> GetSpends(U32 key)
      {
         return await SendRequestAsync<SpendStatus>(_httpClient, "fellowshiptreasury/spends", Substrate.Collectives.NET.NetApiExt.Generated.Storage.FellowshipTreasuryStorage.SpendsParams(key));
      }
      public async Task<bool> SubscribeSpends(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("FellowshipTreasury.Spends", Substrate.Collectives.NET.NetApiExt.Generated.Storage.FellowshipTreasuryStorage.SpendsParams(key));
      }
   }
}
