//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Bajun.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_ajuna_affiliates.traits;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Bajun.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AffiliatesAAAControllerMockupClient : MockupBaseClient, IAffiliatesAAAControllerMockupClient
   {
      private HttpClient _httpClient;
      public AffiliatesAAAControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAffiliatees(BoundedVecT53 value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AffiliatesAAA/Affiliatees", value.Encode(), Substrate.Bajun.NET.NetApiExt.Generated.Storage.AffiliatesAAAStorage.AffiliateesParams(key));
      }
      public async Task<bool> SetAffiliators(AffiliatorState value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AffiliatesAAA/Affiliators", value.Encode(), Substrate.Bajun.NET.NetApiExt.Generated.Storage.AffiliatesAAAStorage.AffiliatorsParams(key));
      }
      public async Task<bool> SetAffiliateRules(BoundedVecT22 value, Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.affiliates.EnumAffiliateMethods key)
      {
         return await SendMockupRequestAsync(_httpClient, "AffiliatesAAA/AffiliateRules", value.Encode(), Substrate.Bajun.NET.NetApiExt.Generated.Storage.AffiliatesAAAStorage.AffiliateRulesParams(key));
      }
      public async Task<bool> SetNextAffiliateId(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AffiliatesAAA/NextAffiliateId", value.Encode(), Substrate.Bajun.NET.NetApiExt.Generated.Storage.AffiliatesAAAStorage.NextAffiliateIdParams());
      }
      public async Task<bool> SetAffiliateIdMapping(AccountId32 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AffiliatesAAA/AffiliateIdMapping", value.Encode(), Substrate.Bajun.NET.NetApiExt.Generated.Storage.AffiliatesAAAStorage.AffiliateIdMappingParams(key));
      }
   }
}