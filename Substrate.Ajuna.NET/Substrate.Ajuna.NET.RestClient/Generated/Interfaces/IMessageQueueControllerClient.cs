//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Ajuna.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.pallet_message_queue;
   using Substrate.Ajuna.NET.NetApiExt.Generated.Model.cumulus_primitives_core;
   
   public interface IMessageQueueControllerClient
   {
      Task<BookState> GetBookStateFor(EnumAggregateMessageOrigin key);
      Task<bool> SubscribeBookStateFor(EnumAggregateMessageOrigin key);
      Task<EnumAggregateMessageOrigin> GetServiceHead();
      Task<bool> SubscribeServiceHead();
      Task<Page> GetPages(Substrate.NetApi.Model.Types.Base.BaseTuple<EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32> key);
      Task<bool> SubscribePages(Substrate.NetApi.Model.Types.Base.BaseTuple<EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32> key);
   }
}