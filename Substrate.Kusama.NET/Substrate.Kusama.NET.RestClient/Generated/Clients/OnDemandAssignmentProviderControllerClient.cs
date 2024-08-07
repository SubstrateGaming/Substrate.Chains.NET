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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand;
   using Substrate.Kusama.NET.RestClient.Generated.Interfaces;
   
   public sealed class OnDemandAssignmentProviderControllerClient : BaseClient, IOnDemandAssignmentProviderControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public OnDemandAssignmentProviderControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<FixedU128> GetSpotTraffic()
      {
         return await SendRequestAsync<FixedU128>(_httpClient, "ondemandassignmentprovider/spottraffic");
      }
      public async Task<bool> SubscribeSpotTraffic()
      {
         return await _subscriptionClient.SubscribeAsync("OnDemandAssignmentProvider.SpotTraffic");
      }
      public async Task<BaseVec<EnqueuedOrder>> GetOnDemandQueue()
      {
         return await SendRequestAsync<BaseVec<EnqueuedOrder>>(_httpClient, "ondemandassignmentprovider/ondemandqueue");
      }
      public async Task<bool> SubscribeOnDemandQueue()
      {
         return await _subscriptionClient.SubscribeAsync("OnDemandAssignmentProvider.OnDemandQueue");
      }
      public async Task<CoreAffinityCount> GetParaIdAffinity(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key)
      {
         return await SendRequestAsync<CoreAffinityCount>(_httpClient, "ondemandassignmentprovider/paraidaffinity", Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.ParaIdAffinityParams(key));
      }
      public async Task<bool> SubscribeParaIdAffinity(Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key)
      {
         return await _subscriptionClient.SubscribeAsync("OnDemandAssignmentProvider.ParaIdAffinity", Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.ParaIdAffinityParams(key));
      }
   }
}
