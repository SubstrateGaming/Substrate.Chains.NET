//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.assigner_on_demand.types;
   using Substrate.Kusama.NET.NetApiExt.Generated.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class OnDemandAssignmentProviderControllerMockupClient : MockupBaseClient, IOnDemandAssignmentProviderControllerMockupClient
   {
      private HttpClient _httpClient;
      public OnDemandAssignmentProviderControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetParaIdAffinity(CoreAffinityCount value, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "OnDemandAssignmentProvider/ParaIdAffinity", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.ParaIdAffinityParams(key));
      }
      public async Task<bool> SetQueueStatus(QueueStatusType value)
      {
         return await SendMockupRequestAsync(_httpClient, "OnDemandAssignmentProvider/QueueStatus", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.QueueStatusParams());
      }
      public async Task<bool> SetFreeEntries(BinaryHeapT2 value)
      {
         return await SendMockupRequestAsync(_httpClient, "OnDemandAssignmentProvider/FreeEntries", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.FreeEntriesParams());
      }
      public async Task<bool> SetAffinityEntries(BinaryHeapT2 value, Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7.CoreIndex key)
      {
         return await SendMockupRequestAsync(_httpClient, "OnDemandAssignmentProvider/AffinityEntries", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.AffinityEntriesParams(key));
      }
      public async Task<bool> SetRevenue(BoundedVecT44 value)
      {
         return await SendMockupRequestAsync(_httpClient, "OnDemandAssignmentProvider/Revenue", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.OnDemandAssignmentProviderStorage.RevenueParams());
      }
   }
}
