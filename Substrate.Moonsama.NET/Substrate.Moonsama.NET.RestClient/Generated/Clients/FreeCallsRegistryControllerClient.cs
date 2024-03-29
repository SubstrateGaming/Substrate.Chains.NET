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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm_calls_registry.types;
   using Substrate.Moonsama.NET.RestClient.Generated.Interfaces;
   
   public sealed class FreeCallsRegistryControllerClient : BaseClient, IFreeCallsRegistryControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public FreeCallsRegistryControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple> GetFreeCallsRegistry(EvmCall key)
      {
         return await SendRequestAsync<BaseTuple>(_httpClient, "freecallsregistry/freecallsregistry", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.FreeCallsRegistryStorage.FreeCallsRegistryParams(key));
      }
      public async Task<bool> SubscribeFreeCallsRegistry(EvmCall key)
      {
         return await _subscriptionClient.SubscribeAsync("FreeCallsRegistry.FreeCallsRegistry", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.FreeCallsRegistryStorage.FreeCallsRegistryParams(key));
      }
      public async Task<U32> GetRequestExpiryDate(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "freecallsregistry/requestexpirydate", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.FreeCallsRegistryStorage.RequestExpiryDateParams(key));
      }
      public async Task<bool> SubscribeRequestExpiryDate(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("FreeCallsRegistry.RequestExpiryDate", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.FreeCallsRegistryStorage.RequestExpiryDateParams(key));
      }
      public async Task<EvmCallCounter> GetFreeCallsAvailable(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await SendRequestAsync<EvmCallCounter>(_httpClient, "freecallsregistry/freecallsavailable", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.FreeCallsRegistryStorage.FreeCallsAvailableParams(key));
      }
      public async Task<bool> SubscribeFreeCallsAvailable(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key)
      {
         return await _subscriptionClient.SubscribeAsync("FreeCallsRegistry.FreeCallsAvailable", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.FreeCallsRegistryStorage.FreeCallsAvailableParams(key));
      }
   }
}
