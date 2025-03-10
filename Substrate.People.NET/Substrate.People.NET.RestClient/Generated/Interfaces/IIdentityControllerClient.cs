//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.People.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.People.NET.NetApiExt.Generated.Model.pallet_identity.types;
   using Substrate.People.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.People.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IIdentityControllerClient
   {
      Task<BaseTuple<Registration, BaseOpt<BoundedVecT4>>> GetIdentityOf(AccountId32 key);
      Task<bool> SubscribeIdentityOf(AccountId32 key);
      Task<BaseTuple<AccountId32, EnumData>> GetSuperOf(AccountId32 key);
      Task<bool> SubscribeSuperOf(AccountId32 key);
      Task<BaseTuple<U128, BoundedVecT18>> GetSubsOf(AccountId32 key);
      Task<bool> SubscribeSubsOf(AccountId32 key);
      Task<BoundedVecT22> GetRegistrars();
      Task<bool> SubscribeRegistrars();
      Task<AuthorityProperties> GetUsernameAuthorities(AccountId32 key);
      Task<bool> SubscribeUsernameAuthorities(AccountId32 key);
      Task<AccountId32> GetAccountOfUsername(BoundedVecT4 key);
      Task<bool> SubscribeAccountOfUsername(BoundedVecT4 key);
      Task<BaseTuple<AccountId32, U32>> GetPendingUsernames(BoundedVecT4 key);
      Task<bool> SubscribePendingUsernames(BoundedVecT4 key);
   }
}
