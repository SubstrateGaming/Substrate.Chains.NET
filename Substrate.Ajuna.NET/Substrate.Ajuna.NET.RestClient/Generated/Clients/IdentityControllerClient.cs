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
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   
   public sealed class IdentityControllerClient : BaseClient, IIdentityControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IdentityControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Registration> GetIdentityOf(AccountId32 key)
      {
         return await SendRequestAsync<Registration>(_httpClient, "identity/identityof", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SubscribeIdentityOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.IdentityOf", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<BaseTuple<AccountId32, EnumData>> GetSuperOf(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<AccountId32, EnumData>>(_httpClient, "identity/superof", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SubscribeSuperOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SuperOf", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<BaseTuple<U128, BoundedVecT7>> GetSubsOf(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<U128, BoundedVecT7>>(_httpClient, "identity/subsof", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SubscribeSubsOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SubsOf", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<BoundedVecT8> GetRegistrars()
      {
         return await SendRequestAsync<BoundedVecT8>(_httpClient, "identity/registrars");
      }
      public async Task<bool> SubscribeRegistrars()
      {
         return await _subscriptionClient.SubscribeAsync("Identity.Registrars");
      }
   }
}