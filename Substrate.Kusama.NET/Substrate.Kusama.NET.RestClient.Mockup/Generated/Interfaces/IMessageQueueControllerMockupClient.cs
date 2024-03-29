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
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.pallet_message_queue;
   using Substrate.Kusama.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion;
   
   public interface IMessageQueueControllerMockupClient
   {
      Task<bool> SetBookStateFor(BookState value, EnumAggregateMessageOrigin key);
      Task<bool> SetServiceHead(EnumAggregateMessageOrigin value);
      Task<bool> SetPages(Page value, Substrate.NetApi.Model.Types.Base.BaseTuple<EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32> key);
   }
}
