//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Astar.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Astar.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Astar.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class EVMControllerMockupClient : MockupBaseClient, IEVMControllerMockupClient
   {
      private HttpClient _httpClient;
      public EVMControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAccountCodes(BaseVec<U8> value, H160 key)
      {
         return await SendMockupRequestAsync(_httpClient, "EVM/AccountCodes", value.Encode(), Substrate.Astar.NET.NetApiExt.Generated.Storage.EVMStorage.AccountCodesParams(key));
      }
      public async Task<bool> SetAccountStorages(H256 value, BaseTuple<H160, H256> key)
      {
         return await SendMockupRequestAsync(_httpClient, "EVM/AccountStorages", value.Encode(), Substrate.Astar.NET.NetApiExt.Generated.Storage.EVMStorage.AccountStoragesParams(key));
      }
   }
}