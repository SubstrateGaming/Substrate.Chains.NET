//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.slashing;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IParasSlashingControllerMockupClient
   {
      Task<bool> SetUnappliedSlashes(PendingSlashes value, Substrate.NetApi.Model.Types.Base.BaseTuple<U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key);
      Task<bool> SetValidatorSetCounts(U32 value, U32 key);
   }
}