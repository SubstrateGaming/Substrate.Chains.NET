//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Collectives.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.pallet_ranked_collective;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Collectives.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IAmbassadorCollectiveControllerClient
   {
      Task<U32> GetMemberCount(U16 key);
      Task<bool> SubscribeMemberCount(U16 key);
      Task<MemberRecord> GetMembers(AccountId32 key);
      Task<bool> SubscribeMembers(AccountId32 key);
      Task<U32> GetIdToIndex(Substrate.NetApi.Model.Types.Base.BaseTuple<U16, AccountId32> key);
      Task<bool> SubscribeIdToIndex(Substrate.NetApi.Model.Types.Base.BaseTuple<U16, AccountId32> key);
      Task<AccountId32> GetIndexToId(Substrate.NetApi.Model.Types.Base.BaseTuple<U16, U32> key);
      Task<bool> SubscribeIndexToId(Substrate.NetApi.Model.Types.Base.BaseTuple<U16, U32> key);
      Task<EnumVoteRecord> GetVoting(Substrate.NetApi.Model.Types.Base.BaseTuple<U32, AccountId32> key);
      Task<bool> SubscribeVoting(Substrate.NetApi.Model.Types.Base.BaseTuple<U32, AccountId32> key);
      Task<BoundedVecT36> GetVotingCleanup(U32 key);
      Task<bool> SubscribeVotingCleanup(U32 key);
   }
}
