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
   using Substrate.People.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.People.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.People.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuraExtControllerMockupClient : MockupBaseClient, IAuraExtControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuraExtControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuthorities(BoundedVecT10 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AuraExt/Authorities", value.Encode(), Substrate.People.NET.NetApiExt.Generated.Storage.AuraExtStorage.AuthoritiesParams());
      }
      public async Task<bool> SetSlotInfo(BaseTuple<Slot, U32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "AuraExt/SlotInfo", value.Encode(), Substrate.People.NET.NetApiExt.Generated.Storage.AuraExtStorage.SlotInfoParams());
      }
   }
}
