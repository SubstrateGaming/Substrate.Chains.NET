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
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.pallet_message_queue;
   using Substrate.PolkadotBridgeHub.NET.NetApiExt.Generated.Model.bridge_hub_common.message_queue;
   
   public interface IMessageQueueControllerMockupClient
   {
      Task<bool> SetBookStateFor(BookState value, EnumAggregateMessageOrigin key);
      Task<bool> SetServiceHead(EnumAggregateMessageOrigin value);
      Task<bool> SetPages(Page value, Substrate.NetApi.Model.Types.Base.BaseTuple<EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32> key);
   }
}
