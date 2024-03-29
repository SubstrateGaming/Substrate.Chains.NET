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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_core_primitives;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class HrmpControllerMockupClient : MockupBaseClient, IHrmpControllerMockupClient
   {
      private HttpClient _httpClient;
      public HrmpControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetHrmpOpenChannelRequests(HrmpOpenChannelRequest value, HrmpChannelId key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpOpenChannelRequests", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpOpenChannelRequestsParams(key));
      }
      public async Task<bool> SetHrmpOpenChannelRequestsList(BaseVec<HrmpChannelId> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpOpenChannelRequestsList", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpOpenChannelRequestsListParams());
      }
      public async Task<bool> SetHrmpOpenChannelRequestCount(U32 value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpOpenChannelRequestCount", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpOpenChannelRequestCountParams(key));
      }
      public async Task<bool> SetHrmpAcceptedChannelRequestCount(U32 value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpAcceptedChannelRequestCount", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpAcceptedChannelRequestCountParams(key));
      }
      public async Task<bool> SetHrmpCloseChannelRequests(BaseTuple value, HrmpChannelId key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpCloseChannelRequests", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpCloseChannelRequestsParams(key));
      }
      public async Task<bool> SetHrmpCloseChannelRequestsList(BaseVec<HrmpChannelId> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpCloseChannelRequestsList", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpCloseChannelRequestsListParams());
      }
      public async Task<bool> SetHrmpWatermarks(U32 value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpWatermarks", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpWatermarksParams(key));
      }
      public async Task<bool> SetHrmpChannels(HrmpChannel value, HrmpChannelId key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpChannels", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpChannelsParams(key));
      }
      public async Task<bool> SetHrmpIngressChannelsIndex(BaseVec<Id> value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpIngressChannelsIndex", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpIngressChannelsIndexParams(key));
      }
      public async Task<bool> SetHrmpEgressChannelsIndex(BaseVec<Id> value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpEgressChannelsIndex", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpEgressChannelsIndexParams(key));
      }
      public async Task<bool> SetHrmpChannelContents(BaseVec<InboundHrmpMessage> value, HrmpChannelId key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpChannelContents", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpChannelContentsParams(key));
      }
      public async Task<bool> SetHrmpChannelDigests(BaseVec<BaseTuple<U32, BaseVec<Id>>> value, Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Hrmp/HrmpChannelDigests", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.HrmpStorage.HrmpChannelDigestsParams(key));
      }
   }
}
