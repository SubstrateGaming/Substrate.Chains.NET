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
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.pallet_evm;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Moonsama.NET.RestClient.Generated.Interfaces;
   
   public sealed class EVMControllerClient : BaseClient, IEVMControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public EVMControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<U8>> GetAccountCodes(H160 key)
      {
         return await SendRequestAsync<BaseVec<U8>>(_httpClient, "evm/accountcodes", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage.AccountCodesParams(key));
      }
      public async Task<bool> SubscribeAccountCodes(H160 key)
      {
         return await _subscriptionClient.SubscribeAsync("EVM.AccountCodes", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage.AccountCodesParams(key));
      }
      public async Task<CodeMetadata> GetAccountCodesMetadata(H160 key)
      {
         return await SendRequestAsync<CodeMetadata>(_httpClient, "evm/accountcodesmetadata", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage.AccountCodesMetadataParams(key));
      }
      public async Task<bool> SubscribeAccountCodesMetadata(H160 key)
      {
         return await _subscriptionClient.SubscribeAsync("EVM.AccountCodesMetadata", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage.AccountCodesMetadataParams(key));
      }
      public async Task<H256> GetAccountStorages(BaseTuple<H160, H256> key)
      {
         return await SendRequestAsync<H256>(_httpClient, "evm/accountstorages", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage.AccountStoragesParams(key));
      }
      public async Task<bool> SubscribeAccountStorages(BaseTuple<H160, H256> key)
      {
         return await _subscriptionClient.SubscribeAsync("EVM.AccountStorages", Substrate.Moonsama.NET.NetApiExt.Generated.Storage.EVMStorage.AccountStoragesParams(key));
      }
   }
}
