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
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   
   public sealed class SchedulerControllerClient : BaseClient, ISchedulerControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SchedulerControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetIncompleteSince()
      {
         return await SendRequestAsync<U32>(_httpClient, "scheduler/incompletesince");
      }
      public async Task<bool> SubscribeIncompleteSince()
      {
         return await _subscriptionClient.SubscribeAsync("Scheduler.IncompleteSince");
      }
      public async Task<BoundedVecT11> GetAgenda(U32 key)
      {
         return await SendRequestAsync<BoundedVecT11>(_httpClient, "scheduler/agenda", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.SchedulerStorage.AgendaParams(key));
      }
      public async Task<bool> SubscribeAgenda(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Scheduler.Agenda", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.SchedulerStorage.AgendaParams(key));
      }
      public async Task<BaseTuple<U32, U32>> GetLookup(Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
      {
         return await SendRequestAsync<BaseTuple<U32, U32>>(_httpClient, "scheduler/lookup", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.SchedulerStorage.LookupParams(key));
      }
      public async Task<bool> SubscribeLookup(Substrate.Ajuna.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
      {
         return await _subscriptionClient.SubscribeAsync("Scheduler.Lookup", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.SchedulerStorage.LookupParams(key));
      }
   }
}