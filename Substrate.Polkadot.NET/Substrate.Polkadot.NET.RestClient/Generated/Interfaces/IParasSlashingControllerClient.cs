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
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.slashing;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IParasSlashingControllerClient
   {
      Task<PendingSlashes> GetUnappliedSlashes(Substrate.NetApi.Model.Types.Base.BaseTuple<U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key);
      Task<bool> SubscribeUnappliedSlashes(Substrate.NetApi.Model.Types.Base.BaseTuple<U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key);
      Task<U32> GetValidatorSetCounts(U32 key);
      Task<bool> SubscribeValidatorSetCounts(U32 key);
   }
}