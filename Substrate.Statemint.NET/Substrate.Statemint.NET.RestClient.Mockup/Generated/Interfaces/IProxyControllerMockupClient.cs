//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Statemint.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IProxyControllerMockupClient
   {
      Task<bool> SetProxies(BaseTuple<BoundedVecT11, U128> value, Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetAnnouncements(BaseTuple<BoundedVecT12, U128> value, Substrate.Statemint.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}