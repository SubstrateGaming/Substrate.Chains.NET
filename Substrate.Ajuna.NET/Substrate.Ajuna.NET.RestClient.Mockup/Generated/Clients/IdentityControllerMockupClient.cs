//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class IdentityControllerMockupClient : MockupBaseClient, IIdentityControllerMockupClient
   {
      private HttpClient _httpClient;
      public IdentityControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetIdentityOf(Registration value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/IdentityOf", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SetSuperOf(BaseTuple<AccountId32, EnumData> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/SuperOf", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SetSubsOf(BaseTuple<U128, BoundedVecT7> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/SubsOf", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SetRegistrars(BoundedVecT8 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/Registrars", value.Encode(), Substrate.Ajuna.NET.NetApiExt.Generated.Storage.IdentityStorage.RegistrarsParams());
      }
   }
}