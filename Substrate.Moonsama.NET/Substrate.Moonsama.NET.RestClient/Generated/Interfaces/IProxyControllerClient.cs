//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Moonsama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Moonsama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IProxyControllerClient
   {
      Task<BaseTuple<BoundedVecT19, U128>> GetProxies(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeProxies(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<BaseTuple<BoundedVecT20, U128>> GetAnnouncements(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
      Task<bool> SubscribeAnnouncements(Substrate.Moonsama.NET.NetApiExt.Generated.Model.fp_account.AccountId20 key);
   }
}
