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
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_referenda.types;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Collectives.NET.RestClient.Generated.Interfaces;
   
   public sealed class AmbassadorReferendaControllerClient : BaseClient, IAmbassadorReferendaControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AmbassadorReferendaControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetReferendumCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "ambassadorreferenda/referendumcount");
      }
      public async Task<bool> SubscribeReferendumCount()
      {
         return await _subscriptionClient.SubscribeAsync("AmbassadorReferenda.ReferendumCount");
      }
      public async Task<EnumReferendumInfo> GetReferendumInfoFor(U32 key)
      {
         return await SendRequestAsync<EnumReferendumInfo>(_httpClient, "ambassadorreferenda/referenduminfofor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.ReferendumInfoForParams(key));
      }
      public async Task<bool> SubscribeReferendumInfoFor(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("AmbassadorReferenda.ReferendumInfoFor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.ReferendumInfoForParams(key));
      }
      public async Task<BoundedVecT37> GetTrackQueue(U16 key)
      {
         return await SendRequestAsync<BoundedVecT37>(_httpClient, "ambassadorreferenda/trackqueue", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.TrackQueueParams(key));
      }
      public async Task<bool> SubscribeTrackQueue(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("AmbassadorReferenda.TrackQueue", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.TrackQueueParams(key));
      }
      public async Task<U32> GetDecidingCount(U16 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "ambassadorreferenda/decidingcount", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.DecidingCountParams(key));
      }
      public async Task<bool> SubscribeDecidingCount(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("AmbassadorReferenda.DecidingCount", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.DecidingCountParams(key));
      }
      public async Task<H256> GetMetadataOf(U32 key)
      {
         return await SendRequestAsync<H256>(_httpClient, "ambassadorreferenda/metadataof", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.MetadataOfParams(key));
      }
      public async Task<bool> SubscribeMetadataOf(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("AmbassadorReferenda.MetadataOf", Substrate.Collectives.NET.NetApiExt.Generated.Storage.AmbassadorReferendaStorage.MetadataOfParams(key));
      }
   }
}
