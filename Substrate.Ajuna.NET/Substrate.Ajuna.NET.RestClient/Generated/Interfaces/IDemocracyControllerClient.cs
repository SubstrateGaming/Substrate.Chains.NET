//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_democracy.types;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_democracy.vote;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.frame_support.traits.preimages;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_democracy.vote_threshold;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types;
   
   public interface IDemocracyControllerClient
   {
      Task<U32> GetPublicPropCount();
      Task<bool> SubscribePublicPropCount();
      Task<BoundedVecT45> GetPublicProps();
      Task<bool> SubscribePublicProps();
      Task<BaseTuple<BoundedVecT46, U128>> GetDepositOf(U32 key);
      Task<bool> SubscribeDepositOf(U32 key);
      Task<U32> GetReferendumCount();
      Task<bool> SubscribeReferendumCount();
      Task<U32> GetLowestUnbaked();
      Task<bool> SubscribeLowestUnbaked();
      Task<EnumReferendumInfo> GetReferendumInfoOf(U32 key);
      Task<bool> SubscribeReferendumInfoOf(U32 key);
      Task<EnumVoting> GetVotingOf(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeVotingOf(Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<Bool> GetLastTabledWasExternal();
      Task<bool> SubscribeLastTabledWasExternal();
      Task<BaseTuple<EnumBounded, EnumVoteThreshold>> GetNextExternal();
      Task<bool> SubscribeNextExternal();
      Task<BaseTuple<U32, BoundedVecT46>> GetBlacklist(H256 key);
      Task<bool> SubscribeBlacklist(H256 key);
      Task<Bool> GetCancellations(H256 key);
      Task<bool> SubscribeCancellations(H256 key);
      Task<H256> GetMetadataOf(EnumMetadataOwner key);
      Task<bool> SubscribeMetadataOf(EnumMetadataOwner key);
   }
}
