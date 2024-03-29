//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.parachain_staking.types;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.parachain_staking.set;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.parachain_staking.inflation;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map;
   using Substrate.Moonsama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ParachainStakingControllerMockupClient : MockupBaseClient, IParachainStakingControllerMockupClient
   {
      private HttpClient _httpClient;
      public ParachainStakingControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetMaxSelectedCandidates(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/MaxSelectedCandidates", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.MaxSelectedCandidatesParams());
      }
      public async Task<bool> SetRound(RoundInfo value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/Round", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.RoundParams());
      }
      public async Task<bool> SetLastDelegation(DelegationCounter value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/LastDelegation", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.LastDelegationParams(key));
      }
      public async Task<bool> SetDelegatorState(Stake value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/DelegatorState", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.DelegatorStateParams(key));
      }
      public async Task<bool> SetCandidatePool(Candidate value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/CandidatePool", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.CandidatePoolParams(key));
      }
      public async Task<bool> SetCounterForCandidatePool(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/CounterForCandidatePool", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.CounterForCandidatePoolParams());
      }
      public async Task<bool> SetTotalCollatorStake(TotalStake value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/TotalCollatorStake", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.TotalCollatorStakeParams());
      }
      public async Task<bool> SetTopCandidates(OrderedSetT2 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/TopCandidates", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.TopCandidatesParams());
      }
      public async Task<bool> SetInflationConfig(InflationInfo value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/InflationConfig", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.InflationConfigParams());
      }
      public async Task<bool> SetUnstaking(BoundedBTreeMap value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/Unstaking", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.UnstakingParams(key));
      }
      public async Task<bool> SetMaxCollatorCandidateStake(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/MaxCollatorCandidateStake", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.MaxCollatorCandidateStakeParams());
      }
      public async Task<bool> SetLastRewardReduction(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/LastRewardReduction", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.LastRewardReductionParams());
      }
      public async Task<bool> SetBlocksAuthored(U32 value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/BlocksAuthored", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.BlocksAuthoredParams(key));
      }
      public async Task<bool> SetBlocksRewarded(U32 value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/BlocksRewarded", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.BlocksRewardedParams(key));
      }
      public async Task<bool> SetRewards(U128 value, Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/Rewards", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.RewardsParams(key));
      }
      public async Task<bool> SetForceNewRound(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParachainStaking/ForceNewRound", value.Encode(), Substrate.Moonsama.NET.NetApiExt.Generated.Storage.ParachainStakingStorage.ForceNewRoundParams());
      }
   }
}
