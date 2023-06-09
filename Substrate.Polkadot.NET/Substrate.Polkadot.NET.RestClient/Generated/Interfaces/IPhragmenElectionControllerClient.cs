//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_elections_phragmen;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IPhragmenElectionControllerClient
   {
      Task<BaseVec<SeatHolder>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<BaseVec<SeatHolder>> GetRunnersUp();
      Task<bool> SubscribeRunnersUp();
      Task<BaseVec<BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U128>>> GetCandidates();
      Task<bool> SubscribeCandidates();
      Task<U32> GetElectionRounds();
      Task<bool> SubscribeElectionRounds();
      Task<Voter> GetVoting(Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeVoting(Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
