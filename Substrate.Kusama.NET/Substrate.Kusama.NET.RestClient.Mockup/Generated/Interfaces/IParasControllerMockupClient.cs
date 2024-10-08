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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_primitives.v7;
   
   public interface IParasControllerMockupClient
   {
      Task<bool> SetPvfActiveVoteMap(PvfCheckActiveVoteState value, ValidationCodeHash key);
      Task<bool> SetPvfActiveVoteList(BaseVec<ValidationCodeHash> value);
      Task<bool> SetParachains(BaseVec<Id> value);
      Task<bool> SetParaLifecycles(EnumParaLifecycle value, Id key);
      Task<bool> SetHeads(HeadData value, Id key);
      Task<bool> SetMostRecentContext(U32 value, Id key);
      Task<bool> SetCurrentCodeHash(ValidationCodeHash value, Id key);
      Task<bool> SetPastCodeHash(ValidationCodeHash value, BaseTuple<Id, U32> key);
      Task<bool> SetPastCodeMeta(ParaPastCodeMeta value, Id key);
      Task<bool> SetPastCodePruning(BaseVec<BaseTuple<Id, U32>> value);
      Task<bool> SetFutureCodeUpgrades(U32 value, Id key);
      Task<bool> SetFutureCodeUpgradesAt(BaseVec<BaseTuple<Id, U32>> value);
      Task<bool> SetFutureCodeHash(ValidationCodeHash value, Id key);
      Task<bool> SetUpgradeGoAheadSignal(EnumUpgradeGoAhead value, Id key);
      Task<bool> SetUpgradeRestrictionSignal(EnumUpgradeRestriction value, Id key);
      Task<bool> SetUpgradeCooldowns(BaseVec<BaseTuple<Id, U32>> value);
      Task<bool> SetUpcomingUpgrades(BaseVec<BaseTuple<Id, U32>> value);
      Task<bool> SetActionsQueue(BaseVec<Id> value, U32 key);
      Task<bool> SetUpcomingParasGenesis(ParaGenesisArgs value, Id key);
      Task<bool> SetCodeByHashRefs(U32 value, ValidationCodeHash key);
      Task<bool> SetCodeByHash(ValidationCode value, ValidationCodeHash key);
   }
}
