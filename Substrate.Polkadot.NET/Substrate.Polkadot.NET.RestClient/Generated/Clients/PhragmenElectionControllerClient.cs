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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_elections_phragmen;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Polkadot.NET.RestClient.Generated.Interfaces;
   
   public sealed class PhragmenElectionControllerClient : BaseClient, IPhragmenElectionControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public PhragmenElectionControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<SeatHolder>> GetMembers()
      {
         return await SendRequestAsync<BaseVec<SeatHolder>>(_httpClient, "phragmenelection/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("PhragmenElection.Members");
      }
      public async Task<BaseVec<SeatHolder>> GetRunnersUp()
      {
         return await SendRequestAsync<BaseVec<SeatHolder>>(_httpClient, "phragmenelection/runnersup");
      }
      public async Task<bool> SubscribeRunnersUp()
      {
         return await _subscriptionClient.SubscribeAsync("PhragmenElection.RunnersUp");
      }
      public async Task<BaseVec<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U128>>> GetCandidates()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U128>>>(_httpClient, "phragmenelection/candidates");
      }
      public async Task<bool> SubscribeCandidates()
      {
         return await _subscriptionClient.SubscribeAsync("PhragmenElection.Candidates");
      }
      public async Task<U32> GetElectionRounds()
      {
         return await SendRequestAsync<U32>(_httpClient, "phragmenelection/electionrounds");
      }
      public async Task<bool> SubscribeElectionRounds()
      {
         return await _subscriptionClient.SubscribeAsync("PhragmenElection.ElectionRounds");
      }
      public async Task<Voter> GetVoting(Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<Voter>(_httpClient, "phragmenelection/voting", Substrate.Polkadot.NET.NetApiExt.Generated.Storage.PhragmenElectionStorage.VotingParams(key));
      }
      public async Task<bool> SubscribeVoting(Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("PhragmenElection.Voting", Substrate.Polkadot.NET.NetApiExt.Generated.Storage.PhragmenElectionStorage.VotingParams(key));
      }
   }
}
