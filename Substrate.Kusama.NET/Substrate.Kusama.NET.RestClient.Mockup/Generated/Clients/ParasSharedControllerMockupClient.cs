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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v6.validator_app;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.shared;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ParasSharedControllerMockupClient : MockupBaseClient, IParasSharedControllerMockupClient
   {
      private HttpClient _httpClient;
      public ParasSharedControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetCurrentSessionIndex(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParasShared/CurrentSessionIndex", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ParasSharedStorage.CurrentSessionIndexParams());
      }
      public async Task<bool> SetActiveValidatorIndices(BaseVec<ValidatorIndex> value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParasShared/ActiveValidatorIndices", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ParasSharedStorage.ActiveValidatorIndicesParams());
      }
      public async Task<bool> SetActiveValidatorKeys(BaseVec<Public> value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParasShared/ActiveValidatorKeys", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ParasSharedStorage.ActiveValidatorKeysParams());
      }
      public async Task<bool> SetAllowedRelayParents(AllowedRelayParentsTracker value)
      {
         return await SendMockupRequestAsync(_httpClient, "ParasShared/AllowedRelayParents", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ParasSharedStorage.AllowedRelayParentsParams());
      }
   }
}