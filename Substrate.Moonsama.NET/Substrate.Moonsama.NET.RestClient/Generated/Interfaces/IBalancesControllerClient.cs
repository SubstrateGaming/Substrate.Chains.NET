//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IBalancesControllerClient
   {
      Task<U128> GetTotalIssuance();
      Task<bool> SubscribeTotalIssuance();
      Task<U128> GetInactiveIssuance();
      Task<bool> SubscribeInactiveIssuance();
      Task<AccountData> GetAccount(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeAccount(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<WeakBoundedVecT2> GetLocks(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeLocks(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<BoundedVecT7> GetReserves(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeReserves(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<BoundedVecT8> GetHolds(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeHolds(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<BoundedVecT9> GetFreezes(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeFreezes(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
   }
}