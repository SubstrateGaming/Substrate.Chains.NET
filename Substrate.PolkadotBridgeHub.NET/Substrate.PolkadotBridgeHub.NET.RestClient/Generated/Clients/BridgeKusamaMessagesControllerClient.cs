//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_messages;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Interfaces;
   
   public sealed class BridgeKusamaMessagesControllerClient : BaseClient, IBridgeKusamaMessagesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BridgeKusamaMessagesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AccountId32> GetPalletOwner()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "bridgekusamamessages/palletowner");
      }
      public async Task<bool> SubscribePalletOwner()
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaMessages.PalletOwner");
      }
      public async Task<EnumMessagesOperatingMode> GetPalletOperatingMode()
      {
         return await SendRequestAsync<EnumMessagesOperatingMode>(_httpClient, "bridgekusamamessages/palletoperatingmode");
      }
      public async Task<bool> SubscribePalletOperatingMode()
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaMessages.PalletOperatingMode");
      }
      public async Task<InboundLaneData> GetInboundLanes(LaneId key)
      {
         return await SendRequestAsync<InboundLaneData>(_httpClient, "bridgekusamamessages/inboundlanes", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.InboundLanesParams(key));
      }
      public async Task<bool> SubscribeInboundLanes(LaneId key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaMessages.InboundLanes", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.InboundLanesParams(key));
      }
      public async Task<OutboundLaneData> GetOutboundLanes(LaneId key)
      {
         return await SendRequestAsync<OutboundLaneData>(_httpClient, "bridgekusamamessages/outboundlanes", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundLanesParams(key));
      }
      public async Task<bool> SubscribeOutboundLanes(LaneId key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaMessages.OutboundLanes", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundLanesParams(key));
      }
      public async Task<Bool> GetOutboundLanesCongestedSignals(LaneId key)
      {
         return await SendRequestAsync<Bool>(_httpClient, "bridgekusamamessages/outboundlanescongestedsignals", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundLanesCongestedSignalsParams(key));
      }
      public async Task<bool> SubscribeOutboundLanesCongestedSignals(LaneId key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaMessages.OutboundLanesCongestedSignals", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundLanesCongestedSignalsParams(key));
      }
      public async Task<BoundedVecT17> GetOutboundMessages(MessageKey key)
      {
         return await SendRequestAsync<BoundedVecT17>(_httpClient, "bridgekusamamessages/outboundmessages", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundMessagesParams(key));
      }
      public async Task<bool> SubscribeOutboundMessages(MessageKey key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaMessages.OutboundMessages", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaMessagesStorage.OutboundMessagesParams(key));
      }
   }
}