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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IProxyControllerMockupClient
   {
      Task<bool> SetProxies(BaseTuple<BoundedVecT30, U128> value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetAnnouncements(BaseTuple<BoundedVecT31, U128> value, Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
