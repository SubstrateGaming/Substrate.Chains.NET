//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Polkadot.NET.RestClient.Generated.Interfaces;
   
   public sealed class ConfigurationControllerClient : BaseClient, IConfigurationControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ConfigurationControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<HostConfiguration> GetActiveConfig()
      {
         return await SendRequestAsync<HostConfiguration>(_httpClient, "configuration/activeconfig");
      }
      public async Task<bool> SubscribeActiveConfig()
      {
         return await _subscriptionClient.SubscribeAsync("Configuration.ActiveConfig");
      }
      public async Task<BaseVec<BaseTuple<U32, HostConfiguration>>> GetPendingConfigs()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<U32, HostConfiguration>>>(_httpClient, "configuration/pendingconfigs");
      }
      public async Task<bool> SubscribePendingConfigs()
      {
         return await _subscriptionClient.SubscribeAsync("Configuration.PendingConfigs");
      }
      public async Task<Bool> GetBypassConsistencyCheck()
      {
         return await SendRequestAsync<Bool>(_httpClient, "configuration/bypassconsistencycheck");
      }
      public async Task<bool> SubscribeBypassConsistencyCheck()
      {
         return await _subscriptionClient.SubscribeAsync("Configuration.BypassConsistencyCheck");
      }
   }
}
