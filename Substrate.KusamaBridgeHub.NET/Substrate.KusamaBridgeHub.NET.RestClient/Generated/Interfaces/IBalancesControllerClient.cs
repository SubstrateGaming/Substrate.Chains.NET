//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.KusamaBridgeHub.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IBalancesControllerClient
   {
      Task<U128> GetTotalIssuance();
      Task<bool> SubscribeTotalIssuance();
      Task<U128> GetInactiveIssuance();
      Task<bool> SubscribeInactiveIssuance();
      Task<AccountData> GetAccount(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAccount(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<WeakBoundedVecT2> GetLocks(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeLocks(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT4> GetReserves(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeReserves(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT5> GetHolds(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeHolds(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT5> GetFreezes(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeFreezes(Substrate.KusamaBridgeHub.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}