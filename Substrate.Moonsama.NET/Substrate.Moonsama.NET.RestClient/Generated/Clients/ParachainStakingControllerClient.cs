//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.parachain_staking.types;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.parachain_staking.set;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.parachain_staking.inflation;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map;
   using Substrate.Moonsama.NET.RestClient.Generated.Interfaces;
   
   public sealed class ParachainStakingControllerClient : BaseClient, IParachainStakingControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ParachainStakingControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetMaxSelectedCandidates()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainstaking/maxselectedcandidates");
      }
      public async Task<bool> SubscribeMaxSelectedCandidates()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.MaxSelectedCandidates");
      }
      public async Task<RoundInfo> GetRound()
      {
         return await SendRequestAsync<RoundInfo>(_httpClient, "parachainstaking/round");
      }
      public async Task<bool> SubscribeRound()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.Round");
      }
      public async Task<DelegationCounter> GetLastDelegation(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<DelegationCounter>(_httpClient, "parachainstaking/lastdelegation", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.LastDelegationParams(key));
      }
      public async Task<bool> SubscribeLastDelegation(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.LastDelegation", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.LastDelegationParams(key));
      }
      public async Task<Stake> GetDelegatorState(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<Stake>(_httpClient, "parachainstaking/delegatorstate", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.DelegatorStateParams(key));
      }
      public async Task<bool> SubscribeDelegatorState(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.DelegatorState", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.DelegatorStateParams(key));
      }
      public async Task<Candidate> GetCandidatePool(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<Candidate>(_httpClient, "parachainstaking/candidatepool", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.CandidatePoolParams(key));
      }
      public async Task<bool> SubscribeCandidatePool(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.CandidatePool", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.CandidatePoolParams(key));
      }
      public async Task<U32> GetCounterForCandidatePool()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainstaking/counterforcandidatepool");
      }
      public async Task<bool> SubscribeCounterForCandidatePool()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.CounterForCandidatePool");
      }
      public async Task<TotalStake> GetTotalCollatorStake()
      {
         return await SendRequestAsync<TotalStake>(_httpClient, "parachainstaking/totalcollatorstake");
      }
      public async Task<bool> SubscribeTotalCollatorStake()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.TotalCollatorStake");
      }
      public async Task<OrderedSetT2> GetTopCandidates()
      {
         return await SendRequestAsync<OrderedSetT2>(_httpClient, "parachainstaking/topcandidates");
      }
      public async Task<bool> SubscribeTopCandidates()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.TopCandidates");
      }
      public async Task<InflationInfo> GetInflationConfig()
      {
         return await SendRequestAsync<InflationInfo>(_httpClient, "parachainstaking/inflationconfig");
      }
      public async Task<bool> SubscribeInflationConfig()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.InflationConfig");
      }
      public async Task<BoundedBTreeMap> GetUnstaking(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<BoundedBTreeMap>(_httpClient, "parachainstaking/unstaking", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.UnstakingParams(key));
      }
      public async Task<bool> SubscribeUnstaking(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.Unstaking", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.UnstakingParams(key));
      }
      public async Task<U128> GetMaxCollatorCandidateStake()
      {
         return await SendRequestAsync<U128>(_httpClient, "parachainstaking/maxcollatorcandidatestake");
      }
      public async Task<bool> SubscribeMaxCollatorCandidateStake()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.MaxCollatorCandidateStake");
      }
      public async Task<U32> GetLastRewardReduction()
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainstaking/lastrewardreduction");
      }
      public async Task<bool> SubscribeLastRewardReduction()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.LastRewardReduction");
      }
      public async Task<U32> GetBlocksAuthored(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainstaking/blocksauthored", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.BlocksAuthoredParams(key));
      }
      public async Task<bool> SubscribeBlocksAuthored(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.BlocksAuthored", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.BlocksAuthoredParams(key));
      }
      public async Task<U32> GetBlocksRewarded(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "parachainstaking/blocksrewarded", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.BlocksRewardedParams(key));
      }
      public async Task<bool> SubscribeBlocksRewarded(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.BlocksRewarded", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.BlocksRewardedParams(key));
      }
      public async Task<U128> GetRewards(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "parachainstaking/rewards", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.RewardsParams(key));
      }
      public async Task<bool> SubscribeRewards(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.Rewards", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.RewardsParams(key));
      }
      public async Task<Bool> GetForceNewRound()
      {
         return await SendRequestAsync<Bool>(_httpClient, "parachainstaking/forcenewround");
      }
      public async Task<bool> SubscribeForceNewRound()
      {
         return await _subscriptionClient.SubscribeAsync("ParachainStaking.ForceNewRound");
      }
   }
}
