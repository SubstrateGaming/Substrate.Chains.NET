//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.RestClient.Generated.Interfaces;
   
   public sealed class SocietyControllerClient : BaseClient, ISocietyControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SocietyControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<GroupParams> GetParameters()
      {
         return await SendRequestAsync<GroupParams>(_httpClient, "society/parameters");
      }
      public async Task<bool> SubscribeParameters()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Parameters");
      }
      public async Task<U128> GetPot()
      {
         return await SendRequestAsync<U128>(_httpClient, "society/pot");
      }
      public async Task<bool> SubscribePot()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Pot");
      }
      public async Task<AccountId32> GetFounder()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "society/founder");
      }
      public async Task<bool> SubscribeFounder()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Founder");
      }
      public async Task<AccountId32> GetHead()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "society/head");
      }
      public async Task<bool> SubscribeHead()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Head");
      }
      public async Task<H256> GetRules()
      {
         return await SendRequestAsync<H256>(_httpClient, "society/rules");
      }
      public async Task<bool> SubscribeRules()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Rules");
      }
      public async Task<MemberRecord> GetMembers(AccountId32 key)
      {
         return await SendRequestAsync<MemberRecord>(_httpClient, "society/members", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.MembersParams(key));
      }
      public async Task<bool> SubscribeMembers(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.Members", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.MembersParams(key));
      }
      public async Task<PayoutRecord> GetPayouts(AccountId32 key)
      {
         return await SendRequestAsync<PayoutRecord>(_httpClient, "society/payouts", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.PayoutsParams(key));
      }
      public async Task<bool> SubscribePayouts(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.Payouts", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.PayoutsParams(key));
      }
      public async Task<U32> GetMemberCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "society/membercount");
      }
      public async Task<bool> SubscribeMemberCount()
      {
         return await _subscriptionClient.SubscribeAsync("Society.MemberCount");
      }
      public async Task<AccountId32> GetMemberByIndex(U32 key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "society/memberbyindex", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.MemberByIndexParams(key));
      }
      public async Task<bool> SubscribeMemberByIndex(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.MemberByIndex", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.MemberByIndexParams(key));
      }
      public async Task<MemberRecord> GetSuspendedMembers(AccountId32 key)
      {
         return await SendRequestAsync<MemberRecord>(_httpClient, "society/suspendedmembers", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.SuspendedMembersParams(key));
      }
      public async Task<bool> SubscribeSuspendedMembers(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.SuspendedMembers", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.SuspendedMembersParams(key));
      }
      public async Task<U32> GetRoundCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "society/roundcount");
      }
      public async Task<bool> SubscribeRoundCount()
      {
         return await _subscriptionClient.SubscribeAsync("Society.RoundCount");
      }
      public async Task<BoundedVecT25> GetBids()
      {
         return await SendRequestAsync<BoundedVecT25>(_httpClient, "society/bids");
      }
      public async Task<bool> SubscribeBids()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Bids");
      }
      public async Task<Candidacy> GetCandidates(AccountId32 key)
      {
         return await SendRequestAsync<Candidacy>(_httpClient, "society/candidates", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.CandidatesParams(key));
      }
      public async Task<bool> SubscribeCandidates(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.Candidates", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.CandidatesParams(key));
      }
      public async Task<AccountId32> GetSkeptic()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "society/skeptic");
      }
      public async Task<bool> SubscribeSkeptic()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Skeptic");
      }
      public async Task<Vote> GetVotes(BaseTuple<AccountId32, AccountId32> key)
      {
         return await SendRequestAsync<Vote>(_httpClient, "society/votes", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.VotesParams(key));
      }
      public async Task<bool> SubscribeVotes(BaseTuple<AccountId32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.Votes", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.VotesParams(key));
      }
      public async Task<BoundedVecT26> GetVoteClearCursor(AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT26>(_httpClient, "society/voteclearcursor", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.VoteClearCursorParams(key));
      }
      public async Task<bool> SubscribeVoteClearCursor(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.VoteClearCursor", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.VoteClearCursorParams(key));
      }
      public async Task<IntakeRecord> GetNextHead()
      {
         return await SendRequestAsync<IntakeRecord>(_httpClient, "society/nexthead");
      }
      public async Task<bool> SubscribeNextHead()
      {
         return await _subscriptionClient.SubscribeAsync("Society.NextHead");
      }
      public async Task<U32> GetChallengeRoundCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "society/challengeroundcount");
      }
      public async Task<bool> SubscribeChallengeRoundCount()
      {
         return await _subscriptionClient.SubscribeAsync("Society.ChallengeRoundCount");
      }
      public async Task<BaseTuple<AccountId32, AccountId32, Tally>> GetDefending()
      {
         return await SendRequestAsync<BaseTuple<AccountId32, AccountId32, Tally>>(_httpClient, "society/defending");
      }
      public async Task<bool> SubscribeDefending()
      {
         return await _subscriptionClient.SubscribeAsync("Society.Defending");
      }
      public async Task<Vote> GetDefenderVotes(BaseTuple<U32, AccountId32> key)
      {
         return await SendRequestAsync<Vote>(_httpClient, "society/defendervotes", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.DefenderVotesParams(key));
      }
      public async Task<bool> SubscribeDefenderVotes(BaseTuple<U32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Society.DefenderVotes", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SocietyStorage.DefenderVotesParams(key));
      }
   }
}
