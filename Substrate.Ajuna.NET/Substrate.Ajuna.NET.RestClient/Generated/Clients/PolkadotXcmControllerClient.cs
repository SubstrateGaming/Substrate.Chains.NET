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
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_xcm.pallet;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_weights.weight_v2;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.staging_xcm.v4;
   using Substrate.Ajuna.NET.RestClient.Generated.Interfaces;
   
   public sealed class PolkadotXcmControllerClient : BaseClient, IPolkadotXcmControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public PolkadotXcmControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U64> GetQueryCounter()
      {
         return await SendRequestAsync<U64>(_httpClient, "polkadotxcm/querycounter");
      }
      public async Task<bool> SubscribeQueryCounter()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.QueryCounter");
      }
      public async Task<EnumQueryStatus> GetQueries(U64 key)
      {
         return await SendRequestAsync<EnumQueryStatus>(_httpClient, "polkadotxcm/queries", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.QueriesParams(key));
      }
      public async Task<bool> SubscribeQueries(U64 key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.Queries", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.QueriesParams(key));
      }
      public async Task<U32> GetAssetTraps(Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "polkadotxcm/assettraps", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.AssetTrapsParams(key));
      }
      public async Task<bool> SubscribeAssetTraps(Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.AssetTraps", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.AssetTrapsParams(key));
      }
      public async Task<U32> GetSafeXcmVersion()
      {
         return await SendRequestAsync<U32>(_httpClient, "polkadotxcm/safexcmversion");
      }
      public async Task<bool> SubscribeSafeXcmVersion()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.SafeXcmVersion");
      }
      public async Task<U32> GetSupportedVersion(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key)
      {
         return await SendRequestAsync<U32>(_httpClient, "polkadotxcm/supportedversion", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.SupportedVersionParams(key));
      }
      public async Task<bool> SubscribeSupportedVersion(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.SupportedVersion", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.SupportedVersionParams(key));
      }
      public async Task<U64> GetVersionNotifiers(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key)
      {
         return await SendRequestAsync<U64>(_httpClient, "polkadotxcm/versionnotifiers", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.VersionNotifiersParams(key));
      }
      public async Task<bool> SubscribeVersionNotifiers(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.VersionNotifiers", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.VersionNotifiersParams(key));
      }
      public async Task<BaseTuple<U64, Weight, U32>> GetVersionNotifyTargets(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key)
      {
         return await SendRequestAsync<BaseTuple<U64, Weight, U32>>(_httpClient, "polkadotxcm/versionnotifytargets", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.VersionNotifyTargetsParams(key));
      }
      public async Task<bool> SubscribeVersionNotifyTargets(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.VersionNotifyTargets", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.VersionNotifyTargetsParams(key));
      }
      public async Task<BoundedVecT38> GetVersionDiscoveryQueue()
      {
         return await SendRequestAsync<BoundedVecT38>(_httpClient, "polkadotxcm/versiondiscoveryqueue");
      }
      public async Task<bool> SubscribeVersionDiscoveryQueue()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.VersionDiscoveryQueue");
      }
      public async Task<EnumVersionMigrationStage> GetCurrentMigration()
      {
         return await SendRequestAsync<EnumVersionMigrationStage>(_httpClient, "polkadotxcm/currentmigration");
      }
      public async Task<bool> SubscribeCurrentMigration()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.CurrentMigration");
      }
      public async Task<RemoteLockedFungibleRecord> GetRemoteLockedFungibles(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key)
      {
         return await SendRequestAsync<RemoteLockedFungibleRecord>(_httpClient, "polkadotxcm/remotelockedfungibles", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.RemoteLockedFungiblesParams(key));
      }
      public async Task<bool> SubscribeRemoteLockedFungibles(BaseTuple<U32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Ajuna.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.RemoteLockedFungibles", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.RemoteLockedFungiblesParams(key));
      }
      public async Task<BoundedVecT40> GetLockedFungibles(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT40>(_httpClient, "polkadotxcm/lockedfungibles", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.LockedFungiblesParams(key));
      }
      public async Task<bool> SubscribeLockedFungibles(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.LockedFungibles", Substrate.Ajuna.NET.NetApiExt.Generated.Storage.PolkadotXcmStorage.LockedFungiblesParams(key));
      }
      public async Task<Bool> GetXcmExecutionSuspended()
      {
         return await SendRequestAsync<Bool>(_httpClient, "polkadotxcm/xcmexecutionsuspended");
      }
      public async Task<bool> SubscribeXcmExecutionSuspended()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.XcmExecutionSuspended");
      }
      public async Task<Bool> GetShouldRecordXcm()
      {
         return await SendRequestAsync<Bool>(_httpClient, "polkadotxcm/shouldrecordxcm");
      }
      public async Task<bool> SubscribeShouldRecordXcm()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.ShouldRecordXcm");
      }
      public async Task<XcmT1> GetRecordedXcm()
      {
         return await SendRequestAsync<XcmT1>(_httpClient, "polkadotxcm/recordedxcm");
      }
      public async Task<bool> SubscribeRecordedXcm()
      {
         return await _subscriptionClient.SubscribeAsync("PolkadotXcm.RecordedXcm");
      }
   }
}
