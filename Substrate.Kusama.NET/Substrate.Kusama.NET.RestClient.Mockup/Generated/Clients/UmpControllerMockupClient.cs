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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class UmpControllerMockupClient : MockupBaseClient, IUmpControllerMockupClient
   {
      private HttpClient _httpClient;
      public UmpControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRelayDispatchQueues(BaseVec<BaseVec<U8>> value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/RelayDispatchQueues", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.RelayDispatchQueuesParams(key));
      }
      public async Task<bool> SetRelayDispatchQueueSize(BaseTuple<U32, U32> value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/RelayDispatchQueueSize", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.RelayDispatchQueueSizeParams(key));
      }
      public async Task<bool> SetNeedsDispatch(BaseVec<Id> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/NeedsDispatch", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.NeedsDispatchParams());
      }
      public async Task<bool> SetNextDispatchRoundStartWith(Id value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/NextDispatchRoundStartWith", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.NextDispatchRoundStartWithParams());
      }
      public async Task<bool> SetOverweight(BaseTuple<Id, BaseVec<U8>> value, U64 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/Overweight", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.OverweightParams(key));
      }
      public async Task<bool> SetCounterForOverweight(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/CounterForOverweight", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.CounterForOverweightParams());
      }
      public async Task<bool> SetOverweightCount(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ump/OverweightCount", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.UmpStorage.OverweightCountParams());
      }
   }
}
