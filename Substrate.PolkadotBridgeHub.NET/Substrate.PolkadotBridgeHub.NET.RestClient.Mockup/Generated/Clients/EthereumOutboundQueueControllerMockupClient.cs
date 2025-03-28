//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotBridgeHub.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_pallet_outbound_queue.types;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class EthereumOutboundQueueControllerMockupClient : MockupBaseClient, IEthereumOutboundQueueControllerMockupClient
   {
      private HttpClient _httpClient;
      public EthereumOutboundQueueControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetMessages(BaseVec<CommittedMessage> value)
      {
         return await SendMockupRequestAsync(_httpClient, "EthereumOutboundQueue/Messages", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage.MessagesParams());
      }
      public async Task<bool> SetMessageLeaves(BaseVec<H256> value)
      {
         return await SendMockupRequestAsync(_httpClient, "EthereumOutboundQueue/MessageLeaves", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage.MessageLeavesParams());
      }
      public async Task<bool> SetNonce(U64 value, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.ChannelId key)
      {
         return await SendMockupRequestAsync(_httpClient, "EthereumOutboundQueue/Nonce", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage.NonceParams(key));
      }
      public async Task<bool> SetOperatingMode(EnumBasicOperatingMode value)
      {
         return await SendMockupRequestAsync(_httpClient, "EthereumOutboundQueue/OperatingMode", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumOutboundQueueStorage.OperatingModeParams());
      }
   }
}
