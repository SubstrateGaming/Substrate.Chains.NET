//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_preimage;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   
   public sealed class PreimageControllerClient : BaseClient, IPreimageControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public PreimageControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<EnumRequestStatus> GetStatusFor(Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<EnumRequestStatus>(_httpClient, "preimage/statusfor", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PreimageStorage.StatusForParams(key));
      }
      public async Task<bool> SubscribeStatusFor(Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Preimage.StatusFor", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PreimageStorage.StatusForParams(key));
      }
      public async Task<BoundedVecT13> GetPreimageFor(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await SendRequestAsync<BoundedVecT13>(_httpClient, "preimage/preimagefor", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PreimageStorage.PreimageForParams(key));
      }
      public async Task<bool> SubscribePreimageFor(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Preimage.PreimageFor", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PreimageStorage.PreimageForParams(key));
      }
   }
}