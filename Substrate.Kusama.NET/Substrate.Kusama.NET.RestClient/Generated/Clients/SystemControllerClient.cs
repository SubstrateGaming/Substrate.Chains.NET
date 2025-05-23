//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.frame_system;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.frame_support.dispatch;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest;
   using Substrate.Kusama.NET.RestClient.Generated.Interfaces;
   
   public sealed class SystemControllerClient : BaseClient, ISystemControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SystemControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AccountInfo> GetAccount(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<AccountInfo>(_httpClient, "system/account", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("System.Account", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.AccountParams(key));
      }
      public async Task<U32> GetExtrinsicCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "system/extrinsiccount");
      }
      public async Task<bool> SubscribeExtrinsicCount()
      {
         return await _subscriptionClient.SubscribeAsync("System.ExtrinsicCount");
      }
      public async Task<Bool> GetInherentsApplied()
      {
         return await SendRequestAsync<Bool>(_httpClient, "system/inherentsapplied");
      }
      public async Task<bool> SubscribeInherentsApplied()
      {
         return await _subscriptionClient.SubscribeAsync("System.InherentsApplied");
      }
      public async Task<PerDispatchClassT1> GetBlockWeight()
      {
         return await SendRequestAsync<PerDispatchClassT1>(_httpClient, "system/blockweight");
      }
      public async Task<bool> SubscribeBlockWeight()
      {
         return await _subscriptionClient.SubscribeAsync("System.BlockWeight");
      }
      public async Task<U32> GetAllExtrinsicsLen()
      {
         return await SendRequestAsync<U32>(_httpClient, "system/allextrinsicslen");
      }
      public async Task<bool> SubscribeAllExtrinsicsLen()
      {
         return await _subscriptionClient.SubscribeAsync("System.AllExtrinsicsLen");
      }
      public async Task<H256> GetBlockHash(U32 key)
      {
         return await SendRequestAsync<H256>(_httpClient, "system/blockhash", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.BlockHashParams(key));
      }
      public async Task<bool> SubscribeBlockHash(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("System.BlockHash", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.BlockHashParams(key));
      }
      public async Task<BaseVec<U8>> GetExtrinsicData(U32 key)
      {
         return await SendRequestAsync<BaseVec<U8>>(_httpClient, "system/extrinsicdata", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.ExtrinsicDataParams(key));
      }
      public async Task<bool> SubscribeExtrinsicData(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("System.ExtrinsicData", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.ExtrinsicDataParams(key));
      }
      public async Task<U32> GetNumber()
      {
         return await SendRequestAsync<U32>(_httpClient, "system/number");
      }
      public async Task<bool> SubscribeNumber()
      {
         return await _subscriptionClient.SubscribeAsync("System.Number");
      }
      public async Task<H256> GetParentHash()
      {
         return await SendRequestAsync<H256>(_httpClient, "system/parenthash");
      }
      public async Task<bool> SubscribeParentHash()
      {
         return await _subscriptionClient.SubscribeAsync("System.ParentHash");
      }
      public async Task<Digest> GetDigest()
      {
         return await SendRequestAsync<Digest>(_httpClient, "system/digest");
      }
      public async Task<bool> SubscribeDigest()
      {
         return await _subscriptionClient.SubscribeAsync("System.Digest");
      }
      public async Task<BaseVec<EventRecord>> GetEvents()
      {
         return await SendRequestAsync<BaseVec<EventRecord>>(_httpClient, "system/events");
      }
      public async Task<bool> SubscribeEvents()
      {
         return await _subscriptionClient.SubscribeAsync("System.Events");
      }
      public async Task<U32> GetEventCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "system/eventcount");
      }
      public async Task<bool> SubscribeEventCount()
      {
         return await _subscriptionClient.SubscribeAsync("System.EventCount");
      }
      public async Task<BaseVec<BaseTuple<U32, U32>>> GetEventTopics(H256 key)
      {
         return await SendRequestAsync<BaseVec<BaseTuple<U32, U32>>>(_httpClient, "system/eventtopics", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.EventTopicsParams(key));
      }
      public async Task<bool> SubscribeEventTopics(H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("System.EventTopics", Substrate.Kusama.NET.NetApiExt.Generated.Storage.SystemStorage.EventTopicsParams(key));
      }
      public async Task<LastRuntimeUpgradeInfo> GetLastRuntimeUpgrade()
      {
         return await SendRequestAsync<LastRuntimeUpgradeInfo>(_httpClient, "system/lastruntimeupgrade");
      }
      public async Task<bool> SubscribeLastRuntimeUpgrade()
      {
         return await _subscriptionClient.SubscribeAsync("System.LastRuntimeUpgrade");
      }
      public async Task<Bool> GetUpgradedToU32RefCount()
      {
         return await SendRequestAsync<Bool>(_httpClient, "system/upgradedtou32refcount");
      }
      public async Task<bool> SubscribeUpgradedToU32RefCount()
      {
         return await _subscriptionClient.SubscribeAsync("System.UpgradedToU32RefCount");
      }
      public async Task<Bool> GetUpgradedToTripleRefCount()
      {
         return await SendRequestAsync<Bool>(_httpClient, "system/upgradedtotriplerefcount");
      }
      public async Task<bool> SubscribeUpgradedToTripleRefCount()
      {
         return await _subscriptionClient.SubscribeAsync("System.UpgradedToTripleRefCount");
      }
      public async Task<EnumPhase> GetExecutionPhase()
      {
         return await SendRequestAsync<EnumPhase>(_httpClient, "system/executionphase");
      }
      public async Task<bool> SubscribeExecutionPhase()
      {
         return await _subscriptionClient.SubscribeAsync("System.ExecutionPhase");
      }
      public async Task<CodeUpgradeAuthorization> GetAuthorizedUpgrade()
      {
         return await SendRequestAsync<CodeUpgradeAuthorization>(_httpClient, "system/authorizedupgrade");
      }
      public async Task<bool> SubscribeAuthorizedUpgrade()
      {
         return await _subscriptionClient.SubscribeAsync("System.AuthorizedUpgrade");
      }
   }
}
