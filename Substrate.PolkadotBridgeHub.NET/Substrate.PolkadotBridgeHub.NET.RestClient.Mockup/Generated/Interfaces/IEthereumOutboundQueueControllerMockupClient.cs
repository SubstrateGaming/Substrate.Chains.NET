//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotBridgeHub.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_pallet_outbound_queue.types;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.operating_mode;
   
   public interface IEthereumOutboundQueueControllerMockupClient
   {
      Task<bool> SetMessages(BaseVec<CommittedMessage> value);
      Task<bool> SetMessageLeaves(BaseVec<H256> value);
      Task<bool> SetNonce(U64 value, Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.ChannelId key);
      Task<bool> SetOperatingMode(EnumBasicOperatingMode value);
   }
}