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
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_runtime;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_parachains;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Interfaces;
   
   public sealed class BridgeKusamaParachainsControllerClient : BaseClient, IBridgeKusamaParachainsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BridgeKusamaParachainsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AccountId32> GetPalletOwner()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "bridgekusamaparachains/palletowner");
      }
      public async Task<bool> SubscribePalletOwner()
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaParachains.PalletOwner");
      }
      public async Task<EnumBasicOperatingMode> GetPalletOperatingMode()
      {
         return await SendRequestAsync<EnumBasicOperatingMode>(_httpClient, "bridgekusamaparachains/palletoperatingmode");
      }
      public async Task<bool> SubscribePalletOperatingMode()
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaParachains.PalletOperatingMode");
      }
      public async Task<ParaInfo> GetParasInfo(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_polkadot_core.parachains.ParaId key)
      {
         return await SendRequestAsync<ParaInfo>(_httpClient, "bridgekusamaparachains/parasinfo", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaParachainsStorage.ParasInfoParams(key));
      }
      public async Task<bool> SubscribeParasInfo(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_polkadot_core.parachains.ParaId key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaParachains.ParasInfo", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaParachainsStorage.ParasInfoParams(key));
      }
      public async Task<ParaStoredHeaderData> GetImportedParaHeads(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_polkadot_core.parachains.ParaId, H256> key)
      {
         return await SendRequestAsync<ParaStoredHeaderData>(_httpClient, "bridgekusamaparachains/importedparaheads", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaParachainsStorage.ImportedParaHeadsParams(key));
      }
      public async Task<bool> SubscribeImportedParaHeads(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_polkadot_core.parachains.ParaId, H256> key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaParachains.ImportedParaHeads", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaParachainsStorage.ImportedParaHeadsParams(key));
      }
      public async Task<H256> GetImportedParaHashes(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_polkadot_core.parachains.ParaId, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await SendRequestAsync<H256>(_httpClient, "bridgekusamaparachains/importedparahashes", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaParachainsStorage.ImportedParaHashesParams(key));
      }
      public async Task<bool> SubscribeImportedParaHashes(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bp_polkadot_core.parachains.ParaId, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await _subscriptionClient.SubscribeAsync("BridgeKusamaParachains.ImportedParaHashes", Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Storage.BridgeKusamaParachainsStorage.ImportedParaHashesParams(key));
      }
   }
}