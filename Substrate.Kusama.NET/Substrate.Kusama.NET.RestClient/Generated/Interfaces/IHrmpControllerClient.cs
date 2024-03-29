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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_core_primitives;
   
   public interface IHrmpControllerClient
   {
      Task<HrmpOpenChannelRequest> GetHrmpOpenChannelRequests(HrmpChannelId key);
      Task<bool> SubscribeHrmpOpenChannelRequests(HrmpChannelId key);
      Task<BaseVec<HrmpChannelId>> GetHrmpOpenChannelRequestsList();
      Task<bool> SubscribeHrmpOpenChannelRequestsList();
      Task<U32> GetHrmpOpenChannelRequestCount(Id key);
      Task<bool> SubscribeHrmpOpenChannelRequestCount(Id key);
      Task<U32> GetHrmpAcceptedChannelRequestCount(Id key);
      Task<bool> SubscribeHrmpAcceptedChannelRequestCount(Id key);
      Task<BaseTuple> GetHrmpCloseChannelRequests(HrmpChannelId key);
      Task<bool> SubscribeHrmpCloseChannelRequests(HrmpChannelId key);
      Task<BaseVec<HrmpChannelId>> GetHrmpCloseChannelRequestsList();
      Task<bool> SubscribeHrmpCloseChannelRequestsList();
      Task<U32> GetHrmpWatermarks(Id key);
      Task<bool> SubscribeHrmpWatermarks(Id key);
      Task<HrmpChannel> GetHrmpChannels(HrmpChannelId key);
      Task<bool> SubscribeHrmpChannels(HrmpChannelId key);
      Task<BaseVec<Id>> GetHrmpIngressChannelsIndex(Id key);
      Task<bool> SubscribeHrmpIngressChannelsIndex(Id key);
      Task<BaseVec<Id>> GetHrmpEgressChannelsIndex(Id key);
      Task<bool> SubscribeHrmpEgressChannelsIndex(Id key);
      Task<BaseVec<InboundHrmpMessage>> GetHrmpChannelContents(HrmpChannelId key);
      Task<bool> SubscribeHrmpChannelContents(HrmpChannelId key);
      Task<BaseVec<BaseTuple<U32, BaseVec<Id>>>> GetHrmpChannelDigests(Id key);
      Task<bool> SubscribeHrmpChannelDigests(Id key);
   }
}
