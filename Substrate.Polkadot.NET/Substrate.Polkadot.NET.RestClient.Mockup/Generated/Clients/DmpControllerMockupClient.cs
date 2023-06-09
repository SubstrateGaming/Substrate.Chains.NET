//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Polkadot.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_core_primitives;
   using Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Polkadot.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class DmpControllerMockupClient : MockupBaseClient, IDmpControllerMockupClient
   {
      private HttpClient _httpClient;
      public DmpControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetDownwardMessageQueues(BaseVec<InboundDownwardMessage> value, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Dmp/DownwardMessageQueues", value.Encode(), Substrate.Polkadot.NET.NetApiExt.Generated.Storage.DmpStorage.DownwardMessageQueuesParams(key));
      }
      public async Task<bool> SetDownwardMessageQueueHeads(H256 value, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "Dmp/DownwardMessageQueueHeads", value.Encode(), Substrate.Polkadot.NET.NetApiExt.Generated.Storage.DmpStorage.DownwardMessageQueueHeadsParams(key));
      }
   }
}
