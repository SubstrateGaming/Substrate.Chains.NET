//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Moonsama.NET.RestClient.Generated.Interfaces;
   
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
      public async Task<AccountData> GetAccount(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<AccountData>(_httpClient, "balances/account", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Account", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<WeakBoundedVecT2> GetLocks(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<WeakBoundedVecT2>(_httpClient, "balances/locks", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SubscribeLocks(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Locks", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<BoundedVecT7> GetReserves(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<BoundedVecT7>(_httpClient, "balances/reserves", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SubscribeReserves(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Reserves", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<BoundedVecT8> GetHolds(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<BoundedVecT8>(_httpClient, "balances/holds", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.HoldsParams(key));
      }
      public async Task<bool> SubscribeHolds(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Holds", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.HoldsParams(key));
      }
      public async Task<BoundedVecT9> GetFreezes(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<BoundedVecT9>(_httpClient, "balances/freezes", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.FreezesParams(key));
      }
      public async Task<bool> SubscribeFreezes(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Freezes", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.BalancesStorage.FreezesParams(key));
      }
   }
}