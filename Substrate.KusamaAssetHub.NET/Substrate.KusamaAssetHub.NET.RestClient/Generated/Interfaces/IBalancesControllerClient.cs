//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.KusamaAssetHub.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IBalancesControllerClient
   {
      Task<U128> GetTotalIssuance();
      Task<bool> SubscribeTotalIssuance();
      Task<U128> GetInactiveIssuance();
      Task<bool> SubscribeInactiveIssuance();
      Task<AccountData> GetAccount(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAccount(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<WeakBoundedVecT2> GetLocks(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeLocks(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT8> GetReserves(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeReserves(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT9> GetHolds(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeHolds(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT9> GetFreezes(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeFreezes(Substrate.KusamaAssetHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
