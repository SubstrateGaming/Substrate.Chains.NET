//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.ajuna_runtime;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_collective;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Ajuna.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TechnicalCommitteeControllerMockupClient : MockupBaseClient, ITechnicalCommitteeControllerMockupClient
   {
      private HttpClient _httpClient;
      public TechnicalCommitteeControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposals(BoundedVecT31 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Proposals", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.ProposalsParams());
      }
      public async Task<bool> SetProposalOf(EnumRuntimeCall value, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/ProposalOf", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.ProposalOfParams(key));
      }
      public async Task<bool> SetVoting(Votes value, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Voting", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.VotingParams(key));
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/ProposalCount", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.ProposalCountParams());
      }
      public async Task<bool> SetMembers(BaseVec<AccountId32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Members", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.MembersParams());
      }
      public async Task<bool> SetPrime(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Prime", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.PrimeParams());
      }
   }
}