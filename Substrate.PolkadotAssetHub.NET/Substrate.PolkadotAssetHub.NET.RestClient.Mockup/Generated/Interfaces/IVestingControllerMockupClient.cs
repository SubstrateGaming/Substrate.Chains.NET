//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotAssetHub.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.pallet_vesting;
   
   public interface IVestingControllerMockupClient
   {
      Task<bool> SetVesting(BoundedVecT11 value, Substrate.PolkadotAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetStorageVersion(EnumReleases value);
   }
}
