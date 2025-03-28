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
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.ajuna_runtime;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_collective;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface ITechnicalCommitteeControllerMockupClient
   {
      Task<bool> SetProposals(BoundedVecT42 value);
      Task<bool> SetProposalOf(EnumRuntimeCall value, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetVoting(Votes value, Substrate.Ajuna.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetProposalCount(U32 value);
      Task<bool> SetMembers(BaseVec<AccountId32> value);
      Task<bool> SetPrime(AccountId32 value);
   }
}
