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
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BridgeKusamaMessagesControllerMockupClient : MockupBaseClient, IBridgeKusamaMessagesControllerMockupClient
   {
      private HttpClient _httpClient;
      public BridgeKusamaMessagesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetPalletOwner(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "BridgeKusamaMessages/PalletOwner", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.PalletOwnerParams());
      }
      public async Task<bool> SetPalletOperatingMode(EnumMessagesOperatingMode value)
      {
         return await SendMockupRequestAsync(_httpClient, "BridgeKusamaMessages/PalletOperatingMode", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.PalletOperatingModeParams());
      }
      public async Task<bool> SetInboundLanes(InboundLaneData value, LaneId key)
      {
         return await SendMockupRequestAsync(_httpClient, "BridgeKusamaMessages/InboundLanes", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.InboundLanesParams(key));
      }
      public async Task<bool> SetOutboundLanes(OutboundLaneData value, LaneId key)
      {
         return await SendMockupRequestAsync(_httpClient, "BridgeKusamaMessages/OutboundLanes", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundLanesParams(key));
      }
      public async Task<bool> SetOutboundLanesCongestedSignals(Bool value, LaneId key)
      {
         return await SendMockupRequestAsync(_httpClient, "BridgeKusamaMessages/OutboundLanesCongestedSignals", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundLanesCongestedSignalsParams(key));
      }
      public async Task<bool> SetOutboundMessages(BoundedVecT17 value, MessageKey key)
      {
         return await SendMockupRequestAsync(_httpClient, "BridgeKusamaMessages/OutboundMessages", value.Encode(), Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundMessagesParams(key));
      }
   }
}