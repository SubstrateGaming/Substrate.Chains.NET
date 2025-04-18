//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_xcm.pallet;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_weights.weight_v2;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.staging_xcm.v4;
   
   public interface IXcmPalletControllerClient
   {
      Task<U64> GetQueryCounter();
      Task<bool> SubscribeQueryCounter();
      Task<EnumQueryStatus> GetQueries(U64 key);
      Task<bool> SubscribeQueries(U64 key);
      Task<U32> GetAssetTraps(Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeAssetTraps(Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<U32> GetSafeXcmVersion();
      Task<bool> SubscribeSafeXcmVersion();
      Task<U32> GetSupportedVersion(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key);
      Task<bool> SubscribeSupportedVersion(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key);
      Task<U64> GetVersionNotifiers(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key);
      Task<bool> SubscribeVersionNotifiers(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key);
      Task<BaseTuple<U64, Weight, U32>> GetVersionNotifyTargets(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key);
      Task<bool> SubscribeVersionNotifyTargets(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedLocation> key);
      Task<BoundedVecT45> GetVersionDiscoveryQueue();
      Task<bool> SubscribeVersionDiscoveryQueue();
      Task<EnumVersionMigrationStage> GetCurrentMigration();
      Task<bool> SubscribeCurrentMigration();
      Task<RemoteLockedFungibleRecord> GetRemoteLockedFungibles(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key);
      Task<bool> SubscribeRemoteLockedFungibles(BaseTuple<U32, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Kusama.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key);
      Task<BoundedVecT47> GetLockedFungibles(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeLockedFungibles(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<Bool> GetXcmExecutionSuspended();
      Task<bool> SubscribeXcmExecutionSuspended();
      Task<Bool> GetShouldRecordXcm();
      Task<bool> SubscribeShouldRecordXcm();
      Task<XcmT1> GetRecordedXcm();
      Task<bool> SubscribeRecordedXcm();
   }
}
