//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Bajun.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_migrations;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Bajun.NET.RestClient.Generated.Interfaces;
   
   public sealed class MigrationsControllerClient : BaseClient, IMigrationsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public MigrationsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<EnumMigrationCursor> GetCursor()
      {
         return await SendRequestAsync<EnumMigrationCursor>(_httpClient, "migrations/cursor");
      }
      public async Task<bool> SubscribeCursor()
      {
         return await _subscriptionClient.SubscribeAsync("Migrations.Cursor");
      }
      public async Task<BaseTuple> GetHistoric(Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT17 key)
      {
         return await SendRequestAsync<BaseTuple>(_httpClient, "migrations/historic", Substrate.Bajun.NET.NetApiExt.Generated.Storage.MigrationsStorage.HistoricParams(key));
      }
      public async Task<bool> SubscribeHistoric(Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT17 key)
      {
         return await _subscriptionClient.SubscribeAsync("Migrations.Historic", Substrate.Bajun.NET.NetApiExt.Generated.Storage.MigrationsStorage.HistoricParams(key));
      }
   }
}