//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Kusama.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   using Substrate.Kusama.NET.NetApiExt.Generated.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_consensus_babe.digests;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.sp_consensus_babe;
   
   public interface IBabeControllerClient
   {
      Task<U64> GetEpochIndex();
      Task<bool> SubscribeEpochIndex();
      Task<WeakBoundedVecT2> GetAuthorities();
      Task<bool> SubscribeAuthorities();
      Task<Slot> GetGenesisSlot();
      Task<bool> SubscribeGenesisSlot();
      Task<Slot> GetCurrentSlot();
      Task<bool> SubscribeCurrentSlot();
      Task<Arr32U8> GetRandomness();
      Task<bool> SubscribeRandomness();
      Task<EnumNextConfigDescriptor> GetPendingEpochConfigChange();
      Task<bool> SubscribePendingEpochConfigChange();
      Task<Arr32U8> GetNextRandomness();
      Task<bool> SubscribeNextRandomness();
      Task<WeakBoundedVecT2> GetNextAuthorities();
      Task<bool> SubscribeNextAuthorities();
      Task<U32> GetSegmentIndex();
      Task<bool> SubscribeSegmentIndex();
      Task<BoundedVecT11> GetUnderConstruction(U32 key);
      Task<bool> SubscribeUnderConstruction(U32 key);
      Task<BaseOpt<EnumPreDigest>> GetInitialized();
      Task<bool> SubscribeInitialized();
      Task<BaseOpt<Arr32U8>> GetAuthorVrfRandomness();
      Task<bool> SubscribeAuthorVrfRandomness();
      Task<BaseTuple<U32, U32>> GetEpochStart();
      Task<bool> SubscribeEpochStart();
      Task<U32> GetLateness();
      Task<bool> SubscribeLateness();
      Task<BabeEpochConfiguration> GetEpochConfig();
      Task<bool> SubscribeEpochConfig();
      Task<BabeEpochConfiguration> GetNextEpochConfig();
      Task<bool> SubscribeNextEpochConfig();
      Task<BoundedVecT12> GetSkippedEpochs();
      Task<bool> SubscribeSkippedEpochs();
   }
}