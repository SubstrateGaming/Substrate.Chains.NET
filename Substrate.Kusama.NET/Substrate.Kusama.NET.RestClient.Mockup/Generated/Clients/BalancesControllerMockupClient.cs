//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BalancesControllerMockupClient : MockupBaseClient, IBalancesControllerMockupClient
   {
      private HttpClient _httpClient;
      public BalancesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetTotalIssuance(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/TotalIssuance", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.TotalIssuanceParams());
      }
      public async Task<bool> SetInactiveIssuance(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/InactiveIssuance", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.InactiveIssuanceParams());
      }
      public async Task<bool> SetAccount(AccountData value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Account", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SetLocks(WeakBoundedVecT3 value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Locks", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SetReserves(BoundedVecT13 value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Reserves", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SetHolds(BoundedVecT14 value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Holds", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.HoldsParams(key));
      }
      public async Task<bool> SetFreezes(BoundedVecT15 value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Freezes", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.BalancesStorage.FreezesParams(key));
      }
   }
}