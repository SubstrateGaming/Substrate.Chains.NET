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
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class SchedulerControllerMockupClient : MockupBaseClient, ISchedulerControllerMockupClient
   {
      private HttpClient _httpClient;
      public SchedulerControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetIncompleteSince(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Scheduler/IncompleteSince", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.SchedulerStorage.IncompleteSinceParams());
      }
      public async Task<bool> SetAgenda(BoundedVecT29 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Scheduler/Agenda", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.SchedulerStorage.AgendaParams(key));
      }
      public async Task<bool> SetLookup(BaseTuple<U32, U32> value, Substrate.Kusama.NET.NetApiExt.Generated.Types.Base.Arr32U8 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Scheduler/Lookup", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.SchedulerStorage.LookupParams(key));
      }
   }
}