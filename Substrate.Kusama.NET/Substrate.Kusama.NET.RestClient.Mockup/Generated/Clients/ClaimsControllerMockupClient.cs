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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.claims;
   using Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ClaimsControllerMockupClient : MockupBaseClient, IClaimsControllerMockupClient
   {
      private HttpClient _httpClient;
      public ClaimsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetClaims(U128 value, EthereumAddress key)
      {
         return await SendMockupRequestAsync(_httpClient, "Claims/Claims", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ClaimsStorage.ClaimsParams(key));
      }
      public async Task<bool> SetTotal(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Claims/Total", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ClaimsStorage.TotalParams());
      }
      public async Task<bool> SetVesting(BaseTuple<U128, U128, U32> value, EthereumAddress key)
      {
         return await SendMockupRequestAsync(_httpClient, "Claims/Vesting", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ClaimsStorage.VestingParams(key));
      }
      public async Task<bool> SetSigning(EnumStatementKind value, EthereumAddress key)
      {
         return await SendMockupRequestAsync(_httpClient, "Claims/Signing", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ClaimsStorage.SigningParams(key));
      }
      public async Task<bool> SetPreclaims(EthereumAddress value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Claims/Preclaims", value.Encode(), Substrate.Kusama.NET.NetApiExt.Generated.Storage.ClaimsStorage.PreclaimsParams(key));
      }
   }
}
