//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Coretime.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Coretime.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IBalancesControllerMockupClient
   {
      Task<bool> SetTotalIssuance(U128 value);
      Task<bool> SetInactiveIssuance(U128 value);
      Task<bool> SetAccount(AccountData value, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetLocks(WeakBoundedVecT2 value, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetReserves(BoundedVecT5 value, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetHolds(BoundedVecT6 value, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetFreezes(BoundedVecT7 value, Substrate.Coretime.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
