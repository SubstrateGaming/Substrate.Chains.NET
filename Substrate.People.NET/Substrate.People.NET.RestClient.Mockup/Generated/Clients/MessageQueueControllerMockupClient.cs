//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.People.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.People.NET.NetApiExt.Generated.Model.pallet_message_queue;
   using Substrate.People.NET.NetApiExt.Generated.Model.cumulus_primitives_core;
   using Substrate.People.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class MessageQueueControllerMockupClient : MockupBaseClient, IMessageQueueControllerMockupClient
   {
      private HttpClient _httpClient;
      public MessageQueueControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetBookStateFor(BookState value, EnumAggregateMessageOrigin key)
      {
         return await SendMockupRequestAsync(_httpClient, "MessageQueue/BookStateFor", value.Encode(), Substrate.People.NET.NetApiExt.Generated.Storage.MessageQueueStorage.BookStateForParams(key));
      }
      public async Task<bool> SetServiceHead(EnumAggregateMessageOrigin value)
      {
         return await SendMockupRequestAsync(_httpClient, "MessageQueue/ServiceHead", value.Encode(), Substrate.People.NET.NetApiExt.Generated.Storage.MessageQueueStorage.ServiceHeadParams());
      }
      public async Task<bool> SetPages(Page value, Substrate.NetApi.Model.Types.Base.BaseTuple<EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "MessageQueue/Pages", value.Encode(), Substrate.People.NET.NetApiExt.Generated.Storage.MessageQueueStorage.PagesParams(key));
      }
   }
}
