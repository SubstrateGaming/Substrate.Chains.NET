//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.PolkadotBridgeHub.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.snowbridge_core.pricing;
   
   public interface IEthereumSystemControllerClient
   {
      Task<BaseTuple> GetAgents(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeAgents(Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<Channel> GetChannels(ChannelId key);
      Task<bool> SubscribeChannels(ChannelId key);
      Task<PricingParameters> GetPricingParameters();
      Task<bool> SubscribePricingParameters();
   }
}
