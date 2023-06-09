//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Statemint.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Statemint.NET.NetApiExt.Generated.Model.pallet_balances;
   using Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec;
   using Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Substrate.Statemint.NET.RestClient.Generated.Interfaces;
   
   public sealed class BalancesControllerClient : BaseClient, IBalancesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BalancesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U128> GetTotalIssuance()
      {
         return await SendRequestAsync<U128>(_httpClient, "balances/totalissuance");
      }
      public async Task<bool> SubscribeTotalIssuance()
      {
         return await _subscriptionClient.SubscribeAsync("Balances.TotalIssuance");
      }
      public async Task<U128> GetInactiveIssuance()
      {
         return await SendRequestAsync<U128>(_httpClient, "balances/inactiveissuance");
      }
      public async Task<bool> SubscribeInactiveIssuance()
      {
         return await _subscriptionClient.SubscribeAsync("Balances.InactiveIssuance");
      }
      public async Task<AccountData> GetAccount(Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<AccountData>(_httpClient, "balances/account", Substrate.Statemint.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Account", Substrate.Statemint.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<WeakBoundedVecT2> GetLocks(Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<WeakBoundedVecT2>(_httpClient, "balances/locks", Substrate.Statemint.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SubscribeLocks(Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Locks", Substrate.Statemint.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<BoundedVecT4> GetReserves(Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT4>(_httpClient, "balances/reserves", Substrate.Statemint.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SubscribeReserves(Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Reserves", Substrate.Statemint.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
   }
}
