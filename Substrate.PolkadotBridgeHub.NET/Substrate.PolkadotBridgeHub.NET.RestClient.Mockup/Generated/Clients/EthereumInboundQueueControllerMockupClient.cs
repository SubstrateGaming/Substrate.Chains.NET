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
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class EthereumInboundQueueControllerMockupClient : MockupBaseClient, IEthereumInboundQueueControllerMockupClient
   {
      private HttpClient _httpClient;
      public EthereumInboundQueueControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetNonce(U64 value, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.ChannelId key)
      {
         return await SendMockupRequestAsync(_httpClient, "EthereumInboundQueue/Nonce", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumInboundQueueStorage.NonceParams(key));
      }
      public async Task<bool> SetOperatingMode(EnumBasicOperatingMode value)
      {
         return await SendMockupRequestAsync(_httpClient, "EthereumInboundQueue/OperatingMode", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.EthereumInboundQueueStorage.OperatingModeParams());
      }
   }
}