//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.KusamaAssetHub.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.pallet_assets.types;
   
   public interface IForeignAssetsControllerMockupClient
   {
      Task<bool> SetAsset(AssetDetails value, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation key);
      Task<bool> SetAccount(AssetAccount value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SetApprovals(Approval value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SetMetadata(AssetMetadataT2 value, Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.xcm.v3.multilocation.MultiLocation key);
   }
}