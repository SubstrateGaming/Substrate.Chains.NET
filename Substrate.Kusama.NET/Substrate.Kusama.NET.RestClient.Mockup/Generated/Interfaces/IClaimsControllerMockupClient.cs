//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_common.claims;
   
   public interface IClaimsControllerMockupClient
   {
      Task<bool> SetClaims(U128 value, EthereumAddress key);
      Task<bool> SetTotal(U128 value);
      Task<bool> SetVesting(BaseTuple<U128, U128, U32> value, EthereumAddress key);
      Task<bool> SetSigning(EnumStatementKind value, EthereumAddress key);
      Task<bool> SetPreclaims(EthereumAddress value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}