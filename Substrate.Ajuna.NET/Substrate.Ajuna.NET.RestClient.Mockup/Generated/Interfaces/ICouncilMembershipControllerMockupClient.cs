//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface ICouncilMembershipControllerMockupClient
   {
      Task<bool> SetMembers(BaseVec<AccountId32> value);
      Task<bool> SetPrime(AccountId32 value);
   }
}
