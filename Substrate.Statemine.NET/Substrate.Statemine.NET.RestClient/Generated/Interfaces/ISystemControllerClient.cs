//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Statemine.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Statemine.NET.NetApiExt.Generated.Model.frame_system;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Statemine.NET.NetApiExt.Generated.Model.frame_support.dispatch;
   using Substrate.Statemine.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest;
   
   public interface ISystemControllerClient
   {
      Task<AccountInfo> GetAccount(Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAccount(Substrate.Statemine.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<U32> GetExtrinsicCount();
      Task<bool> SubscribeExtrinsicCount();
      Task<PerDispatchClassT1> GetBlockWeight();
      Task<bool> SubscribeBlockWeight();
      Task<U32> GetAllExtrinsicsLen();
      Task<bool> SubscribeAllExtrinsicsLen();
      Task<H256> GetBlockHash(U32 key);
      Task<bool> SubscribeBlockHash(U32 key);
      Task<BaseVec<U8>> GetExtrinsicData(U32 key);
      Task<bool> SubscribeExtrinsicData(U32 key);
      Task<U32> GetNumber();
      Task<bool> SubscribeNumber();
      Task<H256> GetParentHash();
      Task<bool> SubscribeParentHash();
      Task<Digest> GetDigest();
      Task<bool> SubscribeDigest();
      Task<BaseVec<EventRecord>> GetEvents();
      Task<bool> SubscribeEvents();
      Task<U32> GetEventCount();
      Task<bool> SubscribeEventCount();
      Task<BaseVec<BaseTuple<U32, U32>>> GetEventTopics(H256 key);
      Task<bool> SubscribeEventTopics(H256 key);
      Task<LastRuntimeUpgradeInfo> GetLastRuntimeUpgrade();
      Task<bool> SubscribeLastRuntimeUpgrade();
      Task<Bool> GetUpgradedToU32RefCount();
      Task<bool> SubscribeUpgradedToU32RefCount();
      Task<Bool> GetUpgradedToTripleRefCount();
      Task<bool> SubscribeUpgradedToTripleRefCount();
      Task<EnumPhase> GetExecutionPhase();
      Task<bool> SubscribeExecutionPhase();
   }
}