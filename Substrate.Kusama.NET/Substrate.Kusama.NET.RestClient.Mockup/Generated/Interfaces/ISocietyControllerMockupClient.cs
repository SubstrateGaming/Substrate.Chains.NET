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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_society;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   
   public interface ISocietyControllerMockupClient
   {
      Task<bool> SetParameters(GroupParams value);
      Task<bool> SetPot(U128 value);
      Task<bool> SetFounder(AccountId32 value);
      Task<bool> SetHead(AccountId32 value);
      Task<bool> SetRules(H256 value);
      Task<bool> SetMembers(MemberRecord value, AccountId32 key);
      Task<bool> SetPayouts(PayoutRecord value, AccountId32 key);
      Task<bool> SetMemberCount(U32 value);
      Task<bool> SetMemberByIndex(AccountId32 value, U32 key);
      Task<bool> SetSuspendedMembers(MemberRecord value, AccountId32 key);
      Task<bool> SetRoundCount(U32 value);
      Task<bool> SetBids(BoundedVecT25 value);
      Task<bool> SetCandidates(Candidacy value, AccountId32 key);
      Task<bool> SetSkeptic(AccountId32 value);
      Task<bool> SetVotes(Vote value, BaseTuple<AccountId32, AccountId32> key);
      Task<bool> SetVoteClearCursor(BoundedVecT26 value, AccountId32 key);
      Task<bool> SetNextHead(IntakeRecord value);
      Task<bool> SetChallengeRoundCount(U32 value);
      Task<bool> SetDefending(BaseTuple<AccountId32, AccountId32, Tally> value);
      Task<bool> SetDefenderVotes(Vote value, BaseTuple<U32, AccountId32> key);
   }
}
