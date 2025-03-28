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
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_preimage;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Collectives.NET.RestClient.Generated.Interfaces;
   
   public sealed class PreimageControllerClient : BaseClient, IPreimageControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public PreimageControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<EnumOldRequestStatus> GetStatusFor(Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<EnumOldRequestStatus>(_httpClient, "preimage/statusfor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.PreimageStorage.StatusForParams(key));
      }
      public async Task<bool> SubscribeStatusFor(Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Preimage.StatusFor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.PreimageStorage.StatusForParams(key));
      }
      public async Task<EnumRequestStatus> GetRequestStatusFor(Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<EnumRequestStatus>(_httpClient, "preimage/requeststatusfor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.PreimageStorage.RequestStatusForParams(key));
      }
      public async Task<bool> SubscribeRequestStatusFor(Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Preimage.RequestStatusFor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.PreimageStorage.RequestStatusForParams(key));
      }
      public async Task<BoundedVecT28> GetPreimageFor(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await SendRequestAsync<BoundedVecT28>(_httpClient, "preimage/preimagefor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.PreimageStorage.PreimageForParams(key));
      }
      public async Task<bool> SubscribePreimageFor(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Collectives.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Preimage.PreimageFor", Substrate.Collectives.NET.NetApiExt.Generated.Storage.PreimageStorage.PreimageForParams(key));
      }
   }
}
